using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultipleChoiceButtonUI : MonoBehaviour
{
    public Text field;
    int goToId;
    ChatUI chatUI;

    public void Init(ChatUI chatUI, Talk.MultipleChoiceData data) {
        this.chatUI = chatUI;
        field.text = data.text;
        goToId = data.goToId;
    }

    public void Clicked(){
        chatUI.GoTo(goToId);
    }
}
