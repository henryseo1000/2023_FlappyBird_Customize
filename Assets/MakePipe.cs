using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public static float timeDiff = 4; // 파이프가 생성되는 시간 간격
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timeDiff){
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(5, Random.Range(-1.1f, 3.9f), 0);
            timer = 0;
            Destroy(newpipe, 8.0f);
        }
    }
}
