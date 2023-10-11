using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnOffBtn : MonoBehaviour
{
    public Sprite[] sprite;

    private bool b_enable = false;
    private GameObject child;

    private void Start()
    {
        child = gameObject.transform.GetChild(0).gameObject;
    }

    public void ChangeSprite()
    {
        if (b_enable)
        {
            b_enable = false;
            child.GetComponent<Image>().sprite = sprite[0];
        }
        else
        {
            b_enable = true;
            child.GetComponent<Image>().sprite = sprite[1];
        }
    }

    public void ChangeColor()
    {
        if (b_enable)
        {
            b_enable = false;
            gameObject.GetComponent<Image>().color = Color.white;
        }
        else
        {
            b_enable = true;
            gameObject.GetComponent<Image>().color = Color.gray;
        }
    }
}
