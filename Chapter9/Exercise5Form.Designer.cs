
namespace Chapter9
{
    partial class Exercise5Form
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
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelZip = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(376, 464);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(133, 46);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(560, 464);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(133, 46);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(376, 329);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 22);
            this.txtZip.TabIndex = 2;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(376, 382);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 22);
            this.txtHours.TabIndex = 3;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(376, 271);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 22);
            this.txtState.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(376, 215);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 22);
            this.txtCity.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(376, 155);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 22);
            this.txtAddress.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(376, 99);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 7;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(190, 99);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(73, 22);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "NAME";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(190, 155);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(111, 22);
            this.labelAddress.TabIndex = 9;
            this.labelAddress.Text = "ADDRESS";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(190, 215);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(60, 22);
            this.labelCity.TabIndex = 10;
            this.labelCity.Text = "CITY";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.Location = new System.Drawing.Point(190, 271);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(78, 22);
            this.labelState.TabIndex = 11;
            this.labelState.Text = "STATE";
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZip.Location = new System.Drawing.Point(190, 329);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(45, 22);
            this.labelZip.TabIndex = 12;
            this.labelZip.Text = "ZIP";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHours.Location = new System.Drawing.Point(190, 385);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(83, 22);
            this.labelHours.TabIndex = 13;
            this.labelHours.Text = "HOURS";
            // 
            // menuButton
            // 
            this.menuButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(168, 464);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(133, 46);
            this.menuButton.TabIndex = 14;
            this.menuButton.Text = "MENU";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "EMPLOYEE INFO";
            // 
            // Exercise5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.labelZip);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Exercise5Form";
            this.Text = "Exercise5Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelZip;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label label1;
    }
}