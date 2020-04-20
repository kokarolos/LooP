namespace Loop.Entities
{
    //TODO: Implement Datetime property as Reply Creation Datetime
    public class Reply
    {
        public int ReplyId { get; set; }
        public string Text { get; set; }

        public int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
