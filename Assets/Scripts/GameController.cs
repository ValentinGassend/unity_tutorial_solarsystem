using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : BaseController<GameController>
{
    public delegate void SpeedEvent(float newSpeed);
    public event SpeedEvent OnSimulationSpeedChanged;

    private float _speed = 1;
    public float simulationSpeed {get{
        return _speed;
    } set {
        _speed = value;
        if (this.OnSimulationSpeedChanged != null)
        {
            this.OnSimulationSpeedChanged(value);
        }
    }
    }
    public float? previousSimulationSpeed;

    public Orbit[] orbitsPrefabs;
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
        InputController.Instance().OnTogglePause += Pause;

        if (this.orbitsPrefabs.Length == 0)
        {
            Debug.LogError("No orbits prefabs found");
        }
        else
        {
            foreach (Orbit orbit in this.orbitsPrefabs)
            {
                GameObject.Instantiate(orbit);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
