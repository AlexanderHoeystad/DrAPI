namespace DrAPI
{
    public class MusicRecord
    {
        public string? Title { get; set; }
        public string? Artist { get; set; }
        public int? Duration { get; set; }
        public int? publicationYear { get; set; }



        public override string ToString()
        {
            return $"{Title} by {Artist} ({publicationYear}) {Duration}";
        }


        public void Validate()
        {
            if (string.IsNullOrEmpty(Title))
            {
                throw new Exception("Title is required");
            }
            if (string.IsNullOrEmpty(Artist))
            {
                throw new Exception("Artist is required");
            }
            if (Duration == null)
            {
                throw new Exception("Duration is required");
            }
            if (publicationYear == null)
            {
                throw new Exception("publicationYear is required");
            }
        }



    }




}
