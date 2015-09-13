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
        if (!Mathf.Approximately(InputHelper.GetAxis("Horizontal"), 0.0f))
		{
            movementController.MoveHorizontaly(InputHelper.GetAxis("Horizontal"));
		}
	}
}
