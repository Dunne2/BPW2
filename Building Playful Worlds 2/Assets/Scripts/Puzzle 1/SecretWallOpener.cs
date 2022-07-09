using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretWallOpener : MonoBehaviour
{
    private Animator SecretDoorAnim;
    private Animator SecretSmallDoorAnim;
    private Animator FrontGateAnim;

    private void Awake()
    {
        SecretDoorAnim = GetComponent<Animator>();
        SecretSmallDoorAnim = GetComponent<Animator>();
        FrontGateAnim = GetComponent<Animator>();
    }

    public void FrontGate()
    {
        FindObjectOfType<AudioManager>().Play("WellDone!");
        FrontGateAnim.Play("Front Gate", 0, 0.0f);
    }

    public void SecretDoor()
    {
        FindObjectOfType<AudioManager>().Play("WellDone!");
        SecretDoorAnim.SetBool("OpenSecretDoor", true);
        SecretDoorAnim.Play("SecretDoor", 0, 0.0f);
        SecretDoorAnim.SetBool("OpenSecretDoor", false);
    }

    public void SmallSecretDoor()
    {
        FindObjectOfType<AudioManager>().Play("WellDone!");
        SecretSmallDoorAnim.SetBool("OpenSecretDoor", true);
        SecretSmallDoorAnim.Play("SecretSmallDoor", 0, 0.0f);
        SecretSmallDoorAnim.SetBool("OpenSecretDoor", false);
    }

}
