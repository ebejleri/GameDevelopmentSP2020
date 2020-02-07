using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayProcesses : MonoBehaviour
{

    public float hunger = 60;

    // speed is amount decremented per call
    public float hungerSpeed = 1;

    // rate is amount of function calls
    public float hungerRate = 1f;
    public Image hungerMeter;

    // hunger adjustment is to offset gameover time for
    // when it reaches whatever image is in the center
    public float hungerAdjustment = 0;

    public float time = 100;
    private float curTime;
    private float curHunger;

    public GameObject heartContainer;
    private int lives;
    private int curlife;
    public GameObject TimeDisplay;
    public GameObject TimeBar;

    public GameObject scoreDisplay;

    public int score = 0;

    void Start()
    {
        curTime = time;
        curHunger = hunger * .3f;
        InvokeRepeating("decreaseHunger", 0f, hungerRate);
        InvokeRepeating("decreaseTime", 0f, 1.0f);
        lives = heartContainer.transform.childCount;
        curlife = lives;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void decreaseHunger()
    {
        //if you run out of hunger you loose
        if (curHunger > 0 + hungerAdjustment)
        {
            curHunger -= hungerSpeed;
            hungerMeter.transform.localScale = new Vector3((curHunger / hunger) + hungerAdjustment, (curHunger / hunger) + hungerAdjustment, 1);

        }
        else SceneManager.LoadScene(0);
    }

    public void increaseHunger(float amount)
    {

        curHunger += amount;
        if (curHunger > hunger * .3f)
            curHunger = hunger * .3f;
        hungerMeter.transform.localScale = new Vector3((curHunger / hunger) + hungerAdjustment, (curHunger / hunger) + hungerAdjustment, 1);
    }

    public void damagePlayer()
    {
        curlife -= 1;
        Debug.Log(curlife);
        heartContainer.transform.GetChild(curlife).gameObject.SetActive(false);
        if (curlife == 0)
            SceneManager.LoadScene(0);
    }

    public void updateScore(int val)
    {
        score += val;
        scoreDisplay.GetComponent<Text>().text = "Score: " + score;
    }


    void decreaseTime()
    {
        //if you run out of time you loose
        if (curTime > 0)
        {
            curTime -= 1;
            TimeDisplay.GetComponent<Text>().text = "Time: " + curTime;
            TimeBar.GetComponent<Slider>().value = (curTime / time);
        }
        else SceneManager.LoadScene(0);
    }
}
