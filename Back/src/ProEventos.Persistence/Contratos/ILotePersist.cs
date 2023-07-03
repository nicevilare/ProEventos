using System;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contratos
{
    public interface ILotePersist
    {
        /// <summary>
        /// Método get que retornara uma lista de lotes por eventoId.
        /// </summary>
        /// <param name="eventoId"></param>
        /// <returns>Lista de Lotes</returns>
        Task<Lote[]> GetLotesByEventoIdAsync(int eventoId);
        /// <summary>
        /// Método get que retornara apenas um lote
        /// </summary>
        /// <param name="eventoId"></param>
        /// <param name="id">Código chave do meu lote</param>
        /// <returns>Apenas  um lote</returns>
        Task<Lote> GetLoteByIdsAsync(int EventoId, int id);

    }
}