using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{

    public float maxSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        pos -= new Vector3(maxSpeed * Time.deltaTime, 0, 0);

        transform.position = pos;
    }
}
