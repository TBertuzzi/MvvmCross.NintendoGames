using System.Collections.Generic;
using System.Threading.Tasks;
using Eshop.Games.Models;

namespace MvvmCross.NintendoGames.Core.Services
{
    public interface INintendoService
    {
        Task<List<Game>> ObterGames();
        Task<GameDetail> ObterDetalhesPorGame(Game game);
    }
}