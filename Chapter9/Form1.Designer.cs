
namespace Chapter9
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
            this.selectionDropdown = new System.Windows.Forms.ListBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectionDropdown
            // 
            this.selectionDropdown.AllowDrop = true;
            this.selectionDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.selectionDropdown.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionDropdown.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.selectionDropdown.FormattingEnabled = true;
            this.selectionDropdown.ItemHeight = 24;
            this.selectionDropdown.Items.AddRange(new object[] {
            "Name Retrieval App",
            "Window Reposition",
            "Trip Calculator",
            "Numeric Check",
            "Employee"});
            this.selectionDropdown.Location = new System.Drawing.Point(177, 124);
            this.selectionDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.selectionDropdown.Name = "selectionDropdown";
            this.selectionDropdown.Size = new System.Drawing.Size(403, 100);
            this.selectionDropdown.TabIndex = 0;
            this.selectionDropdown.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // executeButton
            // 
            this.executeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.executeButton.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.executeButton.Location = new System.Drawing.Point(301, 283);
            this.executeButton.Margin = new System.Windows.Forms.Padding(4);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(149, 78);
            this.executeButton.TabIndex = 1;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = false;
            this.executeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(233, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose one program to Execute";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.selectionDropdown);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Chapter 9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox selectionDropdown;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Label label1;
    }
}

