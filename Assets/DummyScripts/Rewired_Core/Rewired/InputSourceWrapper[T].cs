/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
	internal class InputSourceWrapper<T> : IInputSource // TypeDefIndex: 3509
	{
		// Fields
		private T PESlCqcuFEdCgwfIyyIoKbUwani;
		private bool vsurYtRlepcrpAzAENwjqjJEZPT;
	
		// Properties
		public T source { get => default; }
	
		// Events
		public event Action DeviceChangedEvent;
	
		// Constructors
		public InputSourceWrapper() {} // Dummy constructor
		public InputSourceWrapper(T source) {}
	
		// Methods
		public void Update() {}
		public void UpdateDevices(UpdateLoopType updateLoop) {}
		public void UpdateFinished() {}
		public IList<TJoy> GetJoysticks<TJoy>()
			where TJoy : class => default;
		public void Dispose() {}
		~InputSourceWrapper() {}
		protected virtual void Dispose(bool disposing) {}
	}
}
