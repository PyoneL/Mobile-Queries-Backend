using System;
using Core.Entities.Abstract;

namespace Entities.Dto.TypeOne
{
    public class TypeOne_ArticleOne : IDto
    {
        public DateTime PUDatetime { get; set; }
        public int passenger_count { get; set; }
    }
}