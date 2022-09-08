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
using Rewired.Utils.Interfaces;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x00000001898F1200-0x00000001898F1210
	public abstract class ComponentController : MonoBehaviour, IComponentController // TypeDefIndex: 3528
	{
		// Fields
		[NonSerialized]
		private bool PkVqugVNIpoYIMpSDcpjdJRrnVs; // 0x18
		[NonSerialized]
		private bool uwxnzeOJCWeabnBzbinsyKaDDKm; // 0x19
		private List<IComponentControl> _controls; // 0x20
	
		// Properties
		internal bool initialized { get; } // 0x0000000185A9EE00-0x0000000185A9EE60 
	
		// Constructors
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal ComponentController() {} // 0x0000000185A9ED60-0x0000000185A9EE00
	
		// Methods
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal virtual void Awake() {} // 0x0000000185A9E3C0-0x0000000185A9E420
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal virtual void Update() {} // 0x0000000185A9EBC0-0x0000000185A9ED60
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal virtual void OnEnable() {} // 0x0000000185A9E7B0-0x0000000185A9E850
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal virtual void OnDisable() {} // 0x0000000185A9E720-0x0000000185A9E7B0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal virtual void OnValidate() {} // 0x0000000185A9E960-0x0000000185A9E9E0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal virtual void OnDestroy() {} // 0x0000000185A9E6A0-0x0000000185A9E720
		internal virtual bool OnInitialize() => default; // 0x0000000185A9E850-0x0000000185A9E8A0
		internal virtual void OnSubscribeEvents() {} // 0x0000000185A9E8A0-0x0000000185A9E910
		internal virtual void OnUnsubscribeEvents() {} // 0x0000000185A9E910-0x0000000185A9E960
		void IRegistrar<IComponentControl>.Register(IComponentControl param_00007d67) {} // 0x0000000185A9EB20-0x0000000185A9EBC0
		void IRegistrar<IComponentControl>.Deregister(IComponentControl param_00007d68) {} // 0x0000000185A9EA80-0x0000000185A9EB20
		public virtual void ClearControlValues() {} // 0x0000000185A9E420-0x0000000185A9E5D0
		private void PQSWvFQilTgIeaqvfFMnhhGbNgSO() {} // 0x0000000185A9E9E0-0x0000000185A9EA80
		private void wQiEPKGVkSYAiCZoyTUamohUIKKd() {} // 0x0000000185A9EE60-0x0000000185A9EEF0
		private IEnumerator ITElLdViqdCgTLGvrBGokvbHgub() => default; // 0x0000000185A9E5D0-0x0000000185A9E6A0
	}
}
