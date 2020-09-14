namespace TankLoader
{
    partial class frm_Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_LoadWeightTank = new System.Windows.Forms.Button();
            this.pictBx_Background = new System.Windows.Forms.PictureBox();
            this.cmbBx_materialType = new System.Windows.Forms.ComboBox();
            this.lbl_materialType = new System.Windows.Forms.Label();
            this.lbl_Volume = new System.Windows.Forms.Label();
            this.lbl_m3 = new System.Windows.Forms.Label();
            this.maskTxtBx_tankVolume = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictBx_Background)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_LoadWeightTank
            // 
            this.btn_LoadWeightTank.Location = new System.Drawing.Point(15, 134);
            this.btn_LoadWeightTank.Name = "btn_LoadWeightTank";
            this.btn_LoadWeightTank.Size = new System.Drawing.Size(192, 23);
            this.btn_LoadWeightTank.TabIndex = 1;
            this.btn_LoadWeightTank.Text = "Загрузка бункера и взвешивание";
            this.btn_LoadWeightTank.UseVisualStyleBackColor = true;
            this.btn_LoadWeightTank.Click += new System.EventHandler(this.btn_LoadWeightTank_Click);
            // 
            // pictBx_Background
            // 
            this.pictBx_Background.BackgroundImage = global::TankLoader.Properties.Resources.Tank;
            this.pictBx_Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictBx_Background.Location = new System.Drawing.Point(325, 11);
            this.pictBx_Background.Name = "pictBx_Background";
            this.pictBx_Background.Size = new System.Drawing.Size(297, 289);
            this.pictBx_Background.TabIndex = 0;
            this.pictBx_Background.TabStop = false;
            // 
            // cmbBx_materialType
            // 
            this.cmbBx_materialType.FormattingEnabled = true;
            this.cmbBx_materialType.Items.AddRange(new object[] {
            "Al2O3",
            "CaC2",
            "CaF2",
            "CaMg"});
            this.cmbBx_materialType.Location = new System.Drawing.Point(15, 96);
            this.cmbBx_materialType.Name = "cmbBx_materialType";
            this.cmbBx_materialType.Size = new System.Drawing.Size(125, 21);
            this.cmbBx_materialType.TabIndex = 2;
            // 
            // lbl_materialType
            // 
            this.lbl_materialType.AutoSize = true;
            this.lbl_materialType.Location = new System.Drawing.Point(12, 69);
            this.lbl_materialType.Name = "lbl_materialType";
            this.lbl_materialType.Size = new System.Drawing.Size(211, 13);
            this.lbl_materialType.TabIndex = 3;
            this.lbl_materialType.Text = "Выберите тип загружаемого материала";
            // 
            // lbl_Volume
            // 
            this.lbl_Volume.AutoSize = true;
            this.lbl_Volume.Location = new System.Drawing.Point(12, 13);
            this.lbl_Volume.Name = "lbl_Volume";
            this.lbl_Volume.Size = new System.Drawing.Size(135, 13);
            this.lbl_Volume.TabIndex = 4;
            this.lbl_Volume.Text = "Введите объем бункеров";
            // 
            // lbl_m3
            // 
            this.lbl_m3.AutoSize = true;
            this.lbl_m3.Location = new System.Drawing.Point(83, 39);
            this.lbl_m3.Name = "lbl_m3";
            this.lbl_m3.Size = new System.Drawing.Size(21, 13);
            this.lbl_m3.TabIndex = 6;
            this.lbl_m3.Text = "m3";
            // 
            // maskTxtBx_tankVolume
            // 
            this.maskTxtBx_tankVolume.Location = new System.Drawing.Point(15, 36);
            this.maskTxtBx_tankVolume.Mask = "000";
            this.maskTxtBx_tankVolume.Name = "maskTxtBx_tankVolume";
            this.maskTxtBx_tankVolume.Size = new System.Drawing.Size(51, 20);
            this.maskTxtBx_tankVolume.TabIndex = 7;
            this.maskTxtBx_tankVolume.ValidatingType = typeof(int);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(634, 312);
            this.Controls.Add(this.maskTxtBx_tankVolume);
            this.Controls.Add(this.lbl_m3);
            this.Controls.Add(this.lbl_Volume);
            this.Controls.Add(this.lbl_materialType);
            this.Controls.Add(this.cmbBx_materialType);
            this.Controls.Add(this.btn_LoadWeightTank);
            this.Controls.Add(this.pictBx_Background);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 350);
            this.Name = "frm_Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление загрузкой бункеров";
            ((System.ComponentModel.ISupportInitialize)(this.pictBx_Background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBx_Background;
        private System.Windows.Forms.Button btn_LoadWeightTank;
        private System.Windows.Forms.ComboBox cmbBx_materialType;
        private System.Windows.Forms.Label lbl_materialType;
        private System.Windows.Forms.Label lbl_Volume;
        private System.Windows.Forms.Label lbl_m3;
        private System.Windows.Forms.MaskedTextBox maskTxtBx_tankVolume;
    }
}

