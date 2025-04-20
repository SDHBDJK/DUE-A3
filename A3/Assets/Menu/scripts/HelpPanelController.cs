using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpPanelController : MonoBehaviour
{
    public GameObject helpPanel;
    public GameObject creditPanel;

    public void ShowHelp()
    {
        helpPanel.SetActive(true);
    }

    public void HideHelp()
    {
        helpPanel.SetActive(false);
    }

    public void ShowCredit()
    {
        creditPanel.SetActive(true);
    }

    public void HideCredit()
    {
        creditPanel.SetActive(false);
    }
}
