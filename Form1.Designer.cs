namespace SimplePaint
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAppName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.trbLineWidth = new System.Windows.Forms.TrackBar();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.trbImgSize = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbLineWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbImgSize)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("굴림", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAppName.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblAppName.Location = new System.Drawing.Point(12, 2);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(354, 56);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "Simple Paint";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCircle);
            this.groupBox1.Controls.Add(this.btnRectangle);
            this.groupBox1.Controls.Add(this.btnLine);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(6, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "도형선택";
            // 
            // btnCircle
            // 
            this.btnCircle.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCircle.Image = global::SimplePaint.Properties.Resources.KakaoTalk_20260430_100205471_01;
            this.btnCircle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCircle.Location = new System.Drawing.Point(188, 30);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(84, 71);
            this.btnCircle.TabIndex = 5;
            this.btnCircle.Text = "원";
            this.btnCircle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCircle.UseVisualStyleBackColor = true;
            // 
            // btnRectangle
            // 
            this.btnRectangle.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRectangle.Image = global::SimplePaint.Properties.Resources.KakaoTalk_20260430_100205471;
            this.btnRectangle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRectangle.Location = new System.Drawing.Point(97, 29);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(85, 71);
            this.btnRectangle.TabIndex = 4;
            this.btnRectangle.Text = "사각형";
            this.btnRectangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRectangle.UseVisualStyleBackColor = true;
            // 
            // btnLine
            // 
            this.btnLine.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLine.Image = global::SimplePaint.Properties.Resources.KakaoTalk_20260430_100205471_02;
            this.btnLine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLine.Location = new System.Drawing.Point(6, 29);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(85, 71);
            this.btnLine.TabIndex = 1;
            this.btnLine.Text = "직선";
            this.btnLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLine.UseVisualStyleBackColor = true;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Black 검정",
            "Red 빨강",
            "Blue 파랑",
            "Green 녹색"});
            this.cmbColor.Location = new System.Drawing.Point(0, 74);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(151, 24);
            this.cmbColor.TabIndex = 0;
            // 
            // trbLineWidth
            // 
            this.trbLineWidth.Location = new System.Drawing.Point(6, 49);
            this.trbLineWidth.Name = "trbLineWidth";
            this.trbLineWidth.Size = new System.Drawing.Size(162, 45);
            this.trbLineWidth.TabIndex = 1;
            this.trbLineWidth.Scroll += new System.EventHandler(this.trbLineWidth_Scroll);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.Yellow;
            this.btnOpenFile.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOpenFile.Location = new System.Drawing.Point(637, 2);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 46);
            this.btnOpenFile.TabIndex = 6;
            this.btnOpenFile.Text = "열기";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.BackColor = System.Drawing.Color.Cyan;
            this.btnSaveFile.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSaveFile.Location = new System.Drawing.Point(718, 2);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 46);
            this.btnSaveFile.TabIndex = 7;
            this.btnSaveFile.Text = "저장";
            this.btnSaveFile.UseVisualStyleBackColor = false;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(3, 3);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(784, 314);
            this.picCanvas.TabIndex = 3;
            this.picCanvas.TabStop = false;
            this.picCanvas.Click += new System.EventHandler(this.picCanvas_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbColor);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(290, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 101);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "색 선택";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.trbLineWidth);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(453, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "선 두께";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.trbImgSize);
            this.groupBox4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(620, 61);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(173, 100);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "이미지 사이즈";
            // 
            // trbImgSize
            // 
            this.trbImgSize.Location = new System.Drawing.Point(6, 49);
            this.trbImgSize.Name = "trbImgSize";
            this.trbImgSize.Size = new System.Drawing.Size(162, 45);
            this.trbImgSize.TabIndex = 1;
            this.trbImgSize.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.picCanvas);
            this.panel1.Location = new System.Drawing.Point(6, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 320);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAppName);
            this.Name = "Form1";
            this.Text = "Simple Paint v2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trbLineWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbImgSize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.TrackBar trbLineWidth;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar trbImgSize;
        private System.Windows.Forms.Panel panel1;
    }
}

