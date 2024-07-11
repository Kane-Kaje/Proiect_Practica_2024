namespace ImageEditor
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FinalImage = new System.Windows.Forms.Label();
            this.btn_center = new System.Windows.Forms.Button();
            this.btn_stretch = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_rotate = new System.Windows.Forms.Button();
            this.btn_reload = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.txt_width = new System.Windows.Forms.TextBox();
            this.txt_imgpath = new System.Windows.Forms.TextBox();
            this.lbl_size = new System.Windows.Forms.Label();
            this.trk_bright = new System.Windows.Forms.TrackBar();
            this.trk_contrast = new System.Windows.Forms.TrackBar();
            this.trk_hue = new System.Windows.Forms.TrackBar();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_resize = new System.Windows.Forms.Button();
            this.txt_text = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trk_bright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_hue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 497);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(844, 491);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.FinalImage);
            this.panel2.Controls.Add(this.btn_rotate);
            this.panel2.Controls.Add(this.btn_center);
            this.panel2.Controls.Add(this.btn_stretch);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lbl_size);
            this.panel2.Location = new System.Drawing.Point(868, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 497);
            this.panel2.TabIndex = 1;
            // 
            // FinalImage
            // 
            this.FinalImage.AutoSize = true;
            this.FinalImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FinalImage.Location = new System.Drawing.Point(96, 228);
            this.FinalImage.Name = "FinalImage";
            this.FinalImage.Size = new System.Drawing.Size(73, 13);
            this.FinalImage.TabIndex = 14;
            this.FinalImage.Text = "Original image";
            // 
            // btn_center
            // 
            this.btn_center.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_center.Location = new System.Drawing.Point(12, 331);
            this.btn_center.Name = "btn_center";
            this.btn_center.Size = new System.Drawing.Size(250, 50);
            this.btn_center.TabIndex = 4;
            this.btn_center.Text = "Center";
            this.btn_center.UseVisualStyleBackColor = true;
            this.btn_center.Click += new System.EventHandler(this.btn_center_Click);
            // 
            // btn_stretch
            // 
            this.btn_stretch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stretch.Location = new System.Drawing.Point(12, 275);
            this.btn_stretch.Name = "btn_stretch";
            this.btn_stretch.Size = new System.Drawing.Size(250, 50);
            this.btn_stretch.TabIndex = 2;
            this.btn_stretch.Text = "Stretch";
            this.btn_stretch.UseVisualStyleBackColor = true;
            this.btn_stretch.Click += new System.EventHandler(this.btn_stretch_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(268, 222);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.add_btn);
            this.panel3.Controls.Add(this.txt_text);
            this.panel3.Controls.Add(this.btn_reload);
            this.panel3.Controls.Add(this.btn_save);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_height);
            this.panel3.Controls.Add(this.txt_width);
            this.panel3.Controls.Add(this.txt_imgpath);
            this.panel3.Controls.Add(this.trk_bright);
            this.panel3.Controls.Add(this.trk_contrast);
            this.panel3.Controls.Add(this.trk_hue);
            this.panel3.Controls.Add(this.btn_open);
            this.panel3.Controls.Add(this.btn_resize);
            this.panel3.Location = new System.Drawing.Point(12, 515);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1130, 161);
            this.panel3.TabIndex = 2;
            // 
            // btn_rotate
            // 
            this.btn_rotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rotate.Location = new System.Drawing.Point(12, 387);
            this.btn_rotate.Name = "btn_rotate";
            this.btn_rotate.Size = new System.Drawing.Size(250, 50);
            this.btn_rotate.TabIndex = 26;
            this.btn_rotate.Text = "Rotate";
            this.btn_rotate.UseVisualStyleBackColor = true;
            this.btn_rotate.Click += new System.EventHandler(this.btn_rotate_Click);
            // 
            // btn_reload
            // 
            this.btn_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reload.Location = new System.Drawing.Point(619, 64);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(166, 30);
            this.btn_reload.TabIndex = 25;
            this.btn_reload.Text = "Reset";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(619, 18);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(166, 30);
            this.btn_save.TabIndex = 24;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(340, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Brightness";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(194, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Contrast";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(59, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Hue";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(309, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(95, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Width";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_height
            // 
            this.txt_height.Location = new System.Drawing.Point(236, 71);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(205, 20);
            this.txt_height.TabIndex = 18;
            // 
            // txt_width
            // 
            this.txt_width.Location = new System.Drawing.Point(3, 71);
            this.txt_width.Name = "txt_width";
            this.txt_width.Size = new System.Drawing.Size(216, 20);
            this.txt_width.TabIndex = 17;
            this.txt_width.TextChanged += new System.EventHandler(this.txt_width_TextChanged);
            // 
            // txt_imgpath
            // 
            this.txt_imgpath.Location = new System.Drawing.Point(3, 18);
            this.txt_imgpath.Name = "txt_imgpath";
            this.txt_imgpath.Size = new System.Drawing.Size(438, 20);
            this.txt_imgpath.TabIndex = 16;
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_size.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_size.Location = new System.Drawing.Point(32, 252);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(89, 20);
            this.lbl_size.TabIndex = 15;
            this.lbl_size.Text = "Image Size";
            this.lbl_size.Click += new System.EventHandler(this.lbl_size_Click);
            // 
            // trk_bright
            // 
            this.trk_bright.Location = new System.Drawing.Point(299, 108);
            this.trk_bright.Name = "trk_bright";
            this.trk_bright.Size = new System.Drawing.Size(142, 45);
            this.trk_bright.TabIndex = 13;
            this.trk_bright.Scroll += new System.EventHandler(this.trk_bright_Scroll);
            this.trk_bright.ValueChanged += new System.EventHandler(this.trk_bright_ValueChanged);
            // 
            // trk_contrast
            // 
            this.trk_contrast.Location = new System.Drawing.Point(151, 108);
            this.trk_contrast.Name = "trk_contrast";
            this.trk_contrast.Size = new System.Drawing.Size(142, 45);
            this.trk_contrast.TabIndex = 12;
            this.trk_contrast.ValueChanged += new System.EventHandler(this.trk_contrast_ValueChanged);
            // 
            // trk_hue
            // 
            this.trk_hue.Location = new System.Drawing.Point(3, 108);
            this.trk_hue.Name = "trk_hue";
            this.trk_hue.Size = new System.Drawing.Size(142, 45);
            this.trk_hue.TabIndex = 11;
            this.trk_hue.ValueChanged += new System.EventHandler(this.trk_hue_ValueChanged);
            // 
            // btn_open
            // 
            this.btn_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open.Location = new System.Drawing.Point(447, 18);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(166, 30);
            this.btn_open.TabIndex = 6;
            this.btn_open.Text = "Select Image";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click_1);
            // 
            // btn_resize
            // 
            this.btn_resize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resize.Location = new System.Drawing.Point(447, 64);
            this.btn_resize.Name = "btn_resize";
            this.btn_resize.Size = new System.Drawing.Size(166, 30);
            this.btn_resize.TabIndex = 5;
            this.btn_resize.Text = "Set";
            this.btn_resize.UseVisualStyleBackColor = true;
            this.btn_resize.Click += new System.EventHandler(this.btn_resize_Click);
            // 
            // txt_text
            // 
            this.txt_text.Location = new System.Drawing.Point(868, 74);
            this.txt_text.Name = "txt_text";
            this.txt_text.Size = new System.Drawing.Size(250, 20);
            this.txt_text.TabIndex = 27;
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(868, 18);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(250, 50);
            this.add_btn.TabIndex = 28;
            this.add_btn.Text = "Add Text";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 688);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trk_bright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_hue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_center;
        private System.Windows.Forms.Button btn_stretch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_resize;
        private System.Windows.Forms.TrackBar trk_bright;
        private System.Windows.Forms.TrackBar trk_contrast;
        private System.Windows.Forms.TrackBar trk_hue;
        private System.Windows.Forms.Label FinalImage;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.TextBox txt_width;
        private System.Windows.Forms.TextBox txt_imgpath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_rotate;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox txt_text;
    }
}

