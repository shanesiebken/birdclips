using FTGA.BirdClips.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTGA.BirdClips.Core.Services
{
    public interface IBirdDataService
    {
        List<Bird> GetAll();
        Bird Get(int birdId);

        //Bird Get(long id);

    }
}
