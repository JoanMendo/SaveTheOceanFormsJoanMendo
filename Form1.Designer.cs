namespace SaveTheOceanFormsJoanMendo
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
            RescueName = new Label();
            RescueDate = new Label();
            SpeciesName = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            treeView1 = new TreeView();
            groupBox2 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // RescueName
            // 
            RescueName.AutoSize = true;
            RescueName.Location = new Point(6, 31);
            RescueName.Name = "RescueName";
            RescueName.Size = new Size(104, 15);
            RescueName.TabIndex = 0;
            RescueName.Text = "Nombre de Rescat";
            RescueName.Click += label1_Click;
            // 
            // RescueDate
            // 
            RescueDate.AutoSize = true;
            RescueDate.Location = new Point(6, 65);
            RescueDate.Name = "RescueDate";
            RescueDate.Size = new Size(87, 15);
            RescueDate.TabIndex = 1;
            RescueDate.Text = "Data de Rescat:";
            // 
            // SpeciesName
            // 
            SpeciesName.AutoSize = true;
            SpeciesName.Location = new Point(6, 102);
            SpeciesName.Name = "SpeciesName";
            SpeciesName.Size = new Size(108, 15);
            SpeciesName.TabIndex = 2;
            SpeciesName.Text = "Espècie a Rescatar: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 134);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 3;
            label4.Text = "Grau d'Afectació: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 169);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 4;
            label5.Text = "Localització:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RescueName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(RescueDate);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(SpeciesName);
            groupBox1.Location = new Point(38, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(253, 228);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dades Del Rescat:";
            
            // 
            // treeView1
            // 
            treeView1.Location = new Point(6, 22);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(188, 362);
            treeView1.TabIndex = 6;
            
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(treeView1);
            groupBox2.Location = new Point(588, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 390);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Puntuacions";
            // 
            // button1
            // 
            button1.Location = new Point(38, 335);
            button1.Name = "button1";
            button1.Size = new Size(110, 67);
            button1.TabIndex = 8;
            button1.Text = "Curar Exemplar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(167, 335);
            button2.Name = "button2";
            button2.Size = new Size(124, 67);
            button2.TabIndex = 9;
            button2.Text = "Traslladar al CRAM";
            button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(56, 287);
            label6.Name = "label6";
            label6.Size = new Size(221, 21);
            label6.TabIndex = 10;
            label6.Text = "Escull un dels dos tractaments:";
            
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(313, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(373, 23);
            label7.Name = "label7";
            label7.Size = new Size(122, 21);
            label7.TabIndex = 12;
            label7.Text = "Animal a Tractar";
            
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(349, 287);
            label8.Name = "label8";
            label8.Size = new Size(173, 21);
            label8.TabIndex = 13;
            label8.Text = "Resultat del tractament:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RescueName;
        private Label RescueDate;
        private Label SpeciesName;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private TreeView treeView1;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label8;
    }
}
