using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Player_SO", menuName = "Character Creation/Player_SO")]
public class Player_SO : ScriptableObject
{
    public float movementSpeed { get; private set; }
    public float jumpSpeed { get; private set; }

    private void OnEnable()
    {
        movementSpeed = 5;
        jumpSpeed = 5;
    }

}
