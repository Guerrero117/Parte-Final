﻿using System.Collections.Generic;
using System.Data;

namespace libreria_MOGS.Data.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Book> Books { get; set; } 
    }
}
