namespace MainHero.States
{
	public sealed class Default : State
	{
		public Default(Model actor) : base(actor) { }

		public override void Apply()
		{
			Actor.HorizontalMovement?.EnableInput();
			Actor.UpwardMovement?.EnableInput();
			Actor.SpecialMovement?.EnableInput();
			Actor.BloodSpell0?.EnableInput();
			Actor.BloodSpell1?.EnableInput();
			Actor.UltimateSpell?.EnableInput();
		}
	}
}
