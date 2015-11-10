namespace Mnemonics
{
	public interface IHumanBeing
	{
        bool IsAlive { get; }
        string Poison();
        string FeedWith(string vitamin);            
	}
}