using UnityEngine;
// using은 다음에 적힌 것을 코드에서 사용하는 중
// 유니티에서 유니트를 활용해 작업하는 스크립트 라면 위의 코드를 반드시 추가해주세요
//네임스페이스는 특정 기능을 하는 클래스의 대표적인 이름으로써 사용합니다.
namespace TowerDefence
{
    //  UnityTutorial 영역에서 만들어진 SampleA클래스
    public class PlaySetting
    {
        
    }
}

public class SampleA
{

}
/// <summary>
/// 처음으로 만들어본 유니티의 스크립트
/// </summary>
public class Test2 : MonoBehaviour
    //MonoBehavior 클래스에 연결했을경우
    // 유니티씬에 존재하는 오브젝트에 스크립트를 연결할수 있게 해줍니다.
    // 추가적으로 유니티에서 제공해주는 기능할때 사용합니다.
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello");
    }
    int count = 0;
  

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"{count}좌우 반복뛰기");
        count++;// 카운트가 1 증가한다.
    }
}
