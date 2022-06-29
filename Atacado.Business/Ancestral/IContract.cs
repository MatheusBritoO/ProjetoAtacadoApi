namespace Atacado.Business.Ancestral
{
    public interface IContract
    {
        bool IsValidate { get; }

        List<IRule> Rules { get; }

        List<string> Messages { get; }

        bool Validate();

    }
}
