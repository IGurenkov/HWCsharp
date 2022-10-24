namespace GuessTheNumber
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.butExit = new System.Windows.Forms.Button();
            this.butStartGame = new System.Windows.Forms.Button();
            this.textBoxMyNumber = new System.Windows.Forms.TextBox();
            this.butTry = new System.Windows.Forms.Button();
            this.labelCountTry = new System.Windows.Forms.Label();
            this.labelMoreLess = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "УГАДАЙ ЧИСЛО ОТ 0 ДО 100!";
            // 
            // butExit
            // 
            this.butExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butExit.Location = new System.Drawing.Point(170, 212);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(131, 72);
            this.butExit.TabIndex = 2;
            this.butExit.Text = "ВЫЙТИ";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butStartGame
            // 
            this.butStartGame.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butStartGame.Location = new System.Drawing.Point(360, 212);
            this.butStartGame.Name = "butStartGame";
            this.butStartGame.Size = new System.Drawing.Size(131, 72);
            this.butStartGame.TabIndex = 3;
            this.butStartGame.Text = "ИГРАТЬ";
            this.butStartGame.UseVisualStyleBackColor = true;
            this.butStartGame.Click += new System.EventHandler(this.butPlayRestart_Click);
            // 
            // textBoxMyNumber
            // 
            this.textBoxMyNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxMyNumber.Enabled = false;
            this.textBoxMyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMyNumber.Location = new System.Drawing.Point(256, 81);
            this.textBoxMyNumber.MaxLength = 10;
            this.textBoxMyNumber.Name = "textBoxMyNumber";
            this.textBoxMyNumber.Size = new System.Drawing.Size(147, 26);
            this.textBoxMyNumber.TabIndex = 4;
            this.textBoxMyNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxMyNumber_KeyPress);
            // 
            // butTry
            // 
            this.butTry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butTry.Enabled = false;
            this.butTry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butTry.Location = new System.Drawing.Point(271, 139);
            this.butTry.Name = "butTry";
            this.butTry.Size = new System.Drawing.Size(119, 67);
            this.butTry.TabIndex = 5;
            this.butTry.Text = "ПРОВЕРИТЬ";
            this.butTry.UseVisualStyleBackColor = true;
            this.butTry.Click += new System.EventHandler(this.butTry_Click);
            // 
            // labelCountTry
            // 
            this.labelCountTry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCountTry.AutoSize = true;
            this.labelCountTry.Enabled = false;
            this.labelCountTry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountTry.Location = new System.Drawing.Point(216, 290);
            this.labelCountTry.Name = "labelCountTry";
            this.labelCountTry.Size = new System.Drawing.Size(233, 18);
            this.labelCountTry.TabIndex = 6;
            this.labelCountTry.Text = "КОЛИЧЕСТВО ПОПЫТОК: 0";
            // 
            // labelMoreLess
            // 
            this.labelMoreLess.AutoSize = true;
            this.labelMoreLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoreLess.Location = new System.Drawing.Point(204, 50);
            this.labelMoreLess.Name = "labelMoreLess";
            this.labelMoreLess.Size = new System.Drawing.Size(0, 16);
            this.labelMoreLess.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(274, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ВВЕДИТЕ ЧИСЛО";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 317);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMoreLess);
            this.Controls.Add(this.labelCountTry);
            this.Controls.Add(this.butTry);
            this.Controls.Add(this.textBoxMyNumber);
            this.Controls.Add(this.butStartGame);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1360, 720);
            this.MinimumSize = new System.Drawing.Size(680, 360);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "УГАДАЙ ЧИСЛО";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butStartGame;
        private System.Windows.Forms.TextBox textBoxMyNumber;
        private System.Windows.Forms.Button butTry;
        private System.Windows.Forms.Label labelCountTry;
        private System.Windows.Forms.Label labelMoreLess;
        private System.Windows.Forms.Label label2;
    }
}

