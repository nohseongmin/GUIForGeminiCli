namespace GFG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메뉴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mCP서버추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.불편접수ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.색상설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글자크기설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기타설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.제작자정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.툴정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.tbxQuest = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴ToolStripMenuItem,
            this.설정ToolStripMenuItem,
            this.정보ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(572, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메뉴ToolStripMenuItem
            // 
            this.메뉴ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCP서버추가ToolStripMenuItem,
            this.불편접수ToolStripMenuItem});
            this.메뉴ToolStripMenuItem.Name = "메뉴ToolStripMenuItem";
            this.메뉴ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.메뉴ToolStripMenuItem.Text = "메뉴";
            // 
            // mCP서버추가ToolStripMenuItem
            // 
            this.mCP서버추가ToolStripMenuItem.Name = "mCP서버추가ToolStripMenuItem";
            this.mCP서버추가ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.mCP서버추가ToolStripMenuItem.Text = "MCP 서버 추가";
            // 
            // 불편접수ToolStripMenuItem
            // 
            this.불편접수ToolStripMenuItem.Name = "불편접수ToolStripMenuItem";
            this.불편접수ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.불편접수ToolStripMenuItem.Text = "불편 접수";
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.색상설정ToolStripMenuItem,
            this.글자크기설정ToolStripMenuItem,
            this.기타설정ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // 색상설정ToolStripMenuItem
            // 
            this.색상설정ToolStripMenuItem.Name = "색상설정ToolStripMenuItem";
            this.색상설정ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.색상설정ToolStripMenuItem.Text = "색상 설정";
            // 
            // 글자크기설정ToolStripMenuItem
            // 
            this.글자크기설정ToolStripMenuItem.Name = "글자크기설정ToolStripMenuItem";
            this.글자크기설정ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.글자크기설정ToolStripMenuItem.Text = "글자 크기 설정";
            // 
            // 기타설정ToolStripMenuItem
            // 
            this.기타설정ToolStripMenuItem.Name = "기타설정ToolStripMenuItem";
            this.기타설정ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.기타설정ToolStripMenuItem.Text = "기타 설정";
            // 
            // 정보ToolStripMenuItem
            // 
            this.정보ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.제작자정보ToolStripMenuItem,
            this.툴정보ToolStripMenuItem});
            this.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem";
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.정보ToolStripMenuItem.Text = "정보";
            // 
            // 제작자정보ToolStripMenuItem
            // 
            this.제작자정보ToolStripMenuItem.Name = "제작자정보ToolStripMenuItem";
            this.제작자정보ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.제작자정보ToolStripMenuItem.Text = "제작자 정보";
            // 
            // 툴정보ToolStripMenuItem
            // 
            this.툴정보ToolStripMenuItem.Name = "툴정보ToolStripMenuItem";
            this.툴정보ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.툴정보ToolStripMenuItem.Text = "툴 정보";
            // 
            // lblAnswer
            // 
            this.lblAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer.BackColor = System.Drawing.Color.Black;
            this.lblAnswer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAnswer.Location = new System.Drawing.Point(12, 24);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(548, 321);
            this.lblAnswer.TabIndex = 1;
            // 
            // tbxQuest
            // 
            this.tbxQuest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxQuest.Location = new System.Drawing.Point(17, 356);
            this.tbxQuest.Multiline = true;
            this.tbxQuest.Name = "tbxQuest";
            this.tbxQuest.Size = new System.Drawing.Size(542, 22);
            this.tbxQuest.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 387);
            this.Controls.Add(this.tbxQuest);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gemini";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메뉴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mCP서버추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 불편접수ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 색상설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 글자크기설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기타설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 제작자정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 툴정보ToolStripMenuItem;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox tbxQuest;
    }
}

