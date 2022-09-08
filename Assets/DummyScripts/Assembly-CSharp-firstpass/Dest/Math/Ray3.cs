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

namespace Dest.Math
{
	public struct Ray3 // TypeDefIndex: 8160
	{
		// Fields
		public Vector3 Center; // 0x00
		public Vector3 Direction; // 0x0C
	
		// Constructors
		public Ray3(ref Vector3 center, ref Vector3 direction) {
			Center = default;
			Direction = default;
		} // 0x00000001874A96D0-0x00000001874A96E0
		public Ray3(Vector3 center, Vector3 direction) {
			Center = default;
			Direction = default;
		} // 0x00000001874A95A0-0x00000001874A96D0
	
		// Methods
		// [IDTag] // 0x0000000189AC4900-0x0000000189AC4940
		// [XID] // 0x0000000189AC4900-0x0000000189AC4940
		public static implicit operator Ray(Ray3 value) => default; // 0x00000001874A9880-0x00000001874A9A90
		// [IDTag] // 0x0000000189ACEF30-0x0000000189ACEF70
		// [XID] // 0x0000000189ACEF30-0x0000000189ACEF70
		public static implicit operator Ray3(Ray value) => default; // 0x00000001874A96E0-0x00000001874A9880
		// [XID] // 0x00000001898B3AE0-0x00000001898B3B00
		public Vector3 Eval(float t) => default; // 0x00000001874A91C0-0x00000001874A9330
		// [XID] // 0x0000000189AE16E0-0x0000000189AE1700
		public float DistanceTo(Vector3 point) => default; // 0x00000001874A9000-0x00000001874A91C0
		// [XID] // 0x0000000189AE8C10-0x0000000189AE8C30
		public Vector3 Project(Vector3 point) => default; // 0x00000001874A9330-0x00000001874A94E0
		// [XID] // 0x0000000189AF0AB0-0x0000000189AF0AD0
		public override string ToString() => default; // 0x00000001874A94E0-0x00000001874A9590
	}
}
