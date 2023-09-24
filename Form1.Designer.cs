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
			this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
			this.labelOriginalImage = new System.Windows.Forms.Label();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemOpenFile = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemSaveAsFile = new System.Windows.Forms.ToolStripMenuItem();
			this.labelModifiedImage = new System.Windows.Forms.Label();
			this.pictureBoxModified = new System.Windows.Forms.PictureBox();
			this.buttonExecuteBilinear = new System.Windows.Forms.Button();
			this.buttonExecuteBicubic = new System.Windows.Forms.Button();
			this.numericUpDownBilinearX = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownBilinearY = new System.Windows.Forms.NumericUpDown();
			this.labelBilinearX = new System.Windows.Forms.Label();
			this.labelBilinearY = new System.Windows.Forms.Label();
			this.labelBicubicY = new System.Windows.Forms.Label();
			this.labelBicubicX = new System.Windows.Forms.Label();
			this.numericUpDownBicubicY = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownBicubicX = new System.Windows.Forms.NumericUpDown();
			this.labelOriginalSize = new System.Windows.Forms.Label();
			this.labelModifiedSize = new System.Windows.Forms.Label();
			this.labelExecutionTime = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxModified)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownBilinearX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownBilinearY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownBicubicY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownBicubicX)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxOriginal
			// 
			this.pictureBoxOriginal.Location = new System.Drawing.Point(12, 48);
			this.pictureBoxOriginal.Name = "pictureBoxOriginal";
			this.pictureBoxOriginal.Size = new System.Drawing.Size(512, 512);
			this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxOriginal.TabIndex = 0;
			this.pictureBoxOriginal.TabStop = false;
			// 
			// labelOriginalImage
			// 
			this.labelOriginalImage.AutoSize = true;
			this.labelOriginalImage.ForeColor = System.Drawing.Color.White;
			this.labelOriginalImage.Location = new System.Drawing.Point(12, 24);
			this.labelOriginalImage.Name = "labelOriginalImage";
			this.labelOriginalImage.Size = new System.Drawing.Size(184, 21);
			this.labelOriginalImage.TabIndex = 1;
			this.labelOriginalImage.Text = "Исходное изображение:";
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
            this.ToolStripMenuItemOpenFile,
            this.ToolStripMenuItemSaveAsFile});
			this.File_ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.File_ToolStripMenuItem.Name = "File_ToolStripMenuItem";
			this.File_ToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.File_ToolStripMenuItem.Text = "Файл";
			// 
			// ToolStripMenuItemOpenFile
			// 
			this.ToolStripMenuItemOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.ToolStripMenuItemOpenFile.ForeColor = System.Drawing.Color.White;
			this.ToolStripMenuItemOpenFile.Name = "ToolStripMenuItemOpenFile";
			this.ToolStripMenuItemOpenFile.Size = new System.Drawing.Size(180, 22);
			this.ToolStripMenuItemOpenFile.Text = "Открыть...";
			this.ToolStripMenuItemOpenFile.Click += new System.EventHandler(this.ToolStripMenuItemOpenFileClick);
			// 
			// ToolStripMenuItemSaveAsFile
			// 
			this.ToolStripMenuItemSaveAsFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.ToolStripMenuItemSaveAsFile.ForeColor = System.Drawing.Color.White;
			this.ToolStripMenuItemSaveAsFile.Name = "ToolStripMenuItemSaveAsFile";
			this.ToolStripMenuItemSaveAsFile.Size = new System.Drawing.Size(180, 22);
			this.ToolStripMenuItemSaveAsFile.Text = "Сохранить как...";
			this.ToolStripMenuItemSaveAsFile.Click += new System.EventHandler(this.ToolStripMenuItemSaveAsFileClick);
			// 
			// labelModifiedImage
			// 
			this.labelModifiedImage.AutoSize = true;
			this.labelModifiedImage.ForeColor = System.Drawing.Color.White;
			this.labelModifiedImage.Location = new System.Drawing.Point(530, 24);
			this.labelModifiedImage.Name = "labelModifiedImage";
			this.labelModifiedImage.Size = new System.Drawing.Size(263, 21);
			this.labelModifiedImage.TabIndex = 4;
			this.labelModifiedImage.Text = "Модифицированное изображение:";
			// 
			// pictureBoxModified
			// 
			this.pictureBoxModified.Location = new System.Drawing.Point(530, 48);
			this.pictureBoxModified.Name = "pictureBoxModified";
			this.pictureBoxModified.Size = new System.Drawing.Size(512, 512);
			this.pictureBoxModified.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxModified.TabIndex = 3;
			this.pictureBoxModified.TabStop = false;
			// 
			// buttonExecuteBilinear
			// 
			this.buttonExecuteBilinear.Location = new System.Drawing.Point(12, 639);
			this.buttonExecuteBilinear.Name = "buttonExecuteBilinear";
			this.buttonExecuteBilinear.Size = new System.Drawing.Size(260, 30);
			this.buttonExecuteBilinear.TabIndex = 12;
			this.buttonExecuteBilinear.Text = "Билинейное сглаживание";
			this.buttonExecuteBilinear.UseVisualStyleBackColor = true;
			this.buttonExecuteBilinear.Click += new System.EventHandler(this.ButtonExecuteBilinearClick);
			// 
			// buttonExecuteBicubic
			// 
			this.buttonExecuteBicubic.Location = new System.Drawing.Point(278, 639);
			this.buttonExecuteBicubic.Name = "buttonExecuteBicubic";
			this.buttonExecuteBicubic.Size = new System.Drawing.Size(260, 30);
			this.buttonExecuteBicubic.TabIndex = 13;
			this.buttonExecuteBicubic.Text = "Бикубическое сглаживание";
			this.buttonExecuteBicubic.UseVisualStyleBackColor = true;
			this.buttonExecuteBicubic.Click += new System.EventHandler(this.ButtonExecuteBicubicClick);
			// 
			// numericUpDownBilinearX
			// 
			this.numericUpDownBilinearX.DecimalPlaces = 2;
			this.numericUpDownBilinearX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDownBilinearX.Location = new System.Drawing.Point(152, 569);
			this.numericUpDownBilinearX.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
			this.numericUpDownBilinearX.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDownBilinearX.Name = "numericUpDownBilinearX";
			this.numericUpDownBilinearX.Size = new System.Drawing.Size(120, 29);
			this.numericUpDownBilinearX.TabIndex = 14;
			this.numericUpDownBilinearX.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
			// 
			// numericUpDownBilinearY
			// 
			this.numericUpDownBilinearY.DecimalPlaces = 2;
			this.numericUpDownBilinearY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDownBilinearY.Location = new System.Drawing.Point(152, 604);
			this.numericUpDownBilinearY.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
			this.numericUpDownBilinearY.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDownBilinearY.Name = "numericUpDownBilinearY";
			this.numericUpDownBilinearY.Size = new System.Drawing.Size(120, 29);
			this.numericUpDownBilinearY.TabIndex = 15;
			this.numericUpDownBilinearY.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
			// 
			// labelBilinearX
			// 
			this.labelBilinearX.AutoSize = true;
			this.labelBilinearX.ForeColor = System.Drawing.Color.White;
			this.labelBilinearX.Location = new System.Drawing.Point(81, 571);
			this.labelBilinearX.Name = "labelBilinearX";
			this.labelBilinearX.Size = new System.Drawing.Size(65, 21);
			this.labelBilinearX.TabIndex = 16;
			this.labelBilinearX.Text = "Коэф. X:";
			// 
			// labelBilinearY
			// 
			this.labelBilinearY.AutoSize = true;
			this.labelBilinearY.ForeColor = System.Drawing.Color.White;
			this.labelBilinearY.Location = new System.Drawing.Point(81, 606);
			this.labelBilinearY.Name = "labelBilinearY";
			this.labelBilinearY.Size = new System.Drawing.Size(65, 21);
			this.labelBilinearY.TabIndex = 17;
			this.labelBilinearY.Text = "Коэф. Y:";
			// 
			// labelBicubicY
			// 
			this.labelBicubicY.AutoSize = true;
			this.labelBicubicY.ForeColor = System.Drawing.Color.White;
			this.labelBicubicY.Location = new System.Drawing.Point(347, 606);
			this.labelBicubicY.Name = "labelBicubicY";
			this.labelBicubicY.Size = new System.Drawing.Size(65, 21);
			this.labelBicubicY.TabIndex = 21;
			this.labelBicubicY.Text = "Коэф. Y:";
			// 
			// labelBicubicX
			// 
			this.labelBicubicX.AutoSize = true;
			this.labelBicubicX.ForeColor = System.Drawing.Color.White;
			this.labelBicubicX.Location = new System.Drawing.Point(347, 571);
			this.labelBicubicX.Name = "labelBicubicX";
			this.labelBicubicX.Size = new System.Drawing.Size(65, 21);
			this.labelBicubicX.TabIndex = 20;
			this.labelBicubicX.Text = "Коэф. X:";
			// 
			// numericUpDownBicubicY
			// 
			this.numericUpDownBicubicY.DecimalPlaces = 2;
			this.numericUpDownBicubicY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDownBicubicY.Location = new System.Drawing.Point(418, 604);
			this.numericUpDownBicubicY.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
			this.numericUpDownBicubicY.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDownBicubicY.Name = "numericUpDownBicubicY";
			this.numericUpDownBicubicY.Size = new System.Drawing.Size(120, 29);
			this.numericUpDownBicubicY.TabIndex = 19;
			this.numericUpDownBicubicY.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
			// 
			// numericUpDownBicubicX
			// 
			this.numericUpDownBicubicX.DecimalPlaces = 2;
			this.numericUpDownBicubicX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDownBicubicX.Location = new System.Drawing.Point(418, 569);
			this.numericUpDownBicubicX.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
			this.numericUpDownBicubicX.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDownBicubicX.Name = "numericUpDownBicubicX";
			this.numericUpDownBicubicX.Size = new System.Drawing.Size(120, 29);
			this.numericUpDownBicubicX.TabIndex = 18;
			this.numericUpDownBicubicX.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
			// 
			// labelOriginalSize
			// 
			this.labelOriginalSize.AutoSize = true;
			this.labelOriginalSize.ForeColor = System.Drawing.Color.White;
			this.labelOriginalSize.Location = new System.Drawing.Point(202, 24);
			this.labelOriginalSize.Name = "labelOriginalSize";
			this.labelOriginalSize.Size = new System.Drawing.Size(35, 21);
			this.labelOriginalSize.TabIndex = 22;
			this.labelOriginalSize.Text = "0x0";
			// 
			// labelModifiedSize
			// 
			this.labelModifiedSize.AutoSize = true;
			this.labelModifiedSize.ForeColor = System.Drawing.Color.White;
			this.labelModifiedSize.Location = new System.Drawing.Point(799, 24);
			this.labelModifiedSize.Name = "labelModifiedSize";
			this.labelModifiedSize.Size = new System.Drawing.Size(35, 21);
			this.labelModifiedSize.TabIndex = 23;
			this.labelModifiedSize.Text = "0x0";
			// 
			// labelExecutionTime
			// 
			this.labelExecutionTime.AutoSize = true;
			this.labelExecutionTime.ForeColor = System.Drawing.Color.White;
			this.labelExecutionTime.Location = new System.Drawing.Point(799, 651);
			this.labelExecutionTime.Name = "labelExecutionTime";
			this.labelExecutionTime.Size = new System.Drawing.Size(19, 21);
			this.labelExecutionTime.TabIndex = 24;
			this.labelExecutionTime.Text = "...";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.ClientSize = new System.Drawing.Size(1054, 681);
			this.Controls.Add(this.labelExecutionTime);
			this.Controls.Add(this.labelModifiedSize);
			this.Controls.Add(this.labelOriginalSize);
			this.Controls.Add(this.labelBicubicY);
			this.Controls.Add(this.labelBicubicX);
			this.Controls.Add(this.numericUpDownBicubicY);
			this.Controls.Add(this.numericUpDownBicubicX);
			this.Controls.Add(this.labelBilinearY);
			this.Controls.Add(this.labelBilinearX);
			this.Controls.Add(this.numericUpDownBilinearY);
			this.Controls.Add(this.numericUpDownBilinearX);
			this.Controls.Add(this.buttonExecuteBicubic);
			this.Controls.Add(this.buttonExecuteBilinear);
			this.Controls.Add(this.labelModifiedImage);
			this.Controls.Add(this.pictureBoxModified);
			this.Controls.Add(this.labelOriginalImage);
			this.Controls.Add(this.pictureBoxOriginal);
			this.Controls.Add(this.menuStrip);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MainMenuStrip = this.menuStrip;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainForm";
			this.Text = "Сглаживание изображения";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxModified)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownBilinearX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownBilinearY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownBicubicY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownBicubicX)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxOriginal;
		private System.Windows.Forms.Label labelOriginalImage;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem File_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpenFile;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveAsFile;
		private System.Windows.Forms.Label labelModifiedImage;
		private System.Windows.Forms.PictureBox pictureBoxModified;
		private System.Windows.Forms.Button buttonExecuteBilinear;
		private System.Windows.Forms.Button buttonExecuteBicubic;
		private System.Windows.Forms.NumericUpDown numericUpDownBilinearX;
		private System.Windows.Forms.NumericUpDown numericUpDownBilinearY;
		private System.Windows.Forms.Label labelBilinearX;
		private System.Windows.Forms.Label labelBilinearY;
		private System.Windows.Forms.Label labelBicubicY;
		private System.Windows.Forms.Label labelBicubicX;
		private System.Windows.Forms.NumericUpDown numericUpDownBicubicY;
		private System.Windows.Forms.NumericUpDown numericUpDownBicubicX;
		private System.Windows.Forms.Label labelOriginalSize;
		private System.Windows.Forms.Label labelModifiedSize;
		private System.Windows.Forms.Label labelExecutionTime;
	}
}

