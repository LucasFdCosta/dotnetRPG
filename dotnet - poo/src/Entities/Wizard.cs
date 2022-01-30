namespace dotnet___poo.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

        public override string Attack() {
            return this.Name + " usou uma magia de ataque!";
        }

        public string Attack(int Bonus) {

            if (Bonus > 6) {
                return this.Name + " CAUSOU CRÍTICO!! " + Bonus + " de dano a mais";
            } else {
                return this.Name + " usou uma magia de ataque fraca com bônus de " + Bonus + " de dano";
            }
        }
    }
}