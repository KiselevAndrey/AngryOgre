using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class StepSO : ScriptableObject
{
    [Header("Текст заданий")]
    [TextArea(1, 5)] public string quest;
    [TextArea(1, 5)] public string leftRequest;
    [TextArea(1, 5)] public string rightRequest;

    [Header("Куда перемещаться")]
    public StepSO leftStep;
    public StepSO rightStep;
       
    [Header("Концовка")]
    public bool ending;
    public EndingSO endBool;

    public void SetActive(bool active)
    {
        if (ending && active)
        {
            endBool.active = true;
        }
    }

    public bool InputLeftRequest() => Input.GetKeyDown(HelpInputChar.CharToKeyCode(leftRequest[0]));

    public bool InputRightRequest() => Input.GetKeyDown(HelpInputChar.CharToKeyCode(rightRequest[0]));
}
