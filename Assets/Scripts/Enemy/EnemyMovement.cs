﻿using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    private Transform player; // Reference to the player's position.
    private PlayerHealth playerHealth; // Reference to the player's health.
    private EnemyHealth enemyHealth; // Reference to this enemy's health.
    private NavMeshAgent nav; // Reference to the nav mesh agent.


    private void Awake()
    {
        // Set up the references.
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<NavMeshAgent>();
    }


    private void Update()
    {
        // If the enemy and the player have health left...
        if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        {
            nav.SetDestination(player.position);
        }
        // Otherwise...
        else
        {
            // ... disable the nav mesh agent.
            nav.enabled = false;
        }
    }
}