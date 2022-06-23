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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.win.Checked = Settings.Default.highlightWin;
            this.next.Checked = Settings.Default.highlightNext;
        }

        private void save_Click(object sender, EventArgs e)
        {
            Settings.Default.highlightWin = this.win.Checked;
            Settings.Default.highlightNext = this.next.Checked;
            Settings.Default.Save();
            Form m = Application.OpenForms.Cast<Form>().Where(x => x.Name == "Menu").FirstOrDefault();
            m.Activate();
            this.Close();
        }

        private void win_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
