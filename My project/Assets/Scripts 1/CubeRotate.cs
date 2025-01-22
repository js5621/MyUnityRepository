using UnityEngine;
/// <summary>
/// 큐브를 회전 시키는 
/// </summary>
public class CubeRotate : MonoBehaviour
{
    #region 필기내용
    // 자료형(type)
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // 정수형
    #endregion

    #region 변수
    public float x;//유니티에서 공개되는 변수 
    public float z;
    private int sample; // 유니티 에디터에서 공개가 안되는 변수
    // 사용하는 사람이 실수할까봐 막는변수
    #endregion

    #region 함수
    void Start()
    {
        sample = 10; //변수가 비공개일경우 코드 내부에서 설정되는 경우가 많다.
        Debug.Log(sample);
        // "" 없이 변수만 적으면 그 값이 들어가는 방식
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(x*Time.deltaTime,0,z*Time.deltaTime));//게임수학
        //FPS(FramePer Second) : 초 당 프레임
        //deltaTime: 전 프레임이 완료되기까지 걸리는 시간 
    }
    #endregion 함수
}
