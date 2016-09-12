using System;
using System.IO;
using System.Windows.Forms;

namespace Random_Numbers {
    public partial class Form1 : Form {
        public Form1() { InitializeComponent(); }
        private void btnExit_Click(object sender, EventArgs e) { Close(); }

        private void Form1_Load(object sender, EventArgs e) {
            string flavor;
            try {
                StreamReader inputFile = File.OpenText("flavors.txt");
                while (!inputFile.EndOfStream) {
                    flavor = inputFile.ReadLine();
                    lbxFlavors.Items.Add(flavor);
                }
                inputFile.Close();
                lblFlavors.Text = lbxFlavors.Items.Count + 
                    " flavors available.";
            }
            catch (Exception ex) { 
                MessageBox.Show("Jimmy John's Ice Cream is closed because" + 
                    " of the following reason: " + ex.Message, "Sorry", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void lblFlavor_Click(object sender, EventArgs e) { }
        private void lbxFlavors_SelectedIndexChanged(object sender, EventArgs e) {
            lblFlavor.Text = lbxFlavors.SelectedItem.ToString();
        }
    }
}