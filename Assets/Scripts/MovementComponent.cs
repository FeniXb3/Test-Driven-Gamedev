using UnityEngine;

public class MovementComponent : MonoBehaviour
{
	public Vector3 startingPosition;

	IMovementController movementController;

	void Start()
	{
		movementController = new MovementController(this.transform, startingPosition);	
	}
	
	void Update()
	{
		if (InputHelper.GetButton("Horizontal"))
		{
			movementController.MoveHorizontaly(InputHelper.GetAxis("Horizontal"));
		}
	}
}
