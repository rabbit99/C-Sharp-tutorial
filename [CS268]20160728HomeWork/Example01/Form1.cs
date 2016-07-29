using GameLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            characterListBox.Items.Add(new 角色() { Name = "新手", Hp = 10, status = "角色" });
            characterListBox.Items.Add(new 戰士角色() { Name = "新手", Hp = 10, status = "戰士" });
            characterListBox.Items.Add(new 角色() { Name = "新手", Hp = 10, status = "角色" });
            this.BackColor = System.Drawing.Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "Audio Files (.wav)|*.wav";

            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    string path = dialog.FileName;
            //    playSound(path);
            //}
            characterListBox.Items.Add(new 角色() { Name = nameTextBox.Text, Hp = float.Parse(hpTextBox.Text), status = professionTextBox.Text });
        }

        private void playSound(string path)
        {
            System.Media.SoundPlayer player =
                new System.Media.SoundPlayer();
            player.SoundLocation = path;
            player.Load();
            player.Play();
        }

        private void characterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.BackColor = System.Drawing.Color.Black;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Set the search string:
            string myString = "新手";
            // Search starting from index -1:
            int index = characterListBox.FindString(myString, -1);
            if (index != -1)
            {
                // Select the found item:
                characterListBox.SetSelected(index, true);
                // Send a success message:
                MessageBox.Show("Found the item \"" + myString +
                    "\" at index: " + index);
            }
            else
                MessageBox.Show("Item not found.");
        }
    }
}