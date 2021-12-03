using UnityEngine;

public sealed class DefaultBullet : Bullet
{
	[SerializeField] private int _damage;

	public override int GetDamage()
	{
		return _damage;
	}
}
