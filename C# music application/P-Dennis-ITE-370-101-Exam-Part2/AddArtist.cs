using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Dennis_ITE_370_101_Exam_Part2
{
    public partial class frmAddArtist : Form
    {
        public frmAddArtist()
        {
            InitializeComponent();
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            Artist artist = new Artist();
            artist.FirstName = txtFirstNameAdd.Text;
            artist.LastName = txtLastNameAdd.Text;
            
            Tag = artist;

        }
    }
}
