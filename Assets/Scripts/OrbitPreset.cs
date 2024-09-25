using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "OrbitPreset", menuName = "Scripts/OrbitPreset", order = 1)]

public class OrbitPreset : ScriptableObject
{

    public float DistanceFromOrbit;
    public float BodySize;
    public Vector3 RotationSpeed;
}
