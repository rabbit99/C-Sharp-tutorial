namespace Example01
{
    partial class Form1
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
            if (disposing && (components != null))
            {
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
            this.createCharacterButton = new System.Windows.Forms.Button();
            this.characterListBox = new GameLibrary.combo.CharacterListBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.hpLabel = new System.Windows.Forms.Label();
            this.professionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.hpTextBox = new System.Windows.Forms.TextBox();
            this.professionTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createCharacterButton
            // 
            this.createCharacterButton.Location = new System.Drawing.Point(132, 211);
            this.createCharacterButton.Name = "createCharacterButton";
            this.createCharacterButton.Size = new System.Drawing.Size(174, 64);
            this.createCharacterButton.TabIndex = 0;
            this.createCharacterButton.Text = "CreateCharacter";
            this.createCharacterButton.UseVisualStyleBackColor = true;
            this.createCharacterButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // characterListBox
            // 
            this.characterListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.characterListBox.FormattingEnabled = true;
            this.characterListBox.ItemHeight = 30;
            this.characterListBox.Location = new System.Drawing.Point(421, 52);
            this.characterListBox.Name = "characterListBox";
            this.characterListBox.Size = new System.Drawing.Size(300, 244);
            this.characterListBox.TabIndex = 1;
            this.characterListBox.SelectedIndexChanged += new System.EventHandler(this.characterListBox_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(56, 46);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(40, 15);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Location = new System.Drawing.Point(64, 93);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(25, 15);
            this.hpLabel.TabIndex = 3;
            this.hpLabel.Text = "HP";
            // 
            // professionLabel
            // 
            this.professionLabel.AutoSize = true;
            this.professionLabel.Location = new System.Drawing.Point(43, 147);
            this.professionLabel.Name = "professionLabel";
            this.professionLabel.Size = new System.Drawing.Size(66, 15);
            this.professionLabel.TabIndex = 4;
            this.professionLabel.Text = "Profession";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(132, 39);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(185, 25);
            this.nameTextBox.TabIndex = 5;
            // 
            // hpTextBox
            // 
            this.hpTextBox.Location = new System.Drawing.Point(132, 93);
            this.hpTextBox.Name = "hpTextBox";
            this.hpTextBox.Size = new System.Drawing.Size(185, 25);
            this.hpTextBox.TabIndex = 6;
            // 
            // professionTextBox
            // 
            this.professionTextBox.Location = new System.Drawing.Point(132, 147);
            this.professionTextBox.Name = "professionTextBox";
            this.professionTextBox.Size = new System.Drawing.Size(185, 25);
            this.professionTextBox.TabIndex = 7;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(422, 322);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(98, 40);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 399);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.professionTextBox);
            this.Controls.Add(this.hpTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.professionLabel);
            this.Controls.Add(this.hpLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.characterListBox);
            this.Controls.Add(this.createCharacterButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createCharacterButton;
        private GameLibrary.combo.CharacterListBox characterListBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.Label professionLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox hpTextBox;
        private System.Windows.Forms.TextBox professionTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}

