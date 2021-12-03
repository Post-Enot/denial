using System.Collections;
using UnityEngine;
using MainHero.States;

namespace MainHero.Actions
{
	[CreateAssetMenu(fileName = "Rolling", menuName = "Actions/Special Movement/Rolling", order = 0)]
	public sealed class Rolling : SpecialMovement
	{
		[SerializeField] private float _duracity;
		[SerializeField] private float _speed;
		[SerializeField] private string _parametersKey;

		private UniqueCoroutine _rollingCoroutine;

		protected override void OnInit()
		{
			_rollingCoroutine = new UniqueCoroutine(Performer, () => Roll());
			EnableInput();
		}

		public override void EnableInput()
		{
			if (!IsInputEnabled)
			{
				InputAction.performed += context => _rollingCoroutine.Start();
				base.EnableInput();
			}
		}
		
		public override void DisableInput()
		{
			if (IsInputEnabled)
			{
				InputAction.performed -= context => _rollingCoroutine.Start();
				base.DisableInput();
			}
		}

		private IEnumerator Roll()
		{
			float time = _duracity;
			var velocity = new Vector2(
				x: Performer.transform.localScale.x * _speed,
				y: Performer.Rigidbody.velocity.y
			);
			Performer.View.SetTrigger(_parametersKey);
			Performer.ChangeState(new Inactive(Performer));
			while (time > 0)
			{
				Performer.Rigidbody.velocity = velocity;
				yield return new WaitForFixedUpdate();
				time -= Time.fixedDeltaTime;
			}
			Performer.ChangeState(new Default(Performer));
		}
	}
}
