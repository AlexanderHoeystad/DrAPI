namespace DrAPI
{
    public class MusicRecord
    {
        public string? Title { get; set; }
        public string? Artist { get; set; }
        public int? DurationInSeconds { get; set; }
        public int? PublicationYear { get; set; }



        public override string ToString()
        {
            return $"{Title} by {Artist} ({PublicationYear}) Duration In Seconds: {DurationInSeconds}";
        }


        public void ValidateTitle()
        {
            if (string.IsNullOrEmpty(Title))
            {
                throw new ArgumentNullException("Title is required");
            }
            if (Title.Length < 2)
            {
                throw new ArgumentOutOfRangeException("Title must be at least 2 characters long");
            }
        }

        public void ValidateArtist()
        {
            if (string.IsNullOrEmpty(Artist))
            {
                throw new ArgumentNullException("Artist is required");
            }
            if (Artist.Length < 2)
            {
                throw new ArgumentOutOfRangeException("Artist must be at least 2 characters long");
            }
        }

        public void ValidateDuration()
        {
            if (DurationInSeconds == null)
            {
                throw new ArgumentNullException("Duration is required");
            }
            if (DurationInSeconds < 0)
            {
                throw new ArgumentOutOfRangeException("Duration must be a positive number");
            }
        }

        public void ValidatePublicationYear()
        {
            if (PublicationYear == null)
            {
                throw new ArgumentNullException("Publication year is required");
            }
            if (PublicationYear < 1860)
            {
                throw new ArgumentOutOfRangeException("Publication year must be higher than 1860");
            }
        }

        public void Validate()
        {
            ValidateTitle();
            ValidateArtist();
            ValidateDuration();
            ValidatePublicationYear();
        }

    }




}
