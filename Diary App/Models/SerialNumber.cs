﻿using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Identity.Client;

namespace Diary_App.Models
{
    public class SerialNumber
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? ItemId { get; set; }
        [ForeignKey("ItemId")]
        public Item? Item { get; set; } 
    }
}
