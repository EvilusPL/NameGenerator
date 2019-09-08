namespace GUINameGenerator
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
            this.getName = new System.Windows.Forms.Button();
            this.nameGenerated = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // getName
            // 
            this.getName.Location = new System.Drawing.Point(136, 120);
            this.getName.Name = "getName";
            this.getName.Size = new System.Drawing.Size(75, 23);
            this.getName.TabIndex = 0;
            this.getName.Text = "Get a name!";
            this.getName.UseVisualStyleBackColor = true;
            this.getName.Click += new System.EventHandler(this.GetName_Click);
            // 
            // nameGenerated
            // 
            this.nameGenerated.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameGenerated.Location = new System.Drawing.Point(12, 25);
            this.nameGenerated.Name = "nameGenerated";
            this.nameGenerated.ReadOnly = true;
            this.nameGenerated.Size = new System.Drawing.Size(324, 31);
            this.nameGenerated.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 182);
            this.Controls.Add(this.nameGenerated);
            this.Controls.Add(this.getName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Random Name Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getName;
        private System.Windows.Forms.TextBox nameGenerated;
    }
}

