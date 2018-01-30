using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latin_Translator
{
    public partial class latinTranslator : Form
    {
        public latinTranslator()
        {
            InitializeComponent();
        }

        private void latinSinisterButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The English translation is left");
        }

        private void latinDexterButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The English translation is right");
        }

        private void latinMediumButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This English translation is center");
        }
    }
}
