/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia
{
	public class Growth : MonoBehaviour // TypeDefIndex: 9347
	{
		// Fields
		// [Range] // 0x00000001897D4670-0x00000001897D46D0
		// [Tooltip] // 0x00000001897D4670-0x00000001897D46D0
		public float m_startScale; // 0x18
		// [Range] // 0x00000001897E06D0-0x00000001897E0720
		// [Tooltip] // 0x00000001897E06D0-0x00000001897E0720
		public float m_endScale; // 0x1C
		// [Range] // 0x00000001897ECB50-0x00000001897ECBA0
		// [Tooltip] // 0x00000001897ECB50-0x00000001897ECBA0
		public float m_scaleVariance; // 0x20
		// [Range] // 0x00000001897F8B00-0x00000001897F8B60
		// [Tooltip] // 0x00000001897F8B00-0x00000001897F8B60
		public float m_growthTime; // 0x24
		private float m_actualEndScale; // 0x28
	
		// Constructors
		public Growth() {} // 0x00000001859F7F60-0x00000001859F7FE0
	
		// Methods
		// [XID] // 0x0000000189804870-0x0000000189804890
		private void Start() {} // 0x00000001859F7EB0-0x00000001859F7F60
		// [XID] // 0x00000001896C83E0-0x00000001896C8400
		public virtual void Initialise() {} // 0x00000001859F7DD0-0x00000001859F7EB0
		[DebuggerHidden] // 0x0000000189813550-0x0000000189813590
		// [XID] // 0x0000000189813550-0x0000000189813590
		private IEnumerator Grow() => default; // 0x00000001859F7CC0-0x00000001859F7DD0
		// [XID] // 0x000000018981E050-0x000000018981E070
		public virtual void Die() {} // 0x00000001859F7BE0-0x00000001859F7CC0
	}
}
