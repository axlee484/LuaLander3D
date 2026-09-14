using Unity.Cinemachine;
using UnityEngine;

public class LevelData : MonoBehaviour
{
    [SerializeField] private LevelConfig levelConfig;
    public LevelConfig LevelConfig => levelConfig;
    [SerializeField] private Player playerPrefab;
    [SerializeField] private Transform spawnPosition;
    [SerializeField] private Transform cameraStartPosition;
    [SerializeField] private CameraController cameraController;
    [SerializeField] private float finalOrthographicSize = 80f;
    [SerializeField] private float zoomSpeed = 0.001f;
    
    private Player player;
    public Player Player => player;

    private void Awake()
    {
        player = Instantiate(playerPrefab, spawnPosition);    
        player.transform.position = spawnPosition.position;  
    }

    private void Start()
    {
        LevelManager.Instance.SetCurrentLevel(LevelConfig.LevelNumber);
        EventManager.Instance.LevelStartEvent += OnLevelStart;
    }

    private void OnLevelStart(int level)
    {
        if(level!= LevelConfig.LevelNumber) return;
        cameraController.SetTarget(player.transform);
        cameraController.SetFocus(finalOrthographicSize, zoomSpeed);
    }


}
