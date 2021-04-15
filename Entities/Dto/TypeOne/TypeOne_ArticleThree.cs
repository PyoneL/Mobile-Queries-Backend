using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;

namespace Entities.Dto.TypeOne
{
    public class TypeOne_ArticleThree : IDto
    {
        public DateTime PUDatetime { get; set; }
        public decimal trip_distance { get; set; }
    }
}
