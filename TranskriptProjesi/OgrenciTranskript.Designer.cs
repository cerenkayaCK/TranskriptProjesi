namespace TranskriptProjesi
{
    partial class OgrenciTranskript
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
            flpTranskript1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpTranskript1
            // 
            flpTranskript1.Location = new Point(12, 61);
            flpTranskript1.Name = "flpTranskript1";
            flpTranskript1.Size = new Size(801, 475);
            flpTranskript1.TabIndex = 3;
            // 
            // OgrenciTranskript
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 548);
            Controls.Add(flpTranskript1);
            Name = "OgrenciTranskript";
            Text = "OgrenciTranskript";
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flpTranskript1;
    }
}