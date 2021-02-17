namespace Gaming_Library.ChooseSteamGame.FE.Dialog.Framework.UserInterface
{
    partial class ChooseSteamGameDialog
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
            this.listBox_showAllSearchResults = new System.Windows.Forms.ListBox();
            this.appBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_cancelButton = new System.Windows.Forms.Button();
            this.button_confirmButton = new System.Windows.Forms.Button();
            this.button_searchButton = new System.Windows.Forms.Button();
            this.textBox_searchBar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.appBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_showAllSearchResults
            // 
            this.listBox_showAllSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_showAllSearchResults.DataSource = this.appBindingSource;
            this.listBox_showAllSearchResults.DisplayMember = "name";
            this.listBox_showAllSearchResults.FormattingEnabled = true;
            this.listBox_showAllSearchResults.Location = new System.Drawing.Point(12, 36);
            this.listBox_showAllSearchResults.Name = "listBox_showAllSearchResults";
            this.listBox_showAllSearchResults.Size = new System.Drawing.Size(768, 329);
            this.listBox_showAllSearchResults.TabIndex = 0;
            this.listBox_showAllSearchResults.ValueMember = "appid";
            this.listBox_showAllSearchResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // appBindingSource
            // 
            this.appBindingSource.DataSource = typeof(Gaming_Library.ChooseSteamGame.BL.UseCase.Entity.Types.App);
            // 
            // button_cancelButton
            // 
            this.button_cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancelButton.Location = new System.Drawing.Point(725, 10);
            this.button_cancelButton.Name = "button_cancelButton";
            this.button_cancelButton.Size = new System.Drawing.Size(55, 23);
            this.button_cancelButton.TabIndex = 2;
            this.button_cancelButton.Text = "Cancel";
            this.button_cancelButton.UseVisualStyleBackColor = true;
            this.button_cancelButton.Click += new System.EventHandler(this.button_cancelButton_Click);
            // 
            // button_confirmButton
            // 
            this.button_confirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_confirmButton.Location = new System.Drawing.Point(654, 10);
            this.button_confirmButton.Name = "button_confirmButton";
            this.button_confirmButton.Size = new System.Drawing.Size(65, 23);
            this.button_confirmButton.TabIndex = 3;
            this.button_confirmButton.Text = "Bestätigen";
            this.button_confirmButton.UseVisualStyleBackColor = true;
            this.button_confirmButton.Click += new System.EventHandler(this.button_confirmButton_Click);
            // 
            // button_searchButton
            // 
            this.button_searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_searchButton.Location = new System.Drawing.Point(593, 10);
            this.button_searchButton.Name = "button_searchButton";
            this.button_searchButton.Size = new System.Drawing.Size(55, 23);
            this.button_searchButton.TabIndex = 4;
            this.button_searchButton.Text = "Suchen";
            this.button_searchButton.UseVisualStyleBackColor = true;
            this.button_searchButton.Click += new System.EventHandler(this.button_searchButton_Click);
            // 
            // textBox_searchBar
            // 
            this.textBox_searchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_searchBar.Location = new System.Drawing.Point(12, 12);
            this.textBox_searchBar.Name = "textBox_searchBar";
            this.textBox_searchBar.Size = new System.Drawing.Size(575, 20);
            this.textBox_searchBar.TabIndex = 5;
            // 
            // ChooseSteamGameDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(792, 377);
            this.ControlBox = false;
            this.Controls.Add(this.textBox_searchBar);
            this.Controls.Add(this.button_searchButton);
            this.Controls.Add(this.button_confirmButton);
            this.Controls.Add(this.button_cancelButton);
            this.Controls.Add(this.listBox_showAllSearchResults);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseSteamGameDialog";
            this.ShowInTaskbar = false;
            this.Text = "ChooseSteamGameDialog";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.appBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_showAllSearchResults;
        private System.Windows.Forms.BindingSource appBindingSource;
        private System.Windows.Forms.Button button_cancelButton;
        private System.Windows.Forms.Button button_confirmButton;
        private System.Windows.Forms.Button button_searchButton;
        private System.Windows.Forms.TextBox textBox_searchBar;
    }
}