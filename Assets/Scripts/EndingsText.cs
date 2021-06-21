using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EndingsText : MonoBehaviour
{
    [SerializeField, TextArea(1,5)] string description;
    [SerializeField] Text text;
    [SerializeField] Transform image;

    public EndingSO ending;

    // Start is called before the first frame update
    void Start()
    {
        text.text = description;
        image?.gameObject.SetActive(false);
    }

    public void OnMouseEnter()
    {
        image?.gameObject.SetActive(true);
    }

    public void OnMouseExit()
    {
        image?.gameObject.SetActive(false);
    }

    public void SetActive(bool value)
    {
        gameObject.SetActive(value);
        ending.active = value;
    }
}
