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
            resources.ApplyResources(this.InputTxt, "InputTxt");
            this.InputTxt.Name = "InputTxt";
            this.InputTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InputTxt_KeyUp);
            // 
            // InfoLabelForOutputTxt
            // 
            resources.ApplyResources(this.InfoLabelForOutputTxt, "InfoLabelForOutputTxt");
            this.InfoLabelForOutputTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoLabelForOutputTxt.Name = "InfoLabelForOutputTxt";
            // 
            // OutputTxt
            // 
            resources.ApplyResources(this.OutputTxt, "OutputTxt");
            this.OutputTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputTxt.Name = "OutputTxt";
            // 
            // InfoLabelForResult
            // 
            resources.ApplyResources(this.InfoLabelForResult, "InfoLabelForResult");
            this.InfoLabelForResult.BackColor = System.Drawing.SystemColors.Control;
            this.InfoLabelForResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoLabelForResult.Name = "InfoLabelForResult";
            // 
            // Result
            // 
            resources.ApplyResources(this.Result, "Result");
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Result.Name = "Result";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Result);
            this.Controls.Add(this.InfoLabelForResult);
            this.Controls.Add(this.OutputTxt);
            this.Controls.Add(this.InfoLabelForOutputTxt);
            this.Controls.Add(this.InputTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
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

