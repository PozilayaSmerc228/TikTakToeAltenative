using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.Show();
        }

        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                     "1. Каждый ход делается в одном из маленьких полей.\n" +
                     "2. Достигший в маленьком поле расположения трёх одинаковых фигур в ряд выигрывает это поле.\n" +
                     "3. Чтобы выиграть игру, необходимо одержать победы в трёх маленьких полях в ряд.",
                     "Правила",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information,
                     MessageBoxDefaultButton.Button1,
                     MessageBoxOptions.DefaultDesktopOnly);
            this.Activate();
        }

        private void play_Click(object sender, EventArgs e)
        {
            GameForm gf = new GameForm(Settings.Default.highlightNext, Settings.Default.highlightWin);
            gf.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
