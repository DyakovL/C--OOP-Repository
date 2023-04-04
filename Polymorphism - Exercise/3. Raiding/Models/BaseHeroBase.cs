namespace _3._Raiding.Models
{
    public abstract class BaseHeroBase
    {
        public string Name { get; private set; }

        public string CastAbility()
        {
            throw new NotImplementedException();
        }
    }
}