using UnityEngine;

public class DrawerAniamtion : MonoBehaviour
{
    private Animator _animator;

    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void OpenDrawer()
    {
        _animator.SetTrigger("Open");
    }
}