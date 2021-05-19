
namespace WindowsFormsApp5
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
            this.Glcontrol = new OpenTK.GLControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Glcontrol
            // 
            this.Glcontrol.BackColor = System.Drawing.Color.Black;
            this.Glcontrol.Location = new System.Drawing.Point(13, 13);
            this.Glcontrol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Glcontrol.Name = "Glcontrol";
            this.Glcontrol.Size = new System.Drawing.Size(774, 424);
            this.Glcontrol.TabIndex = 0;
            this.Glcontrol.VSync = false;
            this.Glcontrol.Load += new System.EventHandler(this.openGlControl_Load_1);
            this.Glcontrol.Paint += new System.Windows.Forms.PaintEventHandler(this.openGlControl_Paint_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Glcontrol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private OpenTK.GLControl Glcontrol;
        private System.Windows.Forms.Timer timer1;
    }
}

