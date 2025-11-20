using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using JetBrains.Annotations;
public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance { get; private set; }

    [SerializeField] private InputActionAsset _inputActionAsset;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }

        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        SoundManager.Instance.PlayBGM(SoundManager.Instance._staticBgm);
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        ChangeBGM(sceneName);
    }


    public void ChangeBGM(string sceneName)
    {
        if(sceneName == "MainMenu")
        {
            Debug.Log("MenuPrincipal");
            SoundManager.Instance.PlayBGM(SoundManager.Instance._staticBgm);
        }
        if(sceneName == "Nivel")
        {
            Debug.Log("Escena1");
            SoundManager.Instance.PlayBGM(SoundManager.Instance._bgmClip);
        }
    }

    public void InputReset()
    {
        _inputActionAsset.FindActionMap("UI").Enable();
        _inputActionAsset.FindActionMap("Player").Enable();
    }

}
