using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bathit : MonoBehaviour
{
    public GameObject bat;

    private void OnTriggerEnter(Collider colider)
    {

        bat.transform.position = new Vector3(colider.transform.position.x, bat.transform.position.y, bat.transform.position.z);
    }


}
