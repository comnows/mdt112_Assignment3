using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject BoxTrigger;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.Equals(BoxTrigger))
            Destroy(GameObject.Find("Floor1"));
    }
}
