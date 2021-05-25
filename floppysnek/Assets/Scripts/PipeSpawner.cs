using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;

    public GameObject flippedpipePrefab;

    float pipeRate = 3;

    public float nextPipe = 1;

    public static int score = 0;

    bool counted = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        nextPipe -= Time.deltaTime;

        if (nextPipe <= 0)
        {
            pipeRate *= .95f;

            if (pipeRate < 1)
            {
                pipeRate = 1;
            }

            nextPipe = pipeRate;
            Vector3 topOffset = new Vector3(12, Camera.main.orthographicSize, 0);

            Vector3 bottomOffset = new Vector3(12, Camera.main.orthographicSize * -1, 0);


            GameObject topPipe = Instantiate(flippedpipePrefab, transform.position + topOffset, Quaternion.identity);
            GameObject bottomPipe = Instantiate(pipePrefab, transform.position + bottomOffset, Quaternion.identity);

            topPipe.name = flippedpipePrefab.name;
            bottomPipe.name = pipePrefab.name;
            float f = Random.Range(-.4f, .4f);
            topPipe.transform.localScale += new Vector3(0, f, 0);
            bottomPipe.transform.localScale += new Vector3(0, -f, 0);
        }


    }

    void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 100, 50), "Score: " + score);
    }
}
