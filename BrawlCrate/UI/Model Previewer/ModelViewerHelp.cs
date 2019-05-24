﻿namespace System.Windows.Forms
{
    public class ModelViewerHelp : Form
    {
        public ModelViewerHelp() { InitializeComponent(); }

        public void Show(IWin32Window owner, bool collisionEditor)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelViewerHelp));
            if (collisionEditor)
            {
                richTextBox1.Text = resources.GetString("richTextBox1.Text2");
                Width = 425;
                Height = 425;
            }
            else
            {
                richTextBox1.Text = resources.GetString("richTextBox1.Text");
            }

            base.Show(owner);
        }

        private unsafe void btnOkay_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private RichTextBox richTextBox1;

        #region Designer

        private Button btnOkay;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelViewerHelp));
            btnOkay = new System.Windows.Forms.Button();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            SuspendLayout();
            // 
            // btnOkay
            // 
            btnOkay.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            btnOkay.Location = new System.Drawing.Point(594, 575);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new System.Drawing.Size(75, 23);
            btnOkay.TabIndex = 1;
            btnOkay.Text = "&Okay";
            btnOkay.UseVisualStyleBackColor = true;
            btnOkay.Click += new System.EventHandler(btnOkay_Click);
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right);
            richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = System.Drawing.Color.Black;
            richTextBox1.Location = new System.Drawing.Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            richTextBox1.Size = new System.Drawing.Size(657, 557);
            richTextBox1.TabIndex = 2;
            // 
            // ModelViewerHelp
            // 
            AcceptButton = btnOkay;
            ClientSize = new System.Drawing.Size(681, 610);
            Controls.Add(richTextBox1);
            Controls.Add(btnOkay);
            Name = "ModelViewerHelp";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Viewer Help";
            ResumeLayout(false);

        }
        #endregion
    }
}
