using UnityEngine;

public class Trash : MonoBehaviour
{
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