using UnityEngine;

public static class MihoyoEngineEx
{
    public static bool HasParameter(this Animator animator, int nameHash)
    {
        bool flag = false;
        foreach (var para in animator.parameters)
        {
            if (para.nameHash == nameHash)
            {
                flag = true;
                break;
            }
        }
        return flag;
    }
}