﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.EntityLayer.Concrete
{
    public class AppUser:IdentityUser<int>
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        List<CarRegister> CarRegisters { get; set; }
    }
}
