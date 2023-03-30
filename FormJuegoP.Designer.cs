namespace Rompecabezas1
{
    partial class FormJuegoP
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
            pbcgfImgRef = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbcgfImgRef).BeginInit();
            SuspendLayout();
            // 
            // pbcgfImgRef
            // 
            pbcgfImgRef.Location = new Point(772, 12);
            pbcgfImgRef.Name = "pbcgfImgRef";
            pbcgfImgRef.Size = new Size(275, 200);
            pbcgfImgRef.SizeMode = PictureBoxSizeMode.StretchImage;
            pbcgfImgRef.TabIndex = 2;
            pbcgfImgRef.TabStop = false;
            // 
            // FormJuegoP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1059, 561);
            Controls.Add(pbcgfImgRef);
            Name = "FormJuegoP";
            Text = "Rompecabezs";
            FormClosed += FormJuegoP_FormClosed;
            MouseDown += FormJuegoP_MouseDown;
            MouseMove += FormJuegoP_MouseMove;
            MouseUp += FormJuegoP_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pbcgfImgRef).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pbcgfImgRef;
    }
}