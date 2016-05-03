namespace TicTacToe_V2
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
            this.Pmain_Menu = new System.Windows.Forms.Panel();
            this.Lpmm_Error = new System.Windows.Forms.Label();
            this.Bstart = new System.Windows.Forms.Button();
            this.ply_O = new System.Windows.Forms.Button();
            this.ply_X = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pgame = new System.Windows.Forms.Panel();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pmain_Menu.SuspendLayout();
            this.Pgame.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pmain_Menu
            // 
            this.Pmain_Menu.Controls.Add(this.Lpmm_Error);
            this.Pmain_Menu.Controls.Add(this.Bstart);
            this.Pmain_Menu.Controls.Add(this.ply_O);
            this.Pmain_Menu.Controls.Add(this.ply_X);
            this.Pmain_Menu.Controls.Add(this.label2);
            this.Pmain_Menu.Controls.Add(this.label1);
            this.Pmain_Menu.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pmain_Menu.Location = new System.Drawing.Point(356, 343);
            this.Pmain_Menu.Name = "Pmain_Menu";
            this.Pmain_Menu.Size = new System.Drawing.Size(68, 65);
            this.Pmain_Menu.TabIndex = 0;
            // 
            // Lpmm_Error
            // 
            this.Lpmm_Error.AutoSize = true;
            this.Lpmm_Error.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lpmm_Error.ForeColor = System.Drawing.Color.Red;
            this.Lpmm_Error.Location = new System.Drawing.Point(21, 263);
            this.Lpmm_Error.Name = "Lpmm_Error";
            this.Lpmm_Error.Size = new System.Drawing.Size(216, 28);
            this.Lpmm_Error.TabIndex = 3;
            this.Lpmm_Error.Text = "You must choose a player";
            this.Lpmm_Error.Visible = false;
            // 
            // Bstart
            // 
            this.Bstart.Location = new System.Drawing.Point(343, 356);
            this.Bstart.Name = "Bstart";
            this.Bstart.Size = new System.Drawing.Size(95, 52);
            this.Bstart.TabIndex = 2;
            this.Bstart.Text = "Start";
            this.Bstart.UseVisualStyleBackColor = true;
            this.Bstart.Click += new System.EventHandler(this.Bstart_Click);
            // 
            // ply_O
            // 
            this.ply_O.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ply_O.Location = new System.Drawing.Point(153, 140);
            this.ply_O.Name = "ply_O";
            this.ply_O.Size = new System.Drawing.Size(106, 97);
            this.ply_O.TabIndex = 2;
            this.ply_O.Text = "O";
            this.ply_O.UseVisualStyleBackColor = true;
            this.ply_O.Click += new System.EventHandler(this.Choose_Player_Click);
            // 
            // ply_X
            // 
            this.ply_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ply_X.Location = new System.Drawing.Point(19, 140);
            this.ply_X.Name = "ply_X";
            this.ply_X.Size = new System.Drawing.Size(106, 97);
            this.ply_X.TabIndex = 2;
            this.ply_X.Text = "X";
            this.ply_X.UseVisualStyleBackColor = true;
            this.ply_X.Click += new System.EventHandler(this.Choose_Player_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Player :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            // 
            // Pgame
            // 
            this.Pgame.Controls.Add(this.btn8);
            this.Pgame.Controls.Add(this.btn4);
            this.Pgame.Controls.Add(this.btn2);
            this.Pgame.Controls.Add(this.btn1);
            this.Pgame.Controls.Add(this.btn7);
            this.Pgame.Controls.Add(this.btn9);
            this.Pgame.Controls.Add(this.btn6);
            this.Pgame.Controls.Add(this.btn3);
            this.Pgame.Controls.Add(this.btn5);
            this.Pgame.Controls.Add(this.panel2);
            this.Pgame.Controls.Add(this.panel4);
            this.Pgame.Controls.Add(this.panel3);
            this.Pgame.Controls.Add(this.panel1);
            this.Pgame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pgame.Location = new System.Drawing.Point(0, 0);
            this.Pgame.Name = "Pgame";
            this.Pgame.Size = new System.Drawing.Size(450, 420);
            this.Pgame.TabIndex = 1;
            // 
            // btn8
            // 
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(163, 311);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(95, 91);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "h";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn4
            // 
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(38, 190);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(95, 91);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "d";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(163, 69);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(95, 91);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "b";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(38, 69);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(95, 91);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "a";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn7
            // 
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(38, 311);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(95, 91);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "g";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn9
            // 
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(288, 311);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(95, 91);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "i";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn6
            // 
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(288, 190);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(95, 91);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "f";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn3
            // 
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(288, 69);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(95, 91);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "c";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn5
            // 
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(163, 190);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(95, 91);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "e";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Location = new System.Drawing.Point(264, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(18, 333);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Lime;
            this.panel4.Location = new System.Drawing.Point(38, 287);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(345, 18);
            this.panel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lime;
            this.panel3.Location = new System.Drawing.Point(38, 166);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 18);
            this.panel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(139, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(18, 333);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 420);
            this.Controls.Add(this.Pgame);
            this.Controls.Add(this.Pmain_Menu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Pmain_Menu.ResumeLayout(false);
            this.Pmain_Menu.PerformLayout();
            this.Pgame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pmain_Menu;
        private System.Windows.Forms.Button Bstart;
        private System.Windows.Forms.Button ply_O;
        private System.Windows.Forms.Button ply_X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pgame;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label Lpmm_Error;
    }
}

