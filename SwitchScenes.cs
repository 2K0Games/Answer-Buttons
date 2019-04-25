using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

    /* This script changes the scenes at each command put into the buttons in the main and back to the main scene */

public class SwitchScenes : MonoBehaviour {
   // When you press yes this happens.
    public void IfYesPressed()
    {
        SceneManager.LoadScene("Yes");
    }
   // When you press yesssss this happens.
    public void IfYessssssssPressed()
    {
        SceneManager.LoadScene("Yessssss");
    }
   // When you press maybe this happens.
    public void IfMaybePressed()
    {
        SceneManager.LoadScene("Maybe");
    }
   // When you press no this happens.
     public void IfNoPressed()
     {
         SceneManager.LoadScene("No");
     }
   // When you press nooooo this happens. 
    public void IfNooooooooPressed()
    {
        SceneManager.LoadScene("Nooooo");
    }
  // When you press back in each scene this happens.
    public void IfBackPressed()
    {
        Advertisement.Show();
        SceneManager.LoadScene("Button Game");
    }
}
