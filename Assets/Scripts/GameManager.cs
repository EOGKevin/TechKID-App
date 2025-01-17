using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Text welcomeText;
    // Start is called before the first frame update
    void Start()
    {
        ShowWelcomeMessage();
    }

    private void ShowWelcomeMessage()
    {
        welcomeText.text = $"Welcome {References.userName} to our Game Scene";
    }
}
