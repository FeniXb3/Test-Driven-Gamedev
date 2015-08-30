using NUnit.Framework;
using UnityEngine;
using NSubstitute;

[TestFixture]
public class MoverTests
{
	[Test]
	public void MoveLeftTest()
	{
		// Arrange
		var startingPositionY = 0.0f;
		var mover = GetMockMover(new Vector3(0.0f, startingPositionY, 0.0f));

		// Act
		var newPositionY = mover.MoveHorizontaly(-1.0f)
		
		// Assert
		Assert.Less(newPositionY, startingPositionY);
	}

	internal IMover GetMockMover(Vector3 startingPosition)
	{
		var mover = Substitute.For<Mover>();
		mover.StartingPosition = startingPosition;

		return mover;
	}
}
