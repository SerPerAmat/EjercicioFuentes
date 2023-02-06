using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioFuentes
{
    public partial class Form1 : Form

       
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            texto.Font = new Font(texto.Font, FontStyle.Bold);
            textBox.Font = new Font(textBox.Font, FontStyle.Bold);
            changeFontStyle(FontStyle.Bold);
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            texto.Font = new Font(texto.Font, FontStyle.Italic);
            textBox.Font = new Font(textBox.Font, FontStyle.Italic);
            changeFontStyle(FontStyle.Italic);
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            texto.Font = new Font(texto.Font, FontStyle.Underline);
            textBox.Font = new Font(textBox.Font, FontStyle.Underline);
            changeFontStyle(FontStyle.Underline);
        }

        private void texto_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void changeFontStyle(FontStyle style)
        {
            textBox.Font = new Font(textBox.Font, style);
        }
    }
}
