using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public UnityEvent OnButtonClicked;

    public void ButtonPressed()
    {
        OnButtonClicked?.Invoke();
    }
}
