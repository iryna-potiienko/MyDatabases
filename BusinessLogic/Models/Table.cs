using System;
using System.Collections;
using System.Collections.Generic;

namespace MyDatabase.Models
{
    public class Table
    {
        public Table()
        {
            Attributes = new List<Attribute>();
            Rows = new List<Row>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int DatabaseId { get; set; }
        public virtual Database Database { get; set; }
        public virtual ICollection<Attribute> Attributes { get; set; }
        public virtual ICollection<Row> Rows { get; set; }
    }
}