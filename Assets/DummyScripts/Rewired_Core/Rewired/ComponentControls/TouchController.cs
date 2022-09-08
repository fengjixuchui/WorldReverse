/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x0000000189778420-0x0000000189778480
	// [RequireComponent] // 0x0000000189778420-0x0000000189778480
	public sealed class TouchController : CustomController // TypeDefIndex: 3584
	{
		// Fields
		[CustomObfuscation] // 0x0000000189787390-0x00000001897873F0
		[SerializeField] // 0x0000000189787390-0x00000001897873F0
		// [Tooltip] // 0x0000000189787390-0x00000001897873F0
		private bool _disableMouseInputWhenEnabled; // 0x58
		[CustomObfuscation] // 0x0000000189795FB0-0x0000000189796010
		[SerializeField] // 0x0000000189795FB0-0x0000000189796010
		// [Tooltip] // 0x0000000189795FB0-0x0000000189796010
		private bool _useCustomController; // 0x59
	
		// Properties
		public bool disableMouseInputWhenEnabled { get => default; set {} } // 0x0000000186A03F70-0x0000000186A03FD0 0x0000000186A04030-0x0000000186A040E0
		public bool useCustomController { get => default; set {} } // 0x0000000186A03FD0-0x0000000186A04030 0x0000000186A040E0-0x0000000186A041C0
	
		// Constructors
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private TouchController() {} // 0x0000000186A03F00-0x0000000186A03F70
	
		// Methods
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void OnDisable() {} // 0x0000000186A039B0-0x0000000186A03BD0
		internal override bool OnInitialize() => default; // 0x0000000186A03BD0-0x0000000186A03D10
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override bool GetUseCustomController() => default; // 0x0000000186A03950-0x0000000186A039B0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void SetUseCustomController(bool value) {} // 0x0000000186A03EA0-0x0000000186A03F00
		private void SetMouseState(bool state) {} // 0x0000000186A03D60-0x0000000186A03EA0
		private new void OnSetProperty() {} // 0x0000000186A03D10-0x0000000186A03D60
		private new bool CheckIsRewiredReady() => default; // 0x0000000186A03880-0x0000000186A03950
	}
}
