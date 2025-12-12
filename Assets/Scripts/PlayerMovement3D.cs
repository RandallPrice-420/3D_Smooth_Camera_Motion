using UnityEngine;


public class PlayerMovement3D : MonoBehaviour
{
    public float      Speed = 20;

    private Rigidbody _rb;
    private Vector3   _motion;
    private bool      _canDebug;


    #region .  Start()  .
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _canDebug = DebugManager.Instance.IsLogOn;

    }   // Start()
    #endregion


    #region .  LateUpdate()  .
    void LateUpdate()
    {
        this._motion      = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        this._rb.velocity = _motion * Speed;

        if (_canDebug) DebugManager.Instance.Log($"Horizontal:  {Input.GetAxisRaw("Horizontal")}, Vertical:  {Input.GetAxisRaw("Vertical")}");

    }   // LateUpdate()
    #endregion


}   // class PlayerMovement3D
