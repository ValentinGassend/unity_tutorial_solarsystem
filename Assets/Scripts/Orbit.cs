using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
//    public GameObject Body;
    public GameObjectRotation BodyRotation;
    // Start is called before the first frame update
    public OrbitPreset preset;
    public Transform PlanetTransform;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // move planet child to distance
        this.PlanetTransform.localPosition = new Vector3(0, 0, this.preset.DistanceFromOrbit);

        // modifier le material du body de la planete
        this.BodyRotation.gameObject.GetComponent<Renderer>().material = this.preset.BodyMaterial;
        // set planet size
        this.BodyRotation.gameObject.transform.localScale = new Vector3(this.preset.BodySize, this.preset.BodySize, this.preset.BodySize);

        // set planet rotation speed from preset
        this.BodyRotation.rotationSpeed = preset.RotationSpeed;
    }
}
