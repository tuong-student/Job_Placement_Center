﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_oosee.FactoryMethod
{
    internal class StudentClass : AbstractUserClass
    {
        public override UserInterface CreateUser()
        {
            return new UserStudent();
        }
    }
}
