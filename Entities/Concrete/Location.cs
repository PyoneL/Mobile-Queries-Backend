using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Location : IEntity
    {
        public string Borough { get; set; }
        public int LocationId { get; set; }
        public string Zone { get; set; }
    }
}
