namespace ConnecionMySqlCSHARP
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
            this.label1 = new System.Windows.Forms.Label();
            this.ServidorTxt = new System.Windows.Forms.TextBox();
            this.Puertotxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Usuariotxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ServidorTxt
            // 
            this.ServidorTxt.Location = new System.Drawing.Point(307, 101);
            this.ServidorTxt.Margin = new System.Windows.Forms.Padding(10);
            this.ServidorTxt.Name = "ServidorTxt";
            this.ServidorTxt.Size = new System.Drawing.Size(228, 20);
            this.ServidorTxt.TabIndex = 1;
            // 
            // Puertotxt
            // 
            this.Puertotxt.Location = new System.Drawing.Point(307, 128);
            this.Puertotxt.Margin = new System.Windows.Forms.Padding(10);
            this.Puertotxt.Name = "Puertotxt";
            this.Puertotxt.Size = new System.Drawing.Size(228, 20);
            this.Puertotxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Puerto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Usuariotxt
            // 
            this.Usuariotxt.Location = new System.Drawing.Point(307, 152);
            this.Usuariotxt.Margin = new System.Windows.Forms.Padding(10);
            this.Usuariotxt.Name = "Usuariotxt";
            this.Usuariotxt.Size = new System.Drawing.Size(228, 20);
            this.Usuariotxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(307, 183);
            this.Passwordtxt.Margin = new System.Windows.Forms.Padding(10);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(228, 20);
            this.Passwordtxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(283, 216);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(197, 62);
            this.btnConectar.TabIndex = 8;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Usuariotxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Puertotxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ServidorTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServidorTxt;
        private System.Windows.Forms.TextBox Puertotxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Usuariotxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConectar;
    }
}

