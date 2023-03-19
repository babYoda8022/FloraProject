using Flora.Enumerator;

namespace Flora.Base
{
    public partial class BaseFlora
    {
        private EnumColorFlora _color = EnumColorFlora.Blue;
        public EnumColorFlora Color { get { return _color; } }

        protected void SetRandomColor()
        {
            int randomColor = new Random().Next(0, 4);
            _color = (EnumColorFlora)randomColor;
        }
    }
}
