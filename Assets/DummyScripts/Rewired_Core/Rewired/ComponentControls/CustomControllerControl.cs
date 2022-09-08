/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.ComponentControls.Data;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x00000001898F1200-0x00000001898F1210
	public abstract class CustomControllerControl : ComponentControl // TypeDefIndex: 3533
	{
		// Properties
		internal CustomController controller { get; } // 0x0000000185A9F580-0x0000000185A9F660 
		internal override bool hasController { get; } // 0x0000000185A9F660-0x0000000185A9F770 
	
		// Constructors
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal CustomControllerControl() {} // 0x0000000185A9F4D0-0x0000000185A9F580
	
		// Methods
		internal override void OnSubscribeEvents() {} // 0x0000000185A9F210-0x0000000185A9F300
		internal override void OnUnsubscribeEvents() {} // 0x0000000185A9F300-0x0000000185A9F440
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override IComponentController FindController() => default; // 0x0000000185A9F0E0-0x0000000185A9F180
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override System.Type GetRequiredControllerType() => default; // 0x0000000185A9F180-0x0000000185A9F210
		internal void jdvcKcWQnHxAXPvCkvKHWiFjvWV(CustomControllerElementTargetSet param_00007d86, float param_00007d87, float param_00007d88) {} // 0x0000000185A9FA20-0x0000000185A9FDE0
		internal void jdvcKcWQnHxAXPvCkvKHWiFjvWV(CustomControllerElementTargetSet param_00007d89, bool param_00007d8a) {} // 0x0000000185AA0380-0x0000000185AA0580
		internal abstract void OnCustomControllerUpdate();
		private void jdvcKcWQnHxAXPvCkvKHWiFjvWV(CustomControllerElementTarget param_00007d8b, float param_00007d8c, float param_00007d8d) {} // 0x0000000185A9FDE0-0x0000000185AA0380
		private void jdvcKcWQnHxAXPvCkvKHWiFjvWV(CustomControllerElementTarget param_00007d8e, bool param_00007d8f) {} // 0x0000000185A9F770-0x0000000185A9FA20
		private void PiCJAnAbJpYtVlajDkqOEdsBgDb() {} // 0x0000000185A9F440-0x0000000185A9F4D0
	}
}
