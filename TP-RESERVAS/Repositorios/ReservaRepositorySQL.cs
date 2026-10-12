using System.Text;
using TP_RESERVAS.Modelos;
using Microsoft.Data.SqlClient;
using System.Data;

namespace TP_RESERVAS.Repositorios
{
    internal class ReservaRepositorySQL : IReservaRepository
    {
        private const string CONNECTION_STRING = @"Data Source=localhost\sqlexpress;Initial Catalog=PoePoo;User ID=UserCreator;Password=UserCreator;TrustServerCertificate=True";
        
        private Reserva reservaMapper(SqlDataReader reader)
        {
            return new Reserva(
                    reader.GetInt32("idReserva"),
                    reader.GetString("Salon"),
                    reader.GetString("NombreEvento"),
                    reader.GetDateTime("FechaEvento"),
                    reader.GetTimeSpan(reader.GetOrdinal("HoraInicio")),
                    reader.GetTimeSpan(reader.GetOrdinal("HoraFin")),
                    reader.GetDecimal("Importe"),
                    reader.GetInt32("CantidadInvitados"),
                    reader.GetBoolean("confirmada"));
        }

        public async Task<List<Reserva>> GetAllAsync()
        {
            List<Reserva> reservas = new List<Reserva>();

            string sql = @"
                SELECT idReserva, NombreEvento, Salon, FechaEvento, HoraInicio, HoraFin, Importe, CantidadInvitados, Confirmada
                FROM ReservasSalon;";

            await using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            await conn.OpenAsync();

            await using SqlCommand cmd = new SqlCommand(sql, conn);
            await using SqlDataReader reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                Reserva reserva = reservaMapper(reader);
                reservas.Add(reserva);
            }

            return reservas;
        }
        public async Task<Reserva?> GetByNombreAsync(string nombreEvento)
        {
            Reserva? reserva = null;

            string sql = @"
                SELECT idReserva, NombreEvento, Salon, FechaEvento, HoraInicio, HoraFin, Importe, CantidadInvitados, Confirmada
                FROM ReservasSalon
                WHERE LOWER(NombreEvento)=LOWER(@nombreEvento)";

            await using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            await conn.OpenAsync();

            await using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("nombreEvento", nombreEvento);

            await using SqlDataReader reader = await cmd.ExecuteReaderAsync();

            if (await reader.ReadAsync())
            {
                reserva = reservaMapper(reader);
            }

            return reserva;
        }
        public async Task<Reserva?> GetByFechaAsync(DateTime date)
        {
            Reserva? reserva = null;

            string sql = @"
                SELECT idReserva, NombreEvento, Salon, FechaEvento, HoraInicio, HoraFin, Importe, CantidadInvitados, Confirmada
                FROM ReservasSalon
                WHERE CAST(FechaEvento AS DATE)=@fechaEvento";

            await using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            await conn.OpenAsync();

            await using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("fechaEvento", date.Date);

            await using SqlDataReader reader = await cmd.ExecuteReaderAsync();

            if (await reader.ReadAsync())
            {
                reserva = reservaMapper(reader);
            }

            return reserva;
        }

        public async Task<Reserva?> GetByIdAsync(int idReserva)
        {
            Reserva? reserva = null;

            string sql = @"
                SELECT idReserva, NombreEvento, Salon, FechaEvento, HoraInicio, HoraFin, Importe, CantidadInvitados, Confirmada
                FROM ReservasSalon
                WHERE idReserva=@idReserva";

            await using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            await conn.OpenAsync();

            await using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("idReserva", idReserva);

            await using SqlDataReader reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                reserva = reservaMapper(reader);
            }
            return reserva;
        }
        public async Task<bool> CreateAsync(Reserva reserva)
        {
            string sql = @"
                insert into ReservasSalon (NombreEvento, Salon, FechaEvento, HoraInicio, HoraFin, Importe, CantidadInvitados, Confirmada) 
                values (@nombreEvento, @salon, @fechaEvento, @horaInicio, @horaFin, @importe, @cantidadInvitados, @confirmado)";

            await using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            await conn.OpenAsync();

            await using SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("nombreEvento", reserva.nombreEvento);
            cmd.Parameters.AddWithValue("salon", reserva.salon);
            cmd.Parameters.AddWithValue("fechaEvento", reserva.fechaEvento);
            cmd.Parameters.AddWithValue("horaInicio", reserva.horaInicio);
            cmd.Parameters.AddWithValue("horaFin", reserva.horaFinal);
            cmd.Parameters.AddWithValue("importe", reserva.importe);
            cmd.Parameters.AddWithValue("cantidadInvitados", reserva.cantidadInvitados);
            cmd.Parameters.AddWithValue("confirmado", reserva.confirmado);
          
            int result = await cmd.ExecuteNonQueryAsync();

            return result > 0;
        }
        public async Task<bool> UpdateAsync(Reserva reserva)
        {
            string sql = @"update ReservasSalon set 
                 NombreEvento = @nombreEvento,
                   Salon = @salon,
                   FechaEvento = @fechaEvento,
                   HoraInicio = @horaInicio,
                   HoraFin = @horaFin,
                   Importe = @importe,
                   CantidadInvitados = @cantidadInvitados,
                   Confirmada = @confirmado
                   where IdReserva = @idReserva";

            await using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            await conn.OpenAsync();

            await using SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("nombreEvento", reserva.nombreEvento);
            cmd.Parameters.AddWithValue("salon", reserva.salon);
            cmd.Parameters.AddWithValue("fechaEvento", reserva.fechaEvento);
            cmd.Parameters.AddWithValue("horaInicio", reserva.horaInicio);
            cmd.Parameters.AddWithValue("horaFin", reserva.horaFinal);
            cmd.Parameters.AddWithValue("importe", reserva.importe);
            cmd.Parameters.AddWithValue("cantidadInvitados", reserva.cantidadInvitados);
            cmd.Parameters.AddWithValue("confirmado", reserva.confirmado);
            cmd.Parameters.AddWithValue("idReserva", reserva.idReserva);

            int result = await cmd.ExecuteNonQueryAsync();
            return result > 0;
        }
        public async Task<bool> DeleteAsync(int idReserva)
        {
            string sql = "DELETE from ReservasSalon WHERE idReserva = @idReserva";

            await using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            await conn.OpenAsync();

            await using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("idReserva", idReserva);

            int result = await cmd.ExecuteNonQueryAsync();

            return result > 0;
        }
    }
}
