
namespace ColorCombination
{
    public class MyChip
    {
        public string Left { set; get; }
        public string Right { set; get; }

        public MyChip() { }

        public MyChip(string left, string right)
        {
            Left = left;
            Right = right;
        }
    }
}
