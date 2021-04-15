using System;
using Core.Entities.Abstract;

namespace Entities.Dto.TypeTwo
{
    public class TypeTwo_ArticleThree_Input : IDto
    {
        public DateTime FirstDate { get; set; }
        public DateTime SecondDate { get; set; }
    }
}
