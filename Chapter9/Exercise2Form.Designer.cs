
namespace Chapter9
{
    partial class Exercise2Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xCoordinate = new System.Windows.Forms.TextBox();
            this.yCoordinate = new System.Windows.Forms.TextBox();
            this.reposition = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter values for X and Y to move the window to a new position point.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "X - Coordinate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(403, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y - Coordinate";
            // 
            // xCoordinate
            // 
            this.xCoordinate.BackColor = System.Drawing.SystemColors.MenuBar;
            this.xCoordinate.Location = new System.Drawing.Point(193, 217);
            this.xCoordinate.Margin = new System.Windows.Forms.Padding(4);
            this.xCoordinate.Name = "xCoordinate";
            this.xCoordinate.Size = new System.Drawing.Size(132, 22);
            this.xCoordinate.TabIndex = 3;
            // 
            // yCoordinate
            // 
            this.yCoordinate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.yCoordinate.Location = new System.Drawing.Point(408, 217);
            this.yCoordinate.Margin = new System.Windows.Forms.Padding(4);
            this.yCoordinate.Name = "yCoordinate";
            this.yCoordinate.Size = new System.Drawing.Size(132, 22);
            this.yCoordinate.TabIndex = 4;
            // 
            // reposition
            // 
            this.reposition.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.reposition.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reposition.Location = new System.Drawing.Point(275, 318);
            this.reposition.Margin = new System.Windows.Forms.Padding(4);
            this.reposition.Name = "reposition";
            this.reposition.Size = new System.Drawing.Size(193, 49);
            this.reposition.TabIndex = 5;
            this.reposition.Text = "Reposition";
            this.reposition.UseVisualStyleBackColor = false;
            this.reposition.Click += new System.EventHandler(this.reposition_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.resetButton.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(193, 438);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(132, 49);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuButton.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(418, 438);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(132, 49);
            this.menuButton.TabIndex = 8;
            this.menuButton.Text = "MENU";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Exercise2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.reposition);
            this.Controls.Add(this.yCoordinate);
            this.Controls.Add(this.xCoordinate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Exercise2Form";
            this.Text = "Exercise2Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox xCoordinate;
        private System.Windows.Forms.TextBox yCoordinate;
        private System.Windows.Forms.Button reposition;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button menuButton;
    }
}