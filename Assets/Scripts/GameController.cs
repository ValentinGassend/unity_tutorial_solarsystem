using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : BaseController<GameController>
{

    public float simulationSpeed = 1.0f;
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
