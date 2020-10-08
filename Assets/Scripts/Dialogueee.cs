using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Dialogueee : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public string[] sentences;
    private int index;

    public float typingSpeed = 0.02f;

    public GameObject continueButton;
    public GameObject dialogueBox;
    public GameObject playerIMG;
    public GameObject charaIMG;


    public bool active;
    public bool touchingChara;
    public bool pressedE;
    public bool playerIsTalking;
    public bool blahIsTalking;


    public string Village, Level1, Level2;


    // Start is called before the first frame update
    void Start()
    {


        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Level 1")
        {
            dialogueBox.SetActive(true);

            StartCoroutine(Type());
        }
        else
        {
            StopAllCoroutines();
            dialogueBox.SetActive(false);
            continueButton.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
      

            if (dialogueText.text != "")
        {
            active = true;
        }
        else if(dialogueText.text == "")
        {
            active = false;
        }
     
        if(Input.GetKeyDown(KeyCode.E) && touchingChara == true && pressedE == false)
        {
          
            dialogueBox.SetActive(true);

            StartCoroutine(Type());
            index = 0;
            pressedE = true;
        }

        if (dialogueText.text == sentences[index])
        {
            continueButton.SetActive(true);
        }

    }
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }

    }
    public void NextSentence()
    {
        continueButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Type());
        }
        else
        {
            dialogueText.text = "";
            continueButton.SetActive(false);

        }


        if (index >= sentences.Length - 1)
        {
            StopAllCoroutines();
            dialogueBox.SetActive(false);
            pressedE = false;
       
            index = 0;
            dialogueText.text = "";
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        touchingChara = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        touchingChara = false;

    }

}
