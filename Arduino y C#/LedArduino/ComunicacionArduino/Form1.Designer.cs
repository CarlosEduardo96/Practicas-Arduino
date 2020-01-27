namespace ComunicacionArduino
{
    partial class Linterna
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
            this.Buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Puertoserial = new System.Windows.Forms.ComboBox();
            this.Desconectarbtn = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Offbtn = new System.Windows.Forms.Button();
            this.Onbtn = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Buscar
            // 
            this.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscar.Location = new System.Drawing.Point(320, 79);
            this.Buscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(112, 35);
            this.Buscar.TabIndex = 0;
            this.Buscar.Text = "Escanear";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puerto Serial:";
            // 
            // Puertoserial
            // 
            this.Puertoserial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Puertoserial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Puertoserial.FormattingEnabled = true;
            this.Puertoserial.Location = new System.Drawing.Point(54, 83);
            this.Puertoserial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Puertoserial.Name = "Puertoserial";
            this.Puertoserial.Size = new System.Drawing.Size(258, 28);
            this.Puertoserial.TabIndex = 2;
            this.Puertoserial.SelectedIndexChanged += new System.EventHandler(this.Puertoserial_SelectedIndexChanged);
            // 
            // Desconectarbtn
            // 
            this.Desconectarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Desconectarbtn.Location = new System.Drawing.Point(127, 27);
            this.Desconectarbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Desconectarbtn.Name = "Desconectarbtn";
            this.Desconectarbtn.Size = new System.Drawing.Size(112, 35);
            this.Desconectarbtn.TabIndex = 3;
            this.Desconectarbtn.Text = "Desconectar";
            this.Desconectarbtn.UseVisualStyleBackColor = true;
            this.Desconectarbtn.Click += new System.EventHandler(this.Desconectarbtn_Click);
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.label2);
            this.Panel.Controls.Add(this.Offbtn);
            this.Panel.Controls.Add(this.Onbtn);
            this.Panel.Controls.Add(this.Desconectarbtn);
            this.Panel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel.Location = new System.Drawing.Point(54, 137);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(378, 234);
            this.Panel.TabIndex = 4;
            this.Panel.TabStop = false;
            this.Panel.Text = "Puerto";
            this.Panel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pin 8";
            // 
            // Offbtn
            // 
            this.Offbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Offbtn.Location = new System.Drawing.Point(187, 130);
            this.Offbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Offbtn.Name = "Offbtn";
            this.Offbtn.Size = new System.Drawing.Size(162, 82);
            this.Offbtn.TabIndex = 5;
            this.Offbtn.Text = "Apagar";
            this.Offbtn.UseVisualStyleBackColor = true;
            this.Offbtn.MouseHover += new System.EventHandler(this.Offbtn_MouseHover);
            // 
            // Onbtn
            // 
            this.Onbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Onbtn.Location = new System.Drawing.Point(25, 130);
            this.Onbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Onbtn.Name = "Onbtn";
            this.Onbtn.Size = new System.Drawing.Size(162, 82);
            this.Onbtn.TabIndex = 4;
            this.Onbtn.Text = "Encender";
            this.Onbtn.UseVisualStyleBackColor = true;
            this.Onbtn.MouseHover += new System.EventHandler(this.Onbtn_MouseHover);
            // 
            // Linterna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(536, 402);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.Puertoserial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buscar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Linterna";
            this.Text = "Linterna";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Puertoserial;
        private System.Windows.Forms.Button Desconectarbtn;
        private System.Windows.Forms.GroupBox Panel;
        private System.Windows.Forms.Button Offbtn;
        private System.Windows.Forms.Button Onbtn;
        private System.Windows.Forms.Label label2;
    }
}

