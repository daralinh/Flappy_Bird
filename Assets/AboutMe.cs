using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AboutMe : MonoBehaviour
{
    public Image imageToHide;
    public Text Content;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameObject.SetActive(false);
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (!IsPointerOverUIObject(imageToHide))
            {
                imageToHide.gameObject.SetActive(false);
            }
            else
            {
                CopyToClipboard();
            }
        }

    }

    private void CopyToClipboard()
    {
        if (Content != null)
        {
            GUIUtility.systemCopyBuffer = "khanhtran2002nd@gmail.com";
        }
    }

    private bool IsPointerOverUIObject(Image image)
    {
        RectTransform rectTransform = image.rectTransform;
        Vector2 localMousePosition = rectTransform.InverseTransformPoint(Input.mousePosition);
        return rectTransform.rect.Contains(localMousePosition);
    }
}
