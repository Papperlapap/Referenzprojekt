using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gaming_Library.ChooseSteamGame.FE.Dialog.Framework.UserInterface
{
    public partial class ChooseSteamGameDialog : Form
    {
        private readonly Adapter.Controller.IController _controller;
        private Adapter.View.Model _viewModel;
        public ChooseSteamGameDialog()
        {
            InitializeComponent();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            button_confirmButton_Click(sender, e);
        }

        public void FillListBox(List<BL.UseCase.Entity.Types.App> apps)
        {
            appBindingSource.Clear();
            foreach (var app in apps) {
                appBindingSource.Add(app);
            }
        }

        private void button_searchButton_Click(object sender, EventArgs e)
        {
            _controller.searchForGames(_viewModel.steamGameData);
            FillListBox(_viewModel.steamGameData.searchResultList.applist.apps);
        }

        private void button_confirmButton_Click(object sender, EventArgs e)
        {
            if(listBox_showAllSearchResults.SelectedItem != null) {
                _viewModel.steamGameData.steamId = new Library.BL.UseCase.Entity.Types.SteamId(((BL.UseCase.Entity.Types.App)listBox_showAllSearchResults.SelectedItem).appid);
                this.Close();
            }
        }

        private void button_cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
