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
		var newPositionY = movementController.MoveHorizontaly(-1.0f)
		
		// Assert
		Assert.Less(newPositionY, startingPositionY);
	}

	internal IMovementController GetMockMovementController(Vector3 startingPosition)
	{
		var movementController = Substitute.For<MovementController>();
		movementController.StartingPosition = startingPosition;

		return moveController;
	}
}
