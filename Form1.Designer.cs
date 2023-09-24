namespace PhotoCorrection {
	partial class MainForm {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			this.pictureBox_original = new System.Windows.Forms.PictureBox();
			this.label_original_image = new System.Windows.Forms.Label();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenFile_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveAsFile_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label_modified_image = new System.Windows.Forms.Label();
			this.pictureBox_modified = new System.Windows.Forms.PictureBox();
			this.button_execute_bilinear = new System.Windows.Forms.Button();
			this.button_execute_bicubic = new System.Windows.Forms.Button();
			this.numericUpDown_bilinearX = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_bilinearY = new System.Windows.Forms.NumericUpDown();
			this.label_bilinearX = new System.Windows.Forms.Label();
			this.label_bilinearY = new System.Windows.Forms.Label();
			this.label_bicubicY = new System.Windows.Forms.Label();
			this.label_bicubicX = new System.Windows.Forms.Label();
			this.numericUpDown_bicubicY = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_bicubicX = new System.Windows.Forms.NumericUpDown();
			this.label_original_size = new System.Windows.Forms.Label();
			this.label_modified_size = new System.Windows.Forms.Label();
			this.label_time = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).BeginInit();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_modified)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bilinearX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bilinearY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bicubicY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bicubicX)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox_original
			// 
			this.pictureBox_original.Location = new System.Drawing.Point(12, 48);
			this.pictureBox_original.Name = "pictureBox_original";
			this.pictureBox_original.Size = new System.Drawing.Size(512, 512);
			this.pictureBox_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_original.TabIndex = 0;
			this.pictureBox_original.TabStop = false;
			// 
			// label_original_image
			// 
			this.label_original_image.AutoSize = true;
			this.label_original_image.ForeColor = System.Drawing.Color.White;
			this.label_original_image.Location = new System.Drawing.Point(12, 24);
			this.label_original_image.Name = "label_original_image";
			this.label_original_image.Size = new System.Drawing.Size(184, 21);
			this.label_original_image.TabIndex = 1;
			this.label_original_image.Text = "Исходное изображение:";
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_ToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(1054, 24);
			this.menuStrip.TabIndex = 2;
			this.menuStrip.Text = "Меню";
			// 
			// File_ToolStripMenuItem
			// 
			this.File_ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.File_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile_ToolStripMenuItem,
            this.SaveAsFile_ToolStripMenuItem});
			this.File_ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.File_ToolStripMenuItem.Name = "File_ToolStripMenuItem";
			this.File_ToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.File_ToolStripMenuItem.Text = "Файл";
			// 
			// OpenFile_ToolStripMenuItem
			// 
			this.OpenFile_ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.OpenFile_ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.OpenFile_ToolStripMenuItem.Name = "OpenFile_ToolStripMenuItem";
			this.OpenFile_ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.OpenFile_ToolStripMenuItem.Text = "Открыть...";
			this.OpenFile_ToolStripMenuItem.Click += new System.EventHandler(this.OpenFile_ToolStripMenuItem_Click);
			// 
			// SaveAsFile_ToolStripMenuItem
			// 
			this.SaveAsFile_ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.SaveAsFile_ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.SaveAsFile_ToolStripMenuItem.Name = "SaveAsFile_ToolStripMenuItem";
			this.SaveAsFile_ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.SaveAsFile_ToolStripMenuItem.Text = "Сохранить как...";
			this.SaveAsFile_ToolStripMenuItem.Click += new System.EventHandler(this.SaveAsFile_ToolStripMenuItem_Click);
			// 
			// label_modified_image
			// 
			this.label_modified_image.AutoSize = true;
			this.label_modified_image.ForeColor = System.Drawing.Color.White;
			this.label_modified_image.Location = new System.Drawing.Point(530, 24);
			this.label_modified_image.Name = "label_modified_image";
			this.label_modified_image.Size = new System.Drawing.Size(263, 21);
			this.label_modified_image.TabIndex = 4;
			this.label_modified_image.Text = "Модифицированное изображение:";
			// 
			// pictureBox_modified
			// 
			this.pictureBox_modified.Location = new System.Drawing.Point(530, 48);
			this.pictureBox_modified.Name = "pictureBox_modified";
			this.pictureBox_modified.Size = new System.Drawing.Size(512, 512);
			this.pictureBox_modified.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_modified.TabIndex = 3;
			this.pictureBox_modified.TabStop = false;
			// 
			// button_execute_bilinear
			// 
			this.button_execute_bilinear.Location = new System.Drawing.Point(12, 639);
			this.button_execute_bilinear.Name = "button_execute_bilinear";
			this.button_execute_bilinear.Size = new System.Drawing.Size(260, 30);
			this.button_execute_bilinear.TabIndex = 12;
			this.button_execute_bilinear.Text = "Билинейное сглаживание";
			this.button_execute_bilinear.UseVisualStyleBackColor = true;
			this.button_execute_bilinear.Click += new System.EventHandler(this.button_execute_bilinear_Click);
			// 
			// button_execute_bicubic
			// 
			this.button_execute_bicubic.Location = new System.Drawing.Point(278, 639);
			this.button_execute_bicubic.Name = "button_execute_bicubic";
			this.button_execute_bicubic.Size = new System.Drawing.Size(260, 30);
			this.button_execute_bicubic.TabIndex = 13;
			this.button_execute_bicubic.Text = "Бикубическое сглаживание";
			this.button_execute_bicubic.UseVisualStyleBackColor = true;
			this.button_execute_bicubic.Click += new System.EventHandler(this.button_execute_bicubic_Click);
			// 
			// numericUpDown_bilinearX
			// 
			this.numericUpDown_bilinearX.DecimalPlaces = 2;
			this.numericUpDown_bilinearX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDown_bilinearX.Location = new System.Drawing.Point(152, 569);
			this.numericUpDown_bilinearX.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
			this.numericUpDown_bilinearX.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDown_bilinearX.Name = "numericUpDown_bilinearX";
			this.numericUpDown_bilinearX.Size = new System.Drawing.Size(120, 29);
			this.numericUpDown_bilinearX.TabIndex = 14;
			this.numericUpDown_bilinearX.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
			// 
			// numericUpDown_bilinearY
			// 
			this.numericUpDown_bilinearY.DecimalPlaces = 2;
			this.numericUpDown_bilinearY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDown_bilinearY.Location = new System.Drawing.Point(152, 604);
			this.numericUpDown_bilinearY.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
			this.numericUpDown_bilinearY.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDown_bilinearY.Name = "numericUpDown_bilinearY";
			this.numericUpDown_bilinearY.Size = new System.Drawing.Size(120, 29);
			this.numericUpDown_bilinearY.TabIndex = 15;
			this.numericUpDown_bilinearY.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
			// 
			// label_bilinearX
			// 
			this.label_bilinearX.AutoSize = true;
			this.label_bilinearX.ForeColor = System.Drawing.Color.White;
			this.label_bilinearX.Location = new System.Drawing.Point(81, 571);
			this.label_bilinearX.Name = "label_bilinearX";
			this.label_bilinearX.Size = new System.Drawing.Size(65, 21);
			this.label_bilinearX.TabIndex = 16;
			this.label_bilinearX.Text = "Коэф. X:";
			// 
			// label_bilinearY
			// 
			this.label_bilinearY.AutoSize = true;
			this.label_bilinearY.ForeColor = System.Drawing.Color.White;
			this.label_bilinearY.Location = new System.Drawing.Point(81, 606);
			this.label_bilinearY.Name = "label_bilinearY";
			this.label_bilinearY.Size = new System.Drawing.Size(65, 21);
			this.label_bilinearY.TabIndex = 17;
			this.label_bilinearY.Text = "Коэф. Y:";
			// 
			// label_bicubicY
			// 
			this.label_bicubicY.AutoSize = true;
			this.label_bicubicY.ForeColor = System.Drawing.Color.White;
			this.label_bicubicY.Location = new System.Drawing.Point(347, 606);
			this.label_bicubicY.Name = "label_bicubicY";
			this.label_bicubicY.Size = new System.Drawing.Size(65, 21);
			this.label_bicubicY.TabIndex = 21;
			this.label_bicubicY.Text = "Коэф. Y:";
			// 
			// label_bicubicX
			// 
			this.label_bicubicX.AutoSize = true;
			this.label_bicubicX.ForeColor = System.Drawing.Color.White;
			this.label_bicubicX.Location = new System.Drawing.Point(347, 571);
			this.label_bicubicX.Name = "label_bicubicX";
			this.label_bicubicX.Size = new System.Drawing.Size(65, 21);
			this.label_bicubicX.TabIndex = 20;
			this.label_bicubicX.Text = "Коэф. X:";
			// 
			// numericUpDown_bicubicY
			// 
			this.numericUpDown_bicubicY.DecimalPlaces = 2;
			this.numericUpDown_bicubicY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDown_bicubicY.Location = new System.Drawing.Point(418, 604);
			this.numericUpDown_bicubicY.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
			this.numericUpDown_bicubicY.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDown_bicubicY.Name = "numericUpDown_bicubicY";
			this.numericUpDown_bicubicY.Size = new System.Drawing.Size(120, 29);
			this.numericUpDown_bicubicY.TabIndex = 19;
			this.numericUpDown_bicubicY.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
			// 
			// numericUpDown_bicubicX
			// 
			this.numericUpDown_bicubicX.DecimalPlaces = 2;
			this.numericUpDown_bicubicX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDown_bicubicX.Location = new System.Drawing.Point(418, 569);
			this.numericUpDown_bicubicX.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
			this.numericUpDown_bicubicX.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDown_bicubicX.Name = "numericUpDown_bicubicX";
			this.numericUpDown_bicubicX.Size = new System.Drawing.Size(120, 29);
			this.numericUpDown_bicubicX.TabIndex = 18;
			this.numericUpDown_bicubicX.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
			// 
			// label_original_size
			// 
			this.label_original_size.AutoSize = true;
			this.label_original_size.ForeColor = System.Drawing.Color.White;
			this.label_original_size.Location = new System.Drawing.Point(202, 24);
			this.label_original_size.Name = "label_original_size";
			this.label_original_size.Size = new System.Drawing.Size(35, 21);
			this.label_original_size.TabIndex = 22;
			this.label_original_size.Text = "0x0";
			// 
			// label_modified_size
			// 
			this.label_modified_size.AutoSize = true;
			this.label_modified_size.ForeColor = System.Drawing.Color.White;
			this.label_modified_size.Location = new System.Drawing.Point(799, 24);
			this.label_modified_size.Name = "label_modified_size";
			this.label_modified_size.Size = new System.Drawing.Size(35, 21);
			this.label_modified_size.TabIndex = 23;
			this.label_modified_size.Text = "0x0";
			// 
			// label_time
			// 
			this.label_time.AutoSize = true;
			this.label_time.ForeColor = System.Drawing.Color.White;
			this.label_time.Location = new System.Drawing.Point(799, 651);
			this.label_time.Name = "label_time";
			this.label_time.Size = new System.Drawing.Size(19, 21);
			this.label_time.TabIndex = 24;
			this.label_time.Text = "...";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.ClientSize = new System.Drawing.Size(1054, 681);
			this.Controls.Add(this.label_time);
			this.Controls.Add(this.label_modified_size);
			this.Controls.Add(this.label_original_size);
			this.Controls.Add(this.label_bicubicY);
			this.Controls.Add(this.label_bicubicX);
			this.Controls.Add(this.numericUpDown_bicubicY);
			this.Controls.Add(this.numericUpDown_bicubicX);
			this.Controls.Add(this.label_bilinearY);
			this.Controls.Add(this.label_bilinearX);
			this.Controls.Add(this.numericUpDown_bilinearY);
			this.Controls.Add(this.numericUpDown_bilinearX);
			this.Controls.Add(this.button_execute_bicubic);
			this.Controls.Add(this.button_execute_bilinear);
			this.Controls.Add(this.label_modified_image);
			this.Controls.Add(this.pictureBox_modified);
			this.Controls.Add(this.label_original_image);
			this.Controls.Add(this.pictureBox_original);
			this.Controls.Add(this.menuStrip);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MainMenuStrip = this.menuStrip;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainForm";
			this.Text = "Сглаживание изображения";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).EndInit();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_modified)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bilinearX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bilinearY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bicubicY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bicubicX)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox_original;
		private System.Windows.Forms.Label label_original_image;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem File_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OpenFile_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveAsFile_ToolStripMenuItem;
		private System.Windows.Forms.Label label_modified_image;
		private System.Windows.Forms.PictureBox pictureBox_modified;
		private System.Windows.Forms.Button button_execute_bilinear;
		private System.Windows.Forms.Button button_execute_bicubic;
		private System.Windows.Forms.NumericUpDown numericUpDown_bilinearX;
		private System.Windows.Forms.NumericUpDown numericUpDown_bilinearY;
		private System.Windows.Forms.Label label_bilinearX;
		private System.Windows.Forms.Label label_bilinearY;
		private System.Windows.Forms.Label label_bicubicY;
		private System.Windows.Forms.Label label_bicubicX;
		private System.Windows.Forms.NumericUpDown numericUpDown_bicubicY;
		private System.Windows.Forms.NumericUpDown numericUpDown_bicubicX;
		private System.Windows.Forms.Label label_original_size;
		private System.Windows.Forms.Label label_modified_size;
		private System.Windows.Forms.Label label_time;
	}
}

