using System;
using Core.Entities.Abstract;
using Entities.Dto.TypeThree;

namespace Entities.Dto.TypeTree
{
    public class TypeThree_ArticleOne : IDto
    {
        public DateTime PUDatetime { get; set; }
        public DateTime DODatetime { get; set; }

        public CoordinateDto PULocationCoordinate { get; set; }

        public CoordinateDto DOLocationCoordinate { get; set; }

        public string PULocation { get; set; }
        public string DOLocation { get; set; }

        public decimal trip_distance { get; set; }
    }
}