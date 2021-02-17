using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gaming_Library.ChooseSteamGame.FE.Dialog.Adapter;

namespace Gaming_Library.ChooseSteamGame.FE.Dialog.Adapter.Controller
{
    public class ToSaveRequest
    {
        private View.Model _steamGameView;
        public static ToSaveRequest Create(View.Model genres)
        {
            return new ToSaveRequest(genres);
        }

        private ToSaveRequest(View.Model steamGameData)
        {
            _steamGameView = steamGameData;
        }

        public BL.UseCase.InputPort.Requests.Save CreateSaveRequest()
        {
            var steamGameData = new BL.UseCase.Entity.SteamGameData();

            steamGameData.steamId = _steamGameView.steamGameData.steamId;
            steamGameData.allSteamGames = _steamGameView.steamGameData.allSteamGames;
            steamGameData.searchResultList = _steamGameView.steamGameData.searchResultList;
            steamGameData.searchTerm = _steamGameView.steamGameData.searchTerm;

            var saveRequest = new BL.UseCase.InputPort.Requests.Save(steamGameData);
            return saveRequest;
        }
    }
}
