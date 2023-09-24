using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace PhotoCorrection {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

		public static Bitmap originalImage;
		public static Bitmap modifiedImage;
		public static string imageFullName = "\0";

		/// <summary>
		/// Выбор изображения с помощью диалогового окна
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemOpenFileClick(object sender, EventArgs e) {

			OpenFileDialog openFileDialog = new OpenFileDialog {
				Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				try {
					if (imageFullName != "\0") {
						originalImage.Dispose();
						modifiedImage.Dispose();
					}

					imageFullName = openFileDialog.FileName;

					originalImage = new Bitmap(openFileDialog.FileName);
					modifiedImage = new Bitmap(openFileDialog.FileName);

					UpdateGUI();
				}
				catch {
					imageFullName = "\0";

					MessageBox.Show(
						"Невозможно открыть выбранный файл",
						"Ошибка",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error
					);
				}
			}
		}

		/// <summary>
		/// Сохранение изображения с помощью диалогового окна
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemSaveAsFileClick(object sender, EventArgs e) {
			if (imageFullName == "\0") {
				return;
			}

			SaveFileDialog saveFileDialog = new SaveFileDialog {
				Title = "Сохранить картинку как...",
				OverwritePrompt = true,
				CheckPathExists = true,
				Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*",
				ShowHelp = true
			};

			if (saveFileDialog.ShowDialog() == DialogResult.OK) {
				try {
					modifiedImage.Save(
						saveFileDialog.FileName,
						System.Drawing.Imaging.ImageFormat.Jpeg
					);
				}
				catch {
					MessageBox.Show(
						"Невозможно сохранить изображение",
						"Ошибка",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error
					);
				}
			}
		}

		/// <summary>
		/// Обновить элементы управления на форме
		/// </summary>
		private void UpdateGUI() {

			labelOriginalSize.Text = originalImage.Width.ToString() + " x " + originalImage.Height.ToString();
			labelModifiedSize.Text = modifiedImage.Width.ToString() + " x " + modifiedImage.Height.ToString();

			numericUpDownBicubicX.Value = 1;
			numericUpDownBicubicY.Value = 1;

			numericUpDownBilinearX.Value = 1;
			numericUpDownBilinearY.Value = 1;

			pictureBoxOriginal.Image = originalImage;
			pictureBoxModified.Image = modifiedImage;
		}

		/// <summary>
		/// Вывести модифицированное изображение
		/// </summary>
		public void ShowModified() {
			pictureBoxModified.Image = modifiedImage;
			labelModifiedSize.Text = modifiedImage.Width.ToString() + " x " + modifiedImage.Height.ToString();
		}

		/// <summary>
		/// Эвент нажатия на кнопку применения билинейного сглаживания
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonExecuteBilinearClick(object sender, EventArgs e) {
			if (imageFullName == "\0") {
				return;
			}

			float scaleX = (float)numericUpDownBilinearX.Value;
			float scaleY = (float)numericUpDownBilinearY.Value;

			modifiedImage.Dispose();

			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();

			modifiedImage = BilinearInterpolation.Scale(originalImage, scaleX, scaleY);

			stopWatch.Stop();
			TimeSpan ts = stopWatch.Elapsed;
			string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
			labelExecutionTime.Text = elapsedTime;

			ShowModified();

			modifiedImage.Save(
				imageFullName + "_bilinear" + modifiedImage.Width.ToString() + "x" + modifiedImage.Height.ToString() + ".jpg",
				System.Drawing.Imaging.ImageFormat.Jpeg
			);
		}

		/// <summary>
		/// Эвент нажатия на кнопку применения бикубического сглаживания
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonExecuteBicubicClick(object sender, EventArgs e) {
			if (imageFullName == "\0") {
				return;
			}

			float scaleX = (float)numericUpDownBicubicX.Value;
			float scaleY = (float)numericUpDownBicubicY.Value;

			modifiedImage.Dispose();

			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();

			modifiedImage = BicubicInterpolation.Scale(originalImage, scaleX, scaleY);

			stopWatch.Stop();
			TimeSpan ts = stopWatch.Elapsed;
			string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
			labelExecutionTime.Text = elapsedTime;

			ShowModified();

			modifiedImage.Save(
				imageFullName + "_bicubic" + modifiedImage.Width.ToString() + "x" + modifiedImage.Height.ToString() + ".jpg",
				System.Drawing.Imaging.ImageFormat.Jpeg
			);
		}
	}
}
