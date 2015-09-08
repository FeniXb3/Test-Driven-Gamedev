﻿using NUnit.Framework;

[TestFixture]
public class InputHelperTests
{
	[Test]
	public void ForceInputButtonTest()
	{
		var buttonToForce = "Horizontal";

		InputHelper.ForceButton(buttonToForce);

		Assert.AreEqual(true, InputHelper.GetButton(buttonToForce));
	}

	[Test]
	public void ForceAxisValueTest()
	{
		var axis = "Horizontal";
		var value = 1.0f;

		InputHelper.ForceAxis(axis, value);

		Assert.AreEqual(value, InputHelper.GetAxis(axis));
	}

	[Test]
	public void ForcingValueForGivenAxisOnlyTest()
	{
		var axis = "Horizontal";
		var value = 1.0f;
		
		InputHelper.ForceAxis(axis, value);

		Assert.AreEqual(0.0f, InputHelper.GetAxis("Vertical"));
	}

	[Test]
	[Ignore("Test added to not forget about the issue of not reseting keys after test")]
	public void ResetingForcedKeysAndValuesTest()
	{
		
	}
}
