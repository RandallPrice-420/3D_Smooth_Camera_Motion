using UnityEngine;


public class PlayerTracker : MonoBehaviour
{
    public  Transform    trackedObject;
    public  float        maxDistance  = 16;
    public  float        minDistance  =  5;
    public  float        moveSpeed    = 26;
    public  float        updateSpeed  = 16;
    public  float        hideDistance = 1.5f;

    [Range(5, 16)]
    public float currentDistance = 5;


    private bool         _canDebug;
    private GameObject   _ahead;
    private MeshRenderer _renderer;
    private string       _moveAxis = "Mouse ScrollWheel";


    #region .  Start()  .
    private void Start()
    {
        _ahead    = new GameObject("ahead");
        _renderer = trackedObject.gameObject.GetComponent<MeshRenderer>();
        _canDebug = DebugManager.Instance.IsLogOn;

    }   // Start()
    #endregion


    #region .  LateUpdate()  .
    private void LateUpdate()
    {
        if (_canDebug) DebugManager.Instance.Log($"Input.GetAxisRaw(moveAxis)) = {Input.GetAxisRaw(_moveAxis)}");

        _ahead.transform.position = trackedObject.position + trackedObject.forward * (maxDistance * 0.25F);
        currentDistance          += Input.GetAxisRaw(_moveAxis) * moveSpeed * Time.deltaTime;
        currentDistance           = Mathf.Clamp(currentDistance, minDistance, maxDistance);
        transform.position        = Vector3.MoveTowards(transform.position,
                                                        trackedObject.position + Vector3.up * currentDistance - trackedObject.forward * (currentDistance + maxDistance * 0.5f),
                                                        updateSpeed * Time.deltaTime);
        transform.LookAt(_ahead.transform);

        _renderer.enabled = (currentDistance > hideDistance);

    }   // LateUpdate()
    #endregion


}   // class PlayerTracker
