using System.Collections.Generic;

public class InputHelper
{
    private static Dictionary<string, float> valuesToForceOnAxes;
    private static List<string> forcedButtons;
    private static readonly float defaultAxisValue;

	static InputHelper()
	{
		valuesToForceOnAxes = new Dictionary<string, float>();
        forcedButtons = new List<string>();
		defaultAxisValue = 0.0f;
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
        return forcedButtons.Contains(buttonName);
    }

	public static void ForceAxis(string axis, float value)
	{
		valuesToForceOnAxes[axis] = value;
	}

	public static float GetAxis(string axis)
	{
		return valuesToForceOnAxes.ContainsKey(axis) ? valuesToForceOnAxes[axis] : defaultAxisValue;
	}

    public static void ResetForced()
    {
        forcedButtons.Clear();
        valuesToForceOnAxes.Clear();
    }
}
