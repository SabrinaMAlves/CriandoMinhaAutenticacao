namespace CriandoMinhaAutenticacao
{
    partial class lboPrincipal
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
            BtnLogoff = new Button();
            SuspendLayout();
            // 
            // BtnLogoff
            // 
            BtnLogoff.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLogoff.Location = new Point(90, 154);
            BtnLogoff.Name = "BtnLogoff";
            BtnLogoff.Size = new Size(133, 54);
            BtnLogoff.TabIndex = 0;
            BtnLogoff.Text = "Logoff";
            BtnLogoff.UseVisualStyleBackColor = true;
            BtnLogoff.Click += BtnLogoff_Click;
            // 
            // lboPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 417);
            Controls.Add(BtnLogoff);
            Name = "lboPrincipal";
            Text = "Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnLogoff;
    }
}