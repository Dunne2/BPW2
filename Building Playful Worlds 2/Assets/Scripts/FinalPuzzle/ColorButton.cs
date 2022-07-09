using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColorButton : MonoBehaviour
{
    public UnityEvent OnButtonClicked;
    public void ButtonPressed()
    {
        OnButtonClicked?.Invoke();
    }
}
