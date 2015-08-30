﻿public class MovementController : IMovementController
{
	private UnityEngine.Transform transform;

	public MovementController(UnityEngine.Transform transform)
	{
		this.transform = transform;
	}

	public UnityEngine.Vector3 StartingPosition { get; set; }

	public float MoveHorizontaly(float value)
	{
		transform.Translate(0.0f, value, 0.0f);

		return transform.position.y;
	}
}