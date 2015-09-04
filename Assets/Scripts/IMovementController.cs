using UnityEngine;

public interface IMovementController
{
	Vector3 Position { get; }

	Vector3 MoveHorizontaly(float value);
}
