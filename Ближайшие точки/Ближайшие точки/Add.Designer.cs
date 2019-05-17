namespace Ближайшие_точки
{
    partial class Add
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddNumber = new System.Windows.Forms.TextBox();
            this.AddOldData = new System.Windows.Forms.Button();
            this.Res = new System.Windows.Forms.Button();
            this.AddPoints = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите кол-во точек:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите координаты \r\nточек через пробел:";
            // 
            // AddNumber
            // 
            this.AddNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNumber.Location = new System.Drawing.Point(234, 33);
            this.AddNumber.Name = "AddNumber";
            this.AddNumber.Size = new System.Drawing.Size(100, 26);
            this.AddNumber.TabIndex = 4;
            this.AddNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddNumber_KeyPress);
            this.AddNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AddNumber_KeyUp);
            // 
            // AddOldData
            // 
            this.AddOldData.Location = new System.Drawing.Point(234, 112);
            this.AddOldData.Name = "AddOldData";
            this.AddOldData.Size = new System.Drawing.Size(177, 29);
            this.AddOldData.TabIndex = 5;
            this.AddOldData.Text = "Открыть существующие точки";
            this.AddOldData.UseVisualStyleBackColor = true;
            this.AddOldData.Click += new System.EventHandler(this.AddOldData_Click);
            // 
            // Res
            // 
            this.Res.Enabled = false;
            this.Res.Location = new System.Drawing.Point(449, 112);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(143, 29);
            this.Res.TabIndex = 6;
            this.Res.Text = "Результат обработки";
            this.Res.UseVisualStyleBackColor = true;
            this.Res.Click += new System.EventHandler(this.Res_Click);
            // 
            // AddPoints
            // 
            this.AddPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPoints.Location = new System.Drawing.Point(234, 77);
            this.AddPoints.Name = "AddPoints";
            this.AddPoints.Size = new System.Drawing.Size(358, 26);
            this.AddPoints.TabIndex = 7;
            this.AddPoints.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPoints_KeyPress);
            this.AddPoints.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AddPoints_KeyUp);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 153);
            this.Controls.Add(this.AddPoints);
            this.Controls.Add(this.Res);
            this.Controls.Add(this.AddOldData);
            this.Controls.Add(this.AddNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add";
            this.Text = "Ближайшие точки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddNumber;
        private System.Windows.Forms.Button AddOldData;
        private System.Windows.Forms.Button Res;
        private System.Windows.Forms.TextBox AddPoints;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

