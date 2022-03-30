using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreenMenu : MonoBehaviour
{
    public GameObject[] panels;

    private void Start()
    {
        SelectPanel(0);
    }

    // Called from UI Buttons
    public void SelectPanel(int panelID)
    {
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(i == panelID);
        }
    }

    // Called from UI Buttons
    public void PlayGame()
    {

    }

    // Called from UI Buttons
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }


}
