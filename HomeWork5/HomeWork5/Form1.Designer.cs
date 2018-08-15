namespace HomeWork5
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFinalNumber = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btAgain = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumChosed = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btRule = new System.Windows.Forms.Button();
            this.btMoney = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(211, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "雙贏彩投注單";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(735, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "中獎號碼";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFinalNumber
            // 
            this.lblFinalNumber.AutoEllipsis = true;
            this.lblFinalNumber.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblFinalNumber.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFinalNumber.Location = new System.Drawing.Point(737, 116);
            this.lblFinalNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFinalNumber.Name = "lblFinalNumber";
            this.lblFinalNumber.Size = new System.Drawing.Size(216, 497);
            this.lblFinalNumber.TabIndex = 2;
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("標楷體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btStart.Location = new System.Drawing.Point(580, 154);
            this.btStart.Margin = new System.Windows.Forms.Padding(2);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(108, 64);
            this.btStart.TabIndex = 3;
            this.btStart.Text = "開獎";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btAgain
            // 
            this.btAgain.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btAgain.Location = new System.Drawing.Point(580, 241);
            this.btAgain.Margin = new System.Windows.Forms.Padding(2);
            this.btAgain.Name = "btAgain";
            this.btAgain.Size = new System.Drawing.Size(108, 64);
            this.btAgain.TabIndex = 4;
            this.btAgain.Text = "再玩一次";
            this.btAgain.UseVisualStyleBackColor = true;
            this.btAgain.Click += new System.EventHandler(this.btAgain_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Tomato;
            this.label3.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(316, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "投注號碼";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumChosed
            // 
            this.lblNumChosed.BackColor = System.Drawing.Color.Tomato;
            this.lblNumChosed.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNumChosed.Location = new System.Drawing.Point(316, 116);
            this.lblNumChosed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumChosed.Name = "lblNumChosed";
            this.lblNumChosed.Size = new System.Drawing.Size(217, 497);
            this.lblNumChosed.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.SlateBlue;
            this.label14.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(571, 116);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 23);
            this.label14.TabIndex = 18;
            this.label14.Text = "請任選12個號碼";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btRule
            // 
            this.btRule.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btRule.Location = new System.Drawing.Point(580, 333);
            this.btRule.Margin = new System.Windows.Forms.Padding(2);
            this.btRule.Name = "btRule";
            this.btRule.Size = new System.Drawing.Size(108, 64);
            this.btRule.TabIndex = 19;
            this.btRule.Text = "遊戲規則";
            this.btRule.UseVisualStyleBackColor = true;
            this.btRule.Click += new System.EventHandler(this.btRule_Click);
            // 
            // btMoney
            // 
            this.btMoney.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btMoney.Location = new System.Drawing.Point(580, 423);
            this.btMoney.Margin = new System.Windows.Forms.Padding(2);
            this.btMoney.Name = "btMoney";
            this.btMoney.Size = new System.Drawing.Size(108, 64);
            this.btMoney.TabIndex = 20;
            this.btMoney.Text = "獎金";
            this.btMoney.UseVisualStyleBackColor = true;
            this.btMoney.Click += new System.EventHandler(this.btMoney_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(35, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 39);
            this.label4.TabIndex = 21;
            this.label4.Text = "選號區";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1279, 703);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btMoney);
            this.Controls.Add(this.btRule);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblNumChosed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btAgain);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lblFinalNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "雙贏彩投注";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFinalNumber;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btAgain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumChosed;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btRule;
        private System.Windows.Forms.Button btMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

