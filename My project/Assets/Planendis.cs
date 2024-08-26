using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planendis : MonoBehaviour
{
    public Transform player;
    public GameObject platform;
    public GameObject present;
    public GameObject next;
    public Vector3 present_pos;
    public Vector3 next_pos;
    // Start is called before the first frame update
    void Start()
    {
        present_pos=new Vector3(0,0,0);
        present = Instantiate(platform, present_pos, Quaternion.identity);
        player.position = new Vector3(0,4,0);
        StartCoroutine(playGame());
    }

    IEnumerator playGame()
    {
        while(true)
        {
            next_pos=new Vector3(present_pos.x,present_pos.y,present_pos.z);
            int c=Random.Range(1,4);
            if(c==1) next_pos.x+=20;
            else if(c==2) next_pos.x-=20;
            else if(c==3) next_pos.z+=20;
            else if(c==4) next_pos.z-=20;
            Debug.Log(present_pos);
            Debug.Log(next_pos);
            Debug.Log("---------------");
            yield return new WaitForSeconds(2.5f);
            next = Instantiate(platform, next_pos, Quaternion.identity);
            yield return new WaitForSeconds(2.5f);
            Destroy(this.present);
            present_pos=next_pos;
            present=next;
        }
    }
}
