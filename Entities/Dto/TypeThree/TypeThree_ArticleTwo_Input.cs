using System;
using Core.Entities.Abstract;

namespace Entities.Dto.TypeTree
{
    public class TypeThree_ArticleTwo_Input : IDto
    {
        public DateTime FirstDate { get; set; }
        public int PULocationID { get; set; }
    }
}