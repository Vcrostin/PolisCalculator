namespace Polis_Calc
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InputTxt = new System.Windows.Forms.TextBox();
            this.InfoLabelForOutputTxt = new System.Windows.Forms.Label();
            this.OutputTxt = new System.Windows.Forms.Label();
            this.InfoLabelForResult = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputTxt
            // 
            this.InputTxt.Location = new System.Drawing.Point(13, 13);
            this.InputTxt.Name = "InputTxt";
            this.InputTxt.Size = new System.Drawing.Size(420, 20);
            this.InputTxt.TabIndex = 0;
            this.InputTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InputTxt_KeyUp);
            // 
            // InfoLabelForOutputTxt
            // 
            this.InfoLabelForOutputTxt.AutoSize = true;
            this.InfoLabelForOutputTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoLabelForOutputTxt.Location = new System.Drawing.Point(12, 49);
            this.InfoLabelForOutputTxt.Name = "InfoLabelForOutputTxt";
            this.InfoLabelForOutputTxt.Size = new System.Drawing.Size(358, 15);
            this.InfoLabelForOutputTxt.TabIndex = 1;
            this.InfoLabelForOutputTxt.Text = "Окно преобразования первоначального ввыражения в полис форму";
            // 
            // OutputTxt
            // 
            this.OutputTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputTxt.Location = new System.Drawing.Point(13, 75);
            this.OutputTxt.Name = "OutputTxt";
            this.OutputTxt.Size = new System.Drawing.Size(420, 23);
            this.OutputTxt.TabIndex = 2;
            // 
            // InfoLabelForResult
            // 
            this.InfoLabelForResult.AutoSize = true;
            this.InfoLabelForResult.BackColor = System.Drawing.SystemColors.Control;
            this.InfoLabelForResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoLabelForResult.Location = new System.Drawing.Point(12, 112);
            this.InfoLabelForResult.Name = "InfoLabelForResult";
            this.InfoLabelForResult.Size = new System.Drawing.Size(125, 15);
            this.InfoLabelForResult.TabIndex = 3;
            this.InfoLabelForResult.Text = "Результат вычислений";
            // 
            // Result
            // 
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Result.Location = new System.Drawing.Point(12, 140);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(421, 23);
            this.Result.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.InfoLabelForResult);
            this.Controls.Add(this.OutputTxt);
            this.Controls.Add(this.InfoLabelForOutputTxt);
            this.Controls.Add(this.InputTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Polis calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTxt;
        private System.Windows.Forms.Label InfoLabelForOutputTxt;
        private System.Windows.Forms.Label OutputTxt;
        private System.Windows.Forms.Label InfoLabelForResult;
        private System.Windows.Forms.Label Result;
    }
}

