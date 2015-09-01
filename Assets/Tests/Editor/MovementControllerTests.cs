using NUnit.Framework;
using UnityEngine;
using NSubstitute;

[TestFixture]
public class MovementControllerTests
{
	[Test]
	public void MoveLeftTest()
	{
		// Arrange
		var startingPositionY = 0.0f;
		var movementController = GetMockMovementController(new Vector3(0.0f, startingPositionY, 0.0f));
		
		// Act
		var newPositionY = movementController.MoveHorizontaly(-1.0f);
		
		// Assert
		Assert.Less(newPositionY, startingPositionY);
	}

	[Test]
	public void MoveRightTest()
	{
		// Arrange
		var startingPositionY = 0.0f;
		var movementController = GetMockMovementController(new Vector3(0.0f, startingPositionY, 0.0f));
		
		// Act
		var newPositionY = movementController.MoveHorizontaly(1.0f);
		
		// Assert
		Assert.Greater(newPositionY, startingPositionY);
	}

	internal IMovementController GetMockMovementController(Vector3 startingPosition)
	{
		Transform transform = new GameObject().transform;
		var movementController = Substitute.For<MovementController>(transform);
		movementController.StartingPosition = startingPosition;

		return movementController;
	}
}
