﻿using Movie.Business.Manager.Model.Film;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.UI.Model.ViewModel.Genre
{
    public class ListGenreVM
    {
        public string GenreOfFilm { get; set; }
        public ICollection<FilmForGenreDTO> Films { get; set; }
    }
}
