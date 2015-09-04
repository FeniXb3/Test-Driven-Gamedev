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
		var movementController = GetMockMovementController();
		
		// Act
		var newPosition = movementController.MoveHorizontaly(-1.0f);
		
		// Assert
		var expectedPosition = new Vector3(-1.0f, 0.0f, 0.0f);
		Assert.AreEqual(expectedPosition, newPosition);
	}

	[Test]
	public void MoveRightTest()
	{
		// Arrange
		var movementController = GetMockMovementController();
		
		// Act
		var newPosition = movementController.MoveHorizontaly(1.0f);
		
		// Assert
		var expectedPosition = new Vector3(1.0f, 0.0f, 0.0f);
		Assert.AreEqual(expectedPosition, newPosition);
	}

	[Test]
	public void SetPositionOnCreationTest()
	{
		var startingPotition = new Vector3(1.0f, 1.0f, 0.0f);
		var expectedPosition = new Vector3(1.0f, 1.0f, 0.0f);

		var movementController = GetMockMovementController(startingPotition);

		var newPosition = movementController.Position;
		Assert.AreEqual(expectedPosition, newPosition);
	}

	[Test]
	public void ResetPositionTest()
	{
		var startingPosition = new Vector3(10.0f, 1.0f, 0.0f);
		var expectedPosition = new Vector3(10.0f, 1.0f, 0.0f);
		var movementController = GetMockMovementController(startingPosition);
		movementController.MoveHorizontaly(-5.0f);

		movementController.ResetPosition();

		Assert.AreEqual(expectedPosition, movementController.Position);
	}

	
	internal IMovementController GetMockMovementController()
	{
		
		Transform transform = CreateTempGameObject().transform;
		var movementController = Substitute.For<MovementController>(transform);
		
		return movementController;
	}

	internal IMovementController GetMockMovementController(Vector3 startingPosition)
	{

		Transform transform = CreateTempGameObject().transform;
		var movementController = new MovementController(transform, startingPosition);

		return movementController;
	}

	internal GameObject CreateTempGameObject()
	{
		var gameObject = new GameObject();
		tempGameObjects.Add(gameObject);

		return gameObject;
	}
}
