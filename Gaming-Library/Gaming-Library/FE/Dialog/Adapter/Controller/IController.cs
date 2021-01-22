﻿using Gaming_Library.BL.UseCase.Entity;

namespace Gaming_Library.FE.Dialog.Adapter.Controller
{
    public interface IController
    {
        public void StartGame(int index);
        public void LoadData();
        public void DeleteGame(int index);
        public void AddGame(View.Model.GameData game);
        public void ModifyGame(int index, View.Model.GameData game);
        void SearchForTitle(string title);
    }
}