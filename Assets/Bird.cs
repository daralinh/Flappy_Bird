using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private bool _alive;

    public float JumpLength;
    public Rigidbody2D MyRigi2D;
    public bool Alive;

    // Start is called before the first frame update
    void Start()
    {
        Reborn();
        Alive = _alive;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && _alive)
        {
            MyRigi2D.velocity = Vector2.up * JumpLength;
        }
    }

    public void Reborn()
    {
        _alive = true;
    }

    public void Death()
    {
        _alive = false;
    }
}
