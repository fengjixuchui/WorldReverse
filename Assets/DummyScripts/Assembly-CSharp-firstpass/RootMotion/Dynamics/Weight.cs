/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RootMotion.Dynamics
{
	[Serializable]
	public class Weight // TypeDefIndex: 9918
	{
		// Fields
		public Mode mode; // 0x10
		public float floatValue; // 0x14
		public AnimationCurve curve; // 0x18
		public string tooltip; // 0x20
	
		// Nested types
		[Serializable]
		public enum Mode // TypeDefIndex: 9919
		{
			Float = 0,
			Curve = 1
		}
	
		// Constructors
		public Weight() {} // Dummy constructor
		public Weight(float floatValue) {} // 0x00000001868E5470-0x00000001868E54F0
		public Weight(float floatValue, string tooltip) {} // 0x00000001868E54F0-0x00000001868E5620
	
		// Methods
		// [XID] // 0x00000001896D42C0-0x00000001896D42E0
		public float GetValue(float param) => default; // 0x00000001868E5390-0x00000001868E5470
	}
}
