using System.Collections;
using UnityEngine;

namespace MainHero
{
	public sealed class View : MonoBehaviour
	{
		[Header("Animators:")]
		[SerializeField] private Animator _animator;

		[Header("Parameter keys:")]
		[SerializeField] private string _horizontalVelocityKey;
		[SerializeField] private string _verticalVelocityKey;

		public UniqueCoroutine<Rigidbody2D> VelocityParameterUpdating { get; private set; }

		private void Awake()
		{
			VelocityParameterUpdating = new UniqueCoroutine<Rigidbody2D>(
				performer: this,
				getRoutine: rigidbody => UpdateVelocityParameters(rigidbody)
			);
		}

		public void SetTrigger(string paramKey)
		{
			_animator.SetTrigger(paramKey);
		}

		private IEnumerator UpdateVelocityParameters(Rigidbody2D rigidbody)
		{
			while (true)
			{
				_animator.SetFloat(_horizontalVelocityKey, Mathf.Abs(rigidbody.velocity.x));
				_animator.SetFloat(_verticalVelocityKey, rigidbody.velocity.y);
				yield return null;
			}
		}
	}
}
