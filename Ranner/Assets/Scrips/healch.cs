using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healch : MonoBehaviour
{
    [SerializeField] private int health = 3;
    [SerializeField] private GameObject losePanel;

    public int healthh;
    public int numberOfLives;
    public Image[] lives;
    public Sprite fullLive;
    public Sprite emptyLives;

    private void Update()
    {
        if (health == 0)
        {
            losePanel.SetActive(true);
            Time.timeScale = 0;
        }

        for (int i = 0; i < lives.Length; i++)
        {
            if (i < numberOfLives)
            {
                lives[i].enabled = true;
            }
            else
            {
                lives[i].enabled = false;
            }

            if (i < Mathf.RoundToInt(health))
            {
                lives[i].sprite = fullLive;
            }
            else
            {
                lives[i].sprite = emptyLives;
            }
        }
    }

    private void OnTriggerEnter(Collider collider) 
    {
        if (collider.gameObject.tag == "obstacle")
        {
            health --;
        }
    }


    // private void OnControllerColliderHit(ControllerColliderHit hit)
    // {
    //     if (hit.gameObject.tag == "obstacle")
    //     {
    //         losePanel.SetActive(true);
    //         Time.timeScale = 0;
    //     }
    // }

}
