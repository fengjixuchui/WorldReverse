/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Dest.Math
{
	public class CatmullRomSpline3 : SplineBase // TypeDefIndex: 8170
	{
		// Properties
		public override SplineTypes SplineType { /* [XID] */ /* 0x00000001897BB250-0x00000001897BB270 */ get => default; /* [XID] */ /* 0x00000001897AE550-0x00000001897AE570 */ set {} } // 0x0000000187E3C290-0x0000000187E3C330 0x0000000187E3C330-0x0000000187E3C4E0
	
		// Constructors
		public CatmullRomSpline3() {} // 0x0000000187E3C230-0x0000000187E3C290
	
		// Methods
		// [IDTag] // 0x00000001897B65F0-0x00000001897B6630
		// [XID] // 0x00000001897B65F0-0x00000001897B6630
		public static CatmullRomSpline3 Create() => default; // 0x0000000187E3B3C0-0x0000000187E3B490
		// [IDTag] // 0x00000001897C1090-0x00000001897C10D0
		// [XID] // 0x00000001897C1090-0x00000001897C10D0
		public static CatmullRomSpline3 Create(IList<Vector3> points, SplineTypes type) => default; // 0x0000000187E3B0C0-0x0000000187E3B3C0
		// [XID] // 0x0000000189678E00-0x0000000189678E20
		private void UpdateSegment(int index) {} // 0x0000000187E3BBF0-0x0000000187E3C230
		// [XID] // 0x00000001897D2E90-0x00000001897D2EB0
		private void UpdateAdjacentSegments(int vertexIndex) {} // 0x0000000187E3BA30-0x0000000187E3BBF0
		// [XID] // 0x00000001897DAB50-0x00000001897DAB70
		public override void AddVertexFirst(Vector3 position) {} // 0x0000000187E3ADC0-0x0000000187E3AEB0
		// [XID] // 0x00000001897E2080-0x00000001897E20A0
		public override void AddVertexLast(Vector3 position) {} // 0x0000000187E3AEB0-0x0000000187E3B000
		// [XID] // 0x00000001897E98A0-0x00000001897E98C0
		public override void RemoveVertex(int index) {} // 0x0000000187E3B830-0x0000000187E3B910
		// [XID] // 0x00000001897F14A0-0x00000001897F14C0
		public override void Clear() {} // 0x0000000187E3B000-0x0000000187E3B0C0
		// [XID] // 0x00000001897F8BF0-0x00000001897F8C10
		public override void InsertBefore(int vertexIndex, Vector3 position) {} // 0x0000000187E3B6F0-0x0000000187E3B830
		// [XID] // 0x0000000189864050-0x0000000189864070
		public override void InsertAfter(int vertexIndex, Vector3 position) {} // 0x0000000187E3B5B0-0x0000000187E3B6F0
		// [XID] // 0x0000000189648850-0x0000000189648870
		public override Vector3 GetVertex(int vertexIndex) => default; // 0x0000000187E3B490-0x0000000187E3B5B0
		// [XID] // 0x000000018980F070-0x000000018980F090
		public override void SetVertex(int vertexIndex, Vector3 position) {} // 0x0000000187E3B910-0x0000000187E3BA30
	}
}
