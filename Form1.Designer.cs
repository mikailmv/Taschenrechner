namespace Taschenrechner
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.ergebnisTextBox = new System.Windows.Forms.TextBox();
            this.zahl1TextBox = new System.Windows.Forms.TextBox();
            this.zahl2TextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // ergebnisTextBox
            // 
            this.ergebnisTextBox.Location = new System.Drawing.Point(12, 12);
            this.ergebnisTextBox.Name = "ergebnisTextBox";
            this.ergebnisTextBox.ReadOnly = true;
            this.ergebnisTextBox.Size = new System.Drawing.Size(260, 23);
            this.ergebnisTextBox.TabIndex = 0;
            this.ergebnisTextBox.Text = "Ergebnis";

            // 
            // zahl1TextBox
            // 
            this.zahl1TextBox.Location = new System.Drawing.Point(12, 41);
            this.zahl1TextBox.Name = "zahl1TextBox";
            this.zahl1TextBox.Size = new System.Drawing.Size(120, 23);
            this.zahl1TextBox.TabIndex = 1;

            // 
            // zahl2TextBox
            // 
            this.zahl2TextBox.Location = new System.Drawing.Point(152, 41);
            this.zahl2TextBox.Name = "zahl2TextBox";
            this.zahl2TextBox.Size = new System.Drawing.Size(120, 23);
            this.zahl2TextBox.TabIndex = 2;

            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 70);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(60, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);

            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(78, 70);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(60, 23);
            this.subtractButton.TabIndex = 4;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);

            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(144, 70);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(60, 23);
            this.multiplyButton.TabIndex = 5;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);

            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(210, 70);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(60, 23);
            this.divideButton.TabIndex = 6;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.zahl2TextBox);
            this.Controls.Add(this.zahl1TextBox);
            this.Controls.Add(this.ergebnisTextBox);
            this.Name = "Form1";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox ergebnisTextBox;
        private System.Windows.Forms.TextBox zahl1TextBox;
        private System.Windows.Forms.TextBox zahl2TextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
    }
}
