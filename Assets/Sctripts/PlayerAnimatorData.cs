using UnityEngine;

public class PlayerAnimatorData : MonoBehaviour
{
    private const string HorizonalAxis = "horizonalAxis";
    private const string VerticalAxis = "verticalAxis";

    public readonly int HorizonalAxisID = Animator.StringToHash(HorizonalAxis);
    public readonly int VerticalAxisID = Animator.StringToHash(VerticalAxis);
}