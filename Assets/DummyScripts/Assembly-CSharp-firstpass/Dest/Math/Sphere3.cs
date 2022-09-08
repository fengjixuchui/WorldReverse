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
	public struct Sphere3 // TypeDefIndex: 8163
	{
		// Fields
		private const float _4div3mulPi = 4.1887903f; // Metadata: 0x00ADF678
		public Vector3 Center; // 0x00
		public float Radius; // 0x0C
	
		// Constructors
		public Sphere3(ref Vector3 center, float radius) {
			Center = default;
			Radius = default;
		} // 0x00000001874B2230-0x00000001874B22C0
		public Sphere3(Vector3 center, float radius) {
			Center = default;
			Radius = default;
		} // 0x00000001874B22C0-0x00000001874B2350
	
		// Methods
		// [IDTag] // 0x0000000189B7F5E0-0x0000000189B7F620
		// [XID] // 0x0000000189B7F5E0-0x0000000189B7F620
		public static Sphere3 CreateFromPointsAAB(IEnumerable<Vector3> points) => default; // 0x00000001874B0240-0x00000001874B0420
		// [IDTag] // 0x0000000189B89F80-0x0000000189B89FC0
		// [XID] // 0x0000000189B89F80-0x0000000189B89FC0
		public static Sphere3 CreateFromPointsAAB(IList<Vector3> points) => default; // 0x00000001874B0420-0x00000001874B05C0
		// [IDTag] // 0x0000000189B94210-0x0000000189B94250
		// [XID] // 0x0000000189B94210-0x0000000189B94250
		public static Sphere3 CreateFromPointsAverage(IEnumerable<Vector3> points) => default; // 0x00000001874B05C0-0x00000001874B0A70
		// [IDTag] // 0x0000000189B9E4A0-0x0000000189B9E4E0
		// [XID] // 0x0000000189B9E4A0-0x0000000189B9E4E0
		public static Sphere3 CreateFromPointsAverage(IList<Vector3> points) => default; // 0x00000001874B0A70-0x00000001874B0E10
		// [XID] // 0x00000001897BE8F0-0x00000001897BE910
		public static bool CreateCircumscribed(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, out Sphere3 sphere) {
			sphere = default;
			return default;
		} // 0x00000001874AFBE0-0x00000001874B0240
		// [XID] // 0x0000000189BAFEA0-0x0000000189BAFEC0
		public static bool CreateInscribed(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, out Sphere3 sphere) {
			sphere = default;
			return default;
		} // 0x00000001874B0E10-0x00000001874B1870
		// [XID] // 0x00000001898077C0-0x00000001898077E0
		public float CalcArea() => default; // 0x00000001874AF7D0-0x00000001874AF8A0
		// [XID] // 0x0000000189BBEC30-0x0000000189BBEC50
		public float CalcVolume() => default; // 0x00000001874AF8A0-0x00000001874AFA30
		// [XID] // 0x0000000189B9D210-0x0000000189B9D230
		public Vector3 Eval(float theta, float phi) => default; // 0x00000001874B1A60-0x00000001874B1D40
		// [XID] // 0x00000001895EA610-0x00000001895EA630
		public float DistanceTo(Vector3 point) => default; // 0x00000001874B1870-0x00000001874B1A60
		// [XID] // 0x00000001898CB810-0x00000001898CB830
		public Vector3 Project(Vector3 point) => default; // 0x00000001874B1F70-0x00000001874B2100
		// [IDTag] // 0x0000000189BDD3C0-0x0000000189BDD400
		// [XID] // 0x0000000189BDD3C0-0x0000000189BDD400
		public bool Contains(ref Vector3 point) => default; // 0x00000001874AFBD0-0x00000001874AFBE0
		// [IDTag] // 0x00000001895ECEA0-0x00000001895ECEE0
		// [XID] // 0x00000001895ECEA0-0x00000001895ECEE0
		public bool Contains(Vector3 point) => default; // 0x00000001874AFA30-0x00000001874AFBD0
		// [IDTag] // 0x00000001895F7770-0x00000001895F77B0
		// [XID] // 0x00000001895F7770-0x00000001895F77B0
		public void Include(ref Sphere3 sphere) {} // 0x00000001874B1D40-0x00000001874B1E10
		// [IDTag] // 0x0000000189601E10-0x0000000189601E50
		// [XID] // 0x0000000189601E10-0x0000000189601E50
		public void Include(Sphere3 sphere) {} // 0x00000001874B1E10-0x00000001874B1F70
		// [XID] // 0x000000018960C4E0-0x000000018960C500
		public override string ToString() => default; // 0x00000001874B2100-0x00000001874B21A0
	}
}
