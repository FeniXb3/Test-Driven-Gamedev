using System;

public class InputHelper
{
    private static string buttonToForce;
    private static string axisToForce;
    private static float axisValueToForce;

    public static void ForceButton(string buttonName)
    {
        buttonToForce = buttonName;
    }

    public static bool GetButton(string buttonName)
    {
        return buttonToForce == buttonName;
    }

    public static void ForceAxis(string axis, float value)
    {
        axisToForce = axis;
        axisValueToForce = value;
    }

    public static float GetAxis(string axis)
    {
        return axisValueToForce;
    }
}
