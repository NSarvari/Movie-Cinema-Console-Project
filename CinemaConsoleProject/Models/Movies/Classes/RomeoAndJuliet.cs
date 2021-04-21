using CinemaConsoleProject.Models.Movies.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaConsoleProject.Models.Movies.Classes
{
    public class RomeoAndJuliet : Movie
    {
        private const string RomeoAndJulietHallNumber = "VIP";
        public RomeoAndJuliet() : base(RomeoAndJulietHallNumber)
        {

        }
        
    }
}
