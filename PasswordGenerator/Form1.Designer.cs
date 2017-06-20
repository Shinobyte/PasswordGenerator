namespace PasswordGenerator
{
    partial class passwordGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(passwordGenerator));
            this.bgw_generatePasswords = new System.ComponentModel.BackgroundWorker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStartAsyncOperation = new System.Windows.Forms.Button();
            this.btn_ClipboardAll = new System.Windows.Forms.Button();
            this.tbx_Length = new System.Windows.Forms.TextBox();
            this.panel_top = new System.Windows.Forms.Panel();
            this.panel_top_right_menu = new System.Windows.Forms.Panel();
            this.lbl_about = new System.Windows.Forms.Label();
            this.lbl_topRightX = new System.Windows.Forms.Label();
            this.lbl_topRightMin = new System.Windows.Forms.Label();
            this.pic_Shinobyte = new System.Windows.Forms.PictureBox();
            this.tbx_Amount = new System.Windows.Forms.TextBox();
            this.checkBox_upperCase = new System.Windows.Forms.CheckBox();
            this.checkBox_digits = new System.Windows.Forms.CheckBox();
            this.checkBox_underLine = new System.Windows.Forms.CheckBox();
            this.checkBox_minus = new System.Windows.Forms.CheckBox();
            this.checkBox_space = new System.Windows.Forms.CheckBox();
            this.tbx_passwordOutput = new System.Windows.Forms.TextBox();
            this.btn_ClipboardSelection = new System.Windows.Forms.Button();
            this.checkBox_special = new System.Windows.Forms.CheckBox();
            this.panel_big_right = new System.Windows.Forms.Panel();
            this.pbr_PlayProgression = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lbl_Length = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.panel_left = new System.Windows.Forms.Panel();
            this.lbl_AppName = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            this.panel_top_right_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Shinobyte)).BeginInit();
            this.panel_big_right.SuspendLayout();
            this.panel_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Azure;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCancel.Location = new System.Drawing.Point(123, 8);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 30);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Stop";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnStartAsyncOperation
            // 
            this.btnStartAsyncOperation.BackColor = System.Drawing.Color.Azure;
            this.btnStartAsyncOperation.FlatAppearance.BorderSize = 0;
            this.btnStartAsyncOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartAsyncOperation.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartAsyncOperation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnStartAsyncOperation.Location = new System.Drawing.Point(23, 8);
            this.btnStartAsyncOperation.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnStartAsyncOperation.Name = "btnStartAsyncOperation";
            this.btnStartAsyncOperation.Size = new System.Drawing.Size(90, 30);
            this.btnStartAsyncOperation.TabIndex = 19;
            this.btnStartAsyncOperation.Text = "Generate";
            this.btnStartAsyncOperation.UseVisualStyleBackColor = false;
            this.btnStartAsyncOperation.Click += new System.EventHandler(this.btnStartAsyncOperation_Click);
            // 
            // btn_ClipboardAll
            // 
            this.btn_ClipboardAll.BackColor = System.Drawing.Color.Azure;
            this.btn_ClipboardAll.FlatAppearance.BorderSize = 0;
            this.btn_ClipboardAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClipboardAll.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClipboardAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_ClipboardAll.Location = new System.Drawing.Point(176, 356);
            this.btn_ClipboardAll.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_ClipboardAll.Name = "btn_ClipboardAll";
            this.btn_ClipboardAll.Size = new System.Drawing.Size(90, 30);
            this.btn_ClipboardAll.TabIndex = 20;
            this.btn_ClipboardAll.Text = "Copy all";
            this.btn_ClipboardAll.UseVisualStyleBackColor = false;
            this.btn_ClipboardAll.Click += new System.EventHandler(this.btn_ClipboardAll_Click);
            // 
            // tbx_Length
            // 
            this.tbx_Length.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.tbx_Length.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Length.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tbx_Length.Location = new System.Drawing.Point(370, 83);
            this.tbx_Length.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbx_Length.Name = "tbx_Length";
            this.tbx_Length.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_Length.Size = new System.Drawing.Size(54, 32);
            this.tbx_Length.TabIndex = 24;
            this.tbx_Length.Text = "0";
            this.tbx_Length.Click += new System.EventHandler(this.tbx_Length_Click);
            this.tbx_Length.TextChanged += new System.EventHandler(this.tbx_Length_TextChanged);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Azure;
            this.panel_top.Controls.Add(this.lbl_AppName);
            this.panel_top.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.panel_top.Enabled = false;
            this.panel_top.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(785, 67);
            this.panel_top.TabIndex = 27;
            // 
            // panel_top_right_menu
            // 
            this.panel_top_right_menu.BackColor = System.Drawing.Color.Azure;
            this.panel_top_right_menu.Controls.Add(this.lbl_about);
            this.panel_top_right_menu.Controls.Add(this.lbl_topRightX);
            this.panel_top_right_menu.Controls.Add(this.lbl_topRightMin);
            this.panel_top_right_menu.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_top_right_menu.Location = new System.Drawing.Point(784, 0);
            this.panel_top_right_menu.Margin = new System.Windows.Forms.Padding(0);
            this.panel_top_right_menu.Name = "panel_top_right_menu";
            this.panel_top_right_menu.Size = new System.Drawing.Size(134, 67);
            this.panel_top_right_menu.TabIndex = 32;
            // 
            // lbl_about
            // 
            this.lbl_about.BackColor = System.Drawing.Color.Transparent;
            this.lbl_about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_about.Font = new System.Drawing.Font("Consolas", 18F);
            this.lbl_about.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_about.Image = ((System.Drawing.Image)(resources.GetObject("lbl_about.Image")));
            this.lbl_about.Location = new System.Drawing.Point(15, 16);
            this.lbl_about.Name = "lbl_about";
            this.lbl_about.Size = new System.Drawing.Size(25, 28);
            this.lbl_about.TabIndex = 45;
            this.lbl_about.Text = " ";
            this.lbl_about.Click += new System.EventHandler(this.lbl_about_Click);
            // 
            // lbl_topRightX
            // 
            this.lbl_topRightX.AutoSize = true;
            this.lbl_topRightX.BackColor = System.Drawing.Color.Azure;
            this.lbl_topRightX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_topRightX.Font = new System.Drawing.Font("Consolas", 18F);
            this.lbl_topRightX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_topRightX.Image = global::PasswordGenerator.Properties.Resources.close;
            this.lbl_topRightX.Location = new System.Drawing.Point(97, 16);
            this.lbl_topRightX.Name = "lbl_topRightX";
            this.lbl_topRightX.Size = new System.Drawing.Size(25, 28);
            this.lbl_topRightX.TabIndex = 0;
            this.lbl_topRightX.Text = " ";
            this.lbl_topRightX.Click += new System.EventHandler(this.lbl_topRightX_Click);
            // 
            // lbl_topRightMin
            // 
            this.lbl_topRightMin.AutoSize = true;
            this.lbl_topRightMin.BackColor = System.Drawing.Color.Azure;
            this.lbl_topRightMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_topRightMin.Font = new System.Drawing.Font("Consolas", 18F);
            this.lbl_topRightMin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_topRightMin.Image = global::PasswordGenerator.Properties.Resources.download;
            this.lbl_topRightMin.Location = new System.Drawing.Point(56, 16);
            this.lbl_topRightMin.Name = "lbl_topRightMin";
            this.lbl_topRightMin.Size = new System.Drawing.Size(25, 28);
            this.lbl_topRightMin.TabIndex = 41;
            this.lbl_topRightMin.Text = " ";
            this.lbl_topRightMin.Click += new System.EventHandler(this.lbl_topRightMin_Click);
            // 
            // pic_Shinobyte
            // 
            this.pic_Shinobyte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Shinobyte.Image = global::PasswordGenerator.Properties.Resources.Shinobyte_small1;
            this.pic_Shinobyte.Location = new System.Drawing.Point(342, 349);
            this.pic_Shinobyte.Name = "pic_Shinobyte";
            this.pic_Shinobyte.Size = new System.Drawing.Size(213, 42);
            this.pic_Shinobyte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Shinobyte.TabIndex = 33;
            this.pic_Shinobyte.TabStop = false;
            this.pic_Shinobyte.Click += new System.EventHandler(this.pic_Shinobyte_Click);
            // 
            // tbx_Amount
            // 
            this.tbx_Amount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.tbx_Amount.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tbx_Amount.Location = new System.Drawing.Point(370, 134);
            this.tbx_Amount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbx_Amount.Name = "tbx_Amount";
            this.tbx_Amount.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_Amount.Size = new System.Drawing.Size(54, 32);
            this.tbx_Amount.TabIndex = 32;
            this.tbx_Amount.Text = "0";
            this.tbx_Amount.Click += new System.EventHandler(this.tbx_Amount_Click);
            this.tbx_Amount.TextChanged += new System.EventHandler(this.tbx_Amount_TextChanged);
            // 
            // checkBox_upperCase
            // 
            this.checkBox_upperCase.AutoSize = true;
            this.checkBox_upperCase.FlatAppearance.BorderSize = 0;
            this.checkBox_upperCase.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_upperCase.ForeColor = System.Drawing.Color.Silver;
            this.checkBox_upperCase.Location = new System.Drawing.Point(502, 79);
            this.checkBox_upperCase.Name = "checkBox_upperCase";
            this.checkBox_upperCase.Size = new System.Drawing.Size(208, 24);
            this.checkBox_upperCase.TabIndex = 33;
            this.checkBox_upperCase.Text = "Upper-case (A, B...)";
            this.checkBox_upperCase.UseVisualStyleBackColor = true;
            this.checkBox_upperCase.CheckedChanged += new System.EventHandler(this.checkBox_upperCase_CheckedChanged);
            // 
            // checkBox_digits
            // 
            this.checkBox_digits.AutoSize = true;
            this.checkBox_digits.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_digits.ForeColor = System.Drawing.Color.Silver;
            this.checkBox_digits.Location = new System.Drawing.Point(502, 109);
            this.checkBox_digits.Name = "checkBox_digits";
            this.checkBox_digits.Size = new System.Drawing.Size(172, 24);
            this.checkBox_digits.TabIndex = 35;
            this.checkBox_digits.Text = "Digits (0, 1...)";
            this.checkBox_digits.UseVisualStyleBackColor = true;
            this.checkBox_digits.CheckedChanged += new System.EventHandler(this.checkBox_digits_CheckedChanged);
            // 
            // checkBox_underLine
            // 
            this.checkBox_underLine.AutoSize = true;
            this.checkBox_underLine.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_underLine.ForeColor = System.Drawing.Color.Silver;
            this.checkBox_underLine.Location = new System.Drawing.Point(712, 109);
            this.checkBox_underLine.Name = "checkBox_underLine";
            this.checkBox_underLine.Size = new System.Drawing.Size(145, 24);
            this.checkBox_underLine.TabIndex = 36;
            this.checkBox_underLine.Text = "Underline (_)";
            this.checkBox_underLine.UseVisualStyleBackColor = true;
            this.checkBox_underLine.CheckedChanged += new System.EventHandler(this.checkBox_underLine_CheckedChanged);
            // 
            // checkBox_minus
            // 
            this.checkBox_minus.AutoSize = true;
            this.checkBox_minus.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_minus.ForeColor = System.Drawing.Color.Silver;
            this.checkBox_minus.Location = new System.Drawing.Point(712, 79);
            this.checkBox_minus.Name = "checkBox_minus";
            this.checkBox_minus.Size = new System.Drawing.Size(109, 24);
            this.checkBox_minus.TabIndex = 37;
            this.checkBox_minus.Text = "Minus (-)";
            this.checkBox_minus.UseVisualStyleBackColor = true;
            this.checkBox_minus.CheckedChanged += new System.EventHandler(this.checkBox_minus_CheckedChanged);
            // 
            // checkBox_space
            // 
            this.checkBox_space.AutoSize = true;
            this.checkBox_space.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_space.ForeColor = System.Drawing.Color.Silver;
            this.checkBox_space.Location = new System.Drawing.Point(503, 139);
            this.checkBox_space.Name = "checkBox_space";
            this.checkBox_space.Size = new System.Drawing.Size(100, 24);
            this.checkBox_space.TabIndex = 38;
            this.checkBox_space.Text = "Space( )";
            this.checkBox_space.UseVisualStyleBackColor = true;
            this.checkBox_space.CheckedChanged += new System.EventHandler(this.checkBox_space_CheckedChanged);
            // 
            // tbx_passwordOutput
            // 
            this.tbx_passwordOutput.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_passwordOutput.ForeColor = System.Drawing.Color.DimGray;
            this.tbx_passwordOutput.Location = new System.Drawing.Point(370, 225);
            this.tbx_passwordOutput.Multiline = true;
            this.tbx_passwordOutput.Name = "tbx_passwordOutput";
            this.tbx_passwordOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_passwordOutput.Size = new System.Drawing.Size(532, 294);
            this.tbx_passwordOutput.TabIndex = 40;
            this.tbx_passwordOutput.WordWrap = false;
            // 
            // btn_ClipboardSelection
            // 
            this.btn_ClipboardSelection.BackColor = System.Drawing.Color.Azure;
            this.btn_ClipboardSelection.FlatAppearance.BorderSize = 0;
            this.btn_ClipboardSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClipboardSelection.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClipboardSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_ClipboardSelection.Location = new System.Drawing.Point(370, 536);
            this.btn_ClipboardSelection.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_ClipboardSelection.Name = "btn_ClipboardSelection";
            this.btn_ClipboardSelection.Size = new System.Drawing.Size(143, 30);
            this.btn_ClipboardSelection.TabIndex = 43;
            this.btn_ClipboardSelection.Text = "Copy selection";
            this.btn_ClipboardSelection.UseVisualStyleBackColor = false;
            this.btn_ClipboardSelection.Click += new System.EventHandler(this.btn_ClipboardSelection_Click);
            // 
            // checkBox_special
            // 
            this.checkBox_special.AutoSize = true;
            this.checkBox_special.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_special.ForeColor = System.Drawing.Color.Silver;
            this.checkBox_special.Location = new System.Drawing.Point(712, 137);
            this.checkBox_special.Name = "checkBox_special";
            this.checkBox_special.Size = new System.Drawing.Size(190, 24);
            this.checkBox_special.TabIndex = 44;
            this.checkBox_special.Text = "Special (!, @ ...)";
            this.checkBox_special.UseVisualStyleBackColor = true;
            this.checkBox_special.CheckedChanged += new System.EventHandler(this.checkBox_special_CheckedChanged);
            // 
            // panel_big_right
            // 
            this.panel_big_right.BackColor = System.Drawing.Color.Azure;
            this.panel_big_right.Controls.Add(this.pic_Shinobyte);
            this.panel_big_right.Controls.Add(this.btnCancel);
            this.panel_big_right.Controls.Add(this.btn_ClipboardAll);
            this.panel_big_right.Controls.Add(this.btnStartAsyncOperation);
            this.panel_big_right.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel_big_right.Location = new System.Drawing.Point(347, 180);
            this.panel_big_right.Margin = new System.Windows.Forms.Padding(0);
            this.panel_big_right.Name = "panel_big_right";
            this.panel_big_right.Size = new System.Drawing.Size(571, 403);
            this.panel_big_right.TabIndex = 46;
            // 
            // pbr_PlayProgression
            // 
            this.pbr_PlayProgression.Location = new System.Drawing.Point(6, 546);
            this.pbr_PlayProgression.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbr_PlayProgression.Name = "pbr_PlayProgression";
            this.pbr_PlayProgression.Size = new System.Drawing.Size(337, 20);
            this.pbr_PlayProgression.Step = 5;
            this.pbr_PlayProgression.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbr_PlayProgression.TabIndex = 23;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStatus.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Azure;
            this.lblStatus.Location = new System.Drawing.Point(11, 513);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(332, 30);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_Length
            // 
            this.lbl_Length.AutoSize = true;
            this.lbl_Length.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.lbl_Length.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_Length.Location = new System.Drawing.Point(15, 88);
            this.lbl_Length.Name = "lbl_Length";
            this.lbl_Length.Size = new System.Drawing.Size(300, 22);
            this.lbl_Length.TabIndex = 30;
            this.lbl_Length.Text = "Length of generated password:";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.lbl_Amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_Amount.Location = new System.Drawing.Point(12, 139);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(330, 22);
            this.lbl_Amount.TabIndex = 31;
            this.lbl_Amount.Text = "Amount of passwords to generate:";
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_left.Controls.Add(this.lbl_Amount);
            this.panel_left.Controls.Add(this.lbl_Length);
            this.panel_left.Controls.Add(this.lblStatus);
            this.panel_left.Controls.Add(this.pbr_PlayProgression);
            this.panel_left.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Enabled = false;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(350, 583);
            this.panel_left.TabIndex = 29;
            // 
            // lbl_AppName
            // 
            this.lbl_AppName.Image = ((System.Drawing.Image)(resources.GetObject("lbl_AppName.Image")));
            this.lbl_AppName.Location = new System.Drawing.Point(-25, 6);
            this.lbl_AppName.Name = "lbl_AppName";
            this.lbl_AppName.Size = new System.Drawing.Size(509, 58);
            this.lbl_AppName.TabIndex = 0;
            // 
            // passwordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(918, 583);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.panel_top_right_menu);
            this.Controls.Add(this.checkBox_special);
            this.Controls.Add(this.btn_ClipboardSelection);
            this.Controls.Add(this.tbx_passwordOutput);
            this.Controls.Add(this.checkBox_space);
            this.Controls.Add(this.checkBox_minus);
            this.Controls.Add(this.checkBox_underLine);
            this.Controls.Add(this.checkBox_digits);
            this.Controls.Add(this.checkBox_upperCase);
            this.Controls.Add(this.tbx_Amount);
            this.Controls.Add(this.tbx_Length);
            this.Controls.Add(this.panel_big_right);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "passwordGenerator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Password Generator";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.passwordGenerator_MouseDown);
            this.panel_top.ResumeLayout(false);
            this.panel_top_right_menu.ResumeLayout(false);
            this.panel_top_right_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Shinobyte)).EndInit();
            this.panel_big_right.ResumeLayout(false);
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgw_generatePasswords;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnStartAsyncOperation;
        private System.Windows.Forms.Button btn_ClipboardAll;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label lbl_topRightX;
        private System.Windows.Forms.TextBox tbx_Amount;
        private System.Windows.Forms.CheckBox checkBox_upperCase;
        private System.Windows.Forms.CheckBox checkBox_digits;
        private System.Windows.Forms.CheckBox checkBox_underLine;
        private System.Windows.Forms.CheckBox checkBox_minus;
        private System.Windows.Forms.CheckBox checkBox_space;
        private System.Windows.Forms.TextBox tbx_Length;
        private System.Windows.Forms.TextBox tbx_passwordOutput;
        private System.Windows.Forms.PictureBox pic_Shinobyte;
        private System.Windows.Forms.Label lbl_topRightMin;
        private System.Windows.Forms.Button btn_ClipboardSelection;
        private System.Windows.Forms.CheckBox checkBox_special;
        private System.Windows.Forms.Label lbl_about;
        private System.Windows.Forms.Panel panel_big_right;
        private System.Windows.Forms.Panel panel_top_right_menu;
        public System.Windows.Forms.ProgressBar pbr_PlayProgression;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lbl_Length;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Label lbl_AppName;
    }
}

