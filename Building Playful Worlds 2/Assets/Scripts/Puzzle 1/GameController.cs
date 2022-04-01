using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameController : MonoBehaviour
{
    public static bool LeftUpFixed, RightUpFixed, LeftDownFixed, RightDownFixed, MiddleDownFixed, LeftFixed, RightFixed;
    public static bool DoOnce, DoOnlyOnce;
    SecretWallOpener secretwallopener;
    SecretSmallWallOpener secretsmallwallopener;

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
        secretwallopener = GameObject.Find("SecretWall").GetComponent<SecretWallOpener>();
        secretsmallwallopener = GameObject.Find("SecretWall2").GetComponent<SecretSmallWallOpener>();
    }
    void Update()
    {
        if (LeftUpFixed && RightUpFixed && LeftDownFixed && RightDownFixed && MiddleDownFixed && DoOnce)
        {
            secretwallopener.SecretDoor();
            DoOnce = false;
        }

        if (LeftFixed && RightFixed && DoOnlyOnce)
        {
            secretsmallwallopener.SmallSecretDoor();
            DoOnlyOnce = false;
        }

    }
}
