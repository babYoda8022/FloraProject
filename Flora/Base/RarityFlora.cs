using Flora.Enumerator;

namespace Flora.Base
{
    public partial class BaseFlora
    {

        protected EnumRarityFlora _rarity = EnumRarityFlora.None;
        public EnumRarityFlora Rarity { get { return _rarity; } }
    }
}
