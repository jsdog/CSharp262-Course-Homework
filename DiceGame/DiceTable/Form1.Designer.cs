namespace DiceTable
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DiceBox1 = new System.Windows.Forms.PictureBox();
            this.DiceBox2 = new System.Windows.Forms.PictureBox();
            this.DiceBox3 = new System.Windows.Forms.PictureBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.Sum = new System.Windows.Forms.Label();
            this.Throw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DiceBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // DiceBox1
            // 
            this.DiceBox1.Image = global::DiceTable.Properties.Resources._1;
            this.DiceBox1.Location = new System.Drawing.Point(33, 62);
            this.DiceBox1.Name = "DiceBox1";
            this.DiceBox1.Size = new System.Drawing.Size(125, 125);
            this.DiceBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DiceBox1.TabIndex = 0;
            this.DiceBox1.TabStop = false;
            // 
            // DiceBox2
            // 
            this.DiceBox2.Image = global::DiceTable.Properties.Resources._3;
            this.DiceBox2.Location = new System.Drawing.Point(278, 62);
            this.DiceBox2.Name = "DiceBox2";
            this.DiceBox2.Size = new System.Drawing.Size(125, 125);
            this.DiceBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DiceBox2.TabIndex = 1;
            this.DiceBox2.TabStop = false;
            // 
            // DiceBox3
            // 
            this.DiceBox3.Image = global::DiceTable.Properties.Resources._5;
            this.DiceBox3.Location = new System.Drawing.Point(548, 62);
            this.DiceBox3.Name = "DiceBox3";
            this.DiceBox3.Size = new System.Drawing.Size(125, 125);
            this.DiceBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DiceBox3.TabIndex = 2;
            this.DiceBox3.TabStop = false;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(88, 328);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(178, 22);
            this.Total.TabIndex = 3;
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Location = new System.Drawing.Point(38, 331);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(44, 12);
            this.Sum.TabIndex = 4;
            this.Sum.Text = "總點數:";
            // 
            // Throw
            // 
            this.Throw.Location = new System.Drawing.Point(480, 423);
            this.Throw.Name = "Throw";
            this.Throw.Size = new System.Drawing.Size(193, 69);
            this.Throw.TabIndex = 5;
            this.Throw.Text = "擲骰子";
            this.Throw.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 543);
            this.Controls.Add(this.Throw);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.DiceBox3);
            this.Controls.Add(this.DiceBox2);
            this.Controls.Add(this.DiceBox1);
            this.Name = "Form1";
            this.Text = "擲骰子";
            ((System.ComponentModel.ISupportInitialize)(this.DiceBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiceBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DiceBox1;
        private System.Windows.Forms.PictureBox DiceBox2;
        private System.Windows.Forms.PictureBox DiceBox3;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.Button Throw;
    }
}

