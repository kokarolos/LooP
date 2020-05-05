namespace Loop.Entities
{
    public class ImageFile
    {
        public int ImageFileId { get; set; }
        public string ImgName { get; set; }
        public string ImgPath { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }
    }
}
