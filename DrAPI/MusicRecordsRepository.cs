namespace DrAPI
{
    public class MusicRecordsRepository
    {
        private List<MusicRecord> _musicRecords = new List<MusicRecord>()
        {
            new MusicRecord { Title = "The Dark Side of the Moon", Artist = "Pink Floyd", DurationInSeconds = 2580, PublicationYear = 1973 },
            new MusicRecord { Title = "Back in Black", Artist = "AC/DC", DurationInSeconds = 2540, PublicationYear = 1980 },
            new MusicRecord { Title = "The Bodyguard", Artist = "Whitney Houston", DurationInSeconds = 2730, PublicationYear = 1992 },
            new MusicRecord { Title = "Bat Out of Hell", Artist = "Meat Loaf", DurationInSeconds = 2550, PublicationYear = 1977 },
            new MusicRecord { Title = "Their Greatest Hits (1971-1975)", Artist = "Eagles", DurationInSeconds = 2540, PublicationYear = 1976 },
            new MusicRecord { Title = "Saturday Night Fever", Artist = "Bee Gees", DurationInSeconds = 2540, PublicationYear = 1977 },
            new MusicRecord { Title = "Rumours", Artist = "Fleetwood Mac", DurationInSeconds = 2560, PublicationYear = 1977 },
            new MusicRecord { Title = "Grease", Artist = "Various Artists", DurationInSeconds = 2540, PublicationYear = 1978 },
            new MusicRecord { Title = "The Joshua Tree", Artist = "U2", DurationInSeconds = 3130, PublicationYear = 1987 },
            new MusicRecord { Title = "Thriller", Artist = "Michael Jackson", DurationInSeconds = 4220, PublicationYear = 1982 },
            new MusicRecord { Title = "The Wall", Artist = "Pink Floyd", DurationInSeconds = 4010, PublicationYear = 1979 },
            new MusicRecord { Title = "Greatest Hits", Artist = "Queen", DurationInSeconds = 2540, PublicationYear = 1981 },
            new MusicRecord { Title = "Hysteria", Artist = "Def Leppard", DurationInSeconds = 3870, PublicationYear = 1987 },
            new MusicRecord { Title = "Born in the U.S.A.", Artist = "Bruce Springsteen", DurationInSeconds = 2740, PublicationYear = 1984 },
            new MusicRecord { Title = "Brothers in Arms", Artist = "Dire Straits", DurationInSeconds = 3940, PublicationYear = 1985 },
            new MusicRecord { Title = "Bad", Artist = "Michael Jackson", DurationInSeconds = 4080, PublicationYear = 1987 },
        };

        public IEnumerable<MusicRecord> GetAll(string? title = null, string? artist = null, string? orderBy = null)
        {
            IEnumerable<MusicRecord> result = new List<MusicRecord>(_musicRecords);
            if (title != null)
            {
                result = result.Where(m => m.Title.Contains(title));
            }
            if (artist != null)
            {
                result = result.Where(m => m.Artist.Contains(artist));
            }
            if (orderBy != null)
            {
                switch (orderBy)
                {
                    case "title":
                        result = result.OrderBy(m => m.Title);
                        break;
                    case "artist":
                        result = result.OrderBy(m => m.Artist);
                        break;
                    case "duration":
                        result = result.OrderBy(m => m.DurationInSeconds);
                        break;
                    case "publicationYear":
                        result = result.OrderBy(m => m.PublicationYear);
                        break;
                    default:
                        break;
                }
            }

            return result;
        }

        //public MusicRecord GetByTitle(string title)
        //{
        //    return _musicRecords.FirstOrDefault(m => m.Title == title);
        //}

        public void Add(MusicRecord musicRecord)
        {
            musicRecord.ValidateTitle();
            musicRecord.ValidateArtist();
            musicRecord.ValidateDuration();
            musicRecord.ValidatePublicationYear();

            _musicRecords.Add(musicRecord);
        }


      
        


      

    }
}
