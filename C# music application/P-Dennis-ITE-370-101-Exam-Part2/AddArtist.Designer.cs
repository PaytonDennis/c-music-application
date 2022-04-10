
namespace P_Dennis_ITE_370_101_Exam_Part2
{
    partial class frmAddArtist
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
            this.txtFirstNameAdd = new System.Windows.Forms.TextBox();
            this.txtLastNameAdd = new System.Windows.Forms.TextBox();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // txtFirstNameAdd
            // 
            this.txtFirstNameAdd.Location = new System.Drawing.Point(93, 23);
            this.txtFirstNameAdd.Name = "txtFirstNameAdd";
            this.txtFirstNameAdd.Size = new System.Drawing.Size(110, 20);
            this.txtFirstNameAdd.TabIndex = 2;
            // 
            // txtLastNameAdd
            // 
            this.txtLastNameAdd.Location = new System.Drawing.Point(93, 79);
            this.txtLastNameAdd.Name = "txtLastNameAdd";
            this.txtLastNameAdd.Size = new System.Drawing.Size(110, 20);
            this.txtLastNameAdd.TabIndex = 3;
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddArtist.Location = new System.Drawing.Point(36, 127);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(167, 34);
            this.btnAddArtist.TabIndex = 4;
            this.btnAddArtist.Text = "Add Artist";
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // frmAddArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 189);
            this.Controls.Add(this.btnAddArtist);
            this.Controls.Add(this.txtLastNameAdd);
            this.Controls.Add(this.txtFirstNameAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddArtist";
            this.Text = "AddArtist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstNameAdd;
        private System.Windows.Forms.TextBox txtLastNameAdd;
        private System.Windows.Forms.Button btnAddArtist;
    }
}