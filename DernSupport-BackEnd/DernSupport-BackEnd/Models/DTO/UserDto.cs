﻿namespace DernSupport_BackEnd.Models.DTO
{
    public class UserDto
    {
        public string Id { get; set; }
        public string Username { get; set; }

        public string Token { get; set; }

        public IList<string> Roles { get; set; }
        public string AccountType { get; set; }

    }
}
