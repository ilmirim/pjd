using System.Windows.Forms;
using System.Drawing;
namespace Game
{
    public class Vector2
    {
        public int x;
        public int y;

        public Point ToPoint(int _x, int _y)
        {
            return new Point(_x, _y);
        }
    }
}
