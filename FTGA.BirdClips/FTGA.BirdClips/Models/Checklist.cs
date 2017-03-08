using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTGA.BirdClips.Core.Models
{
    public class Checklist
    {
        public long Id { get; set; }

        public string Name { get; set; }
        public DateTime TimeCreated { get; set; }

        public List<Bird> Birds { get; set; }
    }
}
