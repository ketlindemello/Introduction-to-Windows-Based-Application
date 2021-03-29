
namespace Chapter9
{
    partial class Exercise1Form
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
            this.result = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.Color.Gold;
            this.result.Location = new System.Drawing.Point(171, 330);
            this.result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 38);
            this.result.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(169, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "NAME";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(377, 223);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.resetButton.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.Gold;
            this.resetButton.Location = new System.Drawing.Point(205, 428);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(168, 53);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "CLEAR";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.DarkTurquoise;
            this.txtName.Location = new System.Drawing.Point(313, 130);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(252, 22);
            this.txtName.TabIndex = 8;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.menuButton.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.Gold;
            this.menuButton.Location = new System.Drawing.Point(479, 428);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(168, 53);
            this.menuButton.TabIndex = 9;
            this.menuButton.Text = "MENU";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // Exercise1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.result);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Exercise1Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Exercise1Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button menuButton;
    }
}