
namespace Chapter9
{
    partial class Exercise4Form
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
            this.multButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.txtValeu2 = new System.Windows.Forms.TextBox();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // multButton
            // 
            this.multButton.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multButton.Location = new System.Drawing.Point(467, 255);
            this.multButton.Margin = new System.Windows.Forms.Padding(4);
            this.multButton.Name = "multButton";
            this.multButton.Size = new System.Drawing.Size(108, 73);
            this.multButton.TabIndex = 0;
            this.multButton.Text = "MULT";
            this.multButton.UseVisualStyleBackColor = true;
            this.multButton.Click += new System.EventHandler(this.multButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(467, 164);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(108, 73);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // txtValeu2
            // 
            this.txtValeu2.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValeu2.Location = new System.Drawing.Point(161, 255);
            this.txtValeu2.Margin = new System.Windows.Forms.Padding(4);
            this.txtValeu2.Name = "txtValeu2";
            this.txtValeu2.Size = new System.Drawing.Size(132, 27);
            this.txtValeu2.TabIndex = 2;
            this.txtValeu2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValue1
            // 
            this.txtValue1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue1.Location = new System.Drawing.Point(161, 164);
            this.txtValue1.Margin = new System.Windows.Forms.Padding(4);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(132, 27);
            this.txtValue1.TabIndex = 3;
            this.txtValue1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.Color.Yellow;
            this.result.Location = new System.Drawing.Point(157, 371);
            this.result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 24);
            this.result.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(596, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 73);
            this.button1.TabIndex = 5;
            this.button1.Text = "MENU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(596, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 73);
            this.button2.TabIndex = 6;
            this.button2.Text = "CLEAN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "VALUE 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "VALUE 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "ADDITION AND MULTIPLICATION CALCULATOR";
            // 
            // Exercise4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.txtValeu2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.multButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Exercise4Form";
            this.Text = "Exercise4Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button multButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox txtValeu2;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}