namespace GyakString
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
            this.kiiras = new System.Windows.Forms.TextBox();
            this.bevitel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startGomb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kiiras
            // 
            this.kiiras.Location = new System.Drawing.Point(104, 75);
            this.kiiras.Multiline = true;
            this.kiiras.Name = "kiiras";
            this.kiiras.Size = new System.Drawing.Size(447, 179);
            this.kiiras.TabIndex = 0;
            // 
            // bevitel
            // 
            this.bevitel.Location = new System.Drawing.Point(104, 23);
            this.bevitel.Name = "bevitel";
            this.bevitel.Size = new System.Drawing.Size(447, 26);
            this.bevitel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Szöveg:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Eredmény";
            // 
            // startGomb
            // 
            this.startGomb.Location = new System.Drawing.Point(273, 289);
            this.startGomb.Name = "startGomb";
            this.startGomb.Size = new System.Drawing.Size(102, 42);
            this.startGomb.TabIndex = 4;
            this.startGomb.Text = "Start";
            this.startGomb.UseVisualStyleBackColor = true;
            this.startGomb.Click += new System.EventHandler(this.startGomb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 395);
            this.Controls.Add(this.startGomb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bevitel);
            this.Controls.Add(this.kiiras);
            this.Name = "Form1";
            this.Text = "String gyakorlás";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kiiras;
        private System.Windows.Forms.TextBox bevitel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startGomb;
    }
}

