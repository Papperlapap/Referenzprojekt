using System.Windows.Forms;

namespace Gaming_Library.Library
{
    partial class LibraryDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryDialog));
            this.olvColumn0 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.spielStartenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eigenschaftenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spielEntfernenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.spieleAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.gameListView = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.gamesImageList = new System.Windows.Forms.ImageList(this.components);
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonAddGame = new System.Windows.Forms.Button();
            this.buttonGames = new System.Windows.Forms.Button();
            this.buttonShowFilter = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxSearchTags = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkControllerFull = new System.Windows.Forms.CheckBox();
            this.checkVR = new System.Windows.Forms.CheckBox();
            this.checkControllerPartial = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkMultiplayer = new System.Windows.Forms.CheckBox();
            this.checkCoop = new System.Windows.Forms.CheckBox();
            this.checkSports = new System.Windows.Forms.CheckBox();
            this.checkAction = new System.Windows.Forms.CheckBox();
            this.checkSimulation = new System.Windows.Forms.CheckBox();
            this.checkSinglePlayer = new System.Windows.Forms.CheckBox();
            this.checkStrategy = new System.Windows.Forms.CheckBox();
            this.checkAdventure = new System.Windows.Forms.CheckBox();
            this.checkCasual = new System.Windows.Forms.CheckBox();
            this.checkIndie = new System.Windows.Forms.CheckBox();
            this.checkRacing = new System.Windows.Forms.CheckBox();
            this.buttonResetFilter = new System.Windows.Forms.Button();
            this.checkRPG = new System.Windows.Forms.CheckBox();
            this.checkMMP = new System.Windows.Forms.CheckBox();
            this.gameDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gameDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameListView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // olvColumn0
            // 
            this.olvColumn0.AspectName = "Title";
            this.olvColumn0.FillsFreeSpace = true;
            this.olvColumn0.Groupable = false;
            this.olvColumn0.HeaderForeColor = System.Drawing.Color.Black;
            this.olvColumn0.IsEditable = false;
            this.olvColumn0.Tag = "1";
            this.olvColumn0.Text = "Spiel";
            this.olvColumn0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn0.Width = 247;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielStartenToolStripMenuItem,
            this.eigenschaftenToolStripMenuItem,
            this.spielEntfernenToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(154, 70);
            // 
            // spielStartenToolStripMenuItem
            // 
            this.spielStartenToolStripMenuItem.Image = global::Gaming_Library.Properties.Resources.round_play_button;
            this.spielStartenToolStripMenuItem.Name = "spielStartenToolStripMenuItem";
            this.spielStartenToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.spielStartenToolStripMenuItem.Text = "Spiel starten";
            this.spielStartenToolStripMenuItem.Click += new System.EventHandler(this.spielStartenToolStripMenuItem_Click);
            // 
            // eigenschaftenToolStripMenuItem
            // 
            this.eigenschaftenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eigenschaftenToolStripMenuItem.Image")));
            this.eigenschaftenToolStripMenuItem.Name = "eigenschaftenToolStripMenuItem";
            this.eigenschaftenToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.eigenschaftenToolStripMenuItem.Text = "Eigenschaften";
            this.eigenschaftenToolStripMenuItem.Click += new System.EventHandler(this.eigenschaftenToolStripMenuItem_Click);
            // 
            // spielEntfernenToolStripMenuItem1
            // 
            this.spielEntfernenToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("spielEntfernenToolStripMenuItem1.Image")));
            this.spielEntfernenToolStripMenuItem1.Name = "spielEntfernenToolStripMenuItem1";
            this.spielEntfernenToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.spielEntfernenToolStripMenuItem1.Text = "Spiel entfernen";
            this.spielEntfernenToolStripMenuItem1.Click += new System.EventHandler(this.spielEntfernenToolStripMenuItem1_Click);
            // 
            // spieleAnzeigenToolStripMenuItem
            // 
            this.spieleAnzeigenToolStripMenuItem.Name = "spieleAnzeigenToolStripMenuItem";
            this.spieleAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spieleAnzeigenToolStripMenuItem.Text = "Spiele anzeigen";
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonStatistics.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonStatistics.Enabled = false;
            this.buttonStatistics.FlatAppearance.BorderSize = 0;
            this.buttonStatistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonStatistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatistics.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStatistics.Location = new System.Drawing.Point(342, 10);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(124, 20);
            this.buttonStatistics.TabIndex = 6;
            this.buttonStatistics.Text = "Statistiken";
            this.buttonStatistics.UseVisualStyleBackColor = false;
            // 
            // gameListView
            // 
            this.gameListView.AllColumns.Add(this.olvColumn3);
            this.gameListView.AllColumns.Add(this.olvColumn0);
            this.gameListView.AllColumns.Add(this.olvColumn1);
            this.gameListView.AllColumns.Add(this.olvColumn2);
            this.gameListView.AlternateRowBackColor = System.Drawing.Color.White;
            this.gameListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameListView.BackColor = System.Drawing.Color.LightGray;
            this.gameListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gameListView.CellEditUseWholeCell = false;
            this.gameListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn3,
            this.olvColumn0,
            this.olvColumn1,
            this.olvColumn2});
            this.gameListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.gameListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameListView.FullRowSelect = true;
            this.gameListView.GridLines = true;
            this.gameListView.HideSelection = false;
            this.gameListView.LargeImageList = this.gamesImageList;
            this.gameListView.Location = new System.Drawing.Point(0, 93);
            this.gameListView.Margin = new System.Windows.Forms.Padding(0);
            this.gameListView.Name = "gameListView";
            this.gameListView.RowHeight = 60;
            this.gameListView.Size = new System.Drawing.Size(808, 348);
            this.gameListView.SmallImageList = this.gamesImageList;
            this.gameListView.SortGroupItemsByPrimaryColumn = false;
            this.gameListView.TabIndex = 8;
            this.gameListView.UseCompatibleStateImageBehavior = false;
            this.gameListView.View = System.Windows.Forms.View.Details;
            this.gameListView.DoubleClick += new System.EventHandler(this.gameListView_DoubleClick);
            this.gameListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gameListView_MouseDown);
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "";
            this.olvColumn3.Groupable = false;
            this.olvColumn3.ImageAspectName = "Image";
            this.olvColumn3.IsEditable = false;
            this.olvColumn3.MaximumWidth = 110;
            this.olvColumn3.MinimumWidth = 110;
            this.olvColumn3.Sortable = false;
            this.olvColumn3.Text = "";
            this.olvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn3.Width = 110;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Genres";
            this.olvColumn1.FillsFreeSpace = true;
            this.olvColumn1.HeaderForeColor = System.Drawing.Color.Black;
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.Tag = "1";
            this.olvColumn1.Text = "Genres";
            this.olvColumn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn1.Width = 271;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Year";
            this.olvColumn2.FillsFreeSpace = true;
            this.olvColumn2.Groupable = false;
            this.olvColumn2.HeaderForeColor = System.Drawing.Color.Black;
            this.olvColumn2.IsEditable = false;
            this.olvColumn2.Tag = "1";
            this.olvColumn2.Text = "Erscheinungsjahr";
            this.olvColumn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn2.Width = 466;
            // 
            // gamesImageList
            // 
            this.gamesImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("gamesImageList.ImageStream")));
            this.gamesImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.gamesImageList.Images.SetKeyName(0, "add.png");
            this.gamesImageList.Images.SetKeyName(1, "delete.png");
            this.gamesImageList.Images.SetKeyName(2, "die-einstellungen.ico");
            this.gamesImageList.Images.SetKeyName(3, "die-einstellungen.png");
            this.gamesImageList.Images.SetKeyName(4, "expand-button.png");
            this.gamesImageList.Images.SetKeyName(5, "image(1).png");
            this.gamesImageList.Images.SetKeyName(6, "round-play-button.png");
            this.gamesImageList.Images.SetKeyName(7, "show.png");
            this.gamesImageList.Images.SetKeyName(8, "shrink-button.png");
            this.gamesImageList.Images.SetKeyName(9, "shrink-white.png");
            this.gamesImageList.Images.SetKeyName(10, "spiele.ico");
            this.gamesImageList.Images.SetKeyName(11, "start.png");
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxSearch.BackColor = System.Drawing.Color.LightGray;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Location = new System.Drawing.Point(342, 62);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(98, 20);
            this.textBoxSearch.TabIndex = 10;
            this.textBoxSearch.Text = "Suchen  🔍";
            this.textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxSearch.Enter += new System.EventHandler(this.searchInViewTextBox_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.searchInViewTextBox_Leave);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(674, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 20);
            this.button4.TabIndex = 11;
            this.button4.Text = "Stuff";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.buttonGames);
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Controls.Add(this.buttonStatistics);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.buttonShowFilter);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 91);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.buttonAddGame);
            this.panel3.Location = new System.Drawing.Point(10, 31);
            this.panel3.MaximumSize = new System.Drawing.Size(124, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 0);
            this.panel3.TabIndex = 14;
            // 
            // buttonAddGame
            // 
            this.buttonAddGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddGame.BackColor = System.Drawing.Color.Silver;
            this.buttonAddGame.FlatAppearance.BorderSize = 0;
            this.buttonAddGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonAddGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonAddGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddGame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddGame.Image = global::Gaming_Library.Properties.Resources.plus_dark;
            this.buttonAddGame.Location = new System.Drawing.Point(0, 0);
            this.buttonAddGame.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddGame.Name = "buttonAddGame";
            this.buttonAddGame.Size = new System.Drawing.Size(124, 28);
            this.buttonAddGame.TabIndex = 18;
            this.buttonAddGame.Text = "Hinzufügen";
            this.buttonAddGame.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonAddGame.UseVisualStyleBackColor = false;
            this.buttonAddGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonAddGame_MouseClick);
            // 
            // buttonGames
            // 
            this.buttonGames.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonGames.FlatAppearance.BorderSize = 0;
            this.buttonGames.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonGames.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGames.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGames.Image = global::Gaming_Library.Properties.Resources.expand_white;
            this.buttonGames.Location = new System.Drawing.Point(10, 10);
            this.buttonGames.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGames.Name = "buttonGames";
            this.buttonGames.Size = new System.Drawing.Size(124, 20);
            this.buttonGames.TabIndex = 5;
            this.buttonGames.Text = "Spiele";
            this.buttonGames.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonGames.UseVisualStyleBackColor = false;
            this.buttonGames.Click += new System.EventHandler(this.buttonGames_Click);
            // 
            // buttonShowFilter
            // 
            this.buttonShowFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonShowFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonShowFilter.FlatAppearance.BorderSize = 0;
            this.buttonShowFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonShowFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonShowFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold);
            this.buttonShowFilter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonShowFilter.Image = global::Gaming_Library.Properties.Resources.expand_white;
            this.buttonShowFilter.Location = new System.Drawing.Point(439, 62);
            this.buttonShowFilter.Name = "buttonShowFilter";
            this.buttonShowFilter.Size = new System.Drawing.Size(27, 20);
            this.buttonShowFilter.TabIndex = 9;
            this.buttonShowFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonShowFilter.UseVisualStyleBackColor = false;
            this.buttonShowFilter.Click += new System.EventHandler(this.openFilterView_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.textBoxSearchTags);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkControllerFull);
            this.panel1.Controls.Add(this.checkVR);
            this.panel1.Controls.Add(this.checkControllerPartial);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkMultiplayer);
            this.panel1.Controls.Add(this.checkCoop);
            this.panel1.Controls.Add(this.checkSports);
            this.panel1.Controls.Add(this.checkAction);
            this.panel1.Controls.Add(this.checkSimulation);
            this.panel1.Controls.Add(this.checkSinglePlayer);
            this.panel1.Controls.Add(this.checkStrategy);
            this.panel1.Controls.Add(this.checkAdventure);
            this.panel1.Controls.Add(this.checkCasual);
            this.panel1.Controls.Add(this.checkIndie);
            this.panel1.Controls.Add(this.checkRacing);
            this.panel1.Controls.Add(this.buttonResetFilter);
            this.panel1.Controls.Add(this.checkRPG);
            this.panel1.Controls.Add(this.checkMMP);
            this.panel1.Location = new System.Drawing.Point(0, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MaximumSize = new System.Drawing.Size(4000, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 0);
            this.panel1.TabIndex = 14;
            // 
            // textBoxSearchTags
            // 
            this.textBoxSearchTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchTags.BackColor = System.Drawing.Color.White;
            this.textBoxSearchTags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearchTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchTags.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSearchTags.Location = new System.Drawing.Point(635, 20);
            this.textBoxSearchTags.Multiline = true;
            this.textBoxSearchTags.Name = "textBoxSearchTags";
            this.textBoxSearchTags.Size = new System.Drawing.Size(163, 20);
            this.textBoxSearchTags.TabIndex = 23;
            this.textBoxSearchTags.Text = "hier tags eingeben";
            this.textBoxSearchTags.MouseClick += new System.Windows.Forms.MouseEventHandler(this.filterTextBox_MouseClick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(632, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tags";
            // 
            // checkControllerFull
            // 
            this.checkControllerFull.AutoSize = true;
            this.checkControllerFull.Location = new System.Drawing.Point(517, 38);
            this.checkControllerFull.Margin = new System.Windows.Forms.Padding(0);
            this.checkControllerFull.Name = "checkControllerFull";
            this.checkControllerFull.Size = new System.Drawing.Size(95, 17);
            this.checkControllerFull.TabIndex = 21;
            this.checkControllerFull.Text = "Controller (voll)";
            this.checkControllerFull.UseVisualStyleBackColor = true;
            // 
            // checkVR
            // 
            this.checkVR.AutoSize = true;
            this.checkVR.Location = new System.Drawing.Point(517, 56);
            this.checkVR.Margin = new System.Windows.Forms.Padding(0);
            this.checkVR.Name = "checkVR";
            this.checkVR.Size = new System.Drawing.Size(41, 17);
            this.checkVR.TabIndex = 20;
            this.checkVR.Text = "VR";
            this.checkVR.UseVisualStyleBackColor = true;
            // 
            // checkControllerPartial
            // 
            this.checkControllerPartial.AutoSize = true;
            this.checkControllerPartial.Location = new System.Drawing.Point(517, 20);
            this.checkControllerPartial.Margin = new System.Windows.Forms.Padding(0);
            this.checkControllerPartial.Name = "checkControllerPartial";
            this.checkControllerPartial.Size = new System.Drawing.Size(119, 17);
            this.checkControllerPartial.TabIndex = 19;
            this.checkControllerPartial.Text = "Controller (teilweise)";
            this.checkControllerPartial.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(514, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hardware Support";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Spieler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Genre";
            // 
            // checkMultiplayer
            // 
            this.checkMultiplayer.AutoSize = true;
            this.checkMultiplayer.Location = new System.Drawing.Point(320, 20);
            this.checkMultiplayer.Margin = new System.Windows.Forms.Padding(0);
            this.checkMultiplayer.Name = "checkMultiplayer";
            this.checkMultiplayer.Size = new System.Drawing.Size(80, 17);
            this.checkMultiplayer.TabIndex = 15;
            this.checkMultiplayer.Text = "Mehrspieler";
            this.checkMultiplayer.UseVisualStyleBackColor = true;
            // 
            // checkCoop
            // 
            this.checkCoop.AutoSize = true;
            this.checkCoop.Location = new System.Drawing.Point(320, 56);
            this.checkCoop.Margin = new System.Windows.Forms.Padding(0);
            this.checkCoop.Name = "checkCoop";
            this.checkCoop.Size = new System.Drawing.Size(77, 17);
            this.checkCoop.TabIndex = 14;
            this.checkCoop.Text = "Kooperativ";
            this.checkCoop.UseVisualStyleBackColor = true;
            // 
            // checkSports
            // 
            this.checkSports.AutoSize = true;
            this.checkSports.Location = new System.Drawing.Point(192, 56);
            this.checkSports.Margin = new System.Windows.Forms.Padding(0);
            this.checkSports.Name = "checkSports";
            this.checkSports.Size = new System.Drawing.Size(56, 17);
            this.checkSports.TabIndex = 13;
            this.checkSports.Text = "Sports";
            this.checkSports.UseVisualStyleBackColor = true;
            // 
            // checkAction
            // 
            this.checkAction.AutoSize = true;
            this.checkAction.Location = new System.Drawing.Point(10, 20);
            this.checkAction.Margin = new System.Windows.Forms.Padding(0);
            this.checkAction.Name = "checkAction";
            this.checkAction.Size = new System.Drawing.Size(56, 17);
            this.checkAction.TabIndex = 12;
            this.checkAction.Text = "Action";
            this.checkAction.UseVisualStyleBackColor = true;
            // 
            // checkSimulation
            // 
            this.checkSimulation.AutoSize = true;
            this.checkSimulation.Location = new System.Drawing.Point(101, 56);
            this.checkSimulation.Margin = new System.Windows.Forms.Padding(0);
            this.checkSimulation.Name = "checkSimulation";
            this.checkSimulation.Size = new System.Drawing.Size(74, 17);
            this.checkSimulation.TabIndex = 11;
            this.checkSimulation.Text = "Simulation";
            this.checkSimulation.UseVisualStyleBackColor = true;
            // 
            // checkSinglePlayer
            // 
            this.checkSinglePlayer.AutoSize = true;
            this.checkSinglePlayer.Location = new System.Drawing.Point(320, 38);
            this.checkSinglePlayer.Margin = new System.Windows.Forms.Padding(0);
            this.checkSinglePlayer.Name = "checkSinglePlayer";
            this.checkSinglePlayer.Size = new System.Drawing.Size(84, 17);
            this.checkSinglePlayer.TabIndex = 10;
            this.checkSinglePlayer.Text = "Einzelspieler";
            this.checkSinglePlayer.UseVisualStyleBackColor = true;
            // 
            // checkStrategy
            // 
            this.checkStrategy.AutoSize = true;
            this.checkStrategy.Location = new System.Drawing.Point(192, 74);
            this.checkStrategy.Margin = new System.Windows.Forms.Padding(0);
            this.checkStrategy.Name = "checkStrategy";
            this.checkStrategy.Size = new System.Drawing.Size(65, 17);
            this.checkStrategy.TabIndex = 9;
            this.checkStrategy.Text = "Strategy";
            this.checkStrategy.UseVisualStyleBackColor = true;
            // 
            // checkAdventure
            // 
            this.checkAdventure.AutoSize = true;
            this.checkAdventure.Location = new System.Drawing.Point(10, 38);
            this.checkAdventure.Margin = new System.Windows.Forms.Padding(0);
            this.checkAdventure.Name = "checkAdventure";
            this.checkAdventure.Size = new System.Drawing.Size(75, 17);
            this.checkAdventure.TabIndex = 8;
            this.checkAdventure.Text = "Adventure";
            this.checkAdventure.UseVisualStyleBackColor = true;
            // 
            // checkCasual
            // 
            this.checkCasual.AutoSize = true;
            this.checkCasual.Location = new System.Drawing.Point(10, 56);
            this.checkCasual.Margin = new System.Windows.Forms.Padding(0);
            this.checkCasual.Name = "checkCasual";
            this.checkCasual.Size = new System.Drawing.Size(58, 17);
            this.checkCasual.TabIndex = 7;
            this.checkCasual.Text = "Casual";
            this.checkCasual.UseVisualStyleBackColor = true;
            // 
            // checkIndie
            // 
            this.checkIndie.AutoSize = true;
            this.checkIndie.Location = new System.Drawing.Point(10, 74);
            this.checkIndie.Margin = new System.Windows.Forms.Padding(0);
            this.checkIndie.Name = "checkIndie";
            this.checkIndie.Size = new System.Drawing.Size(49, 17);
            this.checkIndie.TabIndex = 6;
            this.checkIndie.Text = "Indie";
            this.checkIndie.UseVisualStyleBackColor = true;
            // 
            // checkRacing
            // 
            this.checkRacing.AutoSize = true;
            this.checkRacing.Location = new System.Drawing.Point(101, 20);
            this.checkRacing.Margin = new System.Windows.Forms.Padding(0);
            this.checkRacing.Name = "checkRacing";
            this.checkRacing.Size = new System.Drawing.Size(60, 17);
            this.checkRacing.TabIndex = 5;
            this.checkRacing.Text = "Racing";
            this.checkRacing.UseVisualStyleBackColor = true;
            // 
            // buttonResetFilter
            // 
            this.buttonResetFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResetFilter.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonResetFilter.FlatAppearance.BorderSize = 0;
            this.buttonResetFilter.Location = new System.Drawing.Point(718, -26);
            this.buttonResetFilter.Name = "buttonResetFilter";
            this.buttonResetFilter.Size = new System.Drawing.Size(87, 23);
            this.buttonResetFilter.TabIndex = 4;
            this.buttonResetFilter.Text = "Zurücksetzen";
            this.buttonResetFilter.UseVisualStyleBackColor = false;
            this.buttonResetFilter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonResetFilter_MouseClick);
            // 
            // checkRPG
            // 
            this.checkRPG.AutoSize = true;
            this.checkRPG.Location = new System.Drawing.Point(101, 38);
            this.checkRPG.Margin = new System.Windows.Forms.Padding(0);
            this.checkRPG.Name = "checkRPG";
            this.checkRPG.Size = new System.Drawing.Size(49, 17);
            this.checkRPG.TabIndex = 2;
            this.checkRPG.Text = "RPG";
            this.checkRPG.UseVisualStyleBackColor = true;
            // 
            // checkMMP
            // 
            this.checkMMP.AutoSize = true;
            this.checkMMP.Location = new System.Drawing.Point(101, 74);
            this.checkMMP.Margin = new System.Windows.Forms.Padding(0);
            this.checkMMP.Name = "checkMMP";
            this.checkMMP.Size = new System.Drawing.Size(91, 17);
            this.checkMMP.TabIndex = 1;
            this.checkMMP.Text = "Massively MP";
            this.checkMMP.UseVisualStyleBackColor = true;
            // 
            // gameDataBindingSource1
            // 
            this.gameDataBindingSource1.DataSource = typeof(Gaming_Library.Library.BL.UseCase.Entity.GameData);
            // 
            // gameDataBindingSource
            // 
            this.gameDataBindingSource.DataSource = typeof(Gaming_Library.Library.BL.UseCase.Entity.GameData);
            // 
            // LibraryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(808, 434);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gameListView);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 5000);
            this.MinimumSize = new System.Drawing.Size(824, 473);
            this.Name = "LibraryDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibliothek";
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameListView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource gameDataBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem spielStartenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eigenschaftenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spielEntfernenToolStripMenuItem1;
        private ToolStripMenuItem spieleAnzeigenToolStripMenuItem;
        private Button buttonStatistics;
        private BindingSource gameDataBindingSource1;
        private BrightIdeasSoftware.ObjectListView gameListView;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private Button buttonShowFilter;
        private TextBox textBoxSearch;
        private ImageList gamesImageList;
        private Button button4;
        private Timer timer1;
        private Panel panel2;
        private BrightIdeasSoftware.OLVColumn olvColumn0;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private Button buttonGames;
        private Timer timer2;
        private Panel panel3;
        private Button buttonAddGame;
        private Panel panel1;
        private TextBox textBoxSearchTags;
        private Label label4;
        private CheckBox checkControllerFull;
        private CheckBox checkVR;
        private CheckBox checkControllerPartial;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox checkMultiplayer;
        private CheckBox checkCoop;
        private CheckBox checkSports;
        private CheckBox checkAction;
        private CheckBox checkSimulation;
        private CheckBox checkSinglePlayer;
        private CheckBox checkStrategy;
        private CheckBox checkAdventure;
        private CheckBox checkCasual;
        private CheckBox checkIndie;
        private CheckBox checkRacing;
        private Button buttonResetFilter;
        private CheckBox checkRPG;
        private CheckBox checkMMP;
    }
}