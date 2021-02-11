using System;
using System.Drawing;
using System.Windows.Forms;
using Gaming_Library.Library.FE.Dialog.Adapter.View;
using Gaming_Library.Library.FE.Dialog.Framework.UserInterface;
using Gaming_Library.Properties;

namespace Gaming_Library.Library
{
    public partial class LibraryDialog : Form, IView
    {
        private bool isDropdownCollapsed = true;
        private bool isFilterViewCollapsed = true;

        private FE.Dialog.Adapter.Controller.IController _controller;
        private Model _viewModel;

        public LibraryDialog(FE.Dialog.Adapter.Controller.IController controller, Model viewModel)
        {
            _controller = controller;
            _viewModel = viewModel;

            Settings.Default.Reset();
            InitializeComponent();
            if (!Settings.Default.FilterViewCollapsed) {
                timer1.Start();
            }
        }

        public void UpdateView()
        {
            gameListView.SetObjects(_viewModel.Games);
            gameListView.Update();
            Update();
        }

        protected override void OnLoad(EventArgs e)
        {
            LoadData();
        }


        private void LoadData()
        {
            _controller.LoadData();
            gameListView.SetObjects(_viewModel.Games);

        }

        private void searchInViewTextBox_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            textBoxSearch.TextAlign = HorizontalAlignment.Left;
        }

        private void searchInViewTextBox_Leave(object sender, EventArgs e)
        {
            textBoxSearch.Text = Settings.Default.SearchField;
            textBoxSearch.TextAlign = HorizontalAlignment.Right;
        }

        private void openFilterView_Click(object sender, EventArgs e)
        {
            HandleFirstAccess();
            timer1.Start();
        }

        private void HandleFirstAccess()
        {
            if (Settings.Default.IsFirstAccess) {
                DialogResult dialogResult = MessageBox.Show(
                    "Möchten Sie die Filter-View bei Start des Programmes anzeigen lassen?\n",
                    "Filter-View",
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {
                    Settings.Default.FilterViewCollapsed = false;
                }
                Settings.Default.IsFirstAccess = false;
                Settings.Default.Save();
            }
        }
        private void setObjectListAnchorsForFilterPanel()
        {
            //we need to remove the top-anchor to be able to move the objectlist further down
            gameListView.Anchor =
                AnchorStyles.Bottom
                | AnchorStyles.Left
                | AnchorStyles.Right;
        }

        private void resetObjectListAnchors()
        {
            gameListView.Anchor =
                AnchorStyles.Top
                | AnchorStyles.Bottom
                | AnchorStyles.Left
                | AnchorStyles.Right;
        }

        private void AdjustComponents(int adjustment)
        {
            gameListView.Location = new Point(
                gameListView.Location.X,
                gameListView.Location.Y + adjustment
                );
            panel1.Height += adjustment;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            setObjectListAnchorsForFilterPanel();

            if (isFilterViewCollapsed) {
                buttonShowFilter.Image = Properties.Resources.shrink_white;
                AdjustComponents(5);
                if (panel1.Height == panel1.MaximumSize.Height) {
                    isFilterViewCollapsed = false;
                    timer1.Stop();
                }
            } else if (!isFilterViewCollapsed) {
                buttonShowFilter.Image = Properties.Resources.expand_white;
                AdjustComponents(-5);
                if (panel1.Height == panel1.MinimumSize.Height) {
                    isFilterViewCollapsed = true;
                    timer1.Stop();
                }
            }

            resetObjectListAnchors();
        }

        private void gameListView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) {
                //ignore, if no row is selected
                if (gameListView.SelectedItem != null) {
                    var mousePosition = gameListView.PointToClient(Cursor.Position);
                    contextMenuStrip2.Show(gameListView, mousePosition);
                }
            }
        }

        private void buttonAddGame_MouseClick(object sender, MouseEventArgs e)
        {
            //hide button after action was requested
            timer2.Start();

            var propertiesForm = new GameProperties(_controller,
                new Point(e.X, e.Y),
                new Model.GameData());
            propertiesForm.ShowDialog(this);
        }

        private void buttonGames_Click(object sender, EventArgs eventArguments)
        {
            timer2.Start();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isDropdownCollapsed) {
                buttonGames.Image = Properties.Resources.shrink_white;
                panel3.Height += 2;
                if (panel3.Height == panel3.MaximumSize.Height) {
                    isDropdownCollapsed = false;
                    timer2.Stop();
                }
            } else if (!isDropdownCollapsed) {
                buttonGames.Image = Properties.Resources.expand_white;
                panel3.Height -= 2;
                if (panel3.Height == panel3.MinimumSize.Height) {
                    isDropdownCollapsed = true;
                    timer2.Stop();
                }
            }
        }

        private void filterTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxSearchTags.Text = "";
            textBoxSearchTags.Font = new Font(textBoxSearchTags.Font, FontStyle.Regular);
            textBoxSearchTags.ForeColor = Color.Black;
        }

        private void buttonResetFilter_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxSearchTags.Text = Settings.Default.FilterField;
            textBoxSearchTags.Font = new Font(textBoxSearchTags.Font, FontStyle.Italic);
            textBoxSearchTags.ForeColor = Color.Gray;

            checkAction.Checked = false;
            checkMMP.Checked = false;
            checkRPG.Checked = false;
            checkRacing.Checked = false;
            checkIndie.Checked = false;
            checkCasual.Checked = false;
            checkAdventure.Checked = false;
            checkStrategy.Checked = false;
            checkSinglePlayer.Checked = false;
            checkSimulation.Checked = false;
            checkSports.Checked = false;
            checkCoop.Checked = false;
            checkMultiplayer.Checked = false;
            checkControllerPartial.Checked = false;
            checkVR.Checked = false;
            checkControllerFull.Checked = false;
        }

        private void gameListView_DoubleClick(object sender, EventArgs e)
        {
            _controller.StartGame(gameListView.SelectedIndex);
        }

        private void spielEntfernenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _controller.DeleteGame(gameListView.SelectedIndex);
            gameListView.Invalidate();
        }

        private void spielStartenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.StartGame(gameListView.SelectedIndex);
        }

        private void spielHinzufügenToolStripMenuItem_Click(object sender, EventArgs eventArguments)
        {
            var propertiesForm = new GameProperties(_controller,
                new Point(Cursor.Position.X, Cursor.Position.Y),
                new Model.GameData());
            propertiesForm.ShowDialog(this);
        }

        private void eigenschaftenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var propertiesForm = new GameProperties(
                _controller,
                new Point(Cursor.Position.X, Cursor.Position.Y),
                (Model.GameData)gameListView.SelectedObject,
                gameListView.SelectedIndex);
            propertiesForm.ShowDialog(this);
        }

    }
}
