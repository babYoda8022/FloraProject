using Flora.Base;

namespace Flora.Floras
{
    public class StandardFlora : BaseFlora
    {
       public StandardFlora(string name, int life)
       {
            Name = name;
            SetIsAlive(true);
            _life = life;
            _maxLife = life;
            SetRandomPersonality();
            SetRandomMood();
            SetRandomColor();
       }
    }
}
