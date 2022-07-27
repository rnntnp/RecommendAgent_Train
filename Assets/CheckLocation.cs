using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckLocation : MonoBehaviour
{
    public float playerDirection;
    public int wallId;
    public string location;
    public TMP_Text locationText;
    public request newRequest;
    //planet -> playground => 1 (x, +)
    //playground - game box => 2 (z, +)
    //game box - dino => 3 (x, -)
    //dino - planet => 4  (z, -)
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other) {
        if(other.CompareTag("Player")){
            if(wallId == 1){
                playerDirection = GameManager.Instance.owner.GetComponent<Rigidbody>().velocity.x;
                if(playerDirection>=0){
                    location = "playground";
                }
                else{
                    location = "planetland";
                }
                locationText.text = location;
            }
            else if (wallId == 2)
            {
                playerDirection = GameManager.Instance.owner.GetComponent<Rigidbody>().velocity.z;
                if (playerDirection >= 0)
                {
                    location = "gamemachine";
                }
                else
                {
                    location = "playground";
                }
                locationText.text = location;
            }
            else if (wallId == 3)
            {
                playerDirection = GameManager.Instance.owner.GetComponent<Rigidbody>().velocity.x;
                if (playerDirection < 0)
                {
                    location = "Jurassicpark";
                }
                else
                {
                    location = "gamemachine";
                }
                locationText.text = location;
            }
            else if (wallId == 4)
            {
                playerDirection = GameManager.Instance.owner.GetComponent<Rigidbody>().velocity.z;
                if (playerDirection < 0)
                {
                    location = "planetland";
                }
                else
                {
                    location = "Jurassicpark";
                }
                locationText.text = location;
            }
            newRequest.CheckQuestSuccess();
            
        }
    }
}
