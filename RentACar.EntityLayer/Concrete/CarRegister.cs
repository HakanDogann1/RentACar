﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.EntityLayer.Concrete
{
    public class CarRegister
    {
        public int CarRegisterID { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
    }
}
