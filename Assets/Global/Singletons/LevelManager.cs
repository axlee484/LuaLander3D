using System.Collections.Generic;
using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
    private int currentLevel;
    public int CurrentLevel => currentLevel;
    public void SetCurrentLevel(int level) => currentLevel = level;
    private void Awake()
    {
        if(Instance != null) Destroy(gameObject);
        Instance = this;
    }

    public void LoadLevel(int level)
    {
        SceneManager.LoadScene("Level_" + level);
    }
    public void LoadNextLevel()
    {
        LoadLevel(currentLevel + 1);
    }

}
