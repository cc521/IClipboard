namespace MaterialSkin
{
	public interface IMaterialControl
	{
		int Depth
		{
			get;
			set;
		}

		MaterialSkinManager SkinManager
		{
			get;
		}

		MouseState MouseState
		{
			get;
			set;
		}
	}
}
