using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageGame : MonoBehaviour
{
    GameObject SnakeInstance;

    public GameObject snakePreFab;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        SnakeInstance = (GameObject)Instantiate(snakePreFab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        if (SnakeInstance == null)
        {
            Time.timeScale = 0;
            GUI.contentColor = Color.black;
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 25, 100, 50), "Game Over! Score: " + PipeSpawner.score);
            if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 10, 70, 30), "Try Again"))
            {
                PipeSpawner.score = 0;
                SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
