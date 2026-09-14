using Unity.Cinemachine;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] CinemachineCamera cinemachineCamera;
    private float finalOrthographicSize;
    private float zoomSpeed;
    
    public void SetFocus(float finalOrthographicSize, float zoomSpeed)
    {
        this.finalOrthographicSize = finalOrthographicSize;
        this.zoomSpeed = zoomSpeed;
    }
    public void SetTarget(Transform target)
    {
        cinemachineCamera.Target.TrackingTarget = target;
    }

    private void Update()
    {
        cinemachineCamera.Lens.OrthographicSize = Mathf.Lerp(cinemachineCamera.Lens.OrthographicSize, finalOrthographicSize, Time.deltaTime*zoomSpeed);
    }


}
