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
	public struct Segment3 // TypeDefIndex: 8162
	{
		// Fields
		public Vector3 P0; // 0x00
		public Vector3 P1; // 0x0C
		public Vector3 Center; // 0x18
		public Vector3 Direction; // 0x24
		public float Extent; // 0x30
	
		// Constructors
		public Segment3(ref Vector3 p0, ref Vector3 p1) {
			P0 = default;
			P1 = default;
			Center = default;
			Direction = default;
			Extent = default;
		} // 0x00000001874AF310-0x00000001874AF320
		public Segment3(Vector3 p0, Vector3 p1) {
			P0 = default;
			P1 = default;
			Center = default;
			Direction = default;
			Extent = default;
		} // 0x00000001874AF520-0x00000001874AF700
		public Segment3(ref Vector3 center, ref Vector3 direction, float extent) {
			P0 = default;
			P1 = default;
			Center = default;
			Direction = default;
			Extent = default;
		} // 0x00000001874AF700-0x00000001874AF7D0
		public Segment3(Vector3 center, Vector3 direction, float extent) {
			P0 = default;
			P1 = default;
			Center = default;
			Direction = default;
			Extent = default;
		} // 0x00000001874AF320-0x00000001874AF520
	
		// Methods
		// [XID] // 0x0000000189B43D90-0x0000000189B43DB0
		public void SetEndpoints(Vector3 p0, Vector3 p1) {} // 0x00000001874AEDD0-0x00000001874AF150
		// [XID] // 0x00000001898F8EC0-0x00000001898F8EE0
		public void SetCenterDirectionExtent(Vector3 center, Vector3 direction, float extent) {} // 0x00000001874AEC70-0x00000001874AEDD0
		// [XID] // 0x0000000189B52B60-0x0000000189B52B80
		public void CalcCenterDirectionExtent() {} // 0x00000001874AE4C0-0x00000001874AE6A0
		// [XID] // 0x0000000189B5A5A0-0x0000000189B5A5C0
		public void CalcEndPoints() {} // 0x00000001874AE6A0-0x00000001874AE790
		// [XID] // 0x0000000189B61980-0x0000000189B619A0
		public Vector3 Eval(float s) => default; // 0x00000001874AE980-0x00000001874AEAF0
		// [XID] // 0x0000000189B69570-0x0000000189B69590
		public float DistanceTo(Vector3 point) => default; // 0x00000001874AE790-0x00000001874AE980
		// [XID] // 0x0000000189608440-0x0000000189608460
		public Vector3 Project(Vector3 point) => default; // 0x00000001874AEAF0-0x00000001874AEC70
		// [XID] // 0x0000000189B78050-0x0000000189B78070
		public override string ToString() => default; // 0x00000001874AF150-0x00000001874AF210
	}
}
