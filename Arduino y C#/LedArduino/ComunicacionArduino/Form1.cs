using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace ComunicacionArduino
{
    public partial class Linterna : Form
    {
        private SerialPort arduino;
        private string com = "";

        public Linterna()
        {
            InitializeComponent();
            mostrarlista();
        }

        public void Conectar()
        {
            try
            {
                arduino = new SerialPort();
                arduino.PortName = com;
                arduino.BaudRate = 9600;
                arduino.Open();
            }
            catch (Exception e) {
                MessageBox.Show("Error: "+e.Message,"¡Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void Desconectar(){
            try
            {
                arduino.Close();
            }
            catch (Exception e) {
                MessageBox.Show("Error: " + e.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void mostrarlista(){
            Puertoserial.Items.Clear();
            foreach (string puertos in SerialPort.GetPortNames())
            {
                Puertoserial.Items.Add(puertos);
            }
        }
        private void Buscar_Click(object sender, EventArgs e)
        {
            mostrarlista();
            Panel.Visible = false;
            Puertoserial.Enabled = true;
            Onbtn.BackColor = Color.Black;
            Offbtn.BackColor = Color.Black;
        }

        private void Puertoserial_SelectedIndexChanged(object sender, EventArgs e)
        {
            com = Puertoserial.SelectedItem.ToString();
            MessageBox.Show("¡Puerto " + com + " seleccionado con exito!");
            Conectar();            
            Panel.Visible = true;
            Puertoserial.Enabled = false;
        }

        private void Onbtn_MouseHover(object sender, EventArgs e)
        {
            Onbtn.BackColor = Color.Green;
            Offbtn.BackColor = Color.Black;
            try {
                arduino.Write("1");
            }
            catch (Exception d)
            {
                MessageBox.Show("Error: " + d.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Offbtn_MouseHover(object sender, EventArgs e)
        {
            Offbtn.BackColor = Color.Red;
            Onbtn.BackColor = Color.Black;
            try
            {
                arduino.Write("0");
            }
            catch (Exception d)
            {
                MessageBox.Show("Error: " + d.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Desconectarbtn_Click(object sender, EventArgs e)
        {
            Panel.Visible = false;
            Puertoserial.Enabled = true;
            Onbtn.BackColor = Color.Black;
            Offbtn.BackColor = Color.Black;
            Desconectar();
        }    
    }
}
