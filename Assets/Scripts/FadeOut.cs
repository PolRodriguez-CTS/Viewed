using UnityEngine;

public class FadeOut : MonoBehaviour
{
 public void FadeOuts()
    {
        End _endScript = GameObject.Find("Negro").GetComponent<End>();
        _endScript.FinishGame();
    }
}
