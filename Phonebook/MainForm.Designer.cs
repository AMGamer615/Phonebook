namespace Phonebook
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            roundedTextBox1 = new Resources.RoundedTextBox(components);
            component11 = new Resources.RoundedButton(components);
            roundedTextBox2 = new Resources.RoundedTextBox(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(roundedTextBox1);
            groupBox1.Location = new Point(220, 181);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // roundedTextBox1
            // 
            roundedTextBox1.Location = new Point(14, 46);
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.Round = 15;
            roundedTextBox1.Size = new Size(156, 23);
            roundedTextBox1.TabIndex = 0;
            // 
            // component11
            // 
            component11.BackColor = SystemColors.HotTrack;
            component11.ForeColor = Color.White;
            component11.Location = new Point(468, 214);
            component11.Name = "component11";
            component11.Round = 40;
            component11.Size = new Size(84, 47);
            component11.TabIndex = 1;
            component11.Text = "بعدی";
            component11.UseVisualStyleBackColor = false;
            // 
            // roundedTextBox2
            // 
            roundedTextBox2.Location = new Point(527, 134);
            roundedTextBox2.Name = "roundedTextBox2";
            roundedTextBox2.Round = 15;
            roundedTextBox2.Size = new Size(100, 23);
            roundedTextBox2.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 369);
            Controls.Add(roundedTextBox2);
            Controls.Add(component11);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "MainForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Resources.RoundedTextBox roundedTextBox1;
        private Resources.RoundedButton component11;
        private Resources.RoundedTextBox roundedTextBox2;
    }
}