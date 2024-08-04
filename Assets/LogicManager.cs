using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{
    private int _point;
    private Bird _bird;
    private SpawnPipe _spawnPipe;

    public Text TextPoint;
    public ImageCounting ImangeNumber;

    // Start is called before the first frame update
    void Start()
    {
        _point = 0; ShowPoint();

        Time.timeScale = 0;
        StartCoroutine(WaitToStart(3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncPoint()
    {
        _point++;
        ShowPoint();
    }

    public void ShowPoint()
    {
        TextPoint.text = _point.ToString();
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        SceneManager.LoadSceneAsync(2);
    }

    IEnumerator WaitToStart(int timer)
    {
        while (timer > 0)
        {
            ImangeNumber.Show(timer.ToString());
            timer--;
            yield return StartCoroutine(WaitForRealSeconds(1));
        }

        ImangeNumber.Show("GO");
        yield return StartCoroutine(WaitForRealSeconds(1));
        ImangeNumber.gameObject.SetActive(false);

        Time.timeScale = 1;
    }

    IEnumerator WaitForRealSeconds(float time)
    {
        float start = Time.realtimeSinceStartup;
        while (Time.realtimeSinceStartup < start + time)
        {
            yield return null;
        }
    }
}
