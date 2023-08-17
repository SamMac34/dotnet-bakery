using System.Collections.Generic;
using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace DotnetBakery.Models
{
    public class Baker 
    {
        public int Id { get; set; }

        // required is NOT NULL
        [Required]
        public string Name { get; set; }
    }
}
