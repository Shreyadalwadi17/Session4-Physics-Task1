using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LR : MonoBehaviour
{

    public GameObject bat;
    public GameObject point;
    public GameObject ball;
    public RaycastHit hit;
    private LayerMask pitch;
    public LayerMask leftp;
    public LayerMask rightp;


    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            point.transform.position = new Vector3(hit.point.x, -2.09f, hit.point.z);

            GameObject clone = Instantiate(ball, ball.transform.position, ball.transform.rotation);
            Ballshoot shoot = clone.GetComponent<Ballshoot>();
            shoot.Shoot(hit.point);

            Destroy(clone, 3f);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            pitch = leftp;
            leftb();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            pitch = rightp;
            rightb();
        }

        void leftb()
        {
            bat.transform.position = new Vector3(0.974630237f, -2.01155162f, 21.2900391f);
            bat.transform.rotation = new Quaternion(0, 0, 0.262770116f, 0.964858472f);

        }
        void rightb()

        {
            bat.transform.position = new Vector3(0.356243223f, -1.95224953f, 21.2900391f);
            bat.transform.rotation = new Quaternion(0, 0, -0.336531639f, 0.941672206f);
        }

    }
}