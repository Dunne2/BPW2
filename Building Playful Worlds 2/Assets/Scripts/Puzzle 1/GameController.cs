using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameController : MonoBehaviour
{
    public static bool LeftUpFixed, RightUpFixed, LeftDownFixed, RightDownFixed, MiddleDownFixed, LeftFixed, RightFixed;
    public static bool DoOnce, DoOnlyOnce, OnceOnly;
    public static bool ButtonOneOn;
    public static bool YellowPressed, GreenPressed, BluePressed, RedPressed, PurplePressed, OrangePressed, CyanPressed;
    SecretWallOpener secretwallopener1;
    SecretWallOpener secretwallopener2;
    ColorWallMovement finalwallopener;


    private void Start()
    {
        LeftUpFixed = false;
        RightUpFixed = false;
        LeftDownFixed = false;
        RightDownFixed = false;
        MiddleDownFixed = false;
        LeftFixed = false;
        RightFixed = false;
        DoOnce = true;
        DoOnlyOnce = true;
        OnceOnly = true;
        ButtonOneOn = false;
        YellowPressed = false;
        GreenPressed = false;
        BluePressed = false;
        RedPressed = false;
        PurplePressed = false;
        OrangePressed = false;
        CyanPressed = false;

        secretwallopener1 = GameObject.Find("SecretWall").GetComponent<SecretWallOpener>();
        secretwallopener2 = GameObject.Find("SecretWall2").GetComponent<SecretWallOpener>();
        finalwallopener = GameObject.Find("FinalDoor").GetComponent<ColorWallMovement>();
    }
    void Update()
    {
        if (LeftUpFixed && RightUpFixed && LeftDownFixed && RightDownFixed && MiddleDownFixed && DoOnce)
        {
            secretwallopener1.SecretDoor();
            DoOnce = false;
        }

        if (LeftFixed && RightFixed && DoOnlyOnce)
        {
            secretwallopener2.SmallSecretDoor();
            DoOnlyOnce = false;
        }

        if (YellowPressed == false && GreenPressed == false && BluePressed == false && RedPressed == true && PurplePressed == true && OrangePressed == false && CyanPressed == true && OnceOnly == true)
        {
            finalwallopener.FinalDoorHandler();
            OnceOnly = false;
        }
    }

    public void ButtonOne()
    {
        ButtonOneOn = true;
    }
}
