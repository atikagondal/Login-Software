using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Login_software
{
     partial class Welcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// 
       /* public override void Dispose()
        {

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        */
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 450);
           // this.Controls.Add(this.label2); 
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }

        private void PerformLayout()
        {
            throw new NotImplementedException();
        }

        private void ResumeLayout(bool v)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SuspendLayout()
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private bool disposing;
        private SizeF AutoScaleDimensions;

        public AutoScaleMode AutoScaleMode { get; private set; }
        public IContainer Components { get => components; set => components = value; }

        private Size ClientSize;
        private object Controls;
        private string Name;
        private string Text;

        public Welcome(IContainer components, Label label2, bool disposing, SizeF autoScaleDimensions, AutoScaleMode autoScaleMode, Size clientSize, object controls, string name, string text)
        {
            this.Components = components;
            this.label2 = label2;
            this.disposing = disposing;
            AutoScaleDimensions = autoScaleDimensions;
            AutoScaleMode = autoScaleMode;
            ClientSize = clientSize;
            Controls = controls;
            Name = name;
            Text = text;
        }

        public Welcome()
        {
        }
    }
}