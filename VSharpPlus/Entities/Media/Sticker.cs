namespace VSharpPlus.Entities.Media
{
    public class Sticker
    {
        public int Id { get; internal set; }
        public int ProductId { get; internal set; }
        public string Photo64 { get; internal set; }
        public string Photo128 { get; internal set; }
        public string Photo256 { get; internal set; }
        public string Photo352 { get; internal set; }
        public int Width { get; internal set; }
        public int Height { get; internal set; }
    }
}