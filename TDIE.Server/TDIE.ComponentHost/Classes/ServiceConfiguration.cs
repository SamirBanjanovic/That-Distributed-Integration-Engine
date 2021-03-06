using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TDIE.ComponentHost.Classes
{
    public class ServiceConfiguration
    {
        [Required]
        public long Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string Version { get; set; }
        
        public string Description { get; set; }

        [Required]
        public string AssemblyPath { get; set; }

        [Required]
        public string FullyQualifiedClassName { get; set; }


        [Required]
        public IDictionary<string, string> Properties { get; set; }

        public MessagePublisherConfiguration MessagePublisherConfiguration { get; set; }

    }
}
