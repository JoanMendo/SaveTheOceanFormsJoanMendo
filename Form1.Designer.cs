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
            Afection = new Label();
            location = new Label();
            groupBox1 = new GroupBox();
            treeView1 = new TreeView();
            groupBox2 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // RescueName
            // 
            RescueName.AutoSize = true;
            RescueName.Location = new Point(6, 31);
            RescueName.Name = "RescueName";
            RescueName.Size = new Size(110, 15);
            RescueName.TabIndex = 0;
            RescueName.Text = "Número de Rescat: ";
            // 
            // RescueDate
            // 
            RescueDate.AutoSize = true;
            RescueDate.Location = new Point(6, 65);
            RescueDate.Name = "RescueDate";
            RescueDate.Size = new Size(99, 15);
            RescueDate.TabIndex = 1;
            RescueDate.Text = "Data del Rescate: ";
            // 
            // SpeciesName
            // 
            SpeciesName.AutoSize = true;
            SpeciesName.Location = new Point(6, 102);
            SpeciesName.Name = "SpeciesName";
            SpeciesName.Size = new Size(108, 15);
            SpeciesName.TabIndex = 2;
            SpeciesName.Text = "Especie a Rescatar: ";
            // 
            // Afection
            // 
            Afection.AutoSize = true;
            Afection.Location = new Point(6, 134);
            Afection.Name = "Afection";
            Afection.Size = new Size(119, 15);
            Afection.TabIndex = 3;
            Afection.Text = "Grado de afectación: ";
            // 
            // location
            // 
            location.AutoSize = true;
            location.Location = new Point(6, 169);
            location.Name = "location";
            location.Size = new Size(82, 15);
            location.TabIndex = 4;
            location.Text = "Localitzación: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RescueName);
            groupBox1.Controls.Add(location);
            groupBox1.Controls.Add(RescueDate);
            groupBox1.Controls.Add(Afection);
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
            groupBox2.Location = new Point(395, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 390);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Puntuaciones";
            // 
            // button1
            // 
            button1.Location = new Point(38, 335);
            button1.Name = "button1";
            button1.Size = new Size(110, 67);
            button1.TabIndex = 8;
            button1.Text = "Curar Ejemplar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(167, 335);
            button2.Name = "button2";
            button2.Size = new Size(124, 67);
            button2.TabIndex = 9;
            button2.Text = "Trasladar al CRAM";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 450);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RescueName;
        private Label RescueDate;
        private Label SpeciesName;
        private Label Afection;
        private Label location;
        private GroupBox groupBox1;
        private TreeView treeView1;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
        private Label label6;
    }
}
