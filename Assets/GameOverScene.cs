using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScrene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClickPlayAgain()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void ClickBackToMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
