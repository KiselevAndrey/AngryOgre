using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingsManager : MonoBehaviour
{
    [SerializeField] EndingsText[] endings;

    public void ActivateEndings()
    {
        foreach (EndingsText ending in endings)
        {
            if (ending.ending.active) ending.SetActive(true);
        }
    }
}
