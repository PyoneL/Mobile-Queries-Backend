using System;
using Core.Entities.Abstract;

namespace Entities.Dto.TypeTwo
{
    public class TypeTwo_ArticleThree : IDto
    {
        public DateTime PUDatetime { get; set; }
        public DateTime DODatetime { get; set; }
        public decimal trip_distance { get; set; }
    }
}
