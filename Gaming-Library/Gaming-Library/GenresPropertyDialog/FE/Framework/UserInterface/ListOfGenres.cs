using System;
using System.Linq;
using System.Windows.Forms;

namespace Gaming_Library.GenresPropertyDialog.FE.Dialog.Framework.UserInterface
{
    public partial class ListOfGenres : Form, Adapter.View.IView
    {
        private readonly Adapter.Controller.IController _controller;
        private Adapter.View.Model _viewModel;
        private ListView.ListViewItemCollection _genres;

        public ListOfGenres(Adapter.Controller.IController controller, Adapter.View.Model viewModel)
        {
            _controller = controller;
            _viewModel = viewModel;

            InitializeComponent();
            _genres = new ListView.ListViewItemCollection(genresListView);
            foreach (var genre in _viewModel.Genres.Genres) {
                _genres.Add(genre);
            }
        }

        public void UpdateView()
        {
            Close();
        }

        private void buttonDeleteGenre_MouseClick(object sender, MouseEventArgs e)
        {
            if (genresListView.SelectedItems.Count > 0) {
                genresListView.Items.Remove(genresListView.SelectedItems[0]);
            }
        }

        private void ListOfGenres_MouseMove(object sender, MouseEventArgs e)
        {
            buttonAddGenre.Visible = textBoxGenre.Text.Length != 0;
        }

        private void textBoxGenre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)) {
                buttonAddGenre.Visible = true;
            }
        }

        private void buttonAddGenre_Click(object sender, EventArgs e)
        {
            _genres.Add(new ListViewItem(textBoxGenre.Text));
            textBoxGenre.Clear();
        }

        private void buttonSubmit_MouseClick(object sender, MouseEventArgs e)
        {
            _viewModel.Genres.Genres.Clear();
            foreach (ListViewItem genre in _genres) {
                _viewModel.Genres.Genres.Add(genre.Text);
            }
            DialogResult = DialogResult.OK;
            _controller.SaveGenres(_viewModel);
        }
    }
}
