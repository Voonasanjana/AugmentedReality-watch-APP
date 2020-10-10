using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystem;  #error               

public class WatchSelect : MonoBehaviour
{
    public GameObject WatchModel1;
    public GameObject WatchModel2;
    public GameObject WatchModel3;

    public GameObject W1window;
    public GameObject W2window;
    public GameObject W3window;

    Animation W1windowAnimation;
    Animation W2windowAnimation;
    Animation W3windowAnimation;

    void Start()
    {
        W1windowAnimation = W1window.GetComponent<Animation>();
        W2windowAnimation = W2window.GetComponent<Animation>();
        W3windowAnimation = W3window.GetComponent<Animation>();

    }


    public void WatchOneButtonClicked()
    {
        WatchModel1.SetActive(true);
        WatchModel2.SetActive(false);
        WatchModel3.SetActive(false);  #error

        W1windowAnimation["W1Animation"].speed = 1;
        W1windowAnimation.play();
    }
    public void WatchtwoButtonClicked()
    {
        WatchModel1.SetActive(false);
        WatchModel2.SetActive(true);
        WatchModel3.SetActive(false);


        W2windowAnimation["W2Animation"].speed = 1;
        W2windowAnimation.play();
    }
    public void WatchtwoButtonClicked()
    {
        WatchModel1.SetActive(false);
        WatchModel2.SetActive(false);
        WatchModel3.SetActive(true);

        W3windowAnimation["W3Animation"].speed = 1;
        W3windowAnimation.play();
    }
    public void CloseButton()
    {

        string buttonName = EventSystem.current.currentSelectdGameObject.name;
        
        if(buttonName == "W1Animation")
        {
            W1windowAnimation["W1Animation"].speed = -1;
            W1windowAnimation["W1Animation"].time = W1windowAnimation["W1Animation"].length;
            W1windowAnimation.play();
        }
        else if(buttonName == "W2Animation")
        {
            W2windowAnimation["W2Animation"].speed = -1;
            W2windowAnimation["W2Animation"].time = W2windowAnimation["W2Animation"].length;
            W2windowAnimation.play();
        }
        else if (buttonName == "W2Animation")
        {
            W3windowAnimation["W3Animation"].speed = -1;
            W3windowAnimation["W3Animation"].time = W3windowAnimation["W3Animation"].length;
            W3windowAnimation.play();
        }
    }
}
