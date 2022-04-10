using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dennis_ITE_370_101_Exam_Part2
{
    public class Artist
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Album> AlbumList { get; set; }



        public Artist()
        {

            AlbumList = new List<Album>();
        }

        public Artist(string theFirstName, string theLastName)
        {
            FirstName = theFirstName;
            LastName = theLastName;

            AlbumList = new List<Album>();
           
        }
    }
}
