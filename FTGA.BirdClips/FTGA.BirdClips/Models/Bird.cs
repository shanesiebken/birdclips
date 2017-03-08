using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTGA.BirdClips.Core.Models
{
    public class Bird
    {
        public int Id { get; set; }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public List<string> Categories { get; set; }

        public Movie Movie1 { get; set; }
        public Movie Movie2 { get; set; }
        public Movie Movie3 { get; set; }

        public Call Call { get; set; }
        public string IconFilename { get; set; }
        public string ImageFilename { get; set; }
        public Range Range { get; set; }
    }
}
