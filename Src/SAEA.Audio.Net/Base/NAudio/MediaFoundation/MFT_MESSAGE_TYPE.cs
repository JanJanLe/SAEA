using System;

namespace SAEA.Audio.Base.NAudio.MediaFoundation
{
	public enum MFT_MESSAGE_TYPE
	{
		MFT_MESSAGE_COMMAND_FLUSH,
		MFT_MESSAGE_COMMAND_DRAIN,
		MFT_MESSAGE_SET_D3D_MANAGER,
		MFT_MESSAGE_DROP_SAMPLES,
		MFT_MESSAGE_COMMAND_TICK,
		MFT_MESSAGE_NOTIFY_BEGIN_STREAMING = 268435456,
		MFT_MESSAGE_NOTIFY_END_STREAMING,
		MFT_MESSAGE_NOTIFY_END_OF_STREAM,
		MFT_MESSAGE_NOTIFY_START_OF_STREAM,
		MFT_MESSAGE_COMMAND_MARKER = 536870912
	}
}
