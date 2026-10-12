using System;
using System.Collections.Generic;
using System.Text;
using TP_RESERVAS.Modelos;

namespace TP_RESERVAS.Repositorios
{
    internal class ReservaRepositoryFile : IReservaRepository
    {
        public Task<List<Reserva>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
        public Task<Reserva?> GetByNombreAsync(string nombreReserva)
        {
            throw new NotImplementedException();
        }
        public Task<Reserva?> GetByFechaAsync(DateTime date)
        {
            throw new NotImplementedException();
        }
        public Task<bool> CreateAsync(Reserva reserva)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> UpdateAsync(Reserva reserva)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> DeleteAsync(int idReserva)
        {
            throw new NotImplementedException();
        }
        public async Task<Reserva?> GetByIdAsync(int idActualizar)
        {
            throw new NotImplementedException();
        }

    }
}
