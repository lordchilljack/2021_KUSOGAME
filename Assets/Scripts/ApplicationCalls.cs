using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationCalls : MonoBehaviour
{
    public void OpenFacebook()
    {
        Application.OpenURL("https://www.facebook.com/TryHarderOkay");
    }
    public void TurnOffGame()
    {
        Application.Quit();
    }

}
