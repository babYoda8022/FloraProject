using Flora.Enumerator;

namespace Flora.Base
{
    public partial class BaseFlora
    {

        private EnumRarityFlora _rarity = EnumRarityFlora.None;
        internal EnumRarityFlora Rarity { get { return _rarity; } }
        internal void SetRarity(EnumRarityFlora rarity)
        {
            _rarity = rarity;
        }
    }
}
