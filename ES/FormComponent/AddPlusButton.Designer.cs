using System.ComponentModel;
using System.Drawing;

namespace ES.FormComponent
{
    partial class AddPlusButton
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private IContainer components = null;

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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AddPlusButton
            // 
            this.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ResumeLayout(false);
        }

        #endregion
    }
}
