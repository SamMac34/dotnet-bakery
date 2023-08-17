using System.Collections.Generic;
using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DotnetBakery.Models
{
    public class Bread 
    {
        public int Id { get; set; }

        public string description { get; set; }

        [ForeignKey("BakedBy")]
        public int BakerId { get; set; }

        public Baker BakedBy {get; set;}
    }
}
