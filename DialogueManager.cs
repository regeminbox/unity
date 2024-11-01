using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueText;
    public GameObject dialogueBox;
    public Image dialogueImage;
    public Sprite[] dialogueImages;
    public string[] dialogueLines;
    public int currentLine;

    private bool isTyping = false;
    private bool cancelTyping = false;

    void Start()
    {
        dialogueBox.SetActive(false);
        ShowDialogue();
    }

    void Update()
    {
        if (dialogueBox.activeInHierarchy && Input.GetKeyDown(KeyCode.Space))
        {
            if (!isTyping)
            {
                currentLine++;
                if (currentLine < dialogueLines.Length)
                {
                    StartCoroutine(TypeSentence(dialogueLines[currentLine]));
                    if (currentLine < dialogueImages.Length)
                    {
                        dialogueImage.sprite = dialogueImages[currentLine];
                    }
                }
                else
                {
                    dialogueBox.SetActive(false);
                }
            }
            else if (isTyping && !cancelTyping)
            {
                cancelTyping = true;
            }
        }
    }

    IEnumerator TypeSentence(string sentence)
    {
        isTyping = true;
        cancelTyping = false;
        dialogueText.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
            if (cancelTyping)
            {
                dialogueText.text = sentence;
                break;
            }
        }

        isTyping = false;
        cancelTyping = false;
    }

    public void ShowDialogue()
    {
        currentLine = -1;
        dialogueBox.SetActive(true);
        dialogueImage.sprite = dialogueImages[0];
    }
}