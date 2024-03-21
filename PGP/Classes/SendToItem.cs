namespace PGP
{
    public class SendToItem
    {
        public string FileName { get; set; }

        public string DisplayName { get; set; }

        public override string ToString()
        {
            return DisplayName;
        }
    }
}
