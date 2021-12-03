using System;
using UnityEngine;

[Serializable]
public sealed class SpaceOrientation
{
	[SerializeField] private LayerMask _surfaceLayerMask;
	[SerializeField] private Vector2 _groundOverlapBoxSize;
	[SerializeField] private Collider2D _bodyCollider;

	private Bounds _bodyBounds => _bodyCollider.bounds;

	public bool IsGrounded()
	{
		Vector2 origin = CalculateOrigin(
			overlapBoxSize: _groundOverlapBoxSize,
			bounds: new Direction(AxisY.Down)
		);
		return Physics2D.OverlapBox(origin, _groundOverlapBoxSize, angle: 0, _surfaceLayerMask);
	}

	public Vector2 CalculateOrigin(Vector2 overlapBoxSize, Direction bounds)
	{
		overlapBoxSize /= 2;
		Vector2 originOffset = bounds.ToVector(
			x: overlapBoxSize.x + _bodyBounds.extents.x,
			y: overlapBoxSize.y + _bodyBounds.extents.y
		);
		return new Vector2(
			x: _bodyBounds.center.x + originOffset.x,
			y: _bodyBounds.center.y + originOffset.y
		);
	}
}
