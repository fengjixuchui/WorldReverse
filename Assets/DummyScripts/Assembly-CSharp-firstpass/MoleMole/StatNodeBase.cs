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

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class StatNodeBase : IStatNode // TypeDefIndex: 10096
	{
		// Fields
		private List<IStatNode> _childrenNodes; // 0x20
	
		// Properties
		public string statID { /* [XID] */ /* 0x00000001897AAFA0-0x00000001897AAFE0 */ get; /* [XID] */ /* 0x00000001897B6460-0x00000001897B64A0 */ set; } // 0x00000001868ADE50-0x00000001868ADEB0 0x00000001868ADF90-0x00000001868ADFF0
		public float inclusiveTotal { /* [XID] */ /* 0x00000001897C0F50-0x00000001897C0F90 */ get; /* [XID] */ /* 0x00000001897CB600-0x00000001897CB640 */ set; } // 0x00000001868ADDE0-0x00000001868ADE50 0x00000001868ADF20-0x00000001868ADF90
		public float exclusiveTotal { /* [XID] */ /* 0x00000001897D5DB0-0x00000001897D5DF0 */ get; /* [XID] */ /* 0x00000001897E0640-0x00000001897E0680 */ private set; } // 0x00000001868ADD70-0x00000001868ADDE0 0x00000001868ADEB0-0x00000001868ADF20
	
		// Nested types
		public class Spawer : ISpawner<StatNodeBase> // TypeDefIndex: 10097
		{
			// Constructors
			public Spawer() {} // 0x00000001868A9800-0x00000001868A9860
	
			// Methods
			// [XID] // 0x0000000189993100-0x0000000189993120
			public StatNodeBase Spawn() => default; // 0x00000001868A9700-0x00000001868A9800
		}
	
		// Constructors
		private StatNodeBase() {} // 0x00000001868ADD00-0x00000001868ADD70
	
		// Methods
		// [XID] // 0x00000001897EAF20-0x00000001897EAF40
		public void AddChild(IStatNode inNode) {} // 0x00000001868AC9C0-0x00000001868ACAF0
		// [XID] // 0x000000018972BB60-0x000000018972BB80
		public void ClearStat() {} // 0x00000001868ACDE0-0x00000001868AD050
		// [XID] // 0x0000000189B454A0-0x0000000189B454C0
		public void AccumulateStat(float inValue) {} // 0x00000001868AC890-0x00000001868AC9C0
		// [XID] // 0x0000000189B3D5E0-0x0000000189B3D600
		public float CollectStat() => default; // 0x00000001868AD050-0x00000001868AD3B0
		// [XID] // 0x00000001899433F0-0x0000000189943410
		public string ToString(int toStringType, int depth, Action<string, int> onHandleStatString) => default; // 0x00000001868AD7A0-0x00000001868ADD00
		// [XID] // 0x000000018995FB90-0x000000018995FBB0
		private void Init() {} // 0x00000001868AD4C0-0x00000001868AD640
		// [XID] // 0x0000000189817EE0-0x0000000189817F00
		public void BeforeRecycle() {} // 0x00000001868ACAF0-0x00000001868ACDE0
		// [XID] // 0x000000018981F7E0-0x000000018981F800
		public void OnRecycle() {} // 0x00000001868AD640-0x00000001868AD6F0
		[DebuggerHidden] // 0x0000000189826D90-0x0000000189826DD0
		// [XID] // 0x0000000189826D90-0x0000000189826DD0
		public IEnumerator<IStatNode> GetEnumerator() => default; // 0x00000001868AD3B0-0x00000001868AD4C0
		// [XID] // 0x000000018998B520-0x000000018998B540
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x00000001868AD6F0-0x00000001868AD7A0
	}
}
