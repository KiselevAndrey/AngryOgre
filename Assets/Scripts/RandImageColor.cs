using UnityEngine;
using UnityEngine.UI;

public class RandImageColor : MonoBehaviour
{
    [SerializeField] Image image;
    [SerializeField] int slowestIndex;
    [SerializeField] float percentChanger = 0.01f;

    Color _required, _current;
    float _percent;
    int _i;
    bool _colorIsRGB255;

    void Start()
    {
        slowestIndex = Mathf.Abs(slowestIndex);
        
        _percent = 0f;
        _i = 0;
        _colorIsRGB255 = image.color.maxColorComponent > 1;

        _current = image.color;
        _required = _colorIsRGB255 ? ColorTransfusion_255.NewRandomColor() : ColorTransfusion_01.NewRandomColor();
    }

    void FixedUpdate()
    {
        if (_i > slowestIndex)
        {
            if (_colorIsRGB255) image.color = ColorTransfusion_255.NextColorStep(ref _current, ref _required, ref _percent, percentChanger);
            else image.color = ColorTransfusion_01.NextColorStep(ref _current, ref _required, ref _percent, percentChanger);

            _i = 0;
        }

        _i++;
    }
}
