using UnityEngine;


[System.Serializable]
public struct HexCoordinates
{
    [SerializeField]
    private int x, z;

    public readonly int X { get { return x; } }
    public readonly int Z { get { return z; } }


    public HexCoordinates(int x, int z)
    {
        this.x = x;
        this.z = z;
    }
    public static HexCoordinates FromOffsetCoordinates(int x, int z)
    {
        return new HexCoordinates(x - z / 2, z);
    }
    public readonly int Y
    {
        get { return -X - Z; }
    }
    public override readonly string ToString()
    {
        return "(" + X.ToString() + ", " + Y.ToString() + ", " + Z.ToString() + ")";
    }
    public readonly string ToStringOnSeparateLines()
    {
        return X.ToString() + "\n" + Y.ToString() + "\n" + Z.ToString();
    }
}