using System;
using Core.Entities.Abstract;

namespace Entities.Dto.TypeTree
{
    public class TypeThree_ArticleOne : IDto
    {
        public DateTime PUDatetime { get; set; }
        public DateTime DODatetime { get; set; }
        public int PULocationID { get; set; }
        public int DOLocationID { get; set; }
        public decimal trip_distance { get; set; }
    }
}