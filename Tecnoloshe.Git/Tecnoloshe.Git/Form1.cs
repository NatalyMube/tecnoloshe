using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tecnoloshe.Git
{
    public partial class Form1 : Form
    {
        private int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            //Tareas tarea = new Tareas();
            //long n= tarea.num();
            //label1.Text = n.ToString();
            Tareas tarea = new Tareas();
            await Task.Run(() =>
            {
                long n = tarea.num();
            });
            label1.Text = n.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            contador += 1;
            label2.Text = contador.ToString();

        }
    }
}
