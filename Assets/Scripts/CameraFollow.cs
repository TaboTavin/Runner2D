using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offSet = new Vector3(0.2f, 0.0f, -10f);
    public float dampingTime = 0.3f;
    public Vector3 velocity = Vector3.zero;

    // Calculo Score
    public float startTime;
    public float journeyLength;
    public GameObject newTarget;

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }

    private void Start()
    {
        startTime = Time.time;
        journeyLength = Vector3.Distance(this.transform.position, newTarget.transform.position);
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
