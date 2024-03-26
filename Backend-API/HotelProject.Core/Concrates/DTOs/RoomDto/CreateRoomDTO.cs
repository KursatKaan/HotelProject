﻿namespace HotelProject.Core.Concrates.DTOs.RoomDto
{
    public class CreateRoomDTO
    {
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }
        public int RoomPrice { get; set; }
        public string RoomTitle { get; set; }
        public string RoomBedCount { get; set; }
        public string RoomBathCount { get; set; }
        public string RoomWifi { get; set; }
        public string RoomDescription { get; set; }
    }
}
