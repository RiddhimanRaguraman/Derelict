using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class DialogueTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("Player")]
    [SerializeField] private GameObject PLAYER;

    [Header("one JSON")]
    [SerializeField] private TextAsset oneJSON;

    private bool playerInRange;

    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);
    }

    private void Update()
    {
        if (playerInRange)// && !DialogueManager.GetInstance().dialogueIsPlaying)
        {
            visualCue.SetActive(true);
            /*if (PLAYER.GetInstance().GetInteractPressed())
            {
                //DialogueManager.GetInstance().EnterDialogueMode(oneJSON);
            }*/
        }
        else
        {
            visualCue.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }
}
