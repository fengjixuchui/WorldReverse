/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class AngleSection // TypeDefIndex: 26501
	{
		// Fields
		private static readonly float SECTION_ANGLE_TOLERANCE; // 0x00
		public float start; // 0x10
		public float end; // 0x14
	
		// Constructors
		public AngleSection() {} // 0x0000000184E78FD0-0x0000000184E79040
		public AngleSection(float start, float end) {} // 0x0000000184E79040-0x0000000184E790D0
		static AngleSection() {} // 0x0000000184E78F70-0x0000000184E78FD0
	
		// Methods
		// [XID] // 0x00000001899D1450-0x00000001899D1470
		public bool Contain(float angle) => default; // 0x0000000184E78E40-0x0000000184E78F70
		// [XID] // 0x00000001899D88A0-0x00000001899D88C0
		public float GetNearestAngle(bool isInIncreasingOrder) => default; // 0x0000000184E78D70-0x0000000184E78E40
	}
}
