using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dto.Location
{
    public class LocationDto: IDto
    {
        public int LocationID { get; set; }
        public string Location { get; set; }
    }
}
