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
	[DisallowMultipleComponent] // 0x0000000189BB4A20-0x0000000189BB4A90
	// [RequireComponent] // 0x0000000189BB4A20-0x0000000189BB4A90
	public abstract class TouchControl : CustomControllerControl // TypeDefIndex: 3549
	{
		// Fields
		private Canvas _canvas; // 0x28
		private RectTransform __rectTransform; // 0x30
	
		// Properties
		internal TouchController touchController { get; } // 0x0000000186A03800-0x0000000186A03880 
		internal Canvas canvas { get; } // 0x0000000186A03660-0x0000000186A036C0 
		internal RectTransform canvasTransform { get; } // 0x0000000186A03540-0x0000000186A03660 
		internal RectTransform rectTransform { get; } // 0x0000000186A03770-0x0000000186A03800 
		internal override bool hasController { get; } // 0x0000000186A036C0-0x0000000186A03770 
	
		// Constructors
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal TouchControl() {} // 0x0000000186A034E0-0x0000000186A03540
	
		// Methods
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void OnValidate() {} // 0x0000000186A032B0-0x0000000186A03360
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void OnCanvasGroupChanged() {} // 0x0000000186A02CB0-0x0000000186A02E60
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void OnTransformParentChanged() {} // 0x0000000186A030D0-0x0000000186A032B0
		internal override bool OnInitialize() => default; // 0x0000000186A02E60-0x0000000186A02EF0
		internal override void OnSetProperty() {} // 0x0000000186A02EF0-0x0000000186A030D0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override IComponentController FindController() => default; // 0x0000000186A02B80-0x0000000186A02C20
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override System.Type GetRequiredControllerType() => default; // 0x0000000186A02C20-0x0000000186A02CB0
		private new bool YUpNMWDdcElWfUDzNMGTYQRrnsV(bool param_00007dac, bool param_00007dad) => default; // 0x0000000186A03360-0x0000000186A034E0
	}
}
