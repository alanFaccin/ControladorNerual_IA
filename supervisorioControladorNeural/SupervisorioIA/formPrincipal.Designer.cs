namespace SupervisorioIA
{
    partial class formPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chartValue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelv2 = new System.Windows.Forms.Label();
            this.labelv1 = new System.Windows.Forms.Label();
            this.labelb2 = new System.Windows.Forms.Label();
            this.labelb1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_said = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_ent = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxParametrosPorta = new System.Windows.Forms.GroupBox();
            this.buttonAtualizarPortas = new System.Windows.Forms.Button();
            this.buttonClearTextBoxDisplayInfo = new System.Windows.Forms.Button();
            this.buttonDesconectar = new System.Windows.Forms.Button();
            this.buttonConectar = new System.Windows.Forms.Button();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxListPortas = new System.Windows.Forms.ComboBox();
            this.textBoxDisplayInfo = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartValue)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxParametrosPorta.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.groupBoxParametrosPorta);
            this.tabPage2.Controls.Add(this.textBoxDisplayInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1056, 621);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Principal";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chartValue);
            this.groupBox3.Location = new System.Drawing.Point(17, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(727, 366);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gráfico - Nível Tanque ";
            // 
            // chartValue
            // 
            chartArea2.Name = "ChartArea1";
            this.chartValue.ChartAreas.Add(chartArea2);
            this.chartValue.Location = new System.Drawing.Point(3, 20);
            this.chartValue.Margin = new System.Windows.Forms.Padding(20);
            this.chartValue.Name = "chartValue";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Name = "Series2";
            this.chartValue.Series.Add(series3);
            this.chartValue.Series.Add(series4);
            this.chartValue.Size = new System.Drawing.Size(710, 284);
            this.chartValue.TabIndex = 7;
            this.chartValue.Text = "chart1";
            title2.Name = "Real Time Monitor ";
            this.chartValue.Titles.Add(title2);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelv2);
            this.groupBox2.Controls.Add(this.labelv1);
            this.groupBox2.Controls.Add(this.labelb2);
            this.groupBox2.Controls.Add(this.labelb1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(750, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 138);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atuadores Sistema";
            // 
            // labelv2
            // 
            this.labelv2.AutoSize = true;
            this.labelv2.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelv2.Location = new System.Drawing.Point(97, 111);
            this.labelv2.Name = "labelv2";
            this.labelv2.Size = new System.Drawing.Size(70, 13);
            this.labelv2.TabIndex = 11;
            this.labelv2.Text = "label14";
            // 
            // labelv1
            // 
            this.labelv1.AutoSize = true;
            this.labelv1.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelv1.Location = new System.Drawing.Point(97, 84);
            this.labelv1.Name = "labelv1";
            this.labelv1.Size = new System.Drawing.Size(70, 13);
            this.labelv1.TabIndex = 10;
            this.labelv1.Text = "label13";
            // 
            // labelb2
            // 
            this.labelb2.AutoSize = true;
            this.labelb2.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelb2.Location = new System.Drawing.Point(95, 56);
            this.labelb2.Name = "labelb2";
            this.labelb2.Size = new System.Drawing.Size(70, 13);
            this.labelb2.TabIndex = 9;
            this.labelb2.Text = "label12";
            // 
            // labelb1
            // 
            this.labelb1.AutoSize = true;
            this.labelb1.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelb1.Location = new System.Drawing.Point(95, 27);
            this.labelb1.Name = "labelb1";
            this.labelb1.Size = new System.Drawing.Size(70, 13);
            this.labelb1.TabIndex = 8;
            this.labelb1.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "Válvula 2:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Válvula 1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Bomba 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Bomba 1:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_said);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label_ent);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(750, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 107);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rede Neural ";
            // 
            // label_said
            // 
            this.label_said.AutoSize = true;
            this.label_said.Font = new System.Drawing.Font("OCR-A BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_said.Location = new System.Drawing.Point(15, 81);
            this.label_said.Name = "label_said";
            this.label_said.Size = new System.Drawing.Size(0, 21);
            this.label_said.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Saída";
            // 
            // label_ent
            // 
            this.label_ent.AutoSize = true;
            this.label_ent.Font = new System.Drawing.Font("OCR-A BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ent.Location = new System.Drawing.Point(12, 38);
            this.label_ent.Name = "label_ent";
            this.label_ent.Size = new System.Drawing.Size(0, 21);
            this.label_ent.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Monitoramento Controlador Neural";
            // 
            // groupBoxParametrosPorta
            // 
            this.groupBoxParametrosPorta.Controls.Add(this.buttonAtualizarPortas);
            this.groupBoxParametrosPorta.Controls.Add(this.buttonClearTextBoxDisplayInfo);
            this.groupBoxParametrosPorta.Controls.Add(this.buttonDesconectar);
            this.groupBoxParametrosPorta.Controls.Add(this.buttonConectar);
            this.groupBoxParametrosPorta.Controls.Add(this.comboBoxBaudRate);
            this.groupBoxParametrosPorta.Controls.Add(this.label2);
            this.groupBoxParametrosPorta.Controls.Add(this.label1);
            this.groupBoxParametrosPorta.Controls.Add(this.comboBoxListPortas);
            this.groupBoxParametrosPorta.Location = new System.Drawing.Point(750, 36);
            this.groupBoxParametrosPorta.Name = "groupBoxParametrosPorta";
            this.groupBoxParametrosPorta.Size = new System.Drawing.Size(195, 178);
            this.groupBoxParametrosPorta.TabIndex = 0;
            this.groupBoxParametrosPorta.TabStop = false;
            this.groupBoxParametrosPorta.Text = "Parâmetros da porta serial";
            // 
            // buttonAtualizarPortas
            // 
            this.buttonAtualizarPortas.Location = new System.Drawing.Point(87, 143);
            this.buttonAtualizarPortas.Name = "buttonAtualizarPortas";
            this.buttonAtualizarPortas.Size = new System.Drawing.Size(101, 23);
            this.buttonAtualizarPortas.TabIndex = 8;
            this.buttonAtualizarPortas.Text = "Atualizar Portas";
            this.buttonAtualizarPortas.UseVisualStyleBackColor = true;
            this.buttonAtualizarPortas.Click += new System.EventHandler(this.buttonAtualizarPortas_Click);
            // 
            // buttonClearTextBoxDisplayInfo
            // 
            this.buttonClearTextBoxDisplayInfo.Enabled = false;
            this.buttonClearTextBoxDisplayInfo.Location = new System.Drawing.Point(6, 143);
            this.buttonClearTextBoxDisplayInfo.Name = "buttonClearTextBoxDisplayInfo";
            this.buttonClearTextBoxDisplayInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonClearTextBoxDisplayInfo.TabIndex = 7;
            this.buttonClearTextBoxDisplayInfo.Text = "Limpar";
            this.buttonClearTextBoxDisplayInfo.UseVisualStyleBackColor = true;
            this.buttonClearTextBoxDisplayInfo.Click += new System.EventHandler(this.buttonClearTextBoxDisplayInfo_Click);
            // 
            // buttonDesconectar
            // 
            this.buttonDesconectar.Enabled = false;
            this.buttonDesconectar.Location = new System.Drawing.Point(87, 114);
            this.buttonDesconectar.Name = "buttonDesconectar";
            this.buttonDesconectar.Size = new System.Drawing.Size(101, 23);
            this.buttonDesconectar.TabIndex = 6;
            this.buttonDesconectar.Text = "Desconectar";
            this.buttonDesconectar.UseVisualStyleBackColor = true;
            this.buttonDesconectar.Click += new System.EventHandler(this.buttonDesconectar_Click);
            // 
            // buttonConectar
            // 
            this.buttonConectar.Enabled = false;
            this.buttonConectar.Location = new System.Drawing.Point(6, 114);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(75, 23);
            this.buttonConectar.TabIndex = 4;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = true;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.Enabled = false;
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(6, 87);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(182, 21);
            this.comboBoxBaudRate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Porta";
            // 
            // comboBoxListPortas
            // 
            this.comboBoxListPortas.FormattingEnabled = true;
            this.comboBoxListPortas.Location = new System.Drawing.Point(6, 45);
            this.comboBoxListPortas.Name = "comboBoxListPortas";
            this.comboBoxListPortas.Size = new System.Drawing.Size(182, 21);
            this.comboBoxListPortas.TabIndex = 0;
            this.comboBoxListPortas.TextChanged += new System.EventHandler(this.comboBoxListPortas_TextChanged);
            // 
            // textBoxDisplayInfo
            // 
            this.textBoxDisplayInfo.Location = new System.Drawing.Point(17, 81);
            this.textBoxDisplayInfo.Multiline = true;
            this.textBoxDisplayInfo.Name = "textBoxDisplayInfo";
            this.textBoxDisplayInfo.ReadOnly = true;
            this.textBoxDisplayInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDisplayInfo.Size = new System.Drawing.Size(727, 133);
            this.textBoxDisplayInfo.TabIndex = 5;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(13, 25);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1064, 647);
            this.tabControl.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(750, 489);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 109);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Comandos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Full";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Empty";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 729);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supervisorio Controlador Neural";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formPrincipal_FormClosed);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartValue)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxParametrosPorta.ResumeLayout(false);
            this.groupBoxParametrosPorta.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxParametrosPorta;
        private System.Windows.Forms.Button buttonClearTextBoxDisplayInfo;
        private System.Windows.Forms.Button buttonDesconectar;
        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxListPortas;
        private System.Windows.Forms.TextBox textBoxDisplayInfo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button buttonAtualizarPortas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_said;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_ent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartValue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelv2;
        private System.Windows.Forms.Label labelv1;
        private System.Windows.Forms.Label labelb2;
        private System.Windows.Forms.Label labelb1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

