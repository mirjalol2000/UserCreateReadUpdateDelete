﻿using System;

namespace UserCreateReadUpdateDelete.Models.Users
{
    public class Model
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }   

    }
}
