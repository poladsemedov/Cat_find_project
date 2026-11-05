namespace Pisik_bomba_oyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            q_img_1 = new PictureBox();
            q_img_2 = new PictureBox();
            q_img_3 = new PictureBox();
            q_img_4 = new PictureBox();
            q_img_5 = new PictureBox();
            q_img_6 = new PictureBox();
            xal_lbl = new Label();
            count_lbl = new Label();
            new_game_btn = new Button();
            close_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)q_img_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)q_img_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)q_img_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)q_img_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)q_img_5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)q_img_6).BeginInit();
            SuspendLayout();
            // 
            // q_img_1
            // 
            q_img_1.Image = (Image)resources.GetObject("q_img_1.Image");
            q_img_1.Location = new Point(183, 61);
            q_img_1.Name = "q_img_1";
            q_img_1.Size = new Size(161, 148);
            q_img_1.SizeMode = PictureBoxSizeMode.Zoom;
            q_img_1.TabIndex = 0;
            q_img_1.TabStop = false;
            q_img_1.Click += q_img_1_Click;
            // 
            // q_img_2
            // 
            q_img_2.Image = (Image)resources.GetObject("q_img_2.Image");
            q_img_2.Location = new Point(443, 61);
            q_img_2.Name = "q_img_2";
            q_img_2.Size = new Size(161, 148);
            q_img_2.SizeMode = PictureBoxSizeMode.Zoom;
            q_img_2.TabIndex = 1;
            q_img_2.TabStop = false;
            q_img_2.Click += q_img_2_Click;
            // 
            // q_img_3
            // 
            q_img_3.Image = (Image)resources.GetObject("q_img_3.Image");
            q_img_3.Location = new Point(713, 61);
            q_img_3.Name = "q_img_3";
            q_img_3.Size = new Size(161, 148);
            q_img_3.SizeMode = PictureBoxSizeMode.Zoom;
            q_img_3.TabIndex = 2;
            q_img_3.TabStop = false;
            q_img_3.Click += q_img_3_Click;
            // 
            // q_img_4
            // 
            q_img_4.Image = (Image)resources.GetObject("q_img_4.Image");
            q_img_4.Location = new Point(183, 254);
            q_img_4.Name = "q_img_4";
            q_img_4.Size = new Size(161, 148);
            q_img_4.SizeMode = PictureBoxSizeMode.Zoom;
            q_img_4.TabIndex = 3;
            q_img_4.TabStop = false;
            q_img_4.Click += q_img_4_Click;
            // 
            // q_img_5
            // 
            q_img_5.Image = (Image)resources.GetObject("q_img_5.Image");
            q_img_5.Location = new Point(443, 254);
            q_img_5.Name = "q_img_5";
            q_img_5.Size = new Size(161, 148);
            q_img_5.SizeMode = PictureBoxSizeMode.Zoom;
            q_img_5.TabIndex = 4;
            q_img_5.TabStop = false;
            q_img_5.Click += q_img_5_Click;
            // 
            // q_img_6
            // 
            q_img_6.Image = (Image)resources.GetObject("q_img_6.Image");
            q_img_6.Location = new Point(713, 254);
            q_img_6.Name = "q_img_6";
            q_img_6.Size = new Size(161, 148);
            q_img_6.SizeMode = PictureBoxSizeMode.Zoom;
            q_img_6.TabIndex = 5;
            q_img_6.TabStop = false;
            q_img_6.Click += q_img_6_Click;
            // 
            // xal_lbl
            // 
            xal_lbl.AutoSize = true;
            xal_lbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            xal_lbl.Location = new Point(183, 514);
            xal_lbl.Name = "xal_lbl";
            xal_lbl.Size = new Size(74, 38);
            xal_lbl.TabIndex = 6;
            xal_lbl.Text = "Xal: ";
            // 
            // count_lbl
            // 
            count_lbl.AutoSize = true;
            count_lbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            count_lbl.Location = new Point(253, 514);
            count_lbl.Name = "count_lbl";
            count_lbl.Size = new Size(33, 38);
            count_lbl.TabIndex = 7;
            count_lbl.Text = "0";
            // 
            // new_game_btn
            // 
            new_game_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_game_btn.Location = new Point(478, 514);
            new_game_btn.Name = "new_game_btn";
            new_game_btn.Size = new Size(182, 50);
            new_game_btn.TabIndex = 8;
            new_game_btn.Text = "Yeni oyun";
            new_game_btn.UseVisualStyleBackColor = true;
            new_game_btn.Click += new_game_btn_Click;
            // 
            // close_btn
            // 
            close_btn.BackColor = Color.Brown;
            close_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close_btn.ForeColor = Color.Transparent;
            close_btn.Location = new Point(692, 514);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(182, 50);
            close_btn.TabIndex = 9;
            close_btn.Text = "Cixish";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 665);
            Controls.Add(close_btn);
            Controls.Add(new_game_btn);
            Controls.Add(count_lbl);
            Controls.Add(xal_lbl);
            Controls.Add(q_img_6);
            Controls.Add(q_img_5);
            Controls.Add(q_img_4);
            Controls.Add(q_img_3);
            Controls.Add(q_img_2);
            Controls.Add(q_img_1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)q_img_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)q_img_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)q_img_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)q_img_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)q_img_5).EndInit();
            ((System.ComponentModel.ISupportInitialize)q_img_6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox q_img_1;
        private PictureBox q_img_2;
        private PictureBox q_img_3;
        private PictureBox q_img_4;
        private PictureBox q_img_5;
        private PictureBox q_img_6;
        private Label xal_lbl;
        private Label count_lbl;
        private Button new_game_btn;
        private Button close_btn;
    }
}
