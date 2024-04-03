using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrRigRef : MonoBehaviour
{
    public static VrRigRef Singleton;

    public Transform root;
    public Transform Cube;

    private void Awake()
    {
        Singleton = this;
    }

}
