using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class RayCast : MonoBehaviour
{
    [SerializeField] private int RayLength = 2;
    [SerializeField] private LayerMask LayerMaskInteract;

    private ColorChanger RayCastedObj;

    [SerializeField] private KeyCode PressButton = KeyCode.Mouse0;
    [SerializeField] private KeyCode PressReset = KeyCode.Mouse0;
    [SerializeField] private Image CrossHair = null;
    private bool IsCrossHairActive;

    private const string InteractableTag = "InteractiveObject";

    private void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hit, RayLength))
        {
            if (hit.collider != null)
            {
                if (hit.collider.CompareTag(InteractableTag))
                {
                    RayCastedObj = hit.collider.gameObject.GetComponent<ColorChanger>();
                    CrossHairChange(true);
                }

                IsCrossHairActive = true;

                if (Input.GetKeyDown(PressButton) && hit.collider.GetComponent<Button>())
                {
                    Button button = hit.collider.GetComponent<Button>();
                    button.ButtonPressed();
                }

                if (Input.GetKeyDown(PressReset) && hit.collider.GetComponent<ResetButton>())
                {
                    ResetButton resetbutton = hit.collider.GetComponent<ResetButton>();
                    resetbutton.ResetPressed();
                }
            }

        }
        else
        {
            if (IsCrossHairActive)
            {
                CrossHairChange(false);
            }
        }

    }

    void CrossHairChange(bool on)
    {
        if (on)
        {
            CrossHair.color = Color.red;
        }
        else
        {
            CrossHair.color = Color.white;
            IsCrossHairActive = false;
        }
    }
}
