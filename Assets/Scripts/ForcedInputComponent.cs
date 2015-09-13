using UnityEngine;

public class ForcedInputComponent : MonoBehaviour
{
    public string buttonToForce;
    [Range(-1, 1)]
    public float axisValueToForce = float.NaN;

    void Start()
    {
        if (!string.IsNullOrEmpty(buttonToForce))
        {
            InputHelper.ForceButton(buttonToForce);
        }

        if (!float.IsNaN(axisValueToForce))
        {
            InputHelper.ForceAxis(buttonToForce, axisValueToForce);
        }
    }
}
