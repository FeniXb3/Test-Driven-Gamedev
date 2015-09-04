using UnityEngine;

public class MovementController : IMovementController
{
	public Vector3 Position
	{
		get
		{
			return transform.position;
		}
	}

	private Transform transform;

	public MovementController(Transform transform)
	{
		this.transform = transform;
	}

	public MovementController(Transform transform, Vector3 startingPosition)
	{
		this.transform = transform;
		this.transform.Translate(startingPosition);
	}

	public Vector3 MoveHorizontaly(float value)
	{
		transform.Translate(value, 0.0f, 0.0f);

		return transform.position;
	}
}
