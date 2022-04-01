using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColorChanger : MonoBehaviour
{
    public int CurrentIndex = 0;
    public int RequiredIndex = 0;
    private int ColorValue;
    private Material material;

    [SerializeField] private Color[] Colors;


    private void Start()
    {
        material = GetComponent<MeshRenderer>().material;
        SetColor(CurrentIndex);
        ColorValue = CurrentIndex;
    }

    public void Update()
    {
        switch (name)
        {
            case "CubeUpLeft":
                if (RequiredIndex == ColorValue)
                {
                    GameController.LeftUpFixed = true;
                }
                else
                {
                    GameController.LeftUpFixed = false;
                }
                break;
            case "CubeUpRight":
                if (RequiredIndex == ColorValue)
                {
                    GameController.RightUpFixed = true;
                }
                else
                {
                    GameController.RightUpFixed = false;
                }
                break;
            case "CubeDownLeft":
                if (RequiredIndex == ColorValue)
                {
                    GameController.LeftDownFixed = true;
                }
                else
                {
                    GameController.LeftDownFixed = false;
                }
                break;
            case "CubeDownRight":
                if (RequiredIndex == ColorValue)
                {
                    GameController.RightDownFixed = true;
                }
                else
                {
                    GameController.RightDownFixed = false;
                }
                break;
            case "CubeDownCenter":
                if (RequiredIndex == ColorValue)
                {
                    GameController.MiddleDownFixed = true;
                }
                else
                {
                    GameController.MiddleDownFixed = false;
                }
                break;
            case "CubeLeft":
                if (RequiredIndex == ColorValue)
                {
                    GameController.LeftFixed = true;
                }
                else
                {
                    GameController.LeftFixed = false;
                }
                break;
            case "CubeRight":
                if (RequiredIndex == ColorValue)
                {
                    GameController.RightFixed = true;
                }
                else
                {
                    GameController.RightFixed = false;
                }
                break;
        }
    }

    public void SetColor(int index)
    {
        material.color = Colors[index];
    }

    public void GoToNextColor()
    {
        ColorValue++;
        if (ColorValue > 4)
        {
            ColorValue = 0;
        }

        SetColor(ColorValue);
    }

    public void ResetColors()
    {
        SetColor(CurrentIndex);
        ColorValue = CurrentIndex;
    }
}
