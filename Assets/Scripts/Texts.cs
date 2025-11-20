using UnityEngine;

public class Texts : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    private Animator _animation;
    void Awake()
    {
        _animation = GetComponent<Animator>();
    }

 

    public void Animations()
    {
        _animation.SetTrigger("Down");
    }
}
