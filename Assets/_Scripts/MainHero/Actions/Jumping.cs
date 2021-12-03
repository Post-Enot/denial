using UnityEngine;

namespace MainHero.Actions
{
	[CreateAssetMenu(fileName = "Jumping", menuName = "Actions/Upward Movement/Jumping", order = 0)]
	public sealed class Jumping : UpwardMovement
	{
		[SerializeField] private float _defaultJumpForce;

		public float DefaultJumpForce => _defaultJumpForce;

		protected override void OnInit()
		{
			EnableInput();
		}

		public override void EnableInput()
		{
			if (!IsInputEnabled)
			{
				InputAction.performed += context => Jump();
				base.EnableInput();
			}
		}

		public override void DisableInput()
		{
			if (IsInputEnabled)
			{
				InputAction.performed -= context => Jump();
				base.DisableInput();
			}
		}

		private void Jump()
		{
			if (Performer.SpaceOrientation.IsGrounded())
			{
				Performer.Rigidbody.velocity = new Vector2(Performer.Rigidbody.velocity.x, DefaultJumpForce);
			}
		}
	}
}
