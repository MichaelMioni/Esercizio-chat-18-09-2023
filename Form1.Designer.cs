namespace Esercizio_chat_18_09_2023
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxInvia = new System.Windows.Forms.TextBox();
            this.textBoxRicevi = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxInvia
            // 
            this.textBoxInvia.Location = new System.Drawing.Point(132, 63);
            this.textBoxInvia.Name = "textBoxInvia";
            this.textBoxInvia.Size = new System.Drawing.Size(252, 23);
            this.textBoxInvia.TabIndex = 1;
            // 
            // textBoxRicevi
            // 
            this.textBoxRicevi.Location = new System.Drawing.Point(132, 119);
            this.textBoxRicevi.Multiline = true;
            this.textBoxRicevi.Name = "textBoxRicevi";
            this.textBoxRicevi.Size = new System.Drawing.Size(252, 200);
            this.textBoxRicevi.TabIndex = 2;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(415, 119);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(252, 200);
            this.textBoxOutput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxRicevi);
            this.Controls.Add(this.textBoxInvia);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox textBoxInvia;
        private TextBox textBoxRicevi;
        private TextBox textBoxOutput;
    }
}