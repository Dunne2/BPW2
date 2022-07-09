using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColorWallMovement : MonoBehaviour
{
    public Animator animator;
    bool YellowPressed = false;
    bool GreenPressed = false;
    bool BluePressed = false;
    bool RedPressed = false;
    bool PurplePressed = false;
    bool OrangePressed = false;
    bool CyanPressed = false;
    bool ElevatorPressed = false;

    public void FinalDoorHandler()
    {
        FindObjectOfType<AudioManager>().Play("Money");
        animator.SetBool("FinalDoorOpen", true);
        StartCoroutine(Moneyyy());
    }

    public IEnumerator Moneyyy()
    {
        yield return new WaitForSeconds(4f);
        FindObjectOfType<AudioManager>().Play("Cashing In");
        yield return new WaitForSeconds(1f);
        FindObjectOfType<AudioManager>().Play("Cashing In");
        yield return new WaitForSeconds(0.5f);
        FindObjectOfType<AudioManager>().Play("Cashing In");
        yield return new WaitForSeconds(0.5f);
        FindObjectOfType<AudioManager>().Play("Cashing In");
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void YellowHandler()
    {
        if (YellowPressed)
        {
            animator.SetBool("YellowOn", false);
            YellowPressed = false;
            GameController.YellowPressed = false;
            FindObjectOfType<AudioManager>().Play("Off");
        }
        else
        {
            animator.SetBool("YellowOn", true);
            YellowPressed = true;
            GameController.YellowPressed = true;
            FindObjectOfType<AudioManager>().Play("On");
        }
    }

    public void GreenHandler()
    {
        if (GreenPressed)
        {
            animator.SetBool("GreenOn", false);
            GreenPressed = false;
            GameController.GreenPressed = false;
            FindObjectOfType<AudioManager>().Play("Off");
        }
        else
        {
            animator.SetBool("GreenOn", true);
            GreenPressed = true;
            GameController.GreenPressed= true;
            FindObjectOfType<AudioManager>().Play("On");
        }
    }    

    public void BlueHandler()
    {
        if (BluePressed)
        {
            animator.SetBool("BlueOn", false);
            BluePressed = false;
            GameController.BluePressed = false;
            FindObjectOfType<AudioManager>().Play("Off");
        }
        else
        {
            animator.SetBool("BlueOn", true);
            BluePressed = true;
            GameController.BluePressed= true;
            FindObjectOfType<AudioManager>().Play("On");
        }
    }

    public void RedHandler()
    {
        if (RedPressed)
        {
            animator.SetBool("RedOn", false);
            RedPressed = false;
            GameController.RedPressed = false;
            FindObjectOfType<AudioManager>().Play("Off");
        }
        else
        {
            animator.SetBool("RedOn", true);
            RedPressed = true;
            GameController.RedPressed= true;
            FindObjectOfType<AudioManager>().Play("On");
        }
    }

    public void PurpleHandler()
    {
        if (PurplePressed)
        {
            animator.SetBool("PurpleOn", false);
            PurplePressed = false;
            GameController.PurplePressed= false;
            FindObjectOfType<AudioManager>().Play("Off");
        }
        else
        {
            animator.SetBool("PurpleOn", true);
            PurplePressed = true;
            GameController.PurplePressed = true;
            FindObjectOfType<AudioManager>().Play("On");
        }
    }

    public void OrangeHandler()
    {
        if (OrangePressed)
        {
            animator.SetBool("OrangeOn", false);
            OrangePressed = false;
            GameController.OrangePressed= false;
            FindObjectOfType<AudioManager>().Play("Off");
        }
        else
        {
            animator.SetBool("OrangeOn", true);
            OrangePressed = true;
            GameController.OrangePressed = true;
            FindObjectOfType<AudioManager>().Play("On");
        }
    }

    public void CyanHandler()
    {
        if (CyanPressed)
        {
            animator.SetBool("CyanOn", false);
            CyanPressed = false;
            GameController.CyanPressed= false;
            FindObjectOfType<AudioManager>().Play("Off");
        }
        else
        {
            animator.SetBool("CyanOn", true);
            CyanPressed = true;
            GameController.CyanPressed = true;
            FindObjectOfType<AudioManager>().Play("On");
        }
    }

    public void ElevatorHandler()
    {
        if (ElevatorPressed)
        {
            animator.SetBool("ElevatorOn", false);
            ElevatorPressed = false;
            FindObjectOfType<AudioManager>().Play("Off");
        }
        else
        {
            animator.SetBool("ElevatorOn", true);
            ElevatorPressed = true;
            FindObjectOfType<AudioManager>().Play("On");
        }
    }

    public void ResetHandler()
    {
        animator.SetBool("YellowOn", false);
        animator.SetBool("GreenOn", false);
        animator.SetBool("BlueOn", false);
        animator.SetBool("RedOn", false);
        animator.SetBool("PurpleOn", false);
        animator.SetBool("OrangeOn", false);
        animator.SetBool("ElevatorOn", false);
    }
}
