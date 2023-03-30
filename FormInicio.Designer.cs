namespace Rompecabezas1
{
    partial class FormInicio
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
            label1 = new Label();
            label2 = new Label();
            cbxcgfDificultad = new ComboBox();
            cbxcgfImagen = new ComboBox();
            cgfFileDialog = new OpenFileDialog();
            btncgfSelecciona = new Button();
            pbcgfPreview = new PictureBox();
            btncgfJugar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbcgfPreview).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 29);
            label1.Name = "label1";
            label1.Size = new Size(190, 21);
            label1.TabIndex = 4;
            label1.Text = "Selecciona la imagen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 165);
            label2.Name = "label2";
            label2.Size = new Size(226, 21);
            label2.TabIndex = 5;
            label2.Text = "Selecciona la dificultad";
            // 
            // cbxcgfDificultad
            // 
            cbxcgfDificultad.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbxcgfDificultad.FormattingEnabled = true;
            cbxcgfDificultad.Items.AddRange(new object[] { "Fácil", "Medio", "Difícil" });
            cbxcgfDificultad.Location = new Point(27, 196);
            cbxcgfDificultad.Name = "cbxcgfDificultad";
            cbxcgfDificultad.Size = new Size(121, 25);
            cbxcgfDificultad.TabIndex = 2;
            cbxcgfDificultad.Text = "Selecciona";
            cbxcgfDificultad.SelectedValueChanged += cbxcgfDificultad_SelectedValueChanged;
            // 
            // cbxcgfImagen
            // 
            cbxcgfImagen.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbxcgfImagen.FormattingEnabled = true;
            cbxcgfImagen.Items.AddRange(new object[] { "Perrito Fino", "SpiderMan", "Melvin" });
            cbxcgfImagen.Location = new Point(27, 57);
            cbxcgfImagen.Name = "cbxcgfImagen";
            cbxcgfImagen.Size = new Size(121, 25);
            cbxcgfImagen.TabIndex = 0;
            cbxcgfImagen.Text = "Selecciona";
            cbxcgfImagen.SelectedValueChanged += cbxcgfImagen_SelectedValueChanged;
            // 
            // cgfFileDialog
            // 
            cgfFileDialog.Filter = "*.png|*.jpg";
            // 
            // btncgfSelecciona
            // 
            btncgfSelecciona.BackColor = Color.FromArgb(255, 192, 128);
            btncgfSelecciona.FlatAppearance.BorderSize = 0;
            btncgfSelecciona.FlatStyle = FlatStyle.Flat;
            btncgfSelecciona.Location = new Point(214, 57);
            btncgfSelecciona.Name = "btncgfSelecciona";
            btncgfSelecciona.Size = new Size(132, 23);
            btncgfSelecciona.TabIndex = 1;
            btncgfSelecciona.Text = "Seleccionar otra";
            btncgfSelecciona.UseVisualStyleBackColor = false;
            btncgfSelecciona.Click += btnOtherImg_Click;
            // 
            // pbcgfPreview
            // 
            pbcgfPreview.Location = new Point(378, 49);
            pbcgfPreview.Name = "pbcgfPreview";
            pbcgfPreview.Size = new Size(275, 214);
            pbcgfPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            pbcgfPreview.TabIndex = 5;
            pbcgfPreview.TabStop = false;
            // 
            // btncgfJugar
            // 
            btncgfJugar.BackColor = Color.FromArgb(255, 192, 255);
            btncgfJugar.FlatAppearance.BorderSize = 0;
            btncgfJugar.FlatStyle = FlatStyle.Flat;
            btncgfJugar.ForeColor = Color.Black;
            btncgfJugar.Location = new Point(306, 330);
            btncgfJugar.Name = "btncgfJugar";
            btncgfJugar.Size = new Size(75, 23);
            btncgfJugar.TabIndex = 3;
            btncgfJugar.Text = "Jugar";
            btncgfJugar.UseVisualStyleBackColor = false;
            btncgfJugar.Click += btncgfJugar_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(700, 450);
            Controls.Add(btncgfJugar);
            Controls.Add(pbcgfPreview);
            Controls.Add(btncgfSelecciona);
            Controls.Add(cbxcgfImagen);
            Controls.Add(cbxcgfDificultad);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormInicio";
            Text = "Incio";
            ((System.ComponentModel.ISupportInitialize)pbcgfPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbxcgfDificultad;
        private ComboBox cbxcgfImagen;
        private OpenFileDialog cgfFileDialog;
        private Button btncgfSelecciona;
        private PictureBox pbcgfPreview;
        private Button btncgfJugar;
    }
}