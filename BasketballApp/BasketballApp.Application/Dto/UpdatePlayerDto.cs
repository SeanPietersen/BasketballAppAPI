﻿namespace BasketballApp.Application.Dto
{
    public class UpdatePlayerDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double PlayerHeight { get; set; }
        public double PlayerWeight { get; set; }
    }
}
