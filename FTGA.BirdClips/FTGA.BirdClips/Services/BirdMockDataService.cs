using FTGA.BirdClips.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTGA.BirdClips.Core.Services
{
    public class BirdMockDataService : IBirdDataService
    {
        private List<Bird> Birds { get; set; }

        public BirdMockDataService()
        {
            Birds = new List<Bird>();
            for (int i = 0; i < 50; i++)
            {
                Birds.Add(new Bird()
                {
                    Id = i,
                    Name = "Bird" + i,
                    Location = "Some Region"
                });
            }
        }
        public Bird Get(int birdId)
        {
            return Birds.Find(b => b.Id == birdId);
        }

        public List<Bird> GetAll()
        {
            return Birds;
        }
    }
}
