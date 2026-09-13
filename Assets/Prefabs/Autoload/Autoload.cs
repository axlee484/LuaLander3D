using UnityEngine;
using UnityEngine.AddressableAssets;

public class Autoload : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void Initialize()
    {
        string addressKey = "Assets/Prefabs/Autoload/Autoload.prefab";
        var operation = Addressables.InstantiateAsync(addressKey);
        var instance = operation.WaitForCompletion();
        DontDestroyOnLoad(instance);

    }

}
