using UnityEngine;
using GameLib.Components;

public static class VectorExtension
{
    public static Vector3 ConvertVector3(this Pozition pos)
    {
        return new Vector3(pos.X, pos.Y, pos.Z);
    }

    public static Vector2 ConvertVector2(this Pozition pos)
    {
        Vector3 vector = new Vector3(pos.X, pos.Y, 0);
        Vector2 vector2 = vector;
        return vector2;
    }
}
