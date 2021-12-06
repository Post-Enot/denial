using UnityEngine;
using System.Collections;

public sealed class DefaultBullet : Bullet
{
	[SerializeField] private int _damage;
	[SerializeField] private float _flightSpeed;

	public bool IsFLy { get; private set; }

	private Coroutine _flight;
	private Rigidbody2D _rigidbody;

	private void Awake()
	{
		_rigidbody = GetComponent<Rigidbody2D>();
	}

	public override void Fire(Vector2 direction)
	{
		direction = direction.normalized * _flightSpeed;
		_flight = StartCoroutine(Flight(direction));
	}

	private IEnumerator Flight(Vector2 direction)
	{
		IsFLy = true;
		while (true)
		{
			_rigidbody.velocity = direction;
			yield return new WaitForFixedUpdate();
		}
	}

	public override int GetDamage()
	{
		return _damage;
	}
}
