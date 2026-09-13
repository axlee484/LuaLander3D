using UnityEngine;

public class Autoload : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void Initialize()
    {
        var gameObject = new GameObject("Autoload");
        DontDestroyOnLoad(gameObject);

        gameObject.AddComponent<GameInput>();
        gameObject.AddComponent<AudioManager>();
    }

}
