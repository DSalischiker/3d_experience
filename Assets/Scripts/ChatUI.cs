using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatUI : MonoBehaviour {
    public Text simpleField;
    public Text multipleChoiceField;

    public MultipleChoiceButtonUI multipleChoiceButton;
    public Transform mcContainer;

    public Talk talkState;

    public GameObject SimpleText;
    public GameObject MultipleChoice;

    Talk.SpeachData[] speachData;
    Talk.SpeachData speachDataActive;

    private void Awake() {
        Hide();
    }
    int id;

    public void Init(Talk.SpeachData[] speachData, Talk talkState) {
        this.talkState = talkState;
        this.speachData = speachData;
        id = 0;
        gameObject.SetActive(true);
        SetNewLine();
    }

    void SetNewLine() {
        speachDataActive = speachData[id];
        int length = speachDataActive.multipleChoice.Length;

        /* talkState.ChangeMood(speachDataActive.mood); */

        if (length == 0)
        {
            simpleField.text = speachDataActive.text;
            SimpleText.SetActive(true);
            MultipleChoice.SetActive(false);
        } else {
            MultipleChoiceButtonUI[] all = mcContainer.GetComponentsInChildren<MultipleChoiceButtonUI>();
            int i = all.Length;
            while(i>0) {
                Destroy(all[i-1].gameObject);
                i--;
            }

            foreach (Talk.MultipleChoiceData mcData in speachDataActive.multipleChoice)
            {
                MultipleChoiceButtonUI button = Instantiate(multipleChoiceButton, mcContainer);
                button.Init(this, mcData);
            }
            multipleChoiceField.text = speachDataActive.text;
            SimpleText.SetActive(false);
            MultipleChoice.SetActive(true);
        }
    }

    public void OnNext() {
        id = speachDataActive.goToId;
        if (id == 0)
        {
            Hide();
        } else {
            SetNewLine();
        }
    }

    public void GoTo(int _id) {
        id = _id;
        SetNewLine();
    }

    public void Hide() {
        gameObject.SetActive(false);
    }
}