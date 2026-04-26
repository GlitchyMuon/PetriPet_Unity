using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LabSceneMenu : MonoBehaviour
{
    public void GiveAntibiotics(string sceneName) //launches the CellsBulletHell scene
    {
        SceneManager.LoadScene(sceneName);

    }
}
