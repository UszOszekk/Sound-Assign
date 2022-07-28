
namespace Directory_Sound_Player_Assigner
{
    partial class Selector
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selector));
            this.button1 = new System.Windows.Forms.Button();
            this.labelpath = new System.Windows.Forms.Label();
            this.play = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelpath
            // 
            this.labelpath.AutoSize = true;
            this.labelpath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelpath.Cursor = System.Windows.Forms.Cursors.No;
            this.labelpath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelpath.Location = new System.Drawing.Point(12, 94);
            this.labelpath.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.labelpath.MinimumSize = new System.Drawing.Size(200, 23);
            this.labelpath.Name = "labelpath";
            this.labelpath.Size = new System.Drawing.Size(200, 23);
            this.labelpath.TabIndex = 1;
            this.labelpath.Text = "Select Path";
            this.labelpath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(206, 138);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 23);
            this.play.TabIndex = 2;
            this.play.Text = "play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "Open 2nd window";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 295);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.play);
            this.Controls.Add(this.labelpath);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(367, 334);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(367, 334);
            this.Name = "Selector";
            this.Text = "Sound Assign";
            this.Load += new System.EventHandler(this.Selector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelpath;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button button2;
    }
}

