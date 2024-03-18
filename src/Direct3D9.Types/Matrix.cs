namespace Direct3D9.Types;

public record struct Matrix(float _11, float _12, float _13, float _14, float _21, float _22, float _23, float _24, float _31, float _32, float _33, float _34, float _41, float _42, float _43, float _44)
{
	public float this[int x, int y]
	{
		get
		{
			if (x > 3 || y > 3 || x < 0 || y < 0)
				throw new System.IndexOutOfRangeException();
			unsafe
			{
				fixed (Matrix* ptr = &this)
					return ((float*)ptr)[x * 4 + y];
			}
		}
	}
}