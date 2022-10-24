namespace CsharpHomework006_Doubler
{
    partial class Doubler
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doubler));
            this.NewGame = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.LabelComputerNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelUserNumber = new System.Windows.Forms.Label();
            this.CommandSumm1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.File1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.startGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.rulsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cancel = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewGame
            // 
            this.NewGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewGame.Location = new System.Drawing.Point(19, 238);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(120, 75);
            this.NewGame.TabIndex = 0;
            this.NewGame.Text = "НОВАЯ ИГРА";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Plus
            // 
            this.Plus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plus.Location = new System.Drawing.Point(160, 238);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(120, 75);
            this.Plus.TabIndex = 1;
            this.Plus.Text = "+1";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Multiply
            // 
            this.Multiply.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Multiply.Location = new System.Drawing.Point(301, 238);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(120, 75);
            this.Multiply.TabIndex = 2;
            this.Multiply.Text = "x2";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // LabelComputerNumber
            // 
            this.LabelComputerNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelComputerNumber.AutoSize = true;
            this.LabelComputerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelComputerNumber.Location = new System.Drawing.Point(53, 40);
            this.LabelComputerNumber.Name = "LabelComputerNumber";
            this.LabelComputerNumber.Size = new System.Drawing.Size(236, 25);
            this.LabelComputerNumber.TabIndex = 3;
            this.LabelComputerNumber.Text = "ПОЛУЧИТЕ ЧИСЛО: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // LabelUserNumber
            // 
            this.LabelUserNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelUserNumber.AutoSize = true;
            this.LabelUserNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelUserNumber.Location = new System.Drawing.Point(53, 107);
            this.LabelUserNumber.Name = "LabelUserNumber";
            this.LabelUserNumber.Size = new System.Drawing.Size(221, 25);
            this.LabelUserNumber.TabIndex = 5;
            this.LabelUserNumber.Text = "ТЕКУЩЕЕ ЧИСЛО: ";
            // 
            // CommandSumm1
            // 
            this.CommandSumm1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CommandSumm1.AutoSize = true;
            this.CommandSumm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommandSumm1.Location = new System.Drawing.Point(53, 170);
            this.CommandSumm1.Name = "CommandSumm1";
            this.CommandSumm1.Size = new System.Drawing.Size(228, 25);
            this.CommandSumm1.TabIndex = 6;
            this.CommandSumm1.Text = "ЧИСЛО ПОПЫТОК: ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // File1
            // 
            this.File1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.File1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameToolStripMenuItem});
            this.File1.Image = ((System.Drawing.Image)(resources.GetObject("File1.Image")));
            this.File1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.File1.Name = "File1";
            this.File1.Size = new System.Drawing.Size(49, 22);
            this.File1.Text = "Файл";
            // 
            // startGameToolStripMenuItem
            // 
            this.startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
            this.startGameToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.startGameToolStripMenuItem.Text = "Играть";
            this.startGameToolStripMenuItem.Click += new System.EventHandler(this.startGameToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulsToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(80, 22);
            this.toolStripDropDownButton1.Text = "Настройки";
            // 
            // rulsToolStripMenuItem
            // 
            this.rulsToolStripMenuItem.Name = "rulsToolStripMenuItem";
            this.rulsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.rulsToolStripMenuItem.Text = "Правила";
            this.rulsToolStripMenuItem.Click += new System.EventHandler(this.rulsToolStripMenuItem_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(443, 238);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(120, 75);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "ОТМЕНА ХОДА";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Doubler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.CommandSumm1);
            this.Controls.Add(this.LabelUserNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelComputerNumber);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.NewGame);
            this.MaximumSize = new System.Drawing.Size(1200, 760);
            this.MinimumSize = new System.Drawing.Size(600, 380);
            this.Name = "Doubler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "УДВОИТЕЛЬ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Doubler_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Label LabelComputerNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelUserNumber;
        private System.Windows.Forms.Label CommandSumm1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton File1;
        private System.Windows.Forms.ToolStripMenuItem startGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem rulsToolStripMenuItem;
        private System.Windows.Forms.Button Cancel;
    }
}

