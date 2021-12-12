
namespace DynamicTestsLab
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.epsTInput = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.StepNumeric = new System.Windows.Forms.NumericUpDown();
            this.RightBorderTextbox = new System.Windows.Forms.TextBox();
            this.LeftBorderTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.RichTextBox();
            this.BuildTableButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epsTInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.epsTInput);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.StepNumeric);
            this.groupBox1.Controls.Add(this.RightBorderTextbox);
            this.groupBox1.Controls.Add(this.LeftBorderTextbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(717, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные параметры";
            // 
            // epsTInput
            // 
            this.epsTInput.DecimalPlaces = 4;
            this.epsTInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.epsTInput.Location = new System.Drawing.Point(383, 156);
            this.epsTInput.Margin = new System.Windows.Forms.Padding(4);
            this.epsTInput.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.epsTInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.epsTInput.Name = "epsTInput";
            this.epsTInput.Size = new System.Drawing.Size(315, 30);
            this.epsTInput.TabIndex = 5;
            this.epsTInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.epsTInput.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Предел погрешность (eps)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // StepNumeric
            // 
            this.StepNumeric.DecimalPlaces = 4;
            this.StepNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.StepNumeric.Location = new System.Drawing.Point(383, 118);
            this.StepNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.StepNumeric.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.StepNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.StepNumeric.Name = "StepNumeric";
            this.StepNumeric.Size = new System.Drawing.Size(315, 30);
            this.StepNumeric.TabIndex = 3;
            this.StepNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // RightBorderTextbox
            // 
            this.RightBorderTextbox.Location = new System.Drawing.Point(383, 79);
            this.RightBorderTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.RightBorderTextbox.Name = "RightBorderTextbox";
            this.RightBorderTextbox.Size = new System.Drawing.Size(313, 30);
            this.RightBorderTextbox.TabIndex = 2;
            this.RightBorderTextbox.Text = "1";
            // 
            // LeftBorderTextbox
            // 
            this.LeftBorderTextbox.Location = new System.Drawing.Point(383, 36);
            this.LeftBorderTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.LeftBorderTextbox.Name = "LeftBorderTextbox";
            this.LeftBorderTextbox.Size = new System.Drawing.Size(313, 30);
            this.LeftBorderTextbox.TabIndex = 2;
            this.LeftBorderTextbox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Шаг интегрирования";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Верхняя граница интегрирования";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Нижняя граница интегрирования";
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(17, 226);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(257, 46);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Начать тестирование";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTextBox.Location = new System.Drawing.Point(17, 280);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(717, 392);
            this.ResultTextBox.TabIndex = 6;
            this.ResultTextBox.Text = "";
            // 
            // BuildTableButton
            // 
            this.BuildTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildTableButton.Location = new System.Drawing.Point(500, 226);
            this.BuildTableButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuildTableButton.Name = "BuildTableButton";
            this.BuildTableButton.Size = new System.Drawing.Size(236, 46);
            this.BuildTableButton.TabIndex = 4;
            this.BuildTableButton.Text = "Построить таблицу";
            this.BuildTableButton.UseVisualStyleBackColor = true;
            this.BuildTableButton.Click += new System.EventHandler(this.BuildTableButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 688);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.BuildTableButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Тестирование. Полиномы";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epsTInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown StepNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox RightBorderTextbox;
        private System.Windows.Forms.TextBox LeftBorderTextbox;
        private System.Windows.Forms.RichTextBox ResultTextBox;
        private System.Windows.Forms.Button BuildTableButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown epsTInput;
    }
}

