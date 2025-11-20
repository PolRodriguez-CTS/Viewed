using UnityEngine;

public class Trash : MonoBehaviour
{
    
    public void Start()
    {
        ColorEmission _emissionScript = GetComponentInParent<ColorEmission>();
        _emissionScript._color = Color.red;
    }

    void Update()
    {
        if(GameManager.Instance.youSeeNote == true)
        {
            ColorEmission _emissionScript = GetComponentInParent<ColorEmission>();
            _emissionScript._color = Color.white;
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Toy")
        {
                SoundManager.Instance.PlaySFX(SoundManager.Instance._cajaJuguetesSFX);
                PlayerController _playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
                Destroy(_playerScript._grabbedObject.gameObject);
                Debug.Log("gika");
        }
    } 
}