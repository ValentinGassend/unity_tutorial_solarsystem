using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectRotation : MonoBehaviour
{
    [SerializeField]
    public Vector3 rotationSpeed = new Vector3(0, 1, 0);
    private Vector3 angle;
//    private GameController _gameController;
    // Start is called before the first frame update
    void Start()
    {
//        this.gameObject.transform.localRotation = Quaternion.identity;
//        this._gameController = FindObjectOfType<GameController>();

    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        angle = dt * rotationSpeed;
        angle = angle * GameController.Instance().simulationSpeed;
        this.gameObject.transform.localRotation = this.gameObject.transform.localRotation * Quaternion.Euler(angle);
    }
}
