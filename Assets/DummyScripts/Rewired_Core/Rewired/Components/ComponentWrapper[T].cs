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

namespace Rewired.Components
{
	[Serializable]
	// [AddComponentMenu] // 0x0000000189B0FD10-0x0000000189B0FD40
	public abstract class ComponentWrapper<T> : MonoBehaviour // TypeDefIndex: 3603
		where T : class
	{
		// Fields
		[NonSerialized]
		private T PESlCqcuFEdCgwfIyyIoKbUwani;
		[NonSerialized]
		private bool PkVqugVNIpoYIMpSDcpjdJRrnVs;
	
		// Properties
		protected T source { get; }
		protected bool initialized { get; }
	
		// Constructors
		protected ComponentWrapper() {}
	
		// Methods
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void Awake() {}
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void Start() {}
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void OnEnable() {}
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void OnDisable() {}
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void OnDestroy() {}
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void Reset() {}
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private void OnValidate() {}
		protected virtual void OnAwake() {}
		protected virtual void OnAwakeFinished() {}
		protected virtual void OnStart() {}
		protected virtual void OnEnabled() {}
		protected virtual void OnDisabled() {}
		protected virtual void OnDestroyed() {}
		protected virtual void OnReset() {}
		protected virtual void OnValidated() {}
		protected virtual void Initialize() {}
		protected virtual bool TryInitialize() => default;
		protected abstract T CreateSource(object args);
		protected abstract object GetCreateSourceArgs();
		protected virtual void PostInitialize() {}
		protected virtual void Deinitialize() {}
		protected virtual void Subscribe() {}
		protected virtual void Unsubscribe() {}
		private void RStBZqOHvmAJGGJHihpzCVhaEmNk() {}
		private void VRJiPTIEqUKfqksUVQNARBzDfgy() {}
	}
}
