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

namespace Gaia
{
	public class XorshiftPlus // TypeDefIndex: 9345
	{
		// Fields
		private const ulong m_A_Init = 181353; // Metadata: 0x00AE5786
		private const ulong m_B_Init = 7; // Metadata: 0x00AE578E
		public int m_seed; // 0x10
		public ulong m_stateA; // 0x18
		public ulong m_stateB; // 0x20
	
		// Constructors
		public XorshiftPlus() {} // Dummy constructor
		public XorshiftPlus(int seed = 1 /* Metadata: 0x00AE5782 */) {} // 0x0000000185A4A970-0x0000000185A4AA00
	
		// Methods
		// [IDTag] // 0x0000000189743E40-0x0000000189743E80
		// [XID] // 0x0000000189743E40-0x0000000189743E80
		public void Reset() {} // 0x0000000185A4A540-0x0000000185A4A5F0
		// [IDTag] // 0x000000018974E890-0x000000018974E8D0
		// [XID] // 0x000000018974E890-0x000000018974E8D0
		public void Reset(int seed) {} // 0x0000000185A4A5F0-0x0000000185A4A6B0
		// [IDTag] // 0x00000001897588D0-0x0000000189758910
		// [XID] // 0x00000001897588D0-0x0000000189758910
		public void Reset(ulong stateA, ulong stateB) {} // 0x0000000185A4A6B0-0x0000000185A4A970
		// [XID] // 0x0000000189763550-0x0000000189763570
		public void GetState(out int seed, out ulong stateA, out ulong stateB) {
			seed = default;
			stateA = default;
			stateB = default;
		} // 0x0000000185A49E10-0x0000000185A49F00
		// [IDTag] // 0x000000018976ACF0-0x000000018976AD30
		// [XID] // 0x000000018976ACF0-0x000000018976AD30
		public float Next() => default; // 0x0000000185A4A440-0x0000000185A4A540
		// [XID] // 0x0000000189775030-0x0000000189775050
		public int NextInt() => default; // 0x0000000185A49F00-0x0000000185A49FB0
		// [IDTag] // 0x000000018977C840-0x000000018977C880
		// [XID] // 0x000000018977C840-0x000000018977C880
		public float Next(float min, float max) => default; // 0x0000000185A4A360-0x0000000185A4A440
		// [IDTag] // 0x0000000189787110-0x0000000189787150
		// [XID] // 0x0000000189787110-0x0000000189787150
		public int Next(int min, int max) => default; // 0x0000000185A4A270-0x0000000185A4A360
		// [IDTag] // 0x0000000189791700-0x0000000189791740
		// [XID] // 0x0000000189791700-0x0000000189791740
		public Vector3 NextVector() => default; // 0x0000000185A4A130-0x0000000185A4A270
		// [IDTag] // 0x000000018979C780-0x000000018979C7C0
		// [XID] // 0x000000018979C780-0x000000018979C7C0
		public Vector3 NextVector(float min, float max) => default; // 0x0000000185A49FB0-0x0000000185A4A130
	}
}
