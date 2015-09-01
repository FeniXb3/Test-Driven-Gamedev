public class MovementController : IMovementController
{
	private UnityEngine.Transform transform;

	public MovementController(UnityEngine.Transform transform)
	{
		this.transform = transform;
	}

	public UnityEngine.Vector3 StartingPosition { get; set; }

	public UnityEngine.Vector3 MoveHorizontaly(float value)
	{
		transform.Translate(value, 0.0f, 0.0f);

		return transform.position;
	}
}
