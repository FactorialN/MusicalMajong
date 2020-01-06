
using UnityEngine;
using System.Collections;

public class TolowKiller : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -2)//一旦掉出Plane
        {
            GameObject.Destroy(gameObject);//摧毁物件
        }
    }

}