namespace Ближайшие_точки
{
    partial class Result
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minDist = new System.Windows.Forms.TextBox();
            this.ResPoints = new System.Windows.Forms.TextBox();
            this.ResNumbPoints = new System.Windows.Forms.TextBox();
            this.SavePoints = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Минимальное \r\nрасстояние:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номера точек:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(74, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Точки:";
            // 
            // minDist
            // 
            this.minDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minDist.Location = new System.Drawing.Point(137, 24);
            this.minDist.Name = "minDist";
            this.minDist.ReadOnly = true;
            this.minDist.Size = new System.Drawing.Size(155, 26);
            this.minDist.TabIndex = 4;
            // 
            // ResPoints
            // 
            this.ResPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResPoints.Location = new System.Drawing.Point(137, 68);
            this.ResPoints.Name = "ResPoints";
            this.ResPoints.ReadOnly = true;
            this.ResPoints.Size = new System.Drawing.Size(155, 26);
            this.ResPoints.TabIndex = 6;
            // 
            // ResNumbPoints
            // 
            this.ResNumbPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResNumbPoints.Location = new System.Drawing.Point(137, 112);
            this.ResNumbPoints.Name = "ResNumbPoints";
            this.ResNumbPoints.ReadOnly = true;
            this.ResNumbPoints.Size = new System.Drawing.Size(155, 26);
            this.ResNumbPoints.TabIndex = 7;
            // 
            // SavePoints
            // 
            this.SavePoints.Location = new System.Drawing.Point(306, 58);
            this.SavePoints.Name = "SavePoints";
            this.SavePoints.Size = new System.Drawing.Size(75, 49);
            this.SavePoints.TabIndex = 8;
            this.SavePoints.Text = "Сохранить введенные\r\n точки";
            this.SavePoints.UseVisualStyleBackColor = true;
            this.SavePoints.Click += new System.EventHandler(this.SavePoints_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 155);
            this.Controls.Add(this.SavePoints);
            this.Controls.Add(this.ResNumbPoints);
            this.Controls.Add(this.ResPoints);
            this.Controls.Add(this.minDist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Result";
            this.Text = "Результат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox minDist;
        private System.Windows.Forms.TextBox ResPoints;
        private System.Windows.Forms.TextBox ResNumbPoints;
        private System.Windows.Forms.Button SavePoints;
    }
}