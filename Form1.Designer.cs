namespace Neural
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
            this.plikkursowtextBox1 = new System.Windows.Forms.TextBox();
            this.piptextBox2 = new System.Windows.Forms.TextBox();
            this.dokadTreningtextBox3 = new System.Windows.Forms.TextBox();
            this.wczytajKursyBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uczbutton1 = new System.Windows.Forms.Button();
            this.Hlabel4 = new System.Windows.Forms.Label();
            this.Llabel5 = new System.Windows.Forms.Label();
            this.LPredicted = new System.Windows.Forms.Label();
            this.HPredicted = new System.Windows.Forms.Label();
            this.testbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plikkursowtextBox1
            // 
            this.plikkursowtextBox1.Location = new System.Drawing.Point(135, 59);
            this.plikkursowtextBox1.Name = "plikkursowtextBox1";
            this.plikkursowtextBox1.Size = new System.Drawing.Size(285, 20);
            this.plikkursowtextBox1.TabIndex = 0;
            // 
            // piptextBox2
            // 
            this.piptextBox2.Location = new System.Drawing.Point(135, 102);
            this.piptextBox2.Name = "piptextBox2";
            this.piptextBox2.Size = new System.Drawing.Size(100, 20);
            this.piptextBox2.TabIndex = 1;
            this.piptextBox2.Text = "0.0001";
            // 
            // dokadTreningtextBox3
            // 
            this.dokadTreningtextBox3.Location = new System.Drawing.Point(135, 145);
            this.dokadTreningtextBox3.Name = "dokadTreningtextBox3";
            this.dokadTreningtextBox3.Size = new System.Drawing.Size(100, 20);
            this.dokadTreningtextBox3.TabIndex = 2;
            this.dokadTreningtextBox3.Text = "5000";
            // 
            // wczytajKursyBut
            // 
            this.wczytajKursyBut.Location = new System.Drawing.Point(437, 55);
            this.wczytajKursyBut.Name = "wczytajKursyBut";
            this.wczytajKursyBut.Size = new System.Drawing.Size(106, 23);
            this.wczytajKursyBut.TabIndex = 3;
            this.wczytajKursyBut.Text = "Wczytaj kursy";
            this.wczytajKursyBut.UseVisualStyleBackColor = true;
            this.wczytajKursyBut.Click += new System.EventHandler(this.wczytajKursyBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plik kusrów";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Podzial";
            // 
            // uczbutton1
            // 
            this.uczbutton1.Location = new System.Drawing.Point(135, 188);
            this.uczbutton1.Name = "uczbutton1";
            this.uczbutton1.Size = new System.Drawing.Size(75, 23);
            this.uczbutton1.TabIndex = 7;
            this.uczbutton1.Text = "Ucz się";
            this.uczbutton1.UseVisualStyleBackColor = true;
            this.uczbutton1.Click += new System.EventHandler(this.uczbutton1_Click);
            // 
            // Hlabel4
            // 
            this.Hlabel4.AutoSize = true;
            this.Hlabel4.Location = new System.Drawing.Point(139, 257);
            this.Hlabel4.Name = "Hlabel4";
            this.Hlabel4.Size = new System.Drawing.Size(12, 13);
            this.Hlabel4.TabIndex = 8;
            this.Hlabel4.Text = "x";
            // 
            // Llabel5
            // 
            this.Llabel5.AutoSize = true;
            this.Llabel5.Location = new System.Drawing.Point(139, 285);
            this.Llabel5.Name = "Llabel5";
            this.Llabel5.Size = new System.Drawing.Size(12, 13);
            this.Llabel5.TabIndex = 9;
            this.Llabel5.Text = "x";
            // 
            // LPredicted
            // 
            this.LPredicted.AutoSize = true;
            this.LPredicted.Location = new System.Drawing.Point(360, 285);
            this.LPredicted.Name = "LPredicted";
            this.LPredicted.Size = new System.Drawing.Size(12, 13);
            this.LPredicted.TabIndex = 10;
            this.LPredicted.Text = "x";
            // 
            // HPredicted
            // 
            this.HPredicted.AutoSize = true;
            this.HPredicted.Location = new System.Drawing.Point(360, 257);
            this.HPredicted.Name = "HPredicted";
            this.HPredicted.Size = new System.Drawing.Size(12, 13);
            this.HPredicted.TabIndex = 11;
            this.HPredicted.Text = "x";
            // 
            // testbutton1
            // 
            this.testbutton1.Location = new System.Drawing.Point(142, 325);
            this.testbutton1.Name = "testbutton1";
            this.testbutton1.Size = new System.Drawing.Size(75, 23);
            this.testbutton1.TabIndex = 12;
            this.testbutton1.Text = "Testuj";
            this.testbutton1.UseVisualStyleBackColor = true;
            this.testbutton1.Click += new System.EventHandler(this.testbutton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testbutton1);
            this.Controls.Add(this.HPredicted);
            this.Controls.Add(this.LPredicted);
            this.Controls.Add(this.Llabel5);
            this.Controls.Add(this.Hlabel4);
            this.Controls.Add(this.uczbutton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wczytajKursyBut);
            this.Controls.Add(this.dokadTreningtextBox3);
            this.Controls.Add(this.piptextBox2);
            this.Controls.Add(this.plikkursowtextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox plikkursowtextBox1;
        private System.Windows.Forms.TextBox piptextBox2;
        private System.Windows.Forms.TextBox dokadTreningtextBox3;
        private System.Windows.Forms.Button wczytajKursyBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uczbutton1;
        private System.Windows.Forms.Label Hlabel4;
        private System.Windows.Forms.Label Llabel5;
        private System.Windows.Forms.Label LPredicted;
        private System.Windows.Forms.Label HPredicted;
        private System.Windows.Forms.Button testbutton1;
    }
}

