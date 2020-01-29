using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace Sensor_tem_y_humedad
{
    public partial class Form1 : Form
    {
        private SerialPort arduino;
        private string com = "";
        private DateTime hora;

        public Form1()
        {
            InitializeComponent();
            MostarPuertos();
        }

        public void Conectar() {
            try
            {
                arduino = new SerialPort();
                arduino.PortName = com;
                arduino.BaudRate = 9600;
                arduino.Open();
            }
            catch (Exception e) {
                MessageBox.Show("Error: "+e.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public void Desconectar() {
            try
            {
                arduino.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void MostarPuertos(){
            foreach (string port in SerialPort.GetPortNames()) {
                Puerto.Items.Add(port);
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            MostarPuertos();
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            if (com != "" && arduino!=null)
            {
                try
                {
                    hora = DateTime.Now;
                    Datos.Items.Add(arduino.ReadLine()+" | "+hora.ToLocalTime());
                    
                }
                catch (Exception a)
                {
                    Tiempo.Enabled = false;
                    Puerto.Enabled = true;
                    MessageBox.Show("Error: " + a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Puerto_SelectedIndexChanged(object sender, EventArgs e)
        {
            com = Puerto.SelectedItem.ToString();
            MessageBox.Show("Puerto "+com+" seleccionado conexito");
            Conectar();
            Puerto.Enabled = false;
            if (com != "") {
                Tiempo.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Desconectar();
            com = "";
            Datos.Enabled = false;
            Puerto.Enabled = true;
            arduino = null;
            MessageBox.Show("¡Puerto desconectado con exito!");
        }
    }
}
