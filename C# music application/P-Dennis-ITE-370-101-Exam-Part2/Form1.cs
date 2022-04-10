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
{ //Coded by Payton Dennis

    public partial class frmArtistandAlbums : Form
    {
        List<Artist> ArtistList = new List<Artist>();

        int index = 0;

        public frmArtistandAlbums()
        {
            InitializeComponent();

            //add artists

            Artist first = new Artist();
            first.FirstName = "Billie";
            first.LastName = "Eilish";

            ArtistList.Add(first);

            Artist second = new Artist();
            second.FirstName = "Johnny";
            second.LastName = "Cash";

            ArtistList.Add(second);

            Artist third = new Artist();
            third.FirstName = "Earl";
            third.LastName = "Scruggs";

            ArtistList.Add(third);

            //add albums to artists

            ArtistList[0].AlbumList.Add(new Album("Don't smile at me", "2018", "8", "Silver"));
            ArtistList[0].AlbumList.Add(new Album("Live at Third Man Records", "2019", "7", "Platnum"));

            ArtistList[1].AlbumList.Add(new Album("At San Quentin", "1978", "10", "Platnum"));
            ArtistList[1].AlbumList.Add(new Album("I walk the line", "1962", "7", "Platnum"));

            ArtistList[2].AlbumList.Add(new Album("Dualing Banjos", "1955", "6", "silver"));
            ArtistList[2].AlbumList.Add(new Album("Family portrait", "1962", "12", "Gold"));

            txtFirstName.Text = ArtistList[0].FirstName;
            txtLastName.Text = ArtistList[0].LastName;

        }


        private void btnAddNewArtist_Click(object sender, EventArgs e)
        {

            frmAddArtist newArtist = new frmAddArtist();

            if (newArtist.ShowDialog() == DialogResult.OK)
            {
                Artist TheNewArtist = (Artist)newArtist.Tag;

                txtFirstName.Text = TheNewArtist.FirstName;
                txtLastName.Text = TheNewArtist.LastName;
                ArtistList.Add(TheNewArtist);
                index = ArtistList.Count() - 1;
            }
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstAlbums.Items.Clear();


            
              ArtistList.RemoveAt(index);
        

            txtFirstName.Text = ArtistList[0].FirstName;
            txtLastName.Text = ArtistList[0].LastName;


            index = 0;

        }

        private void btnSearchArtistFirstName_Click(object sender, EventArgs e)
        {

            String selectedName = txtSearch.Text;

            lstAlbums.Items.Clear();


            txtFirstName.Text = "";
            txtLastName.Text = "";


            for (int i = 0; i < ArtistList.Count; i++)
            {
                Artist thisArtist = ArtistList[i];

                if (ArtistList[i].FirstName.ToLower().Contains(selectedName))
                {
                    foreach (Album currentAlbum in thisArtist.AlbumList)
                    {
                        lstAlbums.Items.Add(currentAlbum.ToString());
        

                    }

                    
                }
                else
                {
                    MessageBox.Show("That artist does not exist");

                    txtFirstName.Text = ArtistList[0].FirstName;
                }
                

                txtFirstName.Text = thisArtist.FirstName;

                txtFirstName.Text = thisArtist.LastName;
            }
            
                
        }

        private void btnShowAllAlbums_Click(object sender, EventArgs e)
        {
            lstAlbums.Items.Clear();
            for (int i = 0; i < ArtistList.Count; i++)
            {
                Artist currentArtist = ArtistList[i];
                foreach (Album currentAlbum in currentArtist.AlbumList)
                {
                    lstAlbums.Items.Add(currentAlbum.ToString());
                }
            }

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
         

            Random r = new Random();
            index = r.Next(0, ArtistList.Count());

        
            txtFirstName.Text = ArtistList[index].FirstName;
            txtLastName.Text = ArtistList[index].FirstName;

            foreach (Album A in ArtistList[index].AlbumList)
            {
                lstAlbums.Items.Add(A.ToString());
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           


            ArtistList[index].FirstName = txtFirstName.Text;
            ArtistList[index].LastName = txtFirstName.Text;
        }



    }

      
}
