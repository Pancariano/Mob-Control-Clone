using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [Header("Panels")]
    public GameObject winPanel;
    public GameObject tapToPlay;
    public static bool win;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        winPanel.SetActive(false);
        tapToPlay.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        isWin();
    }

    public void NextLevel()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        int sceneIndex = SceneManager.sceneCountInBuildSettings - 1;

        win= false;

        if (nextSceneIndex <= sceneIndex)
            SceneManager.LoadScene(nextSceneIndex);

        if (nextSceneIndex > sceneIndex)
            SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        tapToPlay.gameObject.SetActive(false);
    }

    public void isWin()
    {
        if (win)
        {
            winPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}