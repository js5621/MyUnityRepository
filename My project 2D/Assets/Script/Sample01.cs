using UnityEngine;
[AddComponentMenu("JS/Sample01")]
public enum Rainbow
{
    ��,��,��,��,��,��,��

}
public class Sample01 : MonoBehaviour
{
    public bool isJumpable;
    public string[] basket;
    public int Money;
    public Rainbow Rainbow;
    
    [Range(1,99)]public float FieldOfView;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
