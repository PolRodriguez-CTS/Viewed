using UnityEngine;

public class End : MonoBehaviour
{
    private Animator _animator;
    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void FinishGame()
    {
        _animator.SetTrigger("End");
    }
}
