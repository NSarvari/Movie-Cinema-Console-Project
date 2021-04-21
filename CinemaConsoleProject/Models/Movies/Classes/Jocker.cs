using CinemaConsoleProject.Models.Movies.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaConsoleProject.Models.Movies.Classes
{
    public class Jocker : Movie
    {
        private const string JockerHallNumber = "A";
        public Jocker() : base(JockerHallNumber)
        {
        }
    }
}
