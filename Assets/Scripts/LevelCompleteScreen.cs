using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteScreen : MonoBehaviour
{
    public string sceneToLoad;

   public void OnNextLevelButton()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void OnMainMenuButton()
    {
        SceneManager.LoadScene(0);
    }


}
