using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dennis_ITE_370_101_Exam_Part2
{
    public class Album
    {
        public string Name { get; set; }
        public string ReleaseYear { get; set; }
        public string NumberOfSongs { get; set; }
        public string AwardLevel { get; set; }

        


        public Album()
        { 

        }
          
    



        public Album(string theName, string theReleaseYear, string theNumberOfSongs, string theAwardLevel)
        {

            Name = theName;
            ReleaseYear = theReleaseYear;
            NumberOfSongs = theNumberOfSongs;
            AwardLevel = theAwardLevel;

           
        }

        public override string ToString()
        {
            return Name + " - " + ReleaseYear + " : " + AwardLevel;
        }
    }
}
