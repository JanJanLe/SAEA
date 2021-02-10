using System;

namespace SAEA.Audio.NAudio.SoundFont
{
	public enum ControllerSourceEnum
	{
		NoController,
		NoteOnVelocity = 2,
		NoteOnKeyNumber,
		PolyPressure = 10,
		ChannelPressure = 13,
		PitchWheel,
		PitchWheelSensitivity = 16
	}
}
