namespace WinFormClient
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.lbxTools = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(227, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(835, 603);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClean.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClean.Location = new System.Drawing.Point(13, 528);
            this.btnClean.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(189, 43);
            this.btnClean.TabIndex = 1;
            this.btnClean.Text = "Clear";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnChangeColor.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeColor.Location = new System.Drawing.Point(13, 285);
            this.btnChangeColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(193, 43);
            this.btnChangeColor.TabIndex = 2;
            this.btnChangeColor.Text = "Figure color";
            this.btnChangeColor.UseVisualStyleBackColor = false;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // lbxTools
            // 
            this.lbxTools.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxTools.FormattingEnabled = true;
            this.lbxTools.ItemHeight = 23;
            this.lbxTools.Location = new System.Drawing.Point(13, 44);
            this.lbxTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxTools.Name = "lbxTools";
            this.lbxTools.Size = new System.Drawing.Size(189, 211);
            this.lbxTools.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose figure:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1061, 603);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxTools);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Production-ready client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.ListBox lbxTools;
        private System.Windows.Forms.Label label2;
    }
}

