using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Gaming_Library.Library.FE.Dialog.Framework.UserInterface
{
    public partial class GameProperties : Form, Adapter.View.IView
    {
        private bool _isPropertiesViewCollapsed = true;
        private Adapter.View.Model.GameData _game;
        private readonly Adapter.Controller.IController _controller;
        private readonly int _gameIndex;
        private readonly Point _location;


        public GameProperties(Adapter.Controller.IController controller, Point location, Adapter.View.Model.GameData game, int gameIndex = -1)
        {
            _controller = controller;
            _location = location;

            _game = game;
            _gameIndex = gameIndex;

            InitializeComponent();
            SetupTooltips();

            if (_gameIndex >= 0) {
                SetupControls();
            }
        }
        public void UpdateView()
        {
            SetupControls();
        }

        private void SetupTooltips()
        {
            toolTip1.SetToolTip(buttonSetFolderPath, "Wähle hier den lokalen Pfad der .exe-Datei.");
            toolTip1.SetToolTip(buttonEditGenres, "Passe hier die für dieses Spiel zutreffenden Genres an.");
            toolTip1.SetToolTip(buttonSetImagePath, "Wähle hier das anzuzeigende Bild aus.");
            toolTip1.SetToolTip(buttonSearchForTitle, "Es werden die zu dem eingegebenen Titel passenden Spiele auf Steam gesucht.");
            toolTip1.SetToolTip(tags, "Durch Kommas (',') separierte Tags, zur Erleichterung von Suche/ Filterung");
        }

        private void SetupControls()
        {
            controllerFull.Checked = _game.Attributes.HasFullControllerSupport;
            controllerPart.Checked = _game.Attributes.HasPartialControllerSupport;
            isCoop.Checked = _game.Attributes.IsCooperative;
            isMultiPlayer.Checked = _game.Attributes.IsMultiPlayer;
            isSinglePlayer.Checked = _game.Attributes.IsSinglePlayer;
            isVR.Checked = _game.Attributes.IsVRSupportive;
            publisher.Text = _game.Publisher;
            tags.Text = string.Join(",", _game.Tags);

            genresList.Items.Clear();
            foreach (var genre in _game.Genres.Split(',')) {
                genresList.Items.Add(genre.Trim());
            }
            locationPath.Text = Path.GetFileName(_game.Location);
            title.Text = _game.Title;
            publicationYear.Text = _game.Year;
            imagePath.Text = Path.GetFileName(_game.ImagePath);
        }

        private void GameProperties_Load(object sender, EventArgs e)
        {
            SetDesktopLocation(_location.X, _location.Y);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveProperties_Click(object sender, EventArgs e)
        {
            _game.Attributes.HasFullControllerSupport = controllerFull.Checked;
            _game.Attributes.HasPartialControllerSupport = controllerPart.Checked;
            _game.Attributes.IsCooperative = isCoop.Checked;
            _game.Attributes.IsMultiPlayer = isMultiPlayer.Checked;
            _game.Attributes.IsSinglePlayer = isSinglePlayer.Checked;
            _game.Attributes.IsVRSupportive = isVR.Checked;
            _game.Attributes.HasAchievements = true;
            _game.Publisher = publisher.Text;
            _game.Tags = tags.Text.Split(',').ToList();
            _game.Genres = "";

            foreach (var item in genresList.Items) {
                _game.Genres += ((ListViewItem)item).Text + ", ";
            }

            _game.Genres = _game.Genres.TrimEnd(',', ' ');
            _game.Title = title.Text;
            _game.Year = publicationYear.Text;

            if (_gameIndex >= 0) {
                _controller.ModifyGame(_gameIndex, _game);
            } else {
                _controller.AddGame(_game);
            }
            Close();
        }

        private void buttonSearchForTitle_Click(object sender, EventArgs e)
        {
            _controller.SearchForTitle(title.Text);
            UpdateView();
        }

        private void buttonSetImagePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {
                try {
                    _game.Image = new Bitmap(ofd.FileName);
                } catch (ArgumentException) {
                    MessageBox.Show(
                    "Ausgewähltes Bild ist zu gross.\nVerkleinere es, oder wähle ein anderes Bild!",
                    "Information",
                    MessageBoxButtons.OK);
                    return;
                }
                _game.Image = ResizeImage(_game.Image);
                _game.ImagePath = ofd.FileName;
                imagePath.Text = Path.GetFileName(ofd.FileName);
            }
        }

        private Bitmap ResizeImage(Bitmap image)
        {
            return new Bitmap(image, new Size(110, 62));
        }

        private void buttonSetFolderPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK) {
                if (ofd.FileName.EndsWith(".exe")) {
                    _game.Location = ofd.FileName;
                    locationPath.Text = Path.GetFileName(ofd.FileName);
                    buttonSearchForTitle.Visible = false;
                    buttonSearchForTitle.Enabled = false;
                    return;
                }

                MessageBox.Show(this,
                  "Die ausgewählte Datei entspricht nicht dem benötigten Format (.exe)",
                  "Information",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonProperties_Click(object sender, EventArgs e)
        {
            if (_isPropertiesViewCollapsed) {
                Height = MaximumSize.Height;
                Width = MaximumSize.Width;
                panel1.Visible = true;
                _isPropertiesViewCollapsed = false;
                buttonProperties.Image = Properties.Resources.shrink_white;
            } else {
                Height = MinimumSize.Height;
                Width = MinimumSize.Width;
                panel1.Visible = false;
                _isPropertiesViewCollapsed = true;
                buttonProperties.Image = Properties.Resources.expand_white;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_isPropertiesViewCollapsed) {
                buttonProperties.Image = Properties.Resources.shrink_white;
                AdjustComponents(10);
                if (panel1.Height == panel1.MaximumSize.Height) {
                    _isPropertiesViewCollapsed = false;
                    timer1.Stop();
                }
            } else if (!_isPropertiesViewCollapsed) {
                buttonProperties.Image = Properties.Resources.expand_white;
                AdjustComponents(-10);
                if (panel1.Height == panel1.MinimumSize.Height) {
                    _isPropertiesViewCollapsed = true;
                    timer1.Stop();
                }
            }
        }

        private void AdjustComponents(int adjustment)
        {
            Height += adjustment;
            Width += adjustment;
        }

        private void publicationYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void buttonEditGenres_Click(object sender, EventArgs e)
        {
            _controller.EditGenres(_gameIndex, _game);
            UpdateView();
        }
    }
}
