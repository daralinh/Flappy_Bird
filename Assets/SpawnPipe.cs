using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnPipe : MonoBehaviour
{
    private float _timer;

    public float SpawnRate;
    public float MinY;
    public float MaxY;
    public GameObject Clone;
    public LogicManager Logic;

    // Start is called before the first frame update
    void Start()
    {
        _timer = 0;
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
        SpawnClone();
    }

    // Update is called once per frame
    void Update()
    {
        if (SpawnRate > _timer)
        {
            _timer += Time.deltaTime;
        }
        else
        {
            SpawnClone();
            _timer = 0;
        }
    }

    private void SpawnClone()
    {
        Instantiate(Clone,
                    new Vector2(transform.position.x, Random.Range(MinY, MaxY)),
                    transform.rotation);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bird"))
        {
            Logic.GameOver();
        }
    }
}




