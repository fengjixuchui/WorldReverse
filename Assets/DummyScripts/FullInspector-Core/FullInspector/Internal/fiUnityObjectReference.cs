/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector.Internal
{
	[Serializable]
	public class fiUnityObjectReference // TypeDefIndex: 5020
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.Object _target; // 0x10
		public UnityEngine.Object Target; // 0x18
	
		// Properties
		public bool IsValid { get => default; } // 0x0000000185D06170-0x0000000185D06200 
	
		// Constructors
		public fiUnityObjectReference() {} // 0x0000000185D06110-0x0000000185D06170
		public fiUnityObjectReference(UnityEngine.Object target, bool tryRestore) {} // 0x0000000185D06080-0x0000000185D06110
	
		// Methods
		private void TryRestoreFromInstanceId() {} // 0x0000000185D05FC0-0x0000000185D06080
		public override int GetHashCode() => default; // 0x0000000185D05F30-0x0000000185D05FC0
		public override bool Equals(object obj) => default; // 0x0000000185D05E40-0x0000000185D05F30
	}
}
