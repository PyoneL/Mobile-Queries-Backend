using System;
using Core.Entities.Abstract;
using Entities.Concrete;

namespace Entities.Dto.TypeTree
{
    public class TypeThree_ArticleOne : IDto
    {
        public DateTime PUDatetime { get; set; }
        public DateTime DODatetime { get; set; }

        public Coordinate PULocationCoordinate { get; set; }
        
        public Coordinate DOLocationCoordinate { get; set; }
                
        public string PULocation { get; set; }
        public string DOLocation { get; set; }
        
        public decimal trip_distance { get; set; }
    }
}