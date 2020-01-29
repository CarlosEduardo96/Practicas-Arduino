namespace Sensor_tem_y_humedad
{
    partial class Form1
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
            this.Puerto = new System.Windows.Forms.ComboBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Datos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Puerto
            // 
            this.Puerto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Puerto.FormattingEnabled = true;
            this.Puerto.Location = new System.Drawing.Point(154, 83);
            this.Puerto.Name = "Puerto";
            this.Puerto.Size = new System.Drawing.Size(198, 28);
            this.Puerto.TabIndex = 0;
            this.Puerto.SelectedIndexChanged += new System.EventHandler(this.Puerto_SelectedIndexChanged);
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscar.Location = new System.Drawing.Point(373, 80);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(122, 34);
            this.Buscar.TabIndex = 1;
            this.Buscar.Text = "Escanear";
            this.Buscar.UseVisualStyleBackColor = false;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Puerto Serial:";
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.button1);
            this.Panel.Controls.Add(this.Datos);
            this.Panel.Controls.Add(this.label2);
            this.Panel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel.Location = new System.Drawing.Point(52, 141);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(540, 301);
            this.Panel.TabIndex = 3;
            this.Panel.TabStop = false;
            this.Panel.Text = "Temperatura en C°";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(309, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Desconectar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Datos
            // 
            this.Datos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Datos.FormattingEnabled = true;
            this.Datos.ItemHeight = 20;
            this.Datos.Location = new System.Drawing.Point(21, 85);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(492, 142);
            this.Datos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sensor DHT11 pin 2:";
            // 
            // Tiempo
            // 
            this.Tiempo.Interval = 1000;
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(732, 476);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Puerto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Temperatura y humedad";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Puerto;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Panel;
        private System.Windows.Forms.ListBox Datos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.Button button1;
    }
}

