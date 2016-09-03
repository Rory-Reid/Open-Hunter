namespace OpenHunter.GameCore
{
	public interface IMonoGameConfig
	{
		/// <summary>
		/// Configures the active game, to be called immediately in the Game's constructor with a reference to itself
		/// </summary>
		/// <param name="game">The game currently active</param>
		void SetActiveGame(IActiveGame game);
	}
}
