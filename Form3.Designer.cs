namespace SaveTheOceanFormsJoanMendo
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            RoleBox = new ComboBox();
            NameBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            LeaveButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 9);
            label1.Name = "label1";
            label1.Size = new Size(259, 62);
            label1.TabIndex = 1;
            label1.Text = "Salvar al oceano II : El bombardeo de los Cruds";
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Control;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 85);
            label2.Name = "label2";
            label2.Size = new Size(259, 93);
            label2.TabIndex = 2;
            label2.Text = "El C.L.O.U.D ha lanzado un ataque contra la fauna marina de la costa local, y ahora has de sanarlos para que no se mueran.";
            // 
            // RoleBox
            // 
            RoleBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoleBox.FormattingEnabled = true;
            RoleBox.Items.AddRange(new object[] { "Técnico", "Veterinario" });
            RoleBox.Location = new Point(45, 313);
            RoleBox.Name = "RoleBox";
            RoleBox.Size = new Size(259, 33);
            RoleBox.TabIndex = 3;
            RoleBox.Click += ResetText_click;
            // 
            // NameBox
            // 
            NameBox.Font = new Font("Segoe UI", 14F);
            NameBox.Location = new Point(45, 231);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(259, 32);
            NameBox.TabIndex = 4;
            NameBox.Click += ResetText_click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 203);
            label3.Name = "label3";
            label3.Size = new Size(200, 25);
            label3.TabIndex = 5;
            label3.Text = "Introduce tu nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 285);
            label4.Name = "label4";
            label4.Size = new Size(163, 25);
            label4.TabIndex = 6;
            label4.Text = "Selecciona tu Rol";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(110, 370);
            button1.Name = "button1";
            button1.Size = new Size(135, 45);
            button1.TabIndex = 7;
            button1.Text = "Continuar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Continue_click;
            // 
            // LeaveButton
            // 
            LeaveButton.BackColor = Color.IndianRed;
            LeaveButton.Location = new Point(280, 398);
            LeaveButton.Name = "LeaveButton";
            LeaveButton.Size = new Size(55, 40);
            LeaveButton.TabIndex = 8;
            LeaveButton.Text = "Salir >:(";
            LeaveButton.UseVisualStyleBackColor = false;
            LeaveButton.Click += LeaveButton_click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(347, 450);
            Controls.Add(LeaveButton);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(NameBox);
            Controls.Add(RoleBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox RoleBox;
        private TextBox NameBox;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button LeaveButton;
    }
}