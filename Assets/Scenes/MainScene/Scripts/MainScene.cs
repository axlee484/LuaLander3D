using UnityEngine;
using UnityEngine.UI;

public class MainScene : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button quitButton;
    private void Start()
    {
        startButton.onClick.AddListener(OnStartButtonClick);
        quitButton.onClick.AddListener(OnQuitButtonClick);
    }
    private void OnStartButtonClick()
    {
        EventManager.Instance.InvokeGameStartEvent();
    }
    private void OnQuitButtonClick()
    {
        Application.Quit();
    }
}
