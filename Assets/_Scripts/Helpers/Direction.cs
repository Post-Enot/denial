using UnityEngine;

public readonly struct Direction
{
	public readonly AxisX x;
	public readonly AxisY y;

	public Direction(AxisX x, AxisY y)
	{
		this.x = x;
		this.y = y;
	}

	public Direction(AxisX x)
	{
		this.x = x;
		y = AxisY.None;
	}

	public Direction(AxisY y)
	{
		x = AxisX.None;
		this.y = y;
	}

	public Vector2 ToVector(float x, float y, float xDefaultValue = 0, float yDefaultValue = 0)
	{
		var vector = new Vector2(xDefaultValue, yDefaultValue);
		if (this.x != AxisX.None)
		{
			vector.x = this.x == AxisX.Right ? x : -x;
		}
		if (this.y != AxisY.None)
		{
			vector.y = this.y == AxisY.Up ? y : -y;
		}
		return vector;
	}
}
