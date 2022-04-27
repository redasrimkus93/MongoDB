namespace RobotsManagement
{
    public class Head
    {
        public HeadType HeadType { get; set; }
    }

    public enum HeadType
    {
        Small,
        Medium,
        Large
    }
}