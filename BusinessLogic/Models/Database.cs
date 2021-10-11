﻿using System.Collections;
using System.Collections.Generic;

namespace MyDatabase.Models
{
    public class Database
    {
        public Database()
        {
            Tables = new List<Table>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Table> Tables { get; set; }
    }
}