using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    public GameObject planet;
    public Vector3 rotation;
    // Update is called once per frame
    private void Update()
    {
        planet.transform.Rotate(rotation*Time.deltaTime);
    }
}
