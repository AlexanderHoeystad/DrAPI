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



    }



}
