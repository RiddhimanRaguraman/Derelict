using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerscene : MonoBehaviour
{
    public void Next()
    {
        SceneManager.LoadScene(2);
    }
    public void end()
    {
        SceneManager.LoadScene(3);
    }
}
