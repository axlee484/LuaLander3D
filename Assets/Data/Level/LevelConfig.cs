using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "Level Configuration")]
public class LevelConfig : ScriptableObject
{
    [SerializeField] private int levelNumber;
    public int LevelNumber => levelNumber;
    [SerializeField] private string levelName;
    public string LevelName => levelName;
    [SerializeField] private bool isDefault = false;
    public bool IsDefault => isDefault;
    [SerializeField] private int levelMultiplier = 1;
    public int LevelMultiplier => levelMultiplier;
    [SerializeField] private float gravity = 9.8f;
    public float Gravity => gravity;
    [SerializeField] private float windSpeed = 1;
    public float WindSpeed => windSpeed;
    

}
