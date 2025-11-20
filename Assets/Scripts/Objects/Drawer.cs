using UnityEngine;
public class Drawer : MonoBehaviour
{

    public GameObject loock;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 3)
        {
            if(GameManager.Instance.hasKey)
            {
                Destroy(loock);
                StartCoroutine(UIManager.Instance.DialogeVisible(5));
                UIManager.Instance.DialogText("Sí, mamá. Lo sé... ¡Ya te dije que lo iba a hacer hoy!");
                GameManager.Instance.Open();
                DrawerAniamtion _animation = GetComponentInParent<DrawerAniamtion>();
                _animation.OpenDrawer();
            }
        }
    }
}