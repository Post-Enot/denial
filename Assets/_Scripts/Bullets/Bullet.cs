using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
	public abstract int GetDamage();
	public abstract void Fire(Vector2 direction);
}
