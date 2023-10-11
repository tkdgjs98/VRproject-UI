using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Metronome metronome;
    private GameObject currentPnl = null;
    private bool b_Mute = false;

    public void OnClickEnablePnl(GameObject panel)
    {
        if (currentPnl == null)
        {
            panel.SetActive(true);
            currentPnl = panel;
        }
        else
        {
            if(currentPnl == panel)
            {
                panel.SetActive(false);
                currentPnl = null;
            }
            else
            {
                currentPnl.SetActive(false);
                panel.SetActive(true);
                currentPnl = panel;
            }
        }
    }

    public void OnClickMute()
    {
        Debug.Log("Mute Button Clicked");
        if(b_Mute)
        {
            b_Mute = false;
            AudioListener.volume = 1;
        }
        else
        {
            b_Mute = true;
            AudioListener.volume = 0;
        }
    }

    public void OnClickExit()
    {
        Debug.Log("Exit Button Clicked");
        Application.Quit();
    }
}
