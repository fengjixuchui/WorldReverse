/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Interfaces;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
	[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
	internal abstract class PlatformInputManager // TypeDefIndex: 3498
	{
		// Fields
		protected Action<BridgedController> _DeviceConnectedEvent; // 0x10
		protected Action<ControllerDisconnectedEventArgs> _DeviceDisconnectedEvent; // 0x18
		protected Action<UpdateControllerInfoEventArgs> _UpdateControllerInfoEvent; // 0x20
		protected Action _SystemDeviceConnectedEvent; // 0x28
		protected Action _SystemDeviceDisconnectedEvent; // 0x30
	
		// Properties
		public abstract PlatformInputManager primaryInputManager { get; }
		public abstract IInputSource inputSource { get; }
		public abstract InputSource inputSourceType { get; }
	
		// Events
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public event Action<BridgedController> DeviceConnectedEvent;
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public event Action<ControllerDisconnectedEventArgs> DeviceDisconnectedEvent;
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public event Action<UpdateControllerInfoEventArgs> UpdateControllerInfoEvent;
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public event Action SystemDeviceConnectedEvent;
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public event Action SystemDeviceDisconnectedEvent;
	
		// Constructors
		protected PlatformInputManager() {} // 0x0000000185306F80-0x0000000185306FE0
	
		// Methods
		public abstract void Initialize();
		public abstract void Update(UpdateLoopType currentUpdateLoop);
		public abstract void OnDestroy();
		public abstract void SystemDeviceConnected();
		public abstract void SystemDeviceDisconnected();
		public abstract void UpdateControllerData(int controllerId, ControllerDataUpdater data);
		public abstract Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate();
		public abstract void SetUnityJoystickId(int joystickId, int unityJoystickId);
		public abstract IUnifiedMouseSource GetUnifiedMouseSource();
		public abstract IUnifiedKeyboardSource GetUnifiedKeyboardSource();
	}
}
