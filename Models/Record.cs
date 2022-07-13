using System;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public partial class Record
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Mail { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
    }
}
