using UnityEngine;  
  
public class RandomPositionSphere : MonoBehaviour  
{  
   
  
   
    public Vector2 randomAreaSize = new Vector2(20f, 20f); // X轴和Z轴的范围  
    // 定义地面的高度（对于简单的平面地面）  
    public float groundHeight = 5f;  
  
    private void Start()  
    {  
        // 设置球体的随机位置  
        SetRandomPositionOnGround();  
    }  
  
    private void SetRandomPositionOnGround()  
    {  
        // 生成随机位置（在X和Z轴上）  
        float randomX = Random.Range(-randomAreaSize.x / 2f, randomAreaSize.x / 2f);  
        float randomZ = Random.Range(-randomAreaSize.y / 2f, randomAreaSize.y / 2f);  
          
        // 设置球体的位置（Y轴为地面高度）  
        transform.position = new Vector3(randomX, groundHeight, randomZ);  
    }  
}