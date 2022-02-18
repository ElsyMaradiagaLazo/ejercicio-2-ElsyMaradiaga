namespace Ejercicio2ElsyMaradiaga
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombretextbox1 = new System.Windows.Forms.TextBox();
            this.EdadtextBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.registrobutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el Nombre del Estudiante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la Edad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre-Edad";
            // 
            // Nombretextbox1
            // 
            this.Nombretextbox1.Location = new System.Drawing.Point(267, 45);
            this.Nombretextbox1.Name = "Nombretextbox1";
            this.Nombretextbox1.Size = new System.Drawing.Size(100, 23);
            this.Nombretextbox1.TabIndex = 3;
            // 
            // EdadtextBox2
            // 
            this.EdadtextBox2.Location = new System.Drawing.Point(267, 77);
            this.EdadtextBox2.Name = "EdadtextBox2";
            this.EdadtextBox2.Size = new System.Drawing.Size(100, 23);
            this.EdadtextBox2.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(77, 181);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 94);
            this.listBox1.TabIndex = 5;
            // 
            // registrobutton1
            // 
            this.registrobutton1.Location = new System.Drawing.Point(276, 118);
            this.registrobutton1.Name = "registrobutton1";
            this.registrobutton1.Size = new System.Drawing.Size(75, 23);
            this.registrobutton1.TabIndex = 6;
            this.registrobutton1.Text = "Guardar";
            this.registrobutton1.UseVisualStyleBackColor = true;
            this.registrobutton1.Click += new System.EventHandler(this.registrobutton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registrobutton1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.EdadtextBox2);
            this.Controls.Add(this.Nombretextbox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Nombretextbox1;
        private TextBox EdadtextBox2;
        private ListBox listBox1;
        private Button registrobutton1;
    }
}