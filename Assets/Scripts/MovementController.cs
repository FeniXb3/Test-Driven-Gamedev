public class MovementController : IMovementController
{
	public UnityEngine.Vector3 Position
	{
		get
		{
			return transform.position;
		}
	}

	private UnityEngine.Transform transform;

	public MovementController(UnityEngine.Transform transform)
	{
		this.transform = transform;
	}

	public MovementController(UnityEngine.Transform transform, UnityEngine.Vector3 startingPosition)
	{
		this.transform = transform;
		this.transform.Translate(startingPosition);
	}

	public UnityEngine.Vector3 MoveHorizontaly(float value)
	{
		transform.Translate(value, 0.0f, 0.0f);

		return transform.position;
	}
}
