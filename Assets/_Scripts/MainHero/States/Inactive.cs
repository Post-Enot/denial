namespace MainHero.States
{
	public sealed class Inactive : State
	{
		public Inactive(Model actor) : base(actor) { }

		public override void Apply()
		{
			Actor.HorizontalMovement?.DisableInput();
			Actor.UpwardMovement?.DisableInput();
			Actor.SpecialMovement?.DisableInput();
			Actor.BloodSpell0?.DisableInput();
			Actor.BloodSpell1?.DisableInput();
			Actor.UltimateSpell?.DisableInput();
		}
	}
}
