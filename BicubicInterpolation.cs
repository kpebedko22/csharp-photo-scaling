using System;
using System.Drawing;

namespace PhotoCorrection {
	class BicubicInterpolation {
		/// <summary>
		/// Создание нового изображения на основе исходного с новыми размерами ширины и высоты
		/// </summary>
		/// <param name="original"></param>
		/// <param name="scaleX"></param>
		/// <param name="scaleY"></param>
		/// <returns></returns>
		public static Bitmap Scale(Bitmap original, float scaleX, float scaleY) {

			int newWidth = (int)(original.Width * scaleX);
			int newHeight = (int)(original.Height * scaleY);

			Bitmap modified = new Bitmap(newWidth, newHeight, original.PixelFormat);

			for (int x = 0; x < newWidth; x++) {
				for (int y = 0; y < newHeight; y++) {
					float gx = ((float)x) / newWidth * (original.Width - 1);
					float gy = ((float)y) / newHeight * (original.Height - 1);
					int gxi = (int)gx;
					int gyi = (int)gy;

					Color c00 = GetPixelClamped(original, gxi - 1, gyi - 1);
					Color c10 = GetPixelClamped(original, gxi + 0, gyi - 1);
					Color c20 = GetPixelClamped(original, gxi + 1, gyi - 1);
					Color c30 = GetPixelClamped(original, gxi + 2, gyi - 1);

					Color c01 = GetPixelClamped(original, gxi - 1, gyi + 0);
					Color c11 = GetPixelClamped(original, gxi + 0, gyi + 0);
					Color c21 = GetPixelClamped(original, gxi + 1, gyi + 0);
					Color c31 = GetPixelClamped(original, gxi + 2, gyi + 0);

					Color c02 = GetPixelClamped(original, gxi - 1, gyi + 1);
					Color c12 = GetPixelClamped(original, gxi + 0, gyi + 1);
					Color c22 = GetPixelClamped(original, gxi + 1, gyi + 1);
					Color c32 = GetPixelClamped(original, gxi + 2, gyi + 1);

					Color c03 = GetPixelClamped(original, gxi - 1, gyi + 1);
					Color c13 = GetPixelClamped(original, gxi + 0, gyi + 1);
					Color c23 = GetPixelClamped(original, gxi + 1, gyi + 1);
					Color c33 = GetPixelClamped(original, gxi + 2, gyi + 1);

					float col0 = CubicHermite(c00.R, c10.R, c20.R, c30.R, gx - gxi);
					float col1 = CubicHermite(c01.R, c11.R, c21.R, c31.R, gx - gxi);
					float col2 = CubicHermite(c02.R, c12.R, c22.R, c32.R, gx - gxi);
					float col3 = CubicHermite(c03.R, c13.R, c23.R, c33.R, gx - gxi);
					int red = (int)CubicHermite(col0, col1, col2, col3, gy - gyi);
					Clamp(ref red, 0, 255);

					col0 = CubicHermite(c00.G, c10.G, c20.G, c30.G, gx - gxi);
					col1 = CubicHermite(c01.G, c11.G, c21.G, c31.G, gx - gxi);
					col2 = CubicHermite(c02.G, c12.G, c22.G, c32.G, gx - gxi);
					col3 = CubicHermite(c03.G, c13.G, c23.G, c33.G, gx - gxi);
					int green = (int)CubicHermite(col0, col1, col2, col3, gy - gyi);
					Clamp(ref green, 0, 255);

					col0 = CubicHermite(c00.B, c10.B, c20.B, c30.B, gx - gxi);
					col1 = CubicHermite(c01.B, c11.B, c21.B, c31.B, gx - gxi);
					col2 = CubicHermite(c02.B, c12.B, c22.B, c32.B, gx - gxi);
					col3 = CubicHermite(c03.B, c13.B, c23.B, c33.B, gx - gxi);
					int blue = (int)CubicHermite(col0, col1, col2, col3, gy - gyi);
					Clamp(ref blue, 0, 255);

					Color rgb = Color.FromArgb(red, green, blue);
					modified.SetPixel(x, y, rgb);
				}
			}

			return modified;
		}

		/// <summary>
		/// Приведение значения к мин./макс. значению при выходе за границы
		/// </summary>
		/// <param name="value"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		private static void Clamp(ref int value, int min, int max) {
			if (value < min) {
				value = min;
			}
			else if (value > max) {
				value = max;
			}
		}

		/// <summary>
		/// Возвращает значение пикселы в точках X и Y, предварительно проверив, что точки X и Y принадлежат изображению
		/// </summary>
		/// <param name="img"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		private static Color GetPixelClamped(Bitmap img, int x, int y) {
			Clamp(ref x, 0, img.Width - 1);
			Clamp(ref y, 0, img.Height - 1);

			return img.GetPixel(x, y);
		}

		/// <summary>
		/// Интерполяция по 4 точкам
		/// </summary>
		/// <param name="A"></param>
		/// <param name="B"></param>
		/// <param name="C"></param>
		/// <param name="D"></param>
		/// <param name="t"></param>
		/// <returns></returns>
		private static float CubicHermite(float A, float B, float C, float D, float t) {

			float a = -A / 2.0f + (3.0f * B) / 2.0f - (3.0f * C) / 2.0f + D / 2.0f;
			float b = A - (5.0f * B) / 2.0f + 2.0f * C - D / 2.0f;
			float c = -A / 2.0f + C / 2.0f;
			float d = B;

			return a * t * t * t + b * t * t + c * t + d;
		}
	}
}
