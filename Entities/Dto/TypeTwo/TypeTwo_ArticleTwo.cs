using System;
using Core.Entities.Abstract;

namespace Entities.Dto.TypeTwo
{
    public class TypeTwo_ArticleTwo : IDto
    {
        public DateTime PUDatetime { get; set; }
        public decimal total_amount_average { get; set; }
    }
}