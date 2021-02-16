using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //todo: do stuff as in confirmation
            button_confirmButton_Click(sender, e);
        }

        public void FillListBox(List<Gaming_Library.ChooseSteamGame.BL.UseCase.Entity.Types.App> apps)
        {
            appBindingSource.Clear();
            foreach (var app in apps) {
                appBindingSource.Add(app);
            }
        }

        private void button_searchButton_Click(object sender, EventArgs e)
        {
            //todo: do stuff at search click
            //FillListBox(ParseFunktion.SearchSteamGame(textBox_searchBar.Text));
        }

        private void button_confirmButton_Click(object sender, EventArgs e)
        {
            //todo: do stuff at confirmation
            
        }

        private void button_cancelButton_Click(object sender, EventArgs e)
        {
            //todo: do stuff at cancel
            this.Close();
        }
    }
}
