using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarChart.Models
{
    public abstract class CelestialObjects
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? OrbitedObject { get; set; }
        [NotMapped]
        public List<CelestialObjects> Satellites { get; set; }
        public  TimeSpan OrbitalPeriod { get; set; }
        
        
        
    }
}
