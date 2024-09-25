using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
//    public GameObject Body;
    public GameObjectRotation BodyRotation;
    // Start is called before the first frame update
    public PlanetPreset preset;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.localPosition = new Vector3(0, 0, this.preset.DistanceFromOrbit);
        this.BodyRotation.gameObject.transform.localScale = new Vector3(this.preset.BodySize, this.preset.BodySize, this.preset.BodySize);
        this.BodyRotation.rotationSpeed = preset.RotationSpeed;
    }
}
