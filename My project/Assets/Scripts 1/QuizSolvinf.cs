using UnityEngine;

public enum RainBow
{
    Red,
    Scarlet,
    Yellow,
    Green,
    Blue,
    MarineBlue,
    Purple
}
public enum fruitPackage
{
    Apple,
    Banana,
    Mango
}
[AddComponentMenu("JS/QuizSolvinf")]

public class QuizSolvinf : MonoBehaviour
{
    

    #region 2¹ø¹®Á¦
    public bool isJumpPossible;
    
    public int Money = 100900;
    [Range(1, 99)]
    public float fov;
    public fruitPackage frp;
    public RainBow rbw;
    #endregion

}
