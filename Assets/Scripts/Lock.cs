using UnityEngine;

public class Lock : MonoBehaviour
{

    public void Start()
    {
        ColorEmission _emissionScript = GetComponent<ColorEmission>();
        _emissionScript._color = Color.white;
    }

}
