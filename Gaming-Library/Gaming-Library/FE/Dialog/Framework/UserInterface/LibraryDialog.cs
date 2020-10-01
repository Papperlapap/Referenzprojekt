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
        private bool isFilterCollapsed = true;
        private bool isDropdownCollapsed = true;
        public LibraryDialog()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            //request to controller to return data from DA as list of viewmodels
            var listOfViewModels = createTestObjects();
            objectListView1.SetObjects(listOfViewModels);

        }

        private GameData[] createTestObjects()
        {
            GameData[] gameData = new GameData[2];
            gameData[0].Genre = "Action";
            gameData[0].Title = "Among Us";
            gameData[0].YearOfPublication = "2018";
            gameData[0].Image = Properties.Resources.amongus;
            gameData[1].Genre = "Action";
            gameData[1].Title = "Counter Strike";
            gameData[1].YearOfPublication = "2012";
            gameData[1].Image = Properties.Resources.csgo;
            return gameData;
        }

        private void button1_MouseHover(object sender, EventArgs eventArguments)
        {
            //contextMenuStrip1.Show(button1, new Point(0, button1.Height));
        }

        private void contextMenuStrip1_MouseLeave(object sender, EventArgs eventArguments)
        {
            contextMenuStrip1.Hide();
        }

        private void button1_MouseLeave(object sender, EventArgs eventArguments)
        {
            if (!contextMenuStrip1.Bounds.Contains(MousePosition)) {
                contextMenuStrip1.Hide();
            }
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
            textBox1.Text = "";
            textBox1.TextAlign = HorizontalAlignment.Left;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Text = Settings.Default.SearchField;
            textBox1.TextAlign = HorizontalAlignment.Right;
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
            timer1.Start();
        }
        private void setObjectListAnchorsForFilterPanel()
        {
            //we need to remove the top-anchor to be able to move the objectlist further down
            objectListView1.Anchor =
                AnchorStyles.Bottom
                | AnchorStyles.Left
                | AnchorStyles.Right;
        }
        private void resetObjectListAnchors()
        {
            objectListView1.Anchor =
                AnchorStyles.Top
                | AnchorStyles.Bottom
                | AnchorStyles.Left
                | AnchorStyles.Right;
        }

        private void AdjustComponents(int adjustment)
        {
            //if (WindowState == FormWindowState.Maximized) {
            objectListView1.Location = new Point(
                objectListView1.Location.X,
                objectListView1.Location.Y + adjustment
                );
            panel1.Height += adjustment;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            setObjectListAnchorsForFilterPanel();

            if (isFilterCollapsed) {
                button3.Image = Properties.Resources.shrink_white;
                AdjustComponents(5);
                if (panel1.Height == panel1.MaximumSize.Height) {
                    isFilterCollapsed = false;
                    timer1.Stop();
                }
            } else if (!isFilterCollapsed) {
                button3.Image = Properties.Resources.image_1_;
                AdjustComponents(-5);
                if (panel1.Height == panel1.MinimumSize.Height) {
                    isFilterCollapsed = true;
                    timer1.Stop();
                }
            }

            resetObjectListAnchors();
        }

        private void objectListView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) {
                //ignore, if no row is selected
                if (objectListView1.SelectedItem != null) {
                    var mousePosition = objectListView1.PointToClient(Cursor.Position);
                    contextMenuStrip2.Show(objectListView1, mousePosition);
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
                button1.Image = Properties.Resources.shrink_white;
                panel3.Height += 2;
                if (panel3.Height == panel3.MaximumSize.Height) {
                    isDropdownCollapsed = false;
                    timer2.Stop();
                }
            } else if (!isDropdownCollapsed) {
                button1.Image = Properties.Resources.image_1_;
                panel3.Height -= 2;
                if (panel3.Height == panel3.MinimumSize.Height) {
                    isDropdownCollapsed = true;
                    timer2.Stop();
                }
            }
        }
    }
}
