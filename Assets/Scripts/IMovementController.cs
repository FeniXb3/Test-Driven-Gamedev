public interface IMovementController
{
	UnityEngine.Vector3 StartingPosition { get; set; }

	float MoveHorizontaly(float value);
}
