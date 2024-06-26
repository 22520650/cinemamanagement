﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_management.DTOs
{
    public class SeatDTO
    {
        public SeatDTO()
        {
        }
        public int Id { get; set; }
        public int SeatNumber { get; set; }
        public string Row { get; set; }
        public Nullable<int> RoomId { get; set; }
        public RoomDTO Room { get; set; }
    }
}
