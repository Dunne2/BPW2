using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretSmallWallOpener : MonoBehaviour
{
    private Animator SecretSmallDoorAnim;

    private void Awake()
    {
        SecretSmallDoorAnim = GetComponent<Animator>();
    }

    public void SmallSecretDoor()
    {
        SecretSmallDoorAnim.Play("SecretSmallDoor", 0, 0.0f);
    }
}
