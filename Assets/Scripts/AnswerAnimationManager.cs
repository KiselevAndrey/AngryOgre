using UnityEngine;

public class AnswerAnimationManager : MonoBehaviour
{
    [SerializeField] TextQuest textQuest;

    void LeftAnswer() => textQuest.LeftAnswer();

    void RigthAnswer() => textQuest.RightAnswer();
}
