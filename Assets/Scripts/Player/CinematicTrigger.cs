using UnityEngine;
using UnityEngine.InputSystem;

public class CinematicTrigger : MonoBehaviour
{
    public GameObject _director;
    private Transform _animationStartPosition;
    [SerializeField] private InputActionAsset _inputActionAsset;

    private void Awake()
    {
        _animationStartPosition = GetComponent<Transform>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Player")
        {
            _inputActionAsset.FindActionMap("Player").Disable();
            _director.SetActive(true);

        }
    }
}
