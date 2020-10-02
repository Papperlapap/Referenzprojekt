﻿using System;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;
using BrightIdeasSoftware;
using Gaming_Library.BL.UseCase.Entity;
using Gaming_Library.FE.Dialog.Framework.UserInterface;
using Gaming_Library.Properties;

namespace Gaming_Library
{
    public partial class LibraryDialog : Form
    {
        private bool isDropdownCollapsed = true;
        private bool isFilterViewCollapsed = true;
        public LibraryDialog()
        {
            Settings.Default.Reset();
            InitializeComponent();
            if (!Settings.Default.FilterViewCollapsed) {
                timer1.Start();
            }
            LoadData();
        }

        private void LoadData()
        {
            //request to controller to return data from DA as list of viewmodels
            var listOfViewModels = createTestObjects();
            gameListView.SetObjects(listOfViewModels);

        }

        private GameData[] createTestObjects()
        {
            GameData[] gameData = new GameData[2];
            gameData[0].Genre = "Action";
            gameData[0].Title = "Among Us";
            gameData[0].YearOfPublication = "2018";
            gameData[0].Image = Resources.amongus;
            gameData[1].Genre = "Action";
            gameData[1].Title = "Counter Strike";
            gameData[1].YearOfPublication = "2012";
            gameData[1].Image = Resources.csgo;
            return gameData;
        }

        private void spielHinzufügenToolStripMenuItem_Click(object sender, EventArgs eventArguments)
        {
            //request an den controller zur öffnung des einstellungs-dialogs
            var propertiesForm = new GameProperties();
            propertiesForm.ShowDialog(this);
        }

        private void spielEntfernenToolStripMenuItem_Click(object sender, EventArgs eventArguments)
        {
            //request to controller
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs eventArguments)
        {
            //start game
        }

        private void eigenschaftenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //request an den controller zur öffnung des einstellungs-dialogs
            var propertiesForm = new GameProperties();
            propertiesForm.ShowDialog(this);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            textBoxSearch.TextAlign = HorizontalAlignment.Left;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBoxSearch.Text = Settings.Default.SearchField;
            textBoxSearch.TextAlign = HorizontalAlignment.Right;
        }

        private void objectListView1_SizeChanged(object sender, EventArgs e)
        {
            //if (resizing) {
            //    return;
            //}
            //// Set the resizing flag
            //resizing = true;

            //ObjectListView objectListView = sender as ObjectListView;
            //if (objectListView != null) {
            //    float totalColumnWidth = 0;

            //    // Get the sum of all column tags
            //    for (int i = 1; i < objectListView.Columns.Count; i++) {
            //        totalColumnWidth += Convert.ToInt32(objectListView.Columns[i].Tag);
            //    }

            //    // Calculate the percentage of space each column should 
            //    // occupy in reference to the other columns and then set the 
            //    // width of the column to that percentage of the visible space.
            //    for (int i = 1; i < objectListView.Columns.Count; i++) {
            //        float colPercentage = (Convert.ToInt32(objectListView.Columns[i].Tag) / (totalColumnWidth));

            //        //We have to take into account, that column1 is not resizable - ergo its width has to be subtracted.
            //        var relativeWidth = (colPercentage * (objectListView.ClientRectangle.Width - objectListView.Columns[0].Width));
            //        objectListView.Columns[i].Width = (int)relativeWidth;
            //    }
            //}
            //resizing = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HandleFirstAccess();
            timer1.Start();
        }

        private void HandleFirstAccess()
        {
            if (Settings.Default.IsFirstAccess) {
                DialogResult dialogResult = MessageBox.Show(
                    "Möchten Sie die Filter-View zu Beginn anzeigen lassen?\n",
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
            //if (WindowState == FormWindowState.Maximized) {
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

        private void objectListView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) {
                //ignore, if no row is selected
                if (gameListView.SelectedItem != null) {
                    var mousePosition = gameListView.PointToClient(Cursor.Position);
                    contextMenuStrip2.Show(gameListView, mousePosition);
                }
            }
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            //hide button after action was requested
            timer2.Start();
            //request an den controller zur öffnung des einstellungs-dialogs
            var propertiesForm = new GameProperties();
            propertiesForm.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs eventArguments)
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

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxSearchTags.Text = "";
            textBoxSearchTags.Font = new Font(textBoxSearchTags.Font, FontStyle.Regular);
            textBoxSearchTags.ForeColor = Color.Black;
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
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
    }
}
