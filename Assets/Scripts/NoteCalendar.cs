using UnityEngine;

public class NoteCalendar : MonoBehaviour
{

    private ColorEmission _colorEmission;
    private Animator _animator;
    void Awake()
    {
        _colorEmission = GetComponent<ColorEmission>();
        _animator = GetComponent<Animator>();
    }
    void Update()
    {
        if(GameManager.Instance.youSeeSisterNote == true)
        {
            _animator.SetTrigger("IsSeen");
            _colorEmission.enabled = false;
        }

    }

}
