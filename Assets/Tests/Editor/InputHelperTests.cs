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
}
