using System;
using System.Collections.Generic;
using System.Text;
using TP_RESERVAS.Modelos;

namespace TP_RESERVAS.Repositorios
{
    public interface IReservaRepository
    {
        Task<List<Reserva>> GetAllAsync();
        Task<Reserva?> GetByNombreAsync(string nombreEvento);
        Task<Reserva?> GetByFechaAsync(DateTime fecha);
        Task<bool> CreateAsync(Reserva reserva);
        Task<bool> UpdateAsync(Reserva Reserva);
        Task<bool> DeleteAsync(int idReserva);
        Task<Reserva?> GetByIdAsync(int idActualizar);
    }
}
