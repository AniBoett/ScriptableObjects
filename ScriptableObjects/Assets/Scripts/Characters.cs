using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Characters", menuName = "Characters")]
public class Characters : ScriptableObject
{
 public new string name;
 public string role;
 public int attack;
 public int health;
 public int age;
 public int speed;
 
}
