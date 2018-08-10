using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eshop.Games;
using Eshop.Games.Models;
using Eshop.Games.Services;

namespace MvvmCross.NintendoGames.Core.Services
{
    public class NintendoService : INintendoService
    {
        private readonly EshopService _eshopService;
        public NintendoService()
        {
            Config config = new Config
            {
                Region = Region.NA,
                System = Eshop.Games.System.NintendoSwitch
            };
            
            _eshopService = new EshopService(config);

        }
            
        public async Task<List<Game>> ObterGames()
        {
            Query query = new Query
            {
                Index = 0,
                Limit = 200,
                Order = Order.asc,
                Sort = Sort.title,
                Value = ""
            };
            
            var games = await _eshopService.GetGames(query);

            return games.ToList();

        }

        public Task<GameDetail> ObterDetalhesPorGame(Game game)
        {
            var detail = _eshopService.GetGameDetail(game);
            return detail;
        }
    }
}