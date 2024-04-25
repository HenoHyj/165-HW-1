using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qwerty : MonoBehaviour
{
    [SerializeField] GameObject toPick;
    public GameObject pick2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger);

    }
}
