using System.Collections;
using UnityEngine;
using MainHero.States;

namespace MainHero.Actions
{
	[CreateAssetMenu(fileName = "DefaultShot", menuName = "Actions/Weapon Action/Default Shot", order = 0)]
	public sealed class DefaultShot : WeaponAction
	{
		[SerializeField] private float _stunDuration;
		[SerializeField] private string _parametersKey;

		private UniqueCoroutine _shootingCoroutine;

		protected override void OnInit()
		{
			_shootingCoroutine = new UniqueCoroutine(Performer, () => Shooting());
		}

		public override void EnableInput()
		{
			if (!IsInputEnabled)
			{
				InputAction.performed += context => _shootingCoroutine.Start();
				base.EnableInput();
			}
		}

		public override void DisableInput()
		{
			if (IsInputEnabled)
			{
				InputAction.performed += context => _shootingCoroutine.Stop();
				base.DisableInput();
			}
		}

		private IEnumerator Shooting()
		{
			Performer.View.SetTrigger(_parametersKey);
			Performer.ChangeState(new Inactive(Performer));
			yield return new WaitForSeconds(_stunDuration);
			Performer.ChangeState(new Default(Performer));
		}
	}
}
