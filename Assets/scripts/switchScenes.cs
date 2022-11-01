using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class switchScenes : MonoBehaviour
{
    int sceneIndex;
    public GameObject display;
    public static switchScenes instance;
    
    public GameObject canvas;

    private void Start()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
        DontDestroyOnLoad(canvas);
        DontDestroyOnLoad(display);
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(sceneIndex + 1);
        Destroy(GameObject.FindGameObjectWithTag("quart"));
        Destroy(GameObject.FindGameObjectWithTag("gallon"));
        Destroy(GameObject.FindGameObjectWithTag("2.5"));
        Destroy(GameObject.FindGameObjectWithTag("buckets"));
        Destroy(GameObject.FindGameObjectWithTag("barrel"));
    }
}
