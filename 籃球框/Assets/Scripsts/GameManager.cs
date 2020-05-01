
using UnityEngine;
using UnityEngine.UI;
using Valve.VR.InteractionSystem;

public class GameManager : MonoBehaviour
{
    [Header("籃球數量")]
    public Text textballcount;
    private int ballcount = 5;
    [Header("分數")]
    public Text textscore;
    private int score;
    public void Useball(GameObject ball) 
    {
        Destroy(ball.GetComponent<Throwable>());
        Destroy(ball.GetComponent<Interactable>());
        ballcount--;
        textballcount.text = "籃球數量:" + ballcount + "/5";
    }

    // Update is called once per frame
    private void    OnTriggerEnter(Collider other)
    {
        score += 2;
        textscore.text = "分數" + score;
    }
}
