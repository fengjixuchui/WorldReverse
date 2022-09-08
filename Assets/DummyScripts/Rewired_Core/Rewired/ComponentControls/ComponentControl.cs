/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
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
	[DisallowMultipleComponent] // 0x00000001898F1200-0x00000001898F1210
	public abstract class ComponentControl : MonoBehaviour, IComponentControl // TypeDefIndex: 3524
	{
		// Fields
		private IComponentController _controller; // 0x18
		[NonSerialized]
		private bool PkVqugVNIpoYIMpSDcpjdJRrnVs; // 0x20
		[NonSerialized]
		private bool uwxnzeOJCWeabnBzbinsyKaDDKm; // 0x21
		private int _lastUpdateFrame; // 0x24
	
		// Properties
		internal abstract bool hasController { get; }
		internal bool initialized { get; } // 0x0000000185A9E240-0x0000000185A9E2A0 
	
		// Constructors
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal ComponentControl() {} // 0x0000000185A9E1D0-0x0000000185A9E240
	
		// Methods
		public abstract void ClearValue();
		void IComponentControl.Update() {} // 0x0000000185A9DD10-0x0000000185A9DDB0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal virtual void Awake() {} // 0x0000000185A9D160-0x0000000185A9D1C0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal virtual void Start() {} // 0x0000000185A9DDB0-0x0000000185A9DE00
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal virtual void OnEnable() {} // 0x0000000185A9D710-0x0000000185A9D810
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal virtual void OnDisable() {} // 0x0000000185A9D670-0x0000000185A9D710
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal virtual void OnDestroy() {} // 0x0000000185A9D5D0-0x0000000185A9D620
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal virtual void OnValidate() {} // 0x0000000185A9DB50-0x0000000185A9DC00
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal virtual void OnCanvasGroupChanged() {} // 0x0000000185A9D510-0x0000000185A9D580
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal virtual void OnTransformParentChanged() {} // 0x0000000185A9DA00-0x0000000185A9DA90
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal virtual void OnDidApplyAnimationProperties() {} // 0x0000000185A9D620-0x0000000185A9D670
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal virtual void Reset() {} // 0x0000000185A9DCC0-0x0000000185A9DD10
		internal virtual void OnUpdate() {} // 0x0000000185A9DB00-0x0000000185A9DB50
		internal virtual bool OnInitialize() => default; // 0x0000000185A9D810-0x0000000185A9D8B0
		internal virtual void ESBHzKHIUPqtKrgOXCXYdArebmS() {} // 0x0000000185A9D270-0x0000000185A9D3F0
		internal virtual void OnSubscribeEvents() {} // 0x0000000185A9D960-0x0000000185A9DA00
		internal virtual void OnUnsubscribeEvents() {} // 0x0000000185A9DA90-0x0000000185A9DB00
		internal virtual void OnSetProperty() {} // 0x0000000185A9D8B0-0x0000000185A9D960
		internal virtual void OnClear() {} // 0x0000000185A9D580-0x0000000185A9D5D0
		internal virtual void FindEventHandlers() {} // 0x0000000185A9D3F0-0x0000000185A9D440
		internal bool vWWTQEuzSAtwkwTidoREbMzaAEi() => default; // 0x0000000185A9E330-0x0000000185A9E3C0
		internal bool umueQObHjgIFkfOkmqetfqLVJGol() => default; // 0x0000000185A9E2A0-0x0000000185A9E330
		internal IComponentController LKDXaxXfiiwGAVtjdSCKBcNgYPZ() => default; // 0x0000000185A9D440-0x0000000185A9D4A0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal abstract IComponentController FindController();
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal abstract System.Type GetRequiredControllerType();
		private IEnumerator UFZGxhuVwflbRAOHVycmPgDJfkRE() => default; // 0x0000000185A9DE00-0x0000000185A9DEE0
		private void PQSWvFQilTgIeaqvfFMnhhGbNgSO() {} // 0x0000000185A9DC00-0x0000000185A9DCC0
		private bool YUpNMWDdcElWfUDzNMGTYQRrnsV(bool param_00007d62, bool param_00007d63) => default; // 0x0000000185A9DEE0-0x0000000185A9E1D0
		private void NVWqZPEZaDhGVdcEuqvABdsUKUL() {} // 0x0000000185A9D4A0-0x0000000185A9D510
		private void DPSbkWnOWLjrwEEUDVWndTgnDYB() {} // 0x0000000185A9D1C0-0x0000000185A9D270
	}
}
