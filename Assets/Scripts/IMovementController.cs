public interface IMovementController
{
	UnityEngine.Vector3 Position { get; }

	UnityEngine.Vector3 MoveHorizontaly(float value);
}
