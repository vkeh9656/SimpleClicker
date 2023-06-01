namespace SimpleClicker
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTickPoint = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btn1Add = new System.Windows.Forms.Button();
            this.btn3Add = new System.Windows.Forms.Button();
            this.btn20Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblTickPoint);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "점수";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tick Point :";
            // 
            // lblTickPoint
            // 
            this.lblTickPoint.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblTickPoint.Location = new System.Drawing.Point(81, 11);
            this.lblTickPoint.Name = "lblTickPoint";
            this.lblTickPoint.Size = new System.Drawing.Size(291, 24);
            this.lblTickPoint.TabIndex = 2;
            this.lblTickPoint.Text = "0";
            this.lblTickPoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTotal.Location = new System.Drawing.Point(6, 44);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(366, 53);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn1Add
            // 
            this.btn1Add.Location = new System.Drawing.Point(12, 136);
            this.btn1Add.Name = "btn1Add";
            this.btn1Add.Size = new System.Drawing.Size(188, 23);
            this.btn1Add.TabIndex = 4;
            this.btn1Add.Text = "+1";
            this.btn1Add.UseVisualStyleBackColor = true;
            this.btn1Add.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn3Add
            // 
            this.btn3Add.Location = new System.Drawing.Point(12, 165);
            this.btn3Add.Name = "btn3Add";
            this.btn3Add.Size = new System.Drawing.Size(188, 23);
            this.btn3Add.TabIndex = 3;
            this.btn3Add.Text = "+3";
            this.btn3Add.UseVisualStyleBackColor = true;
            this.btn3Add.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn20Add
            // 
            this.btn20Add.Location = new System.Drawing.Point(12, 194);
            this.btn20Add.Name = "btn20Add";
            this.btn20Add.Size = new System.Drawing.Size(188, 23);
            this.btn20Add.TabIndex = 6;
            this.btn20Add.Text = "+20";
            this.btn20Add.UseVisualStyleBackColor = true;
            this.btn20Add.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "(100)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "(500)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "(5000)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 232);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn20Add);
            this.Controls.Add(this.btn3Add);
            this.Controls.Add(this.btn1Add);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTickPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1Add;
        private System.Windows.Forms.Button btn3Add;
        private System.Windows.Forms.Button btn20Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

