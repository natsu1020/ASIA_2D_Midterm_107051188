using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject final;
    public GameObject restart;
    public AudioSource pineappleAudio;
    public Text textCount;
    public int count;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "傳送門")
        {
            final.SetActive(true);
        }
        if (collision.name == "尖刺")
        {
            restart.SetActive(true);
        }
        if (collision.tag == "鳳梨")
        {
            pineappleAudio.Play();
            Destroy(collision.gameObject);

            count++;
            textCount.text = "Score:" + count;


        }



    }

}
