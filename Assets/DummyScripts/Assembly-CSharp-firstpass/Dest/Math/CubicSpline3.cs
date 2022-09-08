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
	public class CubicSpline3 : SplineBase // TypeDefIndex: 8171
	{
		// Properties
		public override SplineTypes SplineType { /* [XID] */ /* 0x0000000189816800-0x0000000189816820 */ get => default; /* [XID] */ /* 0x000000018981E0C0-0x000000018981E0E0 */ set {} } // 0x0000000187E46E60-0x0000000187E46F00 0x0000000187E46F00-0x0000000187E46FC0
	
		// Constructors
		public CubicSpline3() {} // 0x0000000187E46E00-0x0000000187E46E60
	
		// Methods
		// [IDTag] // 0x00000001898255A0-0x00000001898255E0
		// [XID] // 0x00000001898255A0-0x00000001898255E0
		public static CubicSpline3 Create() => default; // 0x0000000187E467A0-0x0000000187E46870
		// [IDTag] // 0x000000018982FC10-0x000000018982FC50
		// [XID] // 0x000000018982FC10-0x000000018982FC50
		public static CubicSpline3 Create(IList<Vector3> points, SplineTypes type) => default; // 0x0000000187E464C0-0x0000000187E467A0
		// [XID] // 0x000000018975C0A0-0x000000018975C0C0
		private void BuildSpline() {} // 0x0000000187E444A0-0x0000000187E44580
		// [XID] // 0x000000018979FD50-0x000000018979FD70
		private void CreateOpenedSpline() {} // 0x0000000187E45970-0x0000000187E464C0
		// [XID] // 0x0000000189848BC0-0x0000000189848BE0
		private void CreateClosedSpline() {} // 0x0000000187E44640-0x0000000187E45970
		// [XID] // 0x000000018993B000-0x000000018993B020
		public override void AddVertexFirst(Vector3 position) {} // 0x0000000187E44240-0x0000000187E44370
		// [XID] // 0x00000001899C0A10-0x00000001899C0A30
		public override void AddVertexLast(Vector3 position) {} // 0x0000000187E44370-0x0000000187E444A0
		// [XID] // 0x000000018985E910-0x000000018985E930
		public override void RemoveVertex(int index) {} // 0x0000000187E46C10-0x0000000187E46CE0
		// [XID] // 0x00000001898660D0-0x00000001898660F0
		public override void Clear() {} // 0x0000000187E44580-0x0000000187E44640
		// [XID] // 0x000000018986D920-0x000000018986D940
		public override void InsertBefore(int vertexIndex, Vector3 position) {} // 0x0000000187E46AD0-0x0000000187E46C10
		// [XID] // 0x0000000189874DB0-0x0000000189874DD0
		public override void InsertAfter(int vertexIndex, Vector3 position) {} // 0x0000000187E46990-0x0000000187E46AD0
		// [XID] // 0x000000018987C8B0-0x000000018987C8D0
		public override Vector3 GetVertex(int vertexIndex) => default; // 0x0000000187E46870-0x0000000187E46990
		// [XID] // 0x0000000189883970-0x0000000189883990
		public override void SetVertex(int vertexIndex, Vector3 position) {} // 0x0000000187E46CE0-0x0000000187E46E00
	}
}
