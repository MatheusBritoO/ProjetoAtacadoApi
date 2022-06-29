namespace Atacado.Business.Ancestral
{
    public interface IRule
    {

        List<string> RuleMessages { get; }
        bool Process();
    }
}
