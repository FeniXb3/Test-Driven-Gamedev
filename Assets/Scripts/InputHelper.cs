using System.Collections.Generic;
using UnityEngine;

public class InputHelper
{
    private static Dictionary<string, float> valuesToForceOnAxes;
    private static List<string> forcedButtons;

	static InputHelper()
	{
		valuesToForceOnAxes = new Dictionary<string, float>();
        forcedButtons = new List<string>();
	}

	public static void ForceButton(string buttonName)
	{
        if (!forcedButtons.Contains(buttonName))
        {
            forcedButtons.Add(buttonName);
        }
	}

	public static bool GetButton(string buttonName)
	{
        return forcedButtons.Contains(buttonName) || Input.GetButton(buttonName);
    }

	public static void ForceAxis(string axis, float value)
	{
		valuesToForceOnAxes[axis] = value;
	}

	public static float GetAxis(string axis)
	{
		return valuesToForceOnAxes.ContainsKey(axis) ? valuesToForceOnAxes[axis] : Input.GetAxis(axis);
	}

    public static void ResetForced()
    {
        forcedButtons.Clear();
        valuesToForceOnAxes.Clear();
    }
}
