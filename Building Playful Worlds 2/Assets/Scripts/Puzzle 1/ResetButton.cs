using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    public UnityEvent OnButtonClicked;
    public void ResetPressed()
    {
        OnButtonClicked?.Invoke();
    }
}
