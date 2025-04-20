using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpUIManager : MonoBehaviour
{
    public GameObject helpPanel;

    public void ShowHelp()
    {
        helpPanel.SetActive(true);
    }

    public void HideHelp()
    {
        helpPanel.SetActive(false);
    }
}
