﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamContacs.Model
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
    }
}
