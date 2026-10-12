using System;
using System.Collections.Generic;
using System.Text;

namespace TP_RESERVAS.Modelos
{
    public class Reserva
    {
        public int idReserva { get; set; }
        public string salon { get; set; }
        public string nombreEvento { get; set; }
        public DateTime fechaEvento { get; set; }
        public TimeSpan horaInicio { get; set; }
        public TimeSpan horaFinal {  get; set; }
        public decimal importe { get; set; }
        public int cantidadInvitados { get; set; }
        public bool confirmado { get; set; }

        public Reserva(int idReserva, string salon, string nombreEvento, DateTime fechaEvento, TimeSpan horaInicio, TimeSpan horaFinal, decimal importe, int cantidadInvitados, bool confirmado)
        {
            this.idReserva = idReserva;
            this.salon = salon;
            this.nombreEvento = nombreEvento;
            this.fechaEvento = fechaEvento;
            this.horaInicio = horaInicio;
            this.horaFinal = horaFinal;
            this.importe = importe;
            this.cantidadInvitados = cantidadInvitados;
            this.confirmado = confirmado;
        }

        public Reserva()
        {
            var today = DateTime.Now;

            this.idReserva = 0;
            this.salon = String.Empty;
            this.nombreEvento = String.Empty;
            this.cantidadInvitados = 0;
            this.confirmado = false;
            this.fechaEvento = DateTime.Now;
            this.horaInicio = today.TimeOfDay;
            this.horaFinal = today.TimeOfDay;
            this.importe = 0;
        }
    }
}
