
namespace Snake_Games
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textScore = new System.Windows.Forms.Label();
            this.textpuan = new System.Windows.Forms.Label();
            this.textBasla = new System.Windows.Forms.Label();
            this.textsonuc = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 600);
            this.panel1.TabIndex = 0;
            // 
            // textScore
            // 
            this.textScore.AutoSize = true;
            this.textScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textScore.Location = new System.Drawing.Point(650, 75);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(89, 29);
            this.textScore.TabIndex = 1;
            this.textScore.Text = "Score:";
            // 
            // textpuan
            // 
            this.textpuan.AutoSize = true;
            this.textpuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textpuan.Location = new System.Drawing.Point(682, 115);
            this.textpuan.Name = "textpuan";
            this.textpuan.Size = new System.Drawing.Size(27, 29);
            this.textpuan.TabIndex = 2;
            this.textpuan.Text = "0";
            // 
            // textBasla
            // 
            this.textBasla.AutoSize = true;
            this.textBasla.BackColor = System.Drawing.Color.SteelBlue;
            this.textBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBasla.Location = new System.Drawing.Point(650, 167);
            this.textBasla.Name = "textBasla";
            this.textBasla.Size = new System.Drawing.Size(93, 29);
            this.textBasla.TabIndex = 3;
            this.textBasla.Text = "BAŞLA";
            this.textBasla.Click += new System.EventHandler(this.textBasla_Click);
            // 
            // textsonuc
            // 
            this.textsonuc.AutoSize = true;
            this.textsonuc.BackColor = System.Drawing.Color.SandyBrown;
            this.textsonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textsonuc.Location = new System.Drawing.Point(628, 260);
            this.textsonuc.Name = "textsonuc";
            this.textsonuc.Size = new System.Drawing.Size(142, 38);
            this.textsonuc.TabIndex = 4;
            this.textsonuc.Text = "SONUÇ";
            this.textsonuc.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(805, 652);
            this.Controls.Add(this.textsonuc);
            this.Controls.Add(this.textBasla);
            this.Controls.Add(this.textpuan);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SNAKE GAME";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.Label textpuan;
        private System.Windows.Forms.Label textBasla;
        private System.Windows.Forms.Label textsonuc;
        private System.Windows.Forms.Timer timer1;
    }
}

