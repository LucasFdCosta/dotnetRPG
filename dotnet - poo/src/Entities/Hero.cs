namespace dotnet___poo.src.Entities
{
    public abstract class Hero
    {
        public string Name;
        public int Level;
        public string HeroType;
        public int HP;
        public int MP;
                
        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack(){
            return this.Name + " atacou com a espada!";
        }
    }
}