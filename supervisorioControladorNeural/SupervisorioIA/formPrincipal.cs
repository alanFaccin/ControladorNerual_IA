using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;



namespace SupervisorioIA
{



    public partial class formPrincipal : Form
    {

        private String rxString;
        private int rxStringLengh = 20;
        int time = 0;
        /// <summary>
        /// Método construtor da classe.
        /// </summary>
        public formPrincipal()
        {
            InitializeComponent();
            this.atualizaPortas();
            this.populateComboBoxBaudRate();
        }

        /// <summary>
        /// Método responsável por popular o combobox com as portas COMs disponíveis.
        /// </summary>
        private void atualizaPortas()
        {
            this.comboBoxListPortas.Items.Clear();

            foreach (string portName in SerialPort.GetPortNames())
            {
                this.comboBoxListPortas.Items.Add(portName);
            }

            if (this.comboBoxListPortas.Items.Count == 1)
            {
                this.comboBoxListPortas.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Método responsável por popular o combobox do BaudRate.
        /// </summary>
        private void populateComboBoxBaudRate()
        {
            this.comboBoxBaudRate.Items.Add(300);
            this.comboBoxBaudRate.Items.Add(600);
            this.comboBoxBaudRate.Items.Add(1200);
            this.comboBoxBaudRate.Items.Add(2400);
            this.comboBoxBaudRate.Items.Add(4800);
            this.comboBoxBaudRate.Items.Add(9600);
            this.comboBoxBaudRate.Items.Add(14400);
            this.comboBoxBaudRate.Items.Add(19200);
            this.comboBoxBaudRate.Items.Add(28800);
            this.comboBoxBaudRate.Items.Add(38400);
            this.comboBoxBaudRate.Items.Add(57600);
            this.comboBoxBaudRate.Items.Add(115200);

            this.comboBoxBaudRate.SelectedIndex = 5;
        }

        /// <summary>
        /// Método responsável por tratar os dados recebidos da porta serial.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void trataDadoRecebido(Object sender, EventArgs e)
        {
            textBoxDisplayInfo.AppendText(this.rxString + "\r\n");

            

            if (this.rxString.Length > 5)
            {
                if (this.rxString.Substring(0, 1) == "%")
                {
                    string trat = this.rxString;

                    trat = trat.Remove(0, 17);

                    
                    chartValue.Series["Series1"].Points.AddXY(time, "50");
                    chartValue.Series["Series2"].Points.AddXY(time, (Convert.ToDouble(trat)).ToString());
                    
                    if (time >80)
                    {
                        time = 0; 
                        chartValue.Series["Series1"].Points.Clear(); // zera os gráficos
                        chartValue.Series["Series2"].Points.Clear(); // zera os gráficos
                    }
                    // imprime a entarda da ede neural
                    this.label_ent.Text = (Convert.ToDouble(trat)).ToString() + "%";
                    time++;
                }
                if (this.rxString.Substring(0, 1) == "#")
                {
                    string trat = this.rxString;
                    trat = trat.Remove(0, 15);
                    this.label_said.Text = trat;

                    //se for a saida ideal 
                    if (trat == " 1 | 1 | 0 | 1 | 1\r")
                    {
                        this.label_said.ForeColor = System.Drawing.Color.Green;
                    }else
                    {
                        this.label_said.ForeColor = System.Drawing.Color.Black;
                    }

                    // Ajusta label Atuadores bomba 1 
                    if (trat.Substring(1, 1) == "0")
                    {
                        this.labelb2.Text = "Ligado";
                        this.labelb2.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        this.labelb2.Text = "Desligado";
                        this.labelb2.ForeColor = System.Drawing.Color.Red;
                    }
                    // Ajusta label Atuadores bomba 2 
                    if (trat.Substring(5, 1) == "0")
                    {
                        this.labelb1.Text = "Ligado";
                        this.labelb1.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        this.labelb1.Text = "Desligado";
                        this.labelb1.ForeColor = System.Drawing.Color.Red;
                    }
                    // Ajusta label Atuadores valvula 1 
                    if (trat.Substring(13, 1) == "0")
                    {
                        this.labelv1.Text = "Ligado";
                        this.labelv1.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        this.labelv1.Text = "Desligado";
                        this.labelv1.ForeColor = System.Drawing.Color.Red;
                    }
                    // Ajusta label Atuadores valvula 2
                    if (trat.Substring(17, 1) == "0")
                    {
                        this.labelv2.Text = "Ligado";
                        this.labelv2.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        this.labelv2.Text = "Desligado";
                        this.labelv2.ForeColor = System.Drawing.Color.Red;
                    }
                }


            }//    this.textBoxDisplayInfo.AppendText("No Data");
        }

        /// <summary>
        /// Método responsável pelo evento textChanged do combobox comboBoxListPortas.
        /// Habilita o combobox "comboBoxBaudRate" e o botão "buttonConectar".
        /// </summary>
        private void comboBoxListPortas_TextChanged(object sender, EventArgs e)
        {
            this.comboBoxBaudRate.Enabled = true;
            this.buttonConectar.Enabled = true;
        }

        /// <summary>
        /// Método responsável pelo evento click do botão buttonConectar.
        /// Realiza a conexão com a porta(COM) especificada.
        /// </summary>
        private void buttonConectar_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen == false)
            {
                string portName = comboBoxListPortas.Items[comboBoxListPortas.SelectedIndex].ToString();
                serialPort.PortName = portName;

                int baudRate = Convert.ToInt32(comboBoxBaudRate.Items[comboBoxBaudRate.SelectedIndex].ToString());
                serialPort.BaudRate = baudRate;

                try
                {
                    serialPort.Open();

                    if (serialPort.IsOpen)
                    {
                        this.comboBoxListPortas.Enabled = false;
                        this.comboBoxBaudRate.Enabled = false;
                        this.buttonConectar.Enabled = false;
                        this.buttonDesconectar.Enabled = true;
                        this.buttonAtualizarPortas.Enabled = false;
                        this.buttonClearTextBoxDisplayInfo.Enabled = true;

                        DateTime date = DateTime.Today;

                        StringBuilder str = new StringBuilder();

                        if (!"".Equals(this.textBoxDisplayInfo.Text))
                        {
                            str.Append("\r\n\r\n");
                        }

                        str.Append(date.ToString("T"));
                        str.Append(" Conectado a porta: " + portName + " Baud-Rate: " + baudRate);
                        str.Append("\r\n\r\n");

                        this.textBoxDisplayInfo.AppendText(str.ToString());
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Método responsável pelo evento click do botão buttonDesconectar.
        /// Fecha a conexão com a porta(COM) especificada.
        /// </summary>
        private void buttonDesconectar_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Close();

                    if (serialPort.IsOpen == false)
                    {
                        this.comboBoxListPortas.Enabled = true;
                        this.comboBoxBaudRate.Enabled = true;
                        this.buttonDesconectar.Enabled = false;
                        this.buttonConectar.Enabled = true;
                        this.buttonAtualizarPortas.Enabled = true;

                        DateTime date = DateTime.Today;

                        StringBuilder str = new StringBuilder();
                        str.Append("\r\n");
                        str.Append(date.ToString("T"));
                        str.Append(" Desconectado");

                        this.textBoxDisplayInfo.AppendText(str.ToString());
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Método responsável pelo evento formClosed do form.
        /// Fecha a conexão com a porta(COM) especificada.
        /// </summary>
        private void formPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        /// <summary>
        /// Método responsável pelo evento DataReceived do serialPort.
        /// Recebe os dados e chama a função "trataDadoRecebido".
        /// </summary>
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort.BytesToRead > 0)
            {
                this.rxString = serialPort.ReadLine();
                this.Invoke(new EventHandler(trataDadoRecebido));
            }
        }

        /// <summary>
        /// Método responsável pelo evento click do botão buttonClearTextBoxDisplayInfo.
        /// Limpa os dados do componente "textBoxDisplayInfo".
        /// </summary>
        private void buttonClearTextBoxDisplayInfo_Click(object sender, EventArgs e)
        {
            this.textBoxDisplayInfo.Clear();
        }

        /// <summary>
        /// Método responsável pelo evento click do botão buttonAtualizarPortas.
        /// Atualiza o campo porta com as portas COMs disponíveis.
        /// </summary>
        private void buttonAtualizarPortas_Click(object sender, EventArgs e)
        {
            this.atualizaPortas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort.Write("*F");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort.Write("*E");
        }






    }
}