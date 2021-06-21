using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuest : MonoBehaviour
{
    [Header("Тестовые поля")]
    [SerializeField] Text questText;
    [SerializeField] Text requestLeftText;
    [SerializeField] Text requestRightText;

    [Header("")]
    [SerializeField] StepSO startedStep;

    [Header("")]
    [SerializeField] Transform endingsParent;

    [Header("References")]
    [SerializeField] EndingsManager endingsManager;
    [SerializeField] Animator animator;

    StepSO _currentStep;

    bool _writeQuest;
    
    void Start()
    {
        NextStep(startedStep);
    }

    // Update is called once per frame
    void Update()
    {
        Write();
        Request();
    }

    void Write()
    {
        if (!_writeQuest) return;

        questText.text = _currentStep.quest;         // осн текст
        requestLeftText.text = _currentStep.leftRequest;   // левый выбор
        requestRightText.text = _currentStep.rightRequest;  // правый выбор

        _writeQuest = false;    // не обновлять описание
    }

    // проверка на выбор ответа
    void Request()
    {
        if (_currentStep.InputLeftRequest())
        {
            animator.SetTrigger("Left Answer");
        }
        if (_currentStep.InputRightRequest())
        {
            animator.SetTrigger("Rigth Answer");
        }
    }

    void NextStep(StepSO nextStep)
    {
        _currentStep = nextStep;
        _currentStep.SetActive(true);

        if (_currentStep.name == startedStep.name) ClearEndings();

        _writeQuest = true; // обновить описание

        endingsManager.ActivateEndings();
    }

    void ClearEndings()
    {
        foreach (Transform endPict in endingsParent)
        {
            endPict.GetComponent<EndingsText>().SetActive(false);
        }
    }

    public void LeftAnswer() => NextStep(_currentStep.leftStep);

    public void RightAnswer() => NextStep(_currentStep.rightStep);
}
