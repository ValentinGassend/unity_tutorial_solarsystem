using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "PlanetPreset", menuName = "Scripts/PlanetPreset", order = 1)]

public class PlanetPreset : ScriptableObject
{

    public float DistanceFromOrbit;
    public float BodySize;
    public Vector3 RotationSpeed;


}
