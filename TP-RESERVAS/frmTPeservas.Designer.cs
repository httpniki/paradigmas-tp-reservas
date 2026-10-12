namespace TP_RESERVAS
{
    partial class frmTPeservas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnAgregar = new Button();
            btnCancelar = new Button();
            grillaReservas = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            actualizarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            txtNombreEvento = new TextBox();
            label1 = new Label();
            cmbSalon = new ComboBox();
            label2 = new Label();
            pickerFechaEvento = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            pickerHoraInicio = new DateTimePicker();
            label5 = new Label();
            pickerHoraFin = new DateTimePicker();
            label6 = new Label();
            txtCantidadInvitados = new TextBox();
            label7 = new Label();
            txtImporte = new TextBox();
            label8 = new Label();
            checkConfirmacion = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)grillaReservas).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(3, 338);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(244, 22);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Registrar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(4, 364);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(243, 22);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // grillaReservas
            // 
            grillaReservas.AllowUserToAddRows = false;
            grillaReservas.AllowUserToDeleteRows = false;
            grillaReservas.BorderStyle = BorderStyle.None;
            grillaReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaReservas.ContextMenuStrip = contextMenuStrip1;
            grillaReservas.Location = new Point(259, 4);
            grillaReservas.Margin = new Padding(3, 2, 3, 2);
            grillaReservas.Name = "grillaReservas";
            grillaReservas.RowHeadersWidth = 51;
            grillaReservas.Size = new Size(906, 382);
            grillaReservas.TabIndex = 2;
            grillaReservas.CellContentClick += grillaReservas_CellContentClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { actualizarToolStripMenuItem, eliminarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(127, 48);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // actualizarToolStripMenuItem
            // 
            actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            actualizarToolStripMenuItem.Size = new Size(126, 22);
            actualizarToolStripMenuItem.Text = "Actualizar";
            actualizarToolStripMenuItem.Click += actualizarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(126, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // txtNombreEvento
            // 
            txtNombreEvento.Location = new Point(4, 21);
            txtNombreEvento.Margin = new Padding(3, 2, 3, 2);
            txtNombreEvento.Name = "txtNombreEvento";
            txtNombreEvento.Size = new Size(243, 23);
            txtNombreEvento.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 4);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 7;
            label1.Text = "Nombre del evento";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbSalon
            // 
            cmbSalon.FormattingEnabled = true;
            cmbSalon.Location = new Point(4, 63);
            cmbSalon.Margin = new Padding(3, 2, 3, 2);
            cmbSalon.Name = "cmbSalon";
            cmbSalon.Size = new Size(243, 23);
            cmbSalon.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 46);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 9;
            label2.Text = "Salon";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pickerFechaEvento
            // 
            pickerFechaEvento.Format = DateTimePickerFormat.Short;
            pickerFechaEvento.Location = new Point(4, 105);
            pickerFechaEvento.Margin = new Padding(3, 2, 3, 2);
            pickerFechaEvento.Name = "pickerFechaEvento";
            pickerFechaEvento.Size = new Size(243, 23);
            pickerFechaEvento.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 88);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 11;
            label3.Text = "Fecha del evento";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 130);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 13;
            label4.Text = "Hora inicio";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pickerHoraInicio
            // 
            pickerHoraInicio.Format = DateTimePickerFormat.Time;
            pickerHoraInicio.Location = new Point(4, 147);
            pickerHoraInicio.Margin = new Padding(3, 2, 3, 2);
            pickerHoraInicio.Name = "pickerHoraInicio";
            pickerHoraInicio.Size = new Size(243, 23);
            pickerHoraInicio.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 172);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 15;
            label5.Text = "Hora fin";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pickerHoraFin
            // 
            pickerHoraFin.Format = DateTimePickerFormat.Time;
            pickerHoraFin.Location = new Point(4, 189);
            pickerHoraFin.Margin = new Padding(3, 2, 3, 2);
            pickerHoraFin.Name = "pickerHoraFin";
            pickerHoraFin.Size = new Size(243, 23);
            pickerHoraFin.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(4, 214);
            label6.Name = "label6";
            label6.Size = new Size(125, 15);
            label6.TabIndex = 17;
            label6.Text = "Cantidad de invitados";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCantidadInvitados
            // 
            txtCantidadInvitados.Location = new Point(4, 231);
            txtCantidadInvitados.Margin = new Padding(3, 2, 3, 2);
            txtCantidadInvitados.Name = "txtCantidadInvitados";
            txtCantidadInvitados.Size = new Size(243, 23);
            txtCantidadInvitados.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 256);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 19;
            label7.Text = "Importe";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(4, 273);
            txtImporte.Margin = new Padding(3, 2, 3, 2);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(243, 23);
            txtImporte.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 310);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 20;
            label8.Text = "Confirmado";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkConfirmacion
            // 
            checkConfirmacion.AutoSize = true;
            checkConfirmacion.Location = new Point(81, 311);
            checkConfirmacion.Margin = new Padding(3, 2, 3, 2);
            checkConfirmacion.Name = "checkConfirmacion";
            checkConfirmacion.Size = new Size(15, 14);
            checkConfirmacion.TabIndex = 21;
            checkConfirmacion.UseVisualStyleBackColor = true;
            // 
            // frmTPeservas
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 399);
            Controls.Add(checkConfirmacion);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtImporte);
            Controls.Add(label6);
            Controls.Add(txtCantidadInvitados);
            Controls.Add(label5);
            Controls.Add(pickerHoraFin);
            Controls.Add(label4);
            Controls.Add(pickerHoraInicio);
            Controls.Add(label3);
            Controls.Add(pickerFechaEvento);
            Controls.Add(label2);
            Controls.Add(cmbSalon);
            Controls.Add(label1);
            Controls.Add(txtNombreEvento);
            Controls.Add(grillaReservas);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmTPeservas";
            Text = "Eventos Sociales";
            Load += frmTPReservas_Load;
            ((System.ComponentModel.ISupportInitialize)grillaReservas).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnCancelar;
        private DataGridView grillaReservas;
        private TextBox txtNombreEvento;
        private Label label1;
        private ComboBox cmbSalon;
        private Label label2;
        private DateTimePicker pickerFechaEvento;
        private Label label3;
        private Label label4;
        private DateTimePicker pickerHoraInicio;
        private Label label5;
        private DateTimePicker pickerHoraFin;
        private Label label6;
        private TextBox txtCantidadInvitados;
        private Label label7;
        private TextBox txtImporte;
        private Label label8;
        private CheckBox checkConfirmacion;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem actualizarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
    }
}
