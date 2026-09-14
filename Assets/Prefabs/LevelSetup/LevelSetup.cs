using Unity.Cinemachine;
using UnityEngine;

public class LevelData : MonoBehaviour
{
    [SerializeField] private LevelConfig levelConfig;
    public LevelConfig LevelConfig => levelConfig;
    [SerializeField] private Player playerPrefab;
    [SerializeField] private Transform spawnPosition;
    [SerializeField] private Transform cameraStartPosition;
    [SerializeField] private CinemachineCamera camera;
    private Player player;
    public Player Player => player;

    private void Awake()
    {
        player = Instantiate(playerPrefab, spawnPosition);    
        player.transform.position = spawnPosition.position;  
        camera.Target.TrackingTarget = player.transform;
    }

    private void Start()
    {
        LevelManager.Instance.SetCurrentLevel(LevelConfig.LevelNumber);
    }


}
