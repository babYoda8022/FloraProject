using Flora.Base;

namespace Flora.Floras
{
    public class StandardFlora : BaseFlora
    {
       public StandardFlora(string name, int life)
       {
            Name = name;
            SetIsAlive(true);
            Life = life;
            SetMaxLife(life);
            SetRandomPersonality();
            SetRandomMood();
            SetRandomColor();
       }
    }
}
