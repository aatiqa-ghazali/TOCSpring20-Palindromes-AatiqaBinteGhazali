﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class text : MonoBehaviour
{
    public Text nameLabel;

    // Update is called once per frame
    void Update()
    {

        Vector3 namepos = Camera.main.WorldToScreenPoint(this.transform.position);
        nameLabel.transform.position = namepos;
        
    }
}
