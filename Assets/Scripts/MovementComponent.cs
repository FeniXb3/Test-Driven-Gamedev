using UnityEngine;
using System.Collections;

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
		if (Input.GetButton("Horizontal"))
		{
			movementController.MoveHorizontaly(Input.GetAxis("Horizontal"));
		}
	}
}
