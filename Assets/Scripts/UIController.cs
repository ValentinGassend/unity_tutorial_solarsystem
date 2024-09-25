using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Slider sliderSpeed;
    public TMPro.TextMeshProUGUI speedText;
    public Toggle btnPause;
    // Start is called before the first frame update
    void Start()
    {
        GameController.Instance().OnSimulationSpeedChanged += RefreshSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RefreshSpeed(float newSpeed)
    {
        this.sliderSpeed.SetValueWithoutNotify(newSpeed);
        this.speedText.text ="Speed: " + newSpeed.ToString("0");
        this.btnPause.SetIsOnWithoutNotify(newSpeed == 0);
    }
}
