using NUnit.Framework;

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
    public void ForcingMultipleButtonsTest()
    {
        var fireButton = "Fire1";
        var jumpButton = "Jump";

        InputHelper.ForceButton(fireButton);
        InputHelper.ForceButton(jumpButton);

        Assert.IsTrue(InputHelper.GetButton(fireButton));
        Assert.IsTrue(InputHelper.GetButton(jumpButton));
    }

    [Test]
    public void ForcingGivenButtonsOnlyTest()
    {
        var fireButton = "Fire1";
        var jumpButton = "Jump";
        var horizontalButton = "Horizontal";

        InputHelper.ForceButton(fireButton);
        InputHelper.ForceButton(jumpButton);

        Assert.IsTrue(InputHelper.GetButton(fireButton));
        Assert.IsTrue(InputHelper.GetButton(jumpButton));
        Assert.IsFalse(InputHelper.GetButton(horizontalButton));
    }

    [Test]
    public void ResetingForcedKeysAndValuesTest()
	{
        var fireButton = "Fire1";
        var axis = "Horizontal";
        var value = 1.0f;
        InputHelper.ForceButton(fireButton);
        InputHelper.ForceAxis(axis, value);

        InputHelper.ResetForced();

        Assert.IsFalse(InputHelper.GetButton(fireButton));
        Assert.AreEqual(0.0f, InputHelper.GetAxis(axis));
    }
}
