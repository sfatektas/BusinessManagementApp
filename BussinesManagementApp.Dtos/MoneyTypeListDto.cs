﻿using BussinesManagementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Dtos
{
    public class MoneyTypeListDto : IListDto
    {
        public int Id { get; set; }
        public string  Defination { get; set; }
        public double Value { get; set; }
    }
}
