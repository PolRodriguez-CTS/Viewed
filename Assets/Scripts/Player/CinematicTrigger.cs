using UnityEngine;
using UnityEngine.InputSystem;

public class CinematicTrigger : MonoBehaviour
{
    public GameObject _director;
    private Transform _animationStartPosition;
    [SerializeField] private InputActionAsset _inputActionAsset;
    public GameObject controlCanvas; 

    private void Awake()
    {
        _animationStartPosition = GetComponent<Transform>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Player")
        {
            controlCanvas.SetActive(false);
            _inputActionAsset.FindActionMap("Player").Disable();
            _director.SetActive(true);
        }
    }
}
