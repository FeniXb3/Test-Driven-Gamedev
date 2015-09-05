using UnityEngine;

public class MovementController : IMovementController
{
	public Vector3 StartingPosition { get; set; }

	public Vector3 Position
	{
		get
		{
			return transform.position;
		}
	}

	private Transform transform;

	public MovementController(Transform transform) 
		: this(transform, new Vector3(0.0f, 0.0f, 0.0f))
	{
	}

	public MovementController(Transform transform, Vector3 startingPosition)
	{
		this.transform = transform;
        StartingPosition = startingPosition;
		this.transform.Translate(StartingPosition);
	}

	public Vector3 MoveHorizontaly(float value)
	{
		transform.Translate(value, 0.0f, 0.0f);

		return transform.position;
	}

	public void ResetPosition()
	{
		transform.position = StartingPosition;
	}
}
