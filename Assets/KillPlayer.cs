﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
[SerializeField] private Transform Player;
[SerializeField] private Transform respawnPoint;

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
	{
        Player.transform.position = respawnPoint.transform.position;
    }

}
