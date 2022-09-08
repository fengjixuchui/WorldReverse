/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Interfaces
{
	[CustomClassObfuscation] // 0x0000000189658AB0-0x0000000189658B00
	[CustomObfuscation] // 0x0000000189658AB0-0x0000000189658B00
	internal interface IInputManagerJoystickPublic // TypeDefIndex: 3996
	{
		// Properties
		int rewiredId { get; }
		int inputManagerId { get; }
		string name { get; }
		long? systemId { get; }
		int unityId { get; }
		Controller.Extension extension { get; }
		Guid instanceGuid { get; }
		Guid persistentGuid { get; }
	
		// Methods
		void SetVibration(float amount, int motorIndex);
		void StopVibration();
	}
}
