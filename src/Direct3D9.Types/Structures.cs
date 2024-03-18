namespace Direct3D9.Types;

public static class TransformState
{
	public static TransformStateType WorldMatrix(int index) => (TransformStateType)(index + 255);
	public static TransformStateType World => WorldMatrix(0);
	public static TransformStateType World1 => WorldMatrix(1);
	public static TransformStateType World2 => WorldMatrix(2);
	public static TransformStateType World3 => WorldMatrix(3);
}