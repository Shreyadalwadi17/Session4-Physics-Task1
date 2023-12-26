using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    Rigidbody rb;
    public GameObject point;
    public GameObject ball;
    public GameObject bat;
    public RaycastHit hit;
    public LayerMask pitch;


    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 50f, pitch))
        {
            if (Input.GetMouseButtonDown(0))
            {
                point.transform.position = new Vector3(hit.point.x, -2.09f, hit.point.z);

                GameObject clone = Instantiate(ball, ball.transform.position, ball.transform.rotation);
                Ballshoot shoot = clone.GetComponent<Ballshoot>();
                shoot.Shoot(hit.point);

                Destroy(clone, 3f);
            }


        }

    }
}
