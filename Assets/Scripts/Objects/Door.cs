using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator _animator;
    void Awake()
    {
        _animator = GetComponent<Animator>();
        
    }

    public void OpenDoor()
    {
        _animator.SetTrigger("openDoor");
        SoundManager.Instance.PlaySFX(SoundManager.Instance._doorSFX);
    }
}
