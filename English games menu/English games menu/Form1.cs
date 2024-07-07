using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace English_games_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGame1_Click(object sender, EventArgs e)
        {
            try
            {
                EnglishMatchWordToPic.Form1 frm = new EnglishMatchWordToPic.Form1();
                frm.Show(); // Changed from ShowDialog() to Show()
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGame2_Click(object sender, EventArgs e)
        {
            try
            {
                MatchingGameAP.Form1 frm = new MatchingGameAP.Form1();
                frm.Show(); // Changed from ShowDialog() to Show()
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGame3_Click(object sender, EventArgs e)
        {
            try
            {
                EnglishGame3.Form1 frm = new EnglishGame3.Form1();
                frm.Show(); // Changed from ShowDialog() to Show()
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
