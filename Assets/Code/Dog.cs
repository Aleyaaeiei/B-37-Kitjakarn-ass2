using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    //Specifically (dog)
    public string Breed { get; set; }
    public void Fetch()
    {
        Debug.Log($"{Name} Fetch");
    }
    private void Start()
    {
        //Dog
        Name = "Dog";
        Debug.Log($"Name {Name} has health: {Health}, Speed: {Speed}, Hunger: {GetHunger()}");
        Eat(food[0]);
        Move();
        Sleep();
    }
}
