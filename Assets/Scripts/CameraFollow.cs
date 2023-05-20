using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 offSet = new Vector3(0.2f, 0.0f, -10f);
    [SerializeField] float dampingTime = 0.3f;
    [SerializeField] Vector3 velocity = Vector3.zero;

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void ResetCameraPosition()
    {

    }

    private void MoveCamera(bool smooth)
    {
        Vector3 destination = new Vector3(target.position.x - offSet.x, offSet.y, offSet.z);

        if(smooth)
        {
            this.transform.position = Vector3.SmoothDamp(this.transform.position, destination, ref velocity, dampingTime);
        }

        else
        {
            this.transform.position = destination;
        }
    }
}
