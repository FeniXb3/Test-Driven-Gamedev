public interface IMovementController
{
	UnityEngine.Vector3 StartingPosition { get; set; }

	UnityEngine.Vector3 MoveHorizontaly(float value);
}
