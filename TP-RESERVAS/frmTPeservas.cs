using System.ComponentModel.Design;
using TP_RESERVAS.Modelos;
using TP_RESERVAS.Repositorios;

namespace TP_RESERVAS
{
    public partial class frmTPeservas : Form
    {
        private readonly IReservaRepository _repo;
        private int _idReserva = 0;

        public frmTPeservas(IReservaRepository repo)
        {
            InitializeComponent();
            this._repo = repo;

            pickerHoraFin.ShowUpDown = true;
            pickerHoraInicio.ShowUpDown = true;
        }

        private async void CargarGrilla()
        {
            try
            {
                List<Reserva> lista = (List<Reserva>)await _repo.GetAllAsync();
                grillaReservas.DataSource = lista;
                grillaReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                grillaReservas.Columns["IdReserva"].Visible = false;
                grillaReservas.Columns["salon"].HeaderText = "Salón";
                grillaReservas.Columns["salon"].ReadOnly = true;

                grillaReservas.Columns["nombreEvento"].HeaderText = "Nombre del evento";
                grillaReservas.Columns["nombreEvento"].ReadOnly = true;

                grillaReservas.Columns["fechaEvento"].HeaderText = "Fecha";
                grillaReservas.Columns["fechaEvento"].ReadOnly = true;

                grillaReservas.Columns["horaInicio"].HeaderText = "Hora inicio";
                grillaReservas.Columns["horaInicio"].ReadOnly = true;

                grillaReservas.Columns["horaFinal"].HeaderText = "Hora Final";
                grillaReservas.Columns["horaFinal"].ReadOnly = true;

                grillaReservas.Columns["importe"].HeaderText = "Importe";
                grillaReservas.Columns["importe"].ReadOnly = true;

                grillaReservas.Columns["cantidadInvitados"].HeaderText = "Cantidad invitados";
                grillaReservas.Columns["cantidadInvitados"].ReadOnly = true;

                grillaReservas.Columns["confirmado"].HeaderText = "Confirmado";
                grillaReservas.Columns["confirmado"].ReadOnly = true;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ValidarFormulario()
        {
            var errores = new List<string>();
            var today = DateTime.Today;

            int cantidadInvitados = 0;
            Decimal importe = 0;

            if (txtNombreEvento.Text.Length == 0)
                errores.Add("El nombre del evento no puede estar vacio.");

            if (pickerFechaEvento.Value.Date < today)
                errores.Add("La fecha no puede ser anterior a la del dia de hoy.");

            if (pickerHoraInicio.Value > pickerHoraFin.Value)
                errores.Add("La hora de inicio no puede ser posterior o igual a la hora final.");

            if (int.TryParse(txtCantidadInvitados.Text, out cantidadInvitados) == false)
                errores.Add("La cantidad de invitados debe ser un numero.");

            if (cantidadInvitados < 0 || cantidadInvitados > 150)
                errores.Add("La cantidad de invitados debe ser mayor a 0 y menor a 150.");

            if (Decimal.TryParse(txtImporte.Text, out importe) == false)
                errores.Add("El importe debe ser un numero.");

            if (importe < 0)
                errores.Add("El importe debe ser mayor a 0.");

            if (errores.Count > 0)
                throw new Exception(String.Join("\n", errores));
        }

        private async Task ValidarReglas(Reserva reserva)
        {
            Reserva? reservaConNombreDuplicado = await _repo.GetByNombreAsync(reserva.nombreEvento);
            Reserva? reservaConLaMismaFecha = await _repo.GetByFechaAsync(reserva.fechaEvento);

            if (_idReserva == 0)
            {
                if (reservaConNombreDuplicado != null) throw new Exception("Existe un evento con el mismo nombre.");
                if (reservaConLaMismaFecha != null) throw new Exception("La fecha seleccionada ya contiene un evento disponible.");
            }

            if (_idReserva != 0)
            {
                if (reservaConLaMismaFecha != null && reservaConLaMismaFecha.idReserva != _idReserva)
                    throw new Exception("La fecha seleccionada ya contiene un evento disponible.");

                if (reservaConNombreDuplicado != null && reservaConNombreDuplicado.idReserva != _idReserva)
                    throw new Exception("Existe un evento con el mismo nombre.");
            }
        }

        private void ResetearFormulario()
        {
            DateTime today = DateTime.Now;

            txtCantidadInvitados.Clear();
            txtCantidadInvitados.Clear();
            txtNombreEvento.Clear();
            txtImporte.Clear();
            pickerFechaEvento.Value = today;
            pickerHoraInicio.Value = today;
            pickerHoraFin.Value = today;
            cmbSalon.SelectedIndex = 0;
            checkConfirmacion.Checked = false;
        }

        private void frmTPReservas_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            cmbSalon.Items.Add("Salón Principal");
            cmbSalon.Items.Add("Salón Norte");
            cmbSalon.Items.Add("Salon Jardín");
            cmbSalon.Items.Add("Salón Patagonia");
            txtNombreEvento.MaxLength = 100;
            cmbSalon.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSalon.SelectedIndex = 0;

            CargarGrilla();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarFormulario();

                Reserva newReserva = new Reserva
                {
                    salon = cmbSalon.Text,
                    nombreEvento = txtNombreEvento.Text,
                    fechaEvento = pickerFechaEvento.Value,
                    horaInicio = pickerHoraInicio.Value.TimeOfDay,
                    horaFinal = pickerHoraFin.Value.TimeOfDay,
                    importe = Decimal.Parse(txtImporte.Text),
                    cantidadInvitados = int.Parse(txtCantidadInvitados.Text),
                    confirmado = checkConfirmacion.Checked,
                };

                await ValidarReglas(newReserva);

                if (_idReserva == 0)
                {
                    bool guardar = await _repo.CreateAsync(newReserva);
                    if (!guardar) throw new Exception("Error al guardar la reserva");
                }
                else
                {
                    newReserva.idReserva = _idReserva;
                    bool guardar = await _repo.UpdateAsync(newReserva);
                    if (!guardar) throw new Exception("Error al actualizar la reserva");
                }

                CargarGrilla();
                ResetearFormulario();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetearFormulario();
        }

        private async void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetearFormulario();

            if (grillaReservas.CurrentRow != null)
            {

                var result = MessageBox.Show("¿Está seguro que desea eliminar la reserva seleccionada?", "Eliminar reserva", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int idEliminar = int.Parse(grillaReservas.CurrentRow.Cells["IdReserva"].Value.ToString());
                        await this._repo.DeleteAsync(idEliminar);
                        CargarGrilla();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private async void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetearFormulario();
            if (grillaReservas.CurrentRow != null)
            {
                try
                {
                    this._idReserva = int.Parse(grillaReservas.CurrentRow.Cells["IdReserva"].Value.ToString());

                    Reserva? actReserva = (Reserva)await this._repo.GetByIdAsync(_idReserva);
                    if (actReserva == null)
                        throw new Exception($"No se encontró la reserva con id {this._idReserva}");
                    txtNombreEvento.Text = actReserva.nombreEvento;
                    pickerFechaEvento.Value = actReserva.fechaEvento;
                    pickerHoraInicio.Value = DateTime.Today.Add(actReserva.horaInicio);
                    pickerHoraFin.Value = DateTime.Today.Add(actReserva.horaFinal);
                    txtImporte.Text = actReserva.importe.ToString();
                    txtCantidadInvitados.Text = actReserva.cantidadInvitados.ToString();
                    cmbSalon.SelectedItem = actReserva.salon;
                    checkConfirmacion.Checked = actReserva.confirmado;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void grillaReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
