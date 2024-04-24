namespace DrAPI
{
    public class MusicRecord
    {
        public string? Title { get; set; }
        public string? Artist { get; set; }
        public int? DurationInSeconds { get; set; }
        public int? publicationYear { get; set; }



        public override string ToString()
        {
            return $"{Title} by {Artist} ({publicationYear}) {DurationInSeconds}";
        }


        public void ValidateTitle()
        {
            if (string.IsNullOrEmpty(Title))
            {
                throw new Exception("Title is required");
            }
            if (Title.Length < 2)
            {
                throw new Exception("Title must be at least 2 characters long");
            }
        }

        public void ValidateArtist()
        {
            if (string.IsNullOrEmpty(Artist))
            {
                throw new Exception("Artist is required");
            }
            if (Artist.Length < 2)
            {
                throw new Exception("Artist must be at least 2 characters long");
            }
        }

        public void ValidateDuration()
        {
            if (DurationInSeconds == null)
            {
                throw new Exception("Duration is required");
            }
            if (DurationInSeconds < 0)
            {
                throw new Exception("Duration must be a positive number");
            }
        }

        public void ValidatePublicationYear()
        {
            if (publicationYear == null)
            {
                throw new Exception("Publication year is required");
            }
            if (publicationYear < 1860)
            {
                throw new Exception("Publication year must be higher than 1860");
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
