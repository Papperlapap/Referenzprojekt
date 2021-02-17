
namespace Gaming_Library.GenresPropertyDialog.FE.Dialog.Framework.UserInterface
{
    partial class ListOfGenres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListOfGenres));
            this.genresListView = new System.Windows.Forms.ListView();
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.buttonDeleteGenre = new System.Windows.Forms.Button();
            this.buttonAddGenre = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // genresListView
            // 
            this.genresListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Genre});
            this.genresListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.genresListView.HideSelection = false;
            this.genresListView.Location = new System.Drawing.Point(12, 12);
            this.genresListView.MinimumSize = new System.Drawing.Size(75, 140);
            this.genresListView.Name = "genresListView";
            this.genresListView.Scrollable = false;
            this.genresListView.Size = new System.Drawing.Size(75, 166);
            this.genresListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.genresListView.TabIndex = 0;
            this.genresListView.UseCompatibleStateImageBehavior = false;
            this.genresListView.View = System.Windows.Forms.View.List;
            // 
            // Genre
            // 
            this.Genre.Text = "Genre";
            this.Genre.Width = 74;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGenre.Location = new System.Drawing.Point(108, 62);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(129, 20);
            this.textBoxGenre.TabIndex = 7;
            this.textBoxGenre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGenre_KeyPress);
            // 
            // buttonDeleteGenre
            // 
            this.buttonDeleteGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteGenre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDeleteGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonDeleteGenre.FlatAppearance.BorderSize = 0;
            this.buttonDeleteGenre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonDeleteGenre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonDeleteGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteGenre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDeleteGenre.Location = new System.Drawing.Point(108, 12);
            this.buttonDeleteGenre.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDeleteGenre.Name = "buttonDeleteGenre";
            this.buttonDeleteGenre.Size = new System.Drawing.Size(124, 20);
            this.buttonDeleteGenre.TabIndex = 6;
            this.buttonDeleteGenre.Text = "Genre löschen";
            this.buttonDeleteGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteGenre.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDeleteGenre.UseVisualStyleBackColor = false;
            this.buttonDeleteGenre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonDeleteGenre_MouseClick);
            // 
            // buttonAddGenre
            // 
            this.buttonAddGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddGenre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonAddGenre.FlatAppearance.BorderSize = 0;
            this.buttonAddGenre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonAddGenre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonAddGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddGenre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddGenre.Location = new System.Drawing.Point(108, 37);
            this.buttonAddGenre.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddGenre.Name = "buttonAddGenre";
            this.buttonAddGenre.Size = new System.Drawing.Size(124, 20);
            this.buttonAddGenre.TabIndex = 8;
            this.buttonAddGenre.Text = "Genre hinzufügen";
            this.buttonAddGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddGenre.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonAddGenre.UseVisualStyleBackColor = false;
            this.buttonAddGenre.Visible = false;
            this.buttonAddGenre.Click += new System.EventHandler(this.buttonAddGenre_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonSubmit.FlatAppearance.BorderSize = 0;
            this.buttonSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSubmit.Location = new System.Drawing.Point(113, 158);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(124, 20);
            this.buttonSubmit.TabIndex = 9;
            this.buttonSubmit.Text = "Übernehmen";
            this.buttonSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSubmit_MouseClick);
            // 
            // ListOfGenres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(242, 187);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonAddGenre);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.buttonDeleteGenre);
            this.Controls.Add(this.genresListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(258, 226);
            this.Name = "ListOfGenres";
            this.Text = "Genres";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ListOfGenres_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView genresListView;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Button buttonDeleteGenre;
        private System.Windows.Forms.Button buttonAddGenre;
        private System.Windows.Forms.Button buttonSubmit;
    }
}