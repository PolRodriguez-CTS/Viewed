using UnityEngine;

public class EmissionRed : MonoBehaviour
{

    public void Start()
    {
        ColorEmission _emissionScript = GetComponent<ColorEmission>();
        _emissionScript._color = Color.red;
    }

    void Update()
    {
        if(GameManager.Instance.youSeeNote == true)
        {
            ColorEmission _emissionScript = GetComponent<ColorEmission>();
            _emissionScript._color = Color.white;
        }
    }

}
