namespace Raylib 
{
    [System.Serializable]
    public struct Vector4 
    {
        public float x;
        public float y;
        public float z;
        public float w;

        public static Vector4 operator * (Vector4 a, float x) { return new Vector4(a.x * x, a.y * x, a.z * x, a.w * x); }
        public static Vector4 operator * (float x, Vector4 a) { return new Vector4(a.x * x, a.y * x, a.z * x, a.w * x); }

        public static Vector4 operator / (Vector4 a, float x)
        {
            if (x == 0f) { throw new System.DivideByZeroException(); }
            return new Vector4(a.x / x, a.y / x, a.z / x, a.w / x);
        }

        public static Vector4 operator / (float x, Vector4 a)
        {
            if (x == 0f) { throw new System.DivideByZeroException(); }
            return new Vector4(a.x / x, a.y / x, a.z / x, a.w / x);
        }

        public static Vector4 operator + (Vector4 a, Vector4 b) { return new Vector4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w); }
        public static Vector4 operator - (Vector4 a, Vector4 b) { return new Vector4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w); }

        public override string ToString() { return "(" + x.ToString() + ", " + y.ToString() + ", " + z.ToString() + ", " + w.ToString() + ")"; }
        public Vector4(float x, float y, float z, float w) 
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
    }

    [System.Serializable]
    public struct Vector3 
    {
        public float x;
        public float y;
        public float z;

        public static readonly Vector3 zero = new Vector3(0f, 0f, 0f);
        public static readonly Vector3 one = new Vector3(1f, 1f, 1f);
        public static readonly Vector3 back = new Vector3(0f, 0f, -1f);
        public static readonly Vector3 down = new Vector3(0f, -1f, 0f);
        public static readonly Vector3 forward = new Vector3(0f, 0f, 1f);
        public static readonly Vector3 left = new Vector3(-1f, 0f, 0f);
        public static readonly Vector3 right = new Vector3(1f, 0f, 0f);
        public static readonly Vector3 up = new Vector3(0f, 1f, 0f);

        public static Vector3 operator * (Vector3 a, float x) { return new Vector3(a.x * x, a.y * x, a.z * x); }
        public static Vector3 operator * (float x, Vector3 a) { return new Vector3(a.x * x, a.y * x, a.z * x); }

        public static Vector3 operator / (Vector3 a, float x)
        {
            if (x == 0f) { throw new System.DivideByZeroException(); }
            return new Vector3(a.x / x, a.y / x, a.z / x);
        }

        public static Vector3 operator / (float x, Vector3 a)
        {
            if (x == 0f) { throw new System.DivideByZeroException(); }
            return new Vector3(a.x / x, a.y / x, a.z / x);
        }

        public static Vector3 operator + (Vector3 a, Vector3 b) { return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z); }
        public static Vector3 operator - (Vector3 a, Vector3 b) { return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z); }

        public static Vector3 Convert(Vector3 a) { return new Vector3((float)a.x, (float)a.y, (float)a.z); }

        public override string ToString() { return "(" + x.ToString() + ", " + y.ToString() + ", " + z.ToString() + ")"; }
        public Vector3(float x, float y, float z) 
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    [System.Serializable]
    public struct Vector2 
    {
        public float x;
        public float y;

        public static readonly Vector2 zero = new Vector2(0f, 0f);
        public static readonly Vector2 one = new Vector2(1f, 1f);
        public static readonly Vector2 down = new Vector2(0f, -1f);
        public static readonly Vector2 left = new Vector2(-1f, 0f);
        public static readonly Vector2 right = new Vector2(1f, 0f);
        public static readonly Vector2 up = new Vector2(0f, 1f);

        public static Vector2 operator * (Vector2 a, float x) { return new Vector2(a.x * x, a.y * x); }
        public static Vector2 operator * (float x, Vector2 a) { return new Vector2(a.x * x, a.y * x); }

        public static Vector2 operator / (Vector2 a, float x)
        {
            if (x == 0f) { throw new System.DivideByZeroException(); }
            return new Vector2(a.x / x, a.y / x);
        }

        public static Vector2 operator / (float x, Vector2 a)
        {
            if (x == 0f) { throw new System.DivideByZeroException(); }
            return new Vector2(a.x / x, a.y / x);
        }

        public static Vector2 operator + (Vector2 a, Vector2 b) { return new Vector2(a.x + b.x, a.y + b.y); }
        public static Vector2 operator - (Vector2 a, Vector2 b) { return new Vector2(a.x - b.x, a.y - b.y); }

        public static Vector2 Convert(Vector2Int a) { return new Vector2((float)a.x, (float)a.y); }

        public override string ToString() { return "(" + x.ToString() + ", " + y.ToString() + ")"; }
        public Vector2(float x, float y) 
        {
            this.x = x;
            this.y = y;
        }
    }

    [System.Serializable]
    public struct Vector3Int 
    {
        public int x;
        public int y;
        public int z;

        public static readonly Vector3Int zero = new Vector3Int(0, 0, 0);
        public static readonly Vector3Int one = new Vector3Int(1, 1, 1);
        public static readonly Vector3Int back = new Vector3Int(0, 0, -1);
        public static readonly Vector3Int down = new Vector3Int(0, -1, 0);
        public static readonly Vector3Int forward = new Vector3Int(0, 0, 1);
        public static readonly Vector3Int left = new Vector3Int(-1, 0, 0);
        public static readonly Vector3Int right = new Vector3Int(1, 0, 0);
        public static readonly Vector3Int up = new Vector3Int(0, 1, 0);

        public static Vector3Int operator * (Vector3Int a, int x) { return new Vector3Int(a.x * x, a.y * x, a.z * x); }
        public static Vector3Int operator * (int x, Vector3Int a) { return new Vector3Int(a.x * x, a.y * x, a.z * x); }

        public static Vector3Int operator / (Vector3Int a, int x)
        {
            if (x == 0) { throw new System.DivideByZeroException(); }
            return new Vector3Int(a.x / x, a.y / x, a.z / x);
        }

        public static Vector3Int operator / (int x, Vector3Int a)
        {
            if (x == 0) { throw new System.DivideByZeroException(); }
            return new Vector3Int(a.x / x, a.y / x, a.z / x);
        }

        public static Vector3Int operator + (Vector3Int a, Vector3Int b) { return new Vector3Int(a.x + b.x, a.y + b.y, a.z + b.z); }
        public static Vector3Int operator - (Vector3Int a, Vector3Int b) { return new Vector3Int(a.x - b.x, a.y - b.y, a.z - b.z); }

        public static Vector3Int Convert(Vector3 a) { return new Vector3Int((int)a.x, (int)a.y, (int)a.z); }

        public override string ToString() { return "(" + x.ToString() + ", " + y.ToString() + ", " + z.ToString() + ")"; }
        public Vector3Int(int x, int y, int z) 
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    [System.Serializable]
    public struct Vector2Int 
    {
        public int x;
        public int y;

        public static readonly Vector2Int zero = new Vector2Int(0, 0);
        public static readonly Vector2Int one = new Vector2Int(1, 1);
        public static readonly Vector2Int down = new Vector2Int(0, -1);
        public static readonly Vector2Int left = new Vector2Int(-1, 0);
        public static readonly Vector2Int right = new Vector2Int(1, 0);
        public static readonly Vector2Int up = new Vector2Int(0, 1);

        public static Vector2Int operator * (Vector2Int a, int x) { return new Vector2Int(a.x * x, a.y * x); }
        public static Vector2Int operator * (int x, Vector2Int a) { return new Vector2Int(a.x * x, a.y * x); }

        public static Vector2Int operator / (Vector2Int a, int x)
        {
            if (x == 0) { throw new System.DivideByZeroException(); }
            return new Vector2Int(a.x / x, a.y / x);
        }

        public static Vector2Int operator / (int x, Vector2Int a)
        {
            if (x == 0) { throw new System.DivideByZeroException(); }
            return new Vector2Int(a.x / x, a.y / x);
        }

        public static Vector2Int operator + (Vector2Int a, Vector2Int b) { return new Vector2Int(a.x + b.x, a.y + b.y); }
        public static Vector2Int operator - (Vector2Int a, Vector2Int b) { return new Vector2Int(a.x - b.x, a.y - b.y); }

        public static Vector2Int Convert(Vector2 a) { return new Vector2Int((int)a.x, (int)a.y); }

        public override string ToString() { return "(" + x.ToString() + ", " + y.ToString() + ")"; }
        public Vector2Int(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }
    }
}