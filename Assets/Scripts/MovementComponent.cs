using UnityEngine;
using System.Collections;

public class MovementComponent : MonoBehaviour
{

	IMovementController movementController;

	void Start()
	{
		movementController = new MovementController(this.transform);
	
	}
	
	void Update()
	{
		if (Input.GetButton("Horizontal"))
		{
			movementController.MoveHorizontaly(Input.GetAxis("Horizontal"));
		}
	}
}
