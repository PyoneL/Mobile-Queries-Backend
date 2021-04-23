using System;
using Core.Entities.Abstract;

namespace Entities.Dto.TypeOne
{
    public class TypeOne_ArticleTwo : IDto
    {
        public DateTime PUDatetime { get; set; }
        public decimal trip_distance { get; set; }
    }
}