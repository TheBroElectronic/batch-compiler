using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace batch_compiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RTB.Text = " ";
        }
 
        void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "guardar proyecto";
            saveFileDialog1.Filter = "batch(*.bat)|*.bat|vbs script(*.vbe)|*.vbe|documento de texto(*.txt)|*.txt ";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dir = saveFileDialog1.FileName;
                StreamWriter save = File.CreateText(dir);
                save.Write(RTB.Text);
                save.Close();
            }
            resetColor();
        }
        void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "cargar proyecto";
            openFileDialog1.Filter = "batch(*.bat)|*.bat|vbs script(*.vbe)|*.vbe|documento de texto(*.txt)|*.txt ";
            openFileDialog1.ShowDialog();
            string dir = openFileDialog1.FileName;
            if (File.Exists(openFileDialog1.FileName))
            {
                TextReader load = new StreamReader(dir);
                RTB.Text = load.ReadToEnd();
                load.Close();
            }
            resetColor();
        }
        void mensajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTB.Text = RTB.Text + "\r\n";
            RTB.Text = RTB.Text + "\r\n" + "msg * hola de parte de TB";
            resetColor();
        }
        void mensajeConsolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTB.Text = RTB.Text + "\r\n";
            RTB.Text = RTB.Text + "\r\n" + "echo hola en consola :D";
            RTB.Text = RTB.Text + "\r\n" + "pause";
            resetColor();
        }
        void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTB.Text = RTB.Text + "\r\n";
            RTB.Text = RTB.Text + "\r\n" + "color b";
            RTB.Text = RTB.Text + "\r\n" + "echo hola en consola azul :D";
            RTB.Text = RTB.Text + "\r\n" + "pause";
            resetColor();
        }
        void resetColor()
        {
            RTB.SelectAll();
            RTB.SelectionColor = Color.Black;
            RTB.Select(0, 0);
        }
        void compilarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Checker ch = new Checker();
            RTB.SelectAll();
            RTB.SelectionColor = Color.Red;
            RTB.Select(0, 0);

            Pbar.Minimum = 0;
            Pbar.Maximum = 20;
            Pbar.Step = 1;
            Pbar.Value = 0;

            int aux = 0;
            for (int i = 0; i < 40; i++)
            {
                //si la palabra existe busca hasta donde se encuentra la ultima palabra
                while (aux < RTB.Text.LastIndexOf(ch.findWord(i))) { 
                    //busca la palabra y la selecciona desde un caracter espesificado (aux) hasta el final del texto
                    RTB.Find(ch.findWord(i), aux , RTB.Text.Length , RichTextBoxFinds.None);
                    //cambia el color a... verde agua?
                    RTB.SelectionColor = Color.Aqua;
                    //busca la palabra a partir de una posision indicada y guarda la posicion +1 para buscar la siguiente
                    aux = RTB.Text.IndexOf(ch.findWord(i) , aux) + 1; 
                }
                Pbar.PerformStep();
                //resetea la posicion
                aux = 0;
            }
        }
    }
}
