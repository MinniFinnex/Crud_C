using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using MySqlConnector;

namespace mylogin
{
    public partial class Form1 : Form
    {
        private static int attempt = 3;

        // Conexion
        private readonly string connectionString = "Server=localhost;Port=3306;Database=login;Uid=root;Pwd=root;";

        public Form1()
        {
            InitializeComponent();
            LoadImageSafe(pictureBox1, "images.jpeg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (attempt <= 0)
            {
                lbl_Msg.Text = "LOS 3 INTENTOS HAN FALLADO";
                login.Enabled = false;
                return;
            }

            string user = txt_UserName.Text.Trim();
            string pwd = txt_PWD.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection scn = new MySqlConnection(connectionString))
                {
                    scn.Open();

                    string query = "SELECT COUNT(*) FROM username WHERE Nombre = @usr AND password = @pwd";
                    using (MySqlCommand scmd = new MySqlCommand(query, scn))
                    {
                        scmd.Parameters.AddWithValue("@usr", user);
                        scmd.Parameters.AddWithValue("@pwd", pwd);

                        long count = Convert.ToInt64(scmd.ExecuteScalar());

                        if (count != 1)
                        {
                            attempt--;
                            LoadImageSafe(pictureBox1, "denied.jpg");
                            MessageBox.Show("NO SE LE CONCEDE ACCESO", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            if (attempt > 0)
                            {
                                lbl_Msg.Text = "Solo tienes " + attempt + " intento(s) que quedan por probar.";
                            }
                            else
                            {
                                lbl_Msg.Text = "LOS 3 INTENTOS HAN FALLADO";
                                login.Enabled = false;
                            }

                            txt_UserName.Clear();
                            txt_PWD.Clear();
                            txt_UserName.Focus();
                        }
                        else
                        {
                            LoadImageSafe(pictureBox1, "granted.png");
                            lbl_Msg.Text = "";
                            MessageBox.Show("SE LE CONCEDE ACCESO", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos MariaDB/MySQL:\n" + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadImageSafe(PictureBox pb, string filename)
        {
            try
            {
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string localPath = Path.Combine(basePath, filename);
                string absolutePath = Path.Combine("/home/yfinne/Escritorio/Lab_CRUD", filename);

                string selectedPath = File.Exists(localPath) ? localPath : (File.Exists(absolutePath) ? absolutePath : null);

                if (selectedPath != null)
                {
                    pb.Image = Image.FromFile(selectedPath);
                }
            }
            catch
            {
                
            }
        }
    }
}