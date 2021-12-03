using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace MainHero.Actions
{
	[CreateAssetMenu(fileName = "Walking", menuName = "Actions/Horizontal Movement/Walking", order = 0)]
	public sealed class Walking : HorizontalMovement
	{
		[SerializeField] private float _defaultMovementSpeed;

		private const int _defaultScale = 1;
		private const int _inverseScale = -1;

		public Func<float> CalculateMoveFactor { get; private set; }
		public float DefaultMovementSpeed => _defaultMovementSpeed;

		private UniqueCoroutine _movementCoroutine;
		private UniqueCoroutine _flipmentCoroutine;

		protected override void OnInit()
		{
			EnableInput();
			void ReinitCoroutine(ref UniqueCoroutine coroutine, Func<IEnumerator> getRoutine)
			{
				coroutine?.Stop();
				coroutine = new UniqueCoroutine(Performer, getRoutine);
				coroutine.Start();
			}
			ReinitCoroutine(ref _movementCoroutine, () => Move());
			ReinitCoroutine(ref _flipmentCoroutine, () => Flip());
		}

		public override void EnableInput()
		{
			base.EnableInput();
			CalculateMoveFactor = () => InputAction.ReadValue<float>();
		}

		public override void DisableInput()
		{
			base.DisableInput();
			CalculateMoveFactor = () => 0;
		}

		public override void Disable()
		{
			_movementCoroutine.Stop();
			_flipmentCoroutine.Stop();
			DisableInput();
		}

		private IEnumerator Move()
		{
			while (true)
			{
				float movementSpeed = DefaultMovementSpeed * CalculateMoveFactor();
				Performer.Rigidbody.velocity = new Vector2(movementSpeed, Performer.Rigidbody.velocity.y);
				yield return new WaitForFixedUpdate();
			}
		}

		private IEnumerator Flip()
		{
			while (true)
			{
				float moveFactor = CalculateMoveFactor();
				if (moveFactor != 0)
				{
					Performer.transform.localScale = new Vector3(
						x: moveFactor > 0 ? _defaultScale : _inverseScale,
						y: _defaultScale,
						z: _defaultScale
					);
				}
				yield return new WaitForFixedUpdate();
			}
		}
	}
}
