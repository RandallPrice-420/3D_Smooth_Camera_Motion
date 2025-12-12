using UnityEngine;


public class DebugManager : Singleton<DebugManager>
{
    // --------------------------------------------------------------
    // Public Properties:
    // ------------------
    //   IsLogOn
    // --------------------------------------------------------------

    #region .  Public Properties  .

    public bool IsLogOn = true;

    #endregion


    // float
    public void Log(float value)
    {
        if (IsLogOn) Debug.Log(value.ToString());

    }   // Log()


    // bool
    public void Log(bool value)
    {
        if (IsLogOn) Debug.Log(value.ToString());

    }   // Log()


    // int
    public void Log(int value)
    {
        if (IsLogOn) Debug.Log(value.ToString());

    }   // Log()


    // string
    public void Log(string value)
    {
        if (IsLogOn) Debug.Log(value);

    }   // Log()


    // Vector2
    public void Log(Vector2 value)
    {
        if (IsLogOn) Debug.Log($"X: {value.x}, Y: {value.y}");

    }   // Log()


    // Vector3
    public void Log(Vector3 value)
    {
        if (IsLogOn) Debug.Log($"Xx: {value.x}, Y: {value.y}, Z: {value.z}");

    }   // Log()


}   // DebugManager
