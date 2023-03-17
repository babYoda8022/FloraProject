using Flora.Enumerator;

namespace Flora.Base
{
    public partial class BaseFlora
    {
        internal EnumColorFlora _color = EnumColorFlora.Blue;
        internal EnumColorFlora Color { get { return _color; } }

        internal void SetRandomColor()
        {
            int randomColor = new Random().Next(0, 4);
            _color = (EnumColorFlora)randomColor;
        }
    }
}
