using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRack : MonoBehaviour
{
    public GameObject cueBall;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;
    public GameObject seven;
    public GameObject eight;
    public GameObject nine;
    public GameObject ten;
    public GameObject eleven;
    public GameObject twelve;
    public GameObject thirteen;
    public GameObject fourteen;
    public GameObject fifteen;
    public Vector3 cueBallLocation;
    public Vector3 location1;
    public Vector3 location2;
    public Vector3 location3;
    public Vector3 location4;
    public Vector3 location5;
    public Vector3 location6;
    public Vector3 location7;
    public Vector3 location8;
    public Vector3 location9;
    public Vector3 location10;
    public Vector3 location11;
    public Vector3 location12;
    public Vector3 location13;
    public Vector3 location14;
    public Vector3 location15;

    void Awake()
    {
        Rack();
    }
    public void Rack()
    {
        Vector3[] locations = { location11, location15, location2, location3, location4, location8, location6,
                                location7, location9, location10, location12, location13, location14 };
        ArrayList ballsSolids = new ArrayList { two, three, four, five, six, seven };
        ArrayList ballsStripes = new ArrayList { nine, ten, eleven, twelve, thirteen, fourteen, fifteen };

        Instantiate(cueBall, cueBallLocation, Quaternion.identity);
        Instantiate(one, location1, Quaternion.identity);
        Instantiate(eight, location5, Quaternion.identity);

        for (int i = 0; i < 13; i++)
        {
            if (i % 2 != 0)
            {
                int num = Random.Range(0, ballsSolids.Count);
                GameObject ball = (GameObject)ballsSolids[num];
                ballsSolids.RemoveAt(num);
                Instantiate(ball, locations[i], Quaternion.identity);
            }
            if (i % 2 == 0)
            {
                int num = Random.Range(0, ballsStripes.Count);
                GameObject ball = (GameObject)ballsStripes[num];
                ballsStripes.RemoveAt(num);
                Instantiate(ball, locations[i], Quaternion.identity);
            }
        }
    }
}
