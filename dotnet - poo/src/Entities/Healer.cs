namespace dotnet___poo.src.Entities
{
    public class Healer : Hero
    {
        public Healer(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

        public string Heal(int HP, Knight knight) {
            knight.HP += HP;
            return this.Name + " curou " + HP + " de vida de " + knight.Name;
        }
    }
}