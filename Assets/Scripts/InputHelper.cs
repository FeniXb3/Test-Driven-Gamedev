using System;

public class InputHelper
{
    private static string buttonToForce;

    public static void ForceButton(string buttonName)
    {
        buttonToForce = buttonName;
    }

    public static bool GetButton(string buttonName)
    {
        return buttonToForce == buttonName;
    }
}
