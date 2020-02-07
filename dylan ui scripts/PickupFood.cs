using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupFood : MonoBehaviour
{
    public GameObject sceneManager;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Food")
        {
            // if we collide with food, increase hunger meter
            sceneManager.SendMessage("increaseHunger", 10f);

            // update game score based on the food's value
            sceneManager.SendMessage("updateScore", col.gameObject.GetComponent<FoodValue>().score);

            // TODO: apply any status effect on moth here (value stored on col.gameObject.GetComponent<FoodValue>().effect)


            Destroy(col.gameObject);
        }
    }
}
