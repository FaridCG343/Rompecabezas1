using System.Reflection;

namespace Rompecabezas1
{
    public partial class FormInicio : Form
    {
        Image img;
        string dificultad;
        public FormInicio()
        {
            InitializeComponent();
        }
        private void btnOtherImg_Click(object sender, EventArgs e)
        {
            DialogResult r = cgfFileDialog.ShowDialog();
            if (r == DialogResult.OK)
            {
                img = Image.FromFile(cgfFileDialog.FileName);
                pbcgfPreview.Image = img;
            }
        }

        private void cbxcgfImagen_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cbxcgfImagen.SelectedItem)
            {
                case "Perrito Fino":
                    img = Properties.Resources.perrito_elegante;
                    pbcgfPreview.Image = img;
                    break;
                case "Melvin":
                    img = Properties.Resources.melvin;
                    pbcgfPreview.Image = img;
                    break;
                case "SpiderMan":
                    img = Properties.Resources.spiderman;
                    pbcgfPreview.Image = img;
                    break;
            }
        }
        private void cbxcgfDificultad_SelectedValueChanged(object sender, EventArgs e)
        {
            dificultad = (String)cbxcgfDificultad.SelectedItem;
        }

        private void btncgfJugar_Click(object sender, EventArgs e)
        {
            if (img == null)
            {
                MessageBox.Show("Por favor selecciona una imagen");
                cbxcgfImagen.Focus();
                return;
            }
            if (dificultad == null)
            {
                MessageBox.Show("Porfavor selecciona la dificultad");
                cbxcgfDificultad.Focus();
                return;
            }
            Program.formJuego = new (img, dificultad);
            Hide();
            Program.formJuego.Show();
        }
    }
}