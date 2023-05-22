using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    public TextMeshProUGUI dialogueText;
    public GameObject dialoguePrefab;
    public GameObject nextButton;
    public GameObject character;
    public float Xoffset;
    public float Yoffset;
    public GameObject canvas2;
    
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
        nextButton.SetActive(true);
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
        canvas2.SetActive(true);
    }
    // Update is called once per frame
   
}
