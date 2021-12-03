namespace MainHero.States
{
	public abstract class State
	{
		protected Model Actor;

		public State(Model actor)
		{
			Actor = actor;
		}

		public abstract void Apply();
	}
}
