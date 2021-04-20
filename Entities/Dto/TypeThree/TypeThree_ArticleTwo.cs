﻿using Core.Entities.Abstract;
using Entities.Concrete;

namespace Entities.Dto.TypeTree
{
    public class TypeThree_ArticleTwo : IDto
    {
        public Coordinate PULocationCoordinate { get; set; }

        public Coordinate DOLocationCoordinate { get; set; }

        public string PULocation { get; set; }
        public string DOLocation { get; set; }

    }

}
