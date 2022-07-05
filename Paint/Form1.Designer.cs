namespace Paint
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pic_color = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.Desktop;
            this.pnlTop.Controls.Add(this.btn_line);
            this.pnlTop.Controls.Add(this.btn_rect);
            this.pnlTop.Controls.Add(this.btn_ellipse);
            this.pnlTop.Controls.Add(this.btn_eraser);
            this.pnlTop.Controls.Add(this.btn_pencil);
            this.pnlTop.Controls.Add(this.btn_fill);
            this.pnlTop.Controls.Add(this.btn_color);
            this.pnlTop.Controls.Add(this.pic_color);
            this.pnlTop.Controls.Add(this.panel1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(864, 100);
            this.pnlTop.TabIndex = 2;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.Desktop;
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 478);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(864, 33);
            this.pnlBottom.TabIndex = 3;
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.Location = new System.Drawing.Point(126, 33);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(52, 37);
            this.pic_color.TabIndex = 0;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(184, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 82);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Paint.Properties.Resources.color_palette;
            this.pictureBox1.Location = new System.Drawing.Point(35, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 135);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 100);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(864, 378);
            this.pic.TabIndex = 4;
            this.pic.TabStop = false;
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.Color.White;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.ForeColor = System.Drawing.Color.Black;
            this.btn_line.Image = global::Paint.Properties.Resources.Icons8_Windows_8_Editing_Line;
            this.btn_line.Location = new System.Drawing.Point(768, 16);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(90, 70);
            this.btn_line.TabIndex = 7;
            this.btn_line.Text = "Line";
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.UseVisualStyleBackColor = false;
            // 
            // btn_rect
            // 
            this.btn_rect.BackColor = System.Drawing.Color.White;
            this.btn_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.ForeColor = System.Drawing.Color.Black;
            this.btn_rect.Image = global::Paint.Properties.Resources.Icons8_Ios7_Editing_Rectangle;
            this.btn_rect.Location = new System.Drawing.Point(672, 16);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(90, 70);
            this.btn_rect.TabIndex = 6;
            this.btn_rect.Text = "Rectangle";
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rect.UseVisualStyleBackColor = false;
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.BackColor = System.Drawing.Color.White;
            this.btn_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ellipse.ForeColor = System.Drawing.Color.Black;
            this.btn_ellipse.Image = global::Paint.Properties.Resources.Icons8_Windows_8_Editing_Ellipse_Stroked;
            this.btn_ellipse.Location = new System.Drawing.Point(576, 16);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(90, 70);
            this.btn_ellipse.TabIndex = 5;
            this.btn_ellipse.Text = "Ellipse";
            this.btn_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ellipse.UseVisualStyleBackColor = false;
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackColor = System.Drawing.Color.White;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.ForeColor = System.Drawing.Color.Black;
            this.btn_eraser.Image = global::Paint.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_draw_eraser;
            this.btn_eraser.Location = new System.Drawing.Point(480, 16);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(90, 70);
            this.btn_eraser.TabIndex = 4;
            this.btn_eraser.Text = "Eraser";
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = false;
            // 
            // btn_pencil
            // 
            this.btn_pencil.BackColor = System.Drawing.Color.White;
            this.btn_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.ForeColor = System.Drawing.Color.Black;
            this.btn_pencil.Image = global::Paint.Properties.Resources.Awicons_Vista_Artistic_Edit;
            this.btn_pencil.Location = new System.Drawing.Point(384, 16);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(90, 70);
            this.btn_pencil.TabIndex = 3;
            this.btn_pencil.Text = "Pencil";
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.UseVisualStyleBackColor = false;
            // 
            // btn_fill
            // 
            this.btn_fill.BackColor = System.Drawing.Color.White;
            this.btn_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.ForeColor = System.Drawing.Color.Black;
            this.btn_fill.Image = global::Paint.Properties.Resources.Chrisl21_Minecraft_Bucket_Lava;
            this.btn_fill.Location = new System.Drawing.Point(288, 16);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(90, 70);
            this.btn_fill.TabIndex = 2;
            this.btn_fill.Text = "Fill";
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fill.UseVisualStyleBackColor = false;
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.White;
            this.btn_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.ForeColor = System.Drawing.Color.Black;
            this.btn_color.Image = global::Paint.Properties.Resources.Wwalczyszyn_Iwindows_Paint;
            this.btn_color.Location = new System.Drawing.Point(192, 16);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(90, 70);
            this.btn_color.TabIndex = 1;
            this.btn_color.Text = "Color";
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(864, 511);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Paint Application by Ivan Suralta BSCpE 1-G";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

