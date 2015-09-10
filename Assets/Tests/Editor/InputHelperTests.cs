using NUnit.Framework;

[TestFixture]
public class InputHelperTests
{
    [TearDown]
    public void TearDown()
    {
        InputHelper.ResetForced();
    }

	[Test]
	public void ForceInputButtonTest()
	{
		var buttonToForce = "Horizontal";

		InputHelper.ForceButton(buttonToForce);

		Assert.That(InputHelper.GetButton(buttonToForce), Is.True);
	}

	[Test]
	public void ForceAxisValueTest()
	{
		var axis = "Horizontal";
		var value = 1.0f;

		InputHelper.ForceAxis(axis, value);
        
        Assert.That(InputHelper.GetAxis(axis), Is.EqualTo(value).Within(.0001f));
	}

	[Test]
	public void ForcingValueForGivenAxisOnlyTest()
	{
		var axis = "Horizontal";
		var value = 1.0f;
		
		InputHelper.ForceAxis(axis, value);

        Assert.That(InputHelper.GetAxis("Vertical"), Is.EqualTo(0.0f).Within(.0001f));
    }

    [Test]
    public void ForcingMultipleButtonsTest()
    {
        var fireButton = "Fire1";
        var jumpButton = "Jump";

        InputHelper.ForceButton(fireButton);
        InputHelper.ForceButton(jumpButton);
        
        Assert.That(InputHelper.GetButton(fireButton), Is.True);
        Assert.That(InputHelper.GetButton(jumpButton), Is.True);
    }

    [Test]
    public void ForcingGivenButtonsOnlyTest()
    {
        var fireButton = "Fire1";
        var jumpButton = "Jump";
        var horizontalButton = "Horizontal";

        InputHelper.ForceButton(fireButton);
        InputHelper.ForceButton(jumpButton);
        
        Assert.That(InputHelper.GetButton(fireButton), Is.True);
        Assert.That(InputHelper.GetButton(jumpButton), Is.True);
        Assert.That(InputHelper.GetButton(horizontalButton), Is.False);
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
        
        Assert.That(InputHelper.GetButton(fireButton), Is.False);
        Assert.That(InputHelper.GetAxis(axis), Is.EqualTo(0.0f).Within(.0001f));
    }
}
