using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode.Components;

public class NetworkTransofrmClient : NetworkTransform
{
    protected override bool OnIsServerAuthoritative()
    {
        return false;  
    }
}
