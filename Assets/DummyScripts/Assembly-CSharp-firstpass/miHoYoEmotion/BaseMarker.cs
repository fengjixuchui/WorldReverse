/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoEmotion
{
	[Serializable]
	public class BaseMarker // TypeDefIndex: 8501
	{
		// Fields
		public bool postToFinalCanChange; // 0x10
		public string name; // 0x18
		public float startTime; // 0x20
		public float endTime; // 0x24
		public float intensity; // 0x28
	
		// Nested types
		public enum POST_TYPE // TypeDefIndex: 8502
		{
			DEFAULT = 0,
			FORCE_NO_POST = 1,
			FORCE_POST = 2
		}
	
		// Constructors
		public BaseMarker() {} // 0x0000000187318240-0x00000001873182B0
	
		// Methods
		// [XID] // 0x000000018967C1E0-0x000000018967C200
		public void UpdateBothTimeByStart(float newStartTime) {} // 0x0000000187318010-0x00000001873180D0
		// [XID] // 0x0000000189B5A580-0x0000000189B5A5A0
		public void UpdateBothTimeByEnd(float newEndTime) {} // 0x0000000187317F50-0x0000000187318010
		// [XID] // 0x0000000189B61940-0x0000000189B61960
		public void UpdateStartTime(float newStartTime) {} // 0x0000000187318180-0x0000000187318240
		// [XID] // 0x0000000189B69530-0x0000000189B69550
		public void UpdateEndTime(float newEndTime) {} // 0x00000001873180D0-0x0000000187318180
	}
}
