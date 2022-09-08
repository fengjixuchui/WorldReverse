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
	public struct Segment2 // TypeDefIndex: 8150
	{
		// Fields
		public Vector2 P0; // 0x00
		public Vector2 P1; // 0x08
		public Vector2 Center; // 0x10
		public Vector2 Direction; // 0x18
		public float Extent; // 0x20
	
		// Constructors
		public Segment2(ref Vector2 p0, ref Vector2 p1) {
			P0 = default;
			P1 = default;
			Center = default;
			Direction = default;
			Extent = default;
		} // 0x00000001874AE000-0x00000001874AE0D0
		public Segment2(Vector2 p0, Vector2 p1) {
			P0 = default;
			P1 = default;
			Center = default;
			Direction = default;
			Extent = default;
		} // 0x00000001874AE0D0-0x00000001874AE1B0
		public Segment2(ref Vector2 center, ref Vector2 direction, float extent) {
			P0 = default;
			P1 = default;
			Center = default;
			Direction = default;
			Extent = default;
		} // 0x00000001874AE2B0-0x00000001874AE4C0
		public Segment2(Vector2 center, Vector2 direction, float extent) {
			P0 = default;
			P1 = default;
			Center = default;
			Direction = default;
			Extent = default;
		} // 0x00000001874AE1B0-0x00000001874AE2B0
	
		// Methods
		// [XID] // 0x00000001895EB7B0-0x00000001895EB7D0
		public void SetEndpoints(Vector2 p0, Vector2 p1) {} // 0x00000001874ADB70-0x00000001874ADE70
		// [XID] // 0x00000001895F2B90-0x00000001895F2BB0
		public void SetCenterDirectionExtent(Vector2 center, Vector2 direction, float extent) {} // 0x00000001874ADA70-0x00000001874ADB70
		// [XID] // 0x00000001899CDB60-0x00000001899CDB80
		public void CalcCenterDirectionExtent() {} // 0x00000001874AD500-0x00000001874AD660
		// [XID] // 0x00000001899EB4B0-0x00000001899EB4D0
		public void CalcEndPoints() {} // 0x00000001874AD660-0x00000001874AD730
		// [XID] // 0x0000000189609640-0x0000000189609660
		public Vector2 Eval(float s) => default; // 0x00000001874AD870-0x00000001874AD960
		// [XID] // 0x0000000189610E60-0x0000000189610E80
		public float DistanceTo(Vector2 point) => default; // 0x00000001874AD730-0x00000001874AD870
		// [XID] // 0x0000000189A01A00-0x0000000189A01A20
		public Vector2 Project(Vector2 point) => default; // 0x00000001874AD960-0x00000001874ADA70
		// [XID] // 0x0000000189A094D0-0x0000000189A094F0
		public override string ToString() => default; // 0x00000001874ADE70-0x00000001874ADF20
	}
}
