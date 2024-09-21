using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    //Specifically (cat)
    public void Climb()
    {
        Debug.Log($"{Name} Climb");
    }
    private void Start()
    {
        //Cat
        Name = "Cat";
        Debug.Log($"Name {Name} has health: {Health}, Speed: {Speed}, Hunger: {GetHunger()}");
        Eat(food[0]);
        Move();
        Sleep();

    }
}
