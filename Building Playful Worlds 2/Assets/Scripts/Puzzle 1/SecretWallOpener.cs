using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretWallOpener : MonoBehaviour
{
    private Animator SecretDoorAnim;

    private void Awake()
    {
        SecretDoorAnim = GetComponent<Animator>();
    }

    public void SecretDoor()
    {
        SecretDoorAnim.Play("SecretDoor", 0, 0.0f);
    }
}
