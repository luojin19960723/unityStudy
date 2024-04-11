using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test03 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
        print(this.gameObject.tag);
        print(this.gameObject.layer );
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.name = "立方体";
        GameObject obj2 = GameObject.Instantiate(obj);
           GameObject.Destroy(this
           );
           new GameObject("空物体", typeof(Test02));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
