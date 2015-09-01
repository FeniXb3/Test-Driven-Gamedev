using NUnit.Framework;
using UnityEngine;
using NSubstitute;
using System.Collections.Generic;

[TestFixture]
public class MovementControllerTests
{
	List<GameObject> tempGameObjects;

	[SetUp]
	public void SetUp()
	{
		tempGameObjects = new List<GameObject>();
	}

	[TearDown]
	public void TearDown()
	{
		foreach (var gameObject in tempGameObjects)
		{
			GameObject.DestroyImmediate(gameObject);
		}
		tempGameObjects.Clear();
	}

	[Test]
	public void MoveLeftTest()
	{
		// Arrange
		var startingPosition = new Vector3(0.0f, 0.0f, 0.0f);
		var movementController = GetMockMovementController(startingPosition);
		
		// Act
		var newPosition = movementController.MoveHorizontaly(-1.0f);
		
		// Assert
		var expectedPosition = new Vector3(-1.0f, 0.0f, 0.0f);
		Assert.AreEqual(newPosition, expectedPosition);
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

		Transform transform = CreateTempGameObject().transform;
		var movementController = Substitute.For<MovementController>(transform);
		movementController.StartingPosition = startingPosition;

		return movementController;
	}

	internal GameObject CreateTempGameObject()
	{
		var gameObject = new GameObject();
		tempGameObjects.Add(gameObject);

		return gameObject;
	}
}
