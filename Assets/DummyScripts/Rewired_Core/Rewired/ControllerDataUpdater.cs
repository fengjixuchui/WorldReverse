/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
	[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
	internal class ControllerDataUpdater // TypeDefIndex: 4020
	{
		// Fields
		public readonly InputSource source; // 0x10
		public readonly int axisCount; // 0x14
		public readonly int buttonCount; // 0x18
		public readonly float[] axisValues; // 0x20
		public readonly bool[] buttonValues; // 0x28
		public readonly float[] buttonPressureValues; // 0x30
		public readonly bool[] axisHasBeenPressedOSXLinux; // 0x38
		private readonly UnknownControllerHat[] AEKggMXYaAjkhvdIpTgwtPgMhWUg; // 0x40
		public bool hasReceivedInput; // 0x48
	
		// Constructors
		public ControllerDataUpdater() {} // Dummy constructor
		public ControllerDataUpdater(InputSource source, int axisCount, int buttonCount, UnknownControllerHat[] unknownControllerHats) {} // 0x0000000185E77A70-0x0000000185E77BC0
	
		// Methods
		public bool IsUnknownHatCardinal(int buttonIndex) => default; // 0x0000000185E77940-0x0000000185E77A70
		public UnknownControllerHat.HatButtons GetUnknownHatButtons(int buttonIndex) => default; // 0x0000000185E777D0-0x0000000185E77940
		public void ClearData() {} // 0x0000000185E776D0-0x0000000185E777D0
	}
}
