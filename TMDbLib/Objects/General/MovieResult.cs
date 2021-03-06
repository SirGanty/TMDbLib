﻿using System;

namespace TMDbLib.Objects.General
{
    public class MovieResult
    {
        public int Id { get; set; }
        public string BackdropPath { get; set; }
        public string OriginalTitle { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string PosterPath { get; set; }
        public string Title { get; set; }
        public double VoteAverage { get; set; }
        public int VoteCount { get; set; }
    }
}