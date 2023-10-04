using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace richTextBoxKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void brisiBtn_Click(object sender, EventArgs e)
        {
            Textb.Clear();
        }

        private void citajBtn_Click(object sender, EventArgs e)
        {
            Textb.SaveFile(@"C:Tempproba.rtf");

            MessageBox.Show("Tekst spremljen");
        }

        private void spremiBtn_Click(object sender, EventArgs e)
        {
            Textb.LoadFile(@"C:Tempproba.rtf");
        }
    }
}
