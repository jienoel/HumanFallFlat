namespace InControl
{
	[AutoDiscover]
	public class NykoPlayPadProAmazonProfile : UnityInputDeviceProfile
	{
		public NykoPlayPadProAmazonProfile()
		{
			base.Name = "Nyko PlayPad Pro";
			base.Meta = "Nyko PlayPad Pro on Amazon Fire TV";
			base.DeviceClass = InputDeviceClass.Controller;
			base.IncludePlatforms = new string[1]
			{
				"Amazon AFT"
			};
			JoystickNames = new string[1]
			{
				"NYKO PLAYPAD PRO"
			};
			base.ButtonMappings = new InputControlMapping[10]
			{
				new InputControlMapping
				{
					Handle = "A",
					Target = InputControlType.Action1,
					Source = UnityInputDeviceProfile.Button0
				},
				new InputControlMapping
				{
					Handle = "B",
					Target = InputControlType.Action2,
					Source = UnityInputDeviceProfile.Button1
				},
				new InputControlMapping
				{
					Handle = "X",
					Target = InputControlType.Action3,
					Source = UnityInputDeviceProfile.Button2
				},
				new InputControlMapping
				{
					Handle = "Y",
					Target = InputControlType.Action4,
					Source = UnityInputDeviceProfile.Button3
				},
				new InputControlMapping
				{
					Handle = "Left Bumper",
					Target = InputControlType.LeftBumper,
					Source = UnityInputDeviceProfile.Button4
				},
				new InputControlMapping
				{
					Handle = "Right Bumper",
					Target = InputControlType.RightBumper,
					Source = UnityInputDeviceProfile.Button5
				},
				new InputControlMapping
				{
					Handle = "Left Stick Button",
					Target = InputControlType.LeftStickButton,
					Source = UnityInputDeviceProfile.Button8
				},
				new InputControlMapping
				{
					Handle = "Right Stick Button",
					Target = InputControlType.RightStickButton,
					Source = UnityInputDeviceProfile.Button9
				},
				new InputControlMapping
				{
					Handle = "Back",
					Target = InputControlType.Back,
					Source = UnityInputDeviceProfile.EscapeKey
				},
				new InputControlMapping
				{
					Handle = "Menu",
					Target = InputControlType.Menu,
					Source = UnityInputDeviceProfile.Button10
				}
			};
			base.AnalogMappings = new InputControlMapping[10]
			{
				UnityInputDeviceProfile.LeftStickLeftMapping(UnityInputDeviceProfile.Analog0),
				UnityInputDeviceProfile.LeftStickRightMapping(UnityInputDeviceProfile.Analog0),
				UnityInputDeviceProfile.LeftStickUpMapping(UnityInputDeviceProfile.Analog1),
				UnityInputDeviceProfile.LeftStickDownMapping(UnityInputDeviceProfile.Analog1),
				UnityInputDeviceProfile.RightStickLeftMapping(UnityInputDeviceProfile.Analog2),
				UnityInputDeviceProfile.RightStickRightMapping(UnityInputDeviceProfile.Analog2),
				UnityInputDeviceProfile.RightStickUpMapping(UnityInputDeviceProfile.Analog3),
				UnityInputDeviceProfile.RightStickDownMapping(UnityInputDeviceProfile.Analog3),
				new InputControlMapping
				{
					Handle = "Left Trigger",
					Target = InputControlType.LeftTrigger,
					Source = UnityInputDeviceProfile.Analog12
				},
				new InputControlMapping
				{
					Handle = "Right Trigger",
					Target = InputControlType.RightTrigger,
					Source = UnityInputDeviceProfile.Analog11
				}
			};
		}
	}
}
