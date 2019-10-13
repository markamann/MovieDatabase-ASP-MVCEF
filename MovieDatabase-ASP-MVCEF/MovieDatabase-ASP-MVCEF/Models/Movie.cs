using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieDatabase_ASP_MVCEF.Models
{

    [Table(name: "Movies", Schema = "dbo")]
    public class Movie
    {

        public Movie()
        {
            MovieID = -1;
            IMDBID = String.Empty;
            Title = String.Empty;
            OriginalTitle = String.Empty;
            Type = String.Empty;
            MPAARating = String.Empty;
            ReleaseDate = String.Empty;
            Year = String.Empty;
            Runtime = String.Empty;
            Plot = String.Empty;
            SimplePlot = String.Empty;
            Metascore = String.Empty;
            Rating = String.Empty;
            IMDBURL = String.Empty;
            IMDBPosterURL = String.Empty;
            Votes = -1;
            SeriesIMDBID = String.Empty;
            SeriesName = String.Empty;
            PosterFilename = String.Empty;
            LocalPosterFolder = String.Empty;
            LocalPosterPath = String.Empty;
            WebPosterURL = String.Empty;
            MovieJSON = String.Empty;
            DateLastUpdated = String.Empty;

            //BusinessData = new Business();
            //TechnicalData = new Technical();

            //Cast = new List<CastMember>();
            //Directors = new List<Person>();
            //Writers = new List<Person>();
            //Countries = new List<Country>();
            //FilmingLocations = new List<FilmingLocation>();
            //Genres = new List<Genre>();
            //Languages = new List<Language>();
            //Trivia = new List<MovieTrivia>();
            //AKA = new List<AKA>();
            //SimilarMovies = new List<SimilarMovie>();
            //MovieQuotes = new List<MovieQuote>();
            //Goofs = new List<Goof>();
            //Episodes = new List<SimpleTVEpisode>();
            //Keywords = new List<Keyword>();
        }

        [Key]
        [Display(Name = "MovieID")]
        public long MovieID { get; set; }

        [Display(Name = "IMDBID")]
        [StringLength(50)]
        public String IMDBID { get; set; }

        [Display(Name = "Title")]
        [StringLength(500)]
        public String Title { get; set; }

        [Display(Name = "Original Title")]
        [StringLength(500)]
        public String OriginalTitle { get; set; }

        [Display(Name = "Type")]
        [StringLength(500)]
        public String Type { get; set; }

        [Display(Name = "MPAA Rating")]
        [StringLength(50)]
        public String MPAARating { get; set; }

        [Display(Name = "Release Date")]
        [StringLength(50)]
        public String ReleaseDate { get; set; }

        [Display(Name = "Year")]
        [StringLength(10)]
        public String Year { get; set; }

        [Display(Name = "Runtime")]
        [StringLength(20)]
        public String Runtime { get; set; }

        [Display(Name = "Plot")]
        public String Plot { get; set; }

        [Display(Name = "SimplePlot")]
        public String SimplePlot { get; set; }

        [Display(Name = "Metascore")]
        [StringLength(50)]
        public String Metascore { get; set; }

        [Display(Name = "Rating")]
        [StringLength(50)]
        public String Rating { get; set; }

        [Display(Name = "IMDB URL")]
        [StringLength(500)]
        public String IMDBURL { get; set; }

        [Display(Name = "IMDB Poster URL")]
        [StringLength(500)]
        public String IMDBPosterURL { get; set; }

        [Display(Name = "Votes")]
        public int Votes { get; set; }

        [Display(Name = "Series IMDBID")]
        [StringLength(50)]
        public String SeriesIMDBID { get; set; }

        [Display(Name = "Series Name")]
        [StringLength(500)]
        public String SeriesName { get; set; }

        [Display(Name = "Poster Filename")]
        [StringLength(500)]
        public String PosterFilename { get; set; }

        [Display(Name = "Local Poster Folder")]
        [StringLength(500)]
        public String LocalPosterFolder { get; set; }

        [Display(Name = "Local Poster Path")]
        [StringLength(500)]
        public String LocalPosterPath { get; set; }

        [Display(Name = "Web Poster URL")]
        [StringLength(500)]
        public String WebPosterURL { get; set; }

        [Display(Name = "Movie JSON")]
        public String MovieJSON { get; set; }

        [Display(Name = "Date Last Updated")]
        [StringLength(50)]
        public String DateLastUpdated { get; set; }

        //[Display(Name = "Business Data")]
        //public Business BusinessData { get; set; }

        //[Display(Name = "Technical Data")]
        //public Technical TechnicalData { get; set; }

        //[Display(Name = "Cast")]
        //public List<CastMember> Cast { get; set; }

        //[Display(Name = "Directors")]
        //public List<Person> Directors { get; set; }

        //[Display(Name = "Writers")]
        //public List<Person> Writers { get; set; }

        //[Display(Name = "Countries")]
        //public List<Country> Countries { get; set; }

        //[Display(Name = "Filming Locations")]
        //public List<FilmingLocation> FilmingLocations { get; set; }

        //[Display(Name = "Genres")]
        //public List<Genre> Genres { get; set; }

        //[Display(Name = "Languages")]
        //public List<Language> Languages { get; set; }

        //[Display(Name = "Movie Trivia")]
        //public List<MovieTrivia> Trivia { get; set; }

        //[Display(Name = "AKA")]
        //public List<AKA> AKA { get; set; }

        //[Display(Name = "Similar Movies")]
        //public List<SimilarMovie> SimilarMovies { get; set; }

        //[Display(Name = "Movie Quotes")]
        //public List<MovieQuote> MovieQuotes { get; set; }

        //[Display(Name = "Goofs")]
        //public List<Goof> Goofs { get; set; }

        //[Display(Name = "Simple Episodes")]
        //public List<SimpleTVEpisode> Episodes { get; set; }

        //[Display(Name = "Keywords")]
        //public List<Keyword> Keywords { get; set; }


    }
}