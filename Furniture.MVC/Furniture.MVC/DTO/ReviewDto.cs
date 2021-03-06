﻿using System.Collections.Generic;

namespace Furniture.MVC.DTO
{
    public class ReviewDto
    {
        public List<UserCommentsDto> UserComments { get; set; }
        public int AvaregRate { get; set; }
        public int TotalRates { get; set; }
        public RequestedServiceDto ServiceDto { get; set; }
    }
}