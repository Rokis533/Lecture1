namespace FileApiExample.Model
{
    public class Photo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContentType { get; set; }
        public byte[] ImageData { get; set; } // saving file in database
        //public string FilePath { get; set; } //saving file in file system (PC/Server)
    }
}
