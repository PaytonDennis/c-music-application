
namespace P_Dennis_ITE_370_101_Exam_Part2
{
    partial class frmArtistandAlbums
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnSearchArtistFirstName = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNewArtist = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowAllAlbums = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstAlbums = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(25, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(165, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(154, 128);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(254, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(154, 175);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(254, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // btnSearchArtistFirstName
            // 
            this.btnSearchArtistFirstName.Location = new System.Drawing.Point(25, 60);
            this.btnSearchArtistFirstName.Name = "btnSearchArtistFirstName";
            this.btnSearchArtistFirstName.Size = new System.Drawing.Size(165, 44);
            this.btnSearchArtistFirstName.TabIndex = 3;
            this.btnSearchArtistFirstName.Text = "Search By Artist First Name";
            this.btnSearchArtistFirstName.UseVisualStyleBackColor = true;
            this.btnSearchArtistFirstName.Click += new System.EventHandler(this.btnSearchArtistFirstName_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(299, 27);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(109, 77);
            this.btnRandom.TabIndex = 4;
            this.btnRandom.Text = "Show Random Artist";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(43, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 46);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddNewArtist
            // 
            this.btnAddNewArtist.Location = new System.Drawing.Point(179, 374);
            this.btnAddNewArtist.Name = "btnAddNewArtist";
            this.btnAddNewArtist.Size = new System.Drawing.Size(103, 46);
            this.btnAddNewArtist.TabIndex = 6;
            this.btnAddNewArtist.Text = "Add New Artist";
            this.btnAddNewArtist.UseVisualStyleBackColor = true;
            this.btnAddNewArtist.Click += new System.EventHandler(this.btnAddNewArtist_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(299, 374);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 46);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete Artist";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShowAllAlbums
            // 
            this.btnShowAllAlbums.Location = new System.Drawing.Point(43, 446);
            this.btnShowAllAlbums.Name = "btnShowAllAlbums";
            this.btnShowAllAlbums.Size = new System.Drawing.Size(365, 47);
            this.btnShowAllAlbums.TabIndex = 8;
            this.btnShowAllAlbums.Text = "Show All Albums For All Artists";
            this.btnShowAllAlbums.UseVisualStyleBackColor = true;
            this.btnShowAllAlbums.Click += new System.EventHandler(this.btnShowAllAlbums_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "or";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Albums:";
            // 
            // lstAlbums
            // 
            this.lstAlbums.FormattingEnabled = true;
            this.lstAlbums.Location = new System.Drawing.Point(154, 221);
            this.lstAlbums.Name = "lstAlbums";
            this.lstAlbums.Size = new System.Drawing.Size(254, 121);
            this.lstAlbums.TabIndex = 13;
            // 
            // frmArtistandAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 523);
            this.Controls.Add(this.lstAlbums);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowAllAlbums);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNewArtist);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnSearchArtistFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmArtistandAlbums";
            this.Text = "Artists and albums";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnSearchArtistFirstName;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNewArtist;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowAllAlbums;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstAlbums;
    }
}

