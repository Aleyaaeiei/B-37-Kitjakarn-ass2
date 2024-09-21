using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    //Attributes
    public string Name { get; set; }
    protected string[] food = {"Meat","Plant" };

    //Hp all animal
    public int Hp = 10;
    public int Health { get { return Hp; } set { Health = Hp; } }

    private float hunger;
    public float GetHunger()
    {
        return hunger;
    }

    //Hunger all animal
    private void SetHunger(float _hunger)
    {
        _hunger = 0;
        hunger = _hunger;
    }

    //Speed all animal
    private float speed = 3f;
    public float Speed { get { return speed; } private set { Speed = speed; } }

    //Same move all animal
    public void Eat(string food)
    {
        Debug.Log($"{Name} Eat {food}.");
    }
    public void Move()
    {
        Debug.Log($"{Name} Move.");
    }
    public void Sleep()
    {
        Debug.Log($"{Name} Sleep.");
    }
}
