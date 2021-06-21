using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step : MonoBehaviour
{
    [Header("Текст заданий")]
    [TextArea(1, 5)] public string quest;
    [TextArea(1, 5)] public string leftRequest;
    [TextArea(1, 5)] public string rightRequest;

    [Header("Куда перемещаться")]
    public Step leftStep;
    public Step rightStep;

    // Sprites


    [Header("Концовка")]
    public bool ending;
    public GameObject endingSprite;


    // Start is called before the first frame update
    void Start()
    {
        SetActive(false);
    }

    public void SetActive(bool active)
    {
        gameObject?.SetActive(active);
        if (ending && active) endingSprite?.SetActive(true);
    }

    public bool InputLeftRequest() => Input.GetKeyDown(HelpInputChar.CharToKeyCode(leftRequest[0]));

    public bool InputRightRequest() => Input.GetKeyDown(HelpInputChar.CharToKeyCode(rightRequest[0]));
}
