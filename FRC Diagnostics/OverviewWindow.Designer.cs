namespace FRCDiagnostics
{
    partial class OverviewWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            componentSection1 = new Controls.ComponentSection();
            flowLayoutPanel1 = new FlowLayoutPanel();
            statusLabel1 = new Controls.StatusLabel();
            componentSection1.SuspendLayout();
            SuspendLayout();
            // 
            // componentSection1
            // 
            componentSection1.Controls.Add(flowLayoutPanel1);
            componentSection1.Location = new Point(12, 12);
            componentSection1.Name = "componentSection1";
            componentSection1.Padding = new Padding(5);
            componentSection1.Size = new Size(264, 378);
            componentSection1.TabIndex = 1;
            componentSection1.TabStop = false;
            componentSection1.Text = "Status";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(26, 80);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(188, 258);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // statusLabel1
            // 
            statusLabel1.AutoSize = true;
            statusLabel1.Header = false;
            statusLabel1.Location = new Point(365, 131);
            statusLabel1.Muted = false;
            statusLabel1.Name = "statusLabel1";
            statusLabel1.Size = new Size(90, 20);
            statusLabel1.State = FRCDiagnostics.Controls.Status.Unknown;
            statusLabel1.Status = "Hello";
            statusLabel1.TabIndex = 2;
            statusLabel1.Text = "Hello";
            // 
            // OverviewWindow
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(734, 402);
            Controls.Add(statusLabel1);
            Controls.Add(componentSection1);
            Name = "OverviewWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRC Diagnostics - Overview";
            componentSection1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Controls.ComponentSection componentSection1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Controls.StatusLabel statusLabel1;
    }
}
