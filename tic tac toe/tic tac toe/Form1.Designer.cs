
namespace tic_tac_toe
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.AImoves = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b1.Location = new System.Drawing.Point(8, 58);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(100, 100);
            this.b1.TabIndex = 2;
            this.b1.Text = "?";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.playerClick);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b2.Location = new System.Drawing.Point(114, 58);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(100, 100);
            this.b2.TabIndex = 3;
            this.b2.Text = "?";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.playerClick);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b3.Location = new System.Drawing.Point(220, 58);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(100, 100);
            this.b3.TabIndex = 4;
            this.b3.Text = "?";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.playerClick);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b4.Location = new System.Drawing.Point(8, 164);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(100, 100);
            this.b4.TabIndex = 5;
            this.b4.Text = "?";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.playerClick);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b5.Location = new System.Drawing.Point(114, 164);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(100, 100);
            this.b5.TabIndex = 6;
            this.b5.Text = "?";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.playerClick);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b6.Location = new System.Drawing.Point(220, 164);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(100, 100);
            this.b6.TabIndex = 7;
            this.b6.Text = "?";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.playerClick);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b7.Location = new System.Drawing.Point(8, 270);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(100, 100);
            this.b7.TabIndex = 8;
            this.b7.Text = "?";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.playerClick);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b8.Location = new System.Drawing.Point(114, 270);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(100, 100);
            this.b8.TabIndex = 9;
            this.b8.Text = "?";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.playerClick);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b9.Location = new System.Drawing.Point(220, 270);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(100, 100);
            this.b9.TabIndex = 10;
            this.b9.Text = "?";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.playerClick);
            // 
            // AImoves
            // 
            this.AImoves.Interval = 1000;
            this.AImoves.Tick += new System.EventHandler(this.AImoves_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 376);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Timer AImoves;
    }
}

