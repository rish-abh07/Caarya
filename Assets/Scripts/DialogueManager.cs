using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    public Text dialogueText;
    public GameObject dialoguePrefab;
    public GameObject character;
    public float Xoffset;
    public float Yoffset;
    
    // Start is called before the first frame update
    void Start()
    {
        sentences= new Queue<string>();
    }
    public void StartDialogue(Dialogue dialogue)
    {
        
        sentences.Clear();
        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        dialoguePrefab.transform.position = character.transform.position - new Vector3(Xoffset,Yoffset,0);
        dialoguePrefab.SetActive(true);
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if(sentences.Count == 0) {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    void EndDialogue()
    {
       dialoguePrefab.SetActive(false);
    }
    // Update is called once per frame
   
}
