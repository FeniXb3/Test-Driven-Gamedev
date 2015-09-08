using System;
using System.Collections.Generic;

public class InputHelper
{
	private static string buttonToForce;
	private static Dictionary<string, float> valuesToForceOnAxes;
	private static readonly float defaultAxisValue;

	static InputHelper()
	{
		valuesToForceOnAxes = new Dictionary<string, float>();
		defaultAxisValue = 0.0f;
	}

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
		valuesToForceOnAxes[axis] = value;
	}

	public static float GetAxis(string axis)
	{
		return valuesToForceOnAxes.ContainsKey(axis) ? valuesToForceOnAxes[axis] : defaultAxisValue;
	}
}
