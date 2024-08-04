using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidPipe : MonoBehaviour
{
    public LogicManager Logic;
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bird"))
        {
            Logic.IncPoint();
        }
    }
}
