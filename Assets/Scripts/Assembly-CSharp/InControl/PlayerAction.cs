namespace InControl
{
	public class PlayerAction : OneAxisInputControl
	{
		public PlayerAction(string name, PlayerActionSet owner)
		{
		}

		public BindingSourceType LastInputType;
		public ulong LastInputTypeChangedTick;
		public InputDeviceClass LastDeviceClass;
		public InputDeviceStyle LastDeviceStyle;
	}
}
