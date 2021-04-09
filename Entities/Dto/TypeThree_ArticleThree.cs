using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dto
{
    public class TypeThree_ArticleThree
    {
        public row longest_trip { get; set; }
        public row shortest_trip { get; set; }
       
    }
    public class row
    {
        public int PULocationID { get; set; }
        public int DOLocationID { get; set; }
        public float trip_distance { get; set; }
    }
}
