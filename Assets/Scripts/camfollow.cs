﻿using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using UnityEngine;

public class camfollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    private void Update()
    {
        transform.position = target.position + offset;
    }

}
