﻿
namespace project_1
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
            this.Ban = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nhapkho = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.dtkho = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtkho)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Công ty bán thực phẩm";
            // 
            // Ban
            // 
            this.Ban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ban.Location = new System.Drawing.Point(46, 193);
            this.Ban.Name = "Ban";
            this.Ban.Size = new System.Drawing.Size(117, 46);
            this.Ban.TabIndex = 1;
            this.Ban.Text = "Bán hàng";
            this.Ban.UseVisualStyleBackColor = true;
            this.Ban.Click += new System.EventHandler(this.Ban_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bán hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(756, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập kho";
            // 
            // Nhapkho
            // 
            this.Nhapkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nhapkho.Location = new System.Drawing.Point(750, 193);
            this.Nhapkho.Name = "Nhapkho";
            this.Nhapkho.Size = new System.Drawing.Size(117, 46);
            this.Nhapkho.TabIndex = 3;
            this.Nhapkho.Text = "Nhập kho";
            this.Nhapkho.UseVisualStyleBackColor = true;
            this.Nhapkho.Click += new System.EventHandler(this.Nhapkho_Click);
            // 
            // thoat
            // 
            this.thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.Location = new System.Drawing.Point(422, 640);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(117, 46);
            this.thoat.TabIndex = 5;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // dtkho
            // 
            this.dtkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtkho.Location = new System.Drawing.Point(176, 321);
            this.dtkho.Name = "dtkho";
            this.dtkho.RowHeadersWidth = 51;
            this.dtkho.RowTemplate.Height = 24;
            this.dtkho.Size = new System.Drawing.Size(599, 313);
            this.dtkho.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(446, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kho";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 698);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtkho);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nhapkho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ban);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtkho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Nhapkho;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.DataGridView dtkho;
        private System.Windows.Forms.Label label4;
    }
}

