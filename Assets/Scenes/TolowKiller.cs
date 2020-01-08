
using UnityEngine;
using System.Collections;

public class TolowKiller : MonoBehaviour
{
    public CreateBall motherfucker;

    bool retard = true;

    // Use this for initialization
    void Start()
    {
        retard = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (System.Math.Abs(gameObject.GetComponent<Rigidbody>().velocity.x) > (-gameObject.GetComponent<Rigidbody>().velocity.z) && retard)
        {
            motherfucker.score++;
            motherfucker.combo++;
            retard = false;
        }
        if (gameObject.GetComponent<Rigidbody>().position.z < -1.0f && retard)
        {
            motherfucker.combo = 0;
            retard = false;
        }
    }

}