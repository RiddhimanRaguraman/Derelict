using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public static int currentScore;
    //public static int highScore;
    public static int currentLevel = 1;
    public static int unlockedLevel;

    public static void CompleteLevel()
    {
            currentLevel += 1;
            SceneManager.LoadScene(currentLevel);
    }

}
