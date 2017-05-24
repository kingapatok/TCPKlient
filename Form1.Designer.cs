namespace TCPKlient
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
            this.Adress = new System.Windows.Forms.TextBox();
            this.My_port = new System.Windows.Forms.NumericUpDown();
            this.info_o_polonczeniu = new System.Windows.Forms.ListBox();
            this.przycisk_polacz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.My_port)).BeginInit();
            this.SuspendLayout();
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(12, 12);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(265, 20);
            this.Adress.TabIndex = 0;
            this.Adress.Text = "Adress";
            this.Adress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // My_port
            // 
            this.My_port.Location = new System.Drawing.Point(283, 13);
            this.My_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.My_port.Name = "My_port";
            this.My_port.Size = new System.Drawing.Size(292, 20);
            this.My_port.TabIndex = 1;
            // 
            // info_o_polonczeniu
            // 
            this.info_o_polonczeniu.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_o_polonczeniu.FormattingEnabled = true;
            this.info_o_polonczeniu.ItemHeight = 21;
            this.info_o_polonczeniu.Location = new System.Drawing.Point(12, 38);
            this.info_o_polonczeniu.Name = "info_o_polonczeniu";
            this.info_o_polonczeniu.Size = new System.Drawing.Size(563, 319);
            this.info_o_polonczeniu.TabIndex = 2;
            // 
            // przycisk_polacz
            // 
            this.przycisk_polacz.Location = new System.Drawing.Point(128, 384);
            this.przycisk_polacz.Name = "przycisk_polacz";
            this.przycisk_polacz.Size = new System.Drawing.Size(329, 23);
            this.przycisk_polacz.TabIndex = 3;
            this.przycisk_polacz.Text = "Połącz";
            this.przycisk_polacz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 442);
            this.Controls.Add(this.przycisk_polacz);
            this.Controls.Add(this.info_o_polonczeniu);
            this.Controls.Add(this.My_port);
            this.Controls.Add(this.Adress);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.My_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.NumericUpDown My_port;
        private System.Windows.Forms.ListBox info_o_polonczeniu;
        private System.Windows.Forms.Button przycisk_polacz;
    }
}

