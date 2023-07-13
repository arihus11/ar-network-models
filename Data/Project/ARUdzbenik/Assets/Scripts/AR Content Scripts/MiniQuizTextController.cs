using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MiniQuizTextController : MonoBehaviour
{
    [SerializeField]
    public GameObject QuestionTextObject, QuestionFrame;
    [SerializeField]
    public GameObject[] SelectableObjects;

    private TextMeshProUGUI QuestionText;

    [SerializeField]
    private string _question;
    // Start is called before the first frame update
    void Start()
    {
        QuestionText = QuestionTextObject.gameObject.transform.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetQuestionText() 
    {
        QuestionFrame.SetActive(true);
        QuestionText.text = _question;
    }

    public void RemoveQuestionText() 
    {
         QuestionText.text = "";
         foreach (GameObject obj in SelectableObjects) {
            obj.gameObject.GetComponent<ObjectSelect>().ResetSelectedState();
         }
         QuestionFrame.SetActive(false);
    }
}
