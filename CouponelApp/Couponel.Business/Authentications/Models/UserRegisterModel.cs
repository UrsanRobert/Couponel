﻿using Couponel.Entities.Identities;
using Couponel.Entities.Institutions;
using System;
using System.Collections.Generic;
using System.Text;
using Couponel.Entities.ValueObjects;

namespace Couponel.Business.Authentications.Models
{
    public sealed class UserRegisterModel
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRole Role{ get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
    }
}
