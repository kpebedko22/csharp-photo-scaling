using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace PhotoCorrection {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

        public static Bitmap original_image;
        public static Bitmap modified_image;
        public static string full_name_of_image = "\0";

        private void OpenFile_ToolStripMenuItem_Click(object sender, EventArgs e) {
			/* Выбор изображение с помощью диалогового окна */

			OpenFileDialog open_dialog = new OpenFileDialog();
			open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

            if (open_dialog.ShowDialog() == DialogResult.OK) {
                try {
                    if (full_name_of_image != "\0") {
                        original_image.Dispose();
                        modified_image.Dispose();
                    }

                    full_name_of_image = open_dialog.FileName;

                    original_image = new Bitmap(open_dialog.FileName);
                    modified_image = new Bitmap(open_dialog.FileName);

                    UpdateGUI();
                }
                catch {
                    full_name_of_image = "\0";
                    DialogResult result = MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

		private void SaveAsFile_ToolStripMenuItem_Click(object sender, EventArgs e) {
            /* Сохранение изображения с помощью диалогового окна */
            
            if (full_name_of_image != "\0") {
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK) {
                    try {
                        Console.WriteLine(savedialog.FileName);
                        modified_image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void UpdateGUI() {
            /* Обновить элементы управления на форме */

            label_original_size.Text = original_image.Width.ToString() + " x " + original_image.Height.ToString();
            label_modified_size.Text = modified_image.Width.ToString() + " x " + modified_image.Height.ToString();

            numericUpDown_bicubicX.Value = 1;
            numericUpDown_bicubicY.Value = 1;

            numericUpDown_bilinearX.Value = 1;
            numericUpDown_bilinearY.Value = 1;

            pictureBox_original.Image = original_image;
            pictureBox_modified.Image = modified_image;
        }

        public void ShowModified() {
            pictureBox_modified.Image = modified_image;
            label_modified_size.Text = modified_image.Width.ToString() + " x " + modified_image.Height.ToString();
        }

		private void button_execute_bilinear_Click(object sender, EventArgs e) {
            /* Применение билинейного сглаживания к фото */

            if (full_name_of_image != "\0") {

                float scaleX = (float)numericUpDown_bilinearX.Value;
                float scaleY = (float)numericUpDown_bilinearY.Value;

                modified_image.Dispose();

                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                modified_image = BilinearInterpolation.Scale(original_image, scaleX, scaleY);

                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                label_time.Text = elapsedTime;

                ShowModified();
                modified_image.Save(full_name_of_image + "_bilinear" +
                    modified_image.Width.ToString() +
                    " x " +
                    modified_image.Height.ToString() +
                    ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

		private void button_execute_bicubic_Click(object sender, EventArgs e) {
            /* Применение бикубического сглаживания к фото */
            if (full_name_of_image != "\0") {

                float scaleX = (float)numericUpDown_bicubicX.Value;
                float scaleY = (float)numericUpDown_bicubicY.Value;

                modified_image.Dispose();

                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                modified_image = BicubicInterpolation.Scale(original_image, scaleX, scaleY);

                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                label_time.Text = elapsedTime;

                ShowModified();

                modified_image.Save(full_name_of_image + "_bicubic" + 
                    modified_image.Width.ToString() + 
                    " x " + 
                    modified_image.Height.ToString() + 
                    ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
	}
}
