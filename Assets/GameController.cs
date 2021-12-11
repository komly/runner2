using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject groundPref;
    public GameObject ground;

    public float timeSince = 0;

    void Start()
    {
        ground = Instantiate(groundPref, transform, false);

    }

    void Update()
    {
        Debug.Log(timeSince.ToString());
        timeSince += Time.deltaTime;
        if (timeSince >= 100) {
            Debug.Log(timeSince);
            timeSince = 0;
        }
    }
}
