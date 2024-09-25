using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public float simulationSpeed = 1.0f;
    public float? previousSimulationSpeed;
    public static GameController instance = null;

    public static GameController Instance()
    {
        if (instance == null)
        {
            instance = FindObjectOfType<GameController>();
        }
        return instance;
    }

    public void Pause()
    {
       if (this.simulationSpeed == 0)
       {
           if (this.previousSimulationSpeed.HasValue)
           {
                this.simulationSpeed = this.previousSimulationSpeed.Value;
           }
           else
           {
               this.simulationSpeed = 1;

           }
       }
       else
       {
           this.previousSimulationSpeed = this.simulationSpeed;
           this.simulationSpeed = 0;
       }
    }
    // Start is called before the first frame update
    public void Start()
    {
        var inputController = FindObjectOfType<InputController>();
        InputController.OnTogglePause += Pause;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
