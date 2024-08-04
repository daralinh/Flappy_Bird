using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageCounting : MonoBehaviour
{
    public Text Number;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Show(string content)
    {
        gameObject.SetActive(true);
        Number.text = content;
    }
}
