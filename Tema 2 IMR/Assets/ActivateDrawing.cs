using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDrawing : MonoBehaviour
{

    private TrailRenderer trail;
    // Start is called before the first frame update
    void Start()
    {
        trail = GetComponent<TrailRenderer>();
        trail.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            trail.enabled = !trail.enabled;
        }
        
    }
}
