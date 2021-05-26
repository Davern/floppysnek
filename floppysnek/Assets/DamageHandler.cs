using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.y < -Camera.main.orthographicSize || gameObject.transform.position.y > Camera.main.orthographicSize)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D()
    {
        Destroy(gameObject);
    }

}
