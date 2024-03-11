namespace Raiding.Models;

public abstract class Fighter : BaseHero
{
    protected Fighter(string name) : base(name) { }

    public override string CastAbility()
    {
        return $"{base.CastAbility()} hit for {this.Power} damage";
    }
}
