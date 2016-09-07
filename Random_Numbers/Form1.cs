using System;
using System.Windows.Forms;

namespace Random_Numbers {
    public partial class Form1 : Form {
        public Form1() { InitializeComponent(); }
        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e) {
            lbxFlavors.Items.Add("Chocolate");
            lbxFlavors.Items.Add("Vanilla");
            lbxFlavors.Items.Add("Cookie Dough");
            lbxFlavors.Items.Add("Strawberry");
            lbxFlavors.Items.Add("Monster Mash");
            lbxFlavors.Items.Add("Birthday Cake");
            lbxFlavors.Items.Add("Rockin' Poppin' Cotton Candy");
            lbxFlavors.Items.Add("Hunka Chunka PB Fudge");
            lbxFlavors.Items.Add("Jim Dandy");
        }

        private void lblFlavor_Click(object sender, EventArgs e) { }

        private void lbxFlavors_SelectedIndexChanged(object sender, EventArgs e) {
            lblFlavor.Text = lbxFlavors.SelectedItem.ToString();
        }
    }
}