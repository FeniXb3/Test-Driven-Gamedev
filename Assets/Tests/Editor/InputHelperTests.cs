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
        Assert.AreEqual(0.0f, InputHelper.GetAxis("Vertical"));
    }
}
