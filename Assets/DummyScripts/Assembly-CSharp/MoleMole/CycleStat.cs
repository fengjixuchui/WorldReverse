/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class CycleStat // TypeDefIndex: 27844
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string _statID; // 0x10
		public int scopeCount; // 0x18
		[NonSerialized]
		[NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
		private BaseEntity _entityOwner; // 0x20
		public const int SOT_None = -1; // Metadata: 0x00B0D04C
		public const int SOT_ECPComponent = 0; // Metadata: 0x00B0D050
		public const int SOT_ECPEntity = 1; // Metadata: 0x00B0D054
		public const int SOT_BaseManager = 2; // Metadata: 0x00B0D058
		public const int SOT_Monobehaviour = 3; // Metadata: 0x00B0D05C
		public const int SOT_CategoryTotal = 4; // Metadata: 0x00B0D060
		public const int SOT_EngineModule = 5; // Metadata: 0x00B0D064
		public const int SOT_ECPPlugin = 6; // Metadata: 0x00B0D068
		public const int SOT_EntityManager = 7; // Metadata: 0x00B0D06C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public int statOwnerType; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public CycleStatData statData; // 0x30
		[NonSerialized]
		public BaseEntity.ECPDebugInfo.EFilterEntityType entityType; // 0xA8
		public object owner; // 0xB0
	
		// Properties
		public string statIDForceCache { /* [XID] */ /* 0x0000000189600B20-0x0000000189600B40 */ get => default; } // 0x0000000184D7E000-0x0000000184D7E0A0 
		public string statID { /* [XID] */ /* 0x00000001896084C0-0x00000001896084E0 */ get => default; /* [XID] */ /* 0x000000018960FD80-0x000000018960FDA0 */ set {} } // 0x0000000184D7E0A0-0x0000000184D7E1A0 0x0000000184D7E250-0x0000000184D7E330
		public BaseEntity entityOwner { /* [XID] */ /* 0x0000000189734E50-0x0000000189734E70 */ get => default; } // 0x0000000184D7DF60-0x0000000184D7E000 
		public double totalTickMilliseconds { /* [XID] */ /* 0x0000000189644260-0x0000000189644280 */ get => default; } // 0x0000000184D7E1A0-0x0000000184D7E250 
	
		// Constructors
		public CycleStat() {} // 0x0000000184D7DEE0-0x0000000184D7DF60
		public CycleStat(BaseEntity inOwner) {} // 0x0000000184D7DE40-0x0000000184D7DEE0
		public CycleStat(string inStatID, object inOwner, int inScopeCount) {} // 0x0000000184D7DD90-0x0000000184D7DE40
	
		// Methods
		// [XID] // 0x0000000189617080-0x00000001896170A0
		public static bool ShouldSampleStat(int inSOT) => default; // 0x0000000184D7D5A0-0x0000000184D7D6E0
		// [XID] // 0x000000018961EC00-0x000000018961EC20
		public bool IsComponent() => default; // 0x0000000184D7D4F0-0x0000000184D7D5A0
		// [XID] // 0x0000000189626040-0x0000000189626060
		public bool IsECP() => default; // 0x0000000184D7DB40-0x0000000184D7DBF0
		// [XID] // 0x000000018962DA20-0x000000018962DA40
		public bool IsEntityManager() => default; // 0x0000000184D7DA90-0x0000000184D7DB40
		// [XID] // 0x000000018963CC60-0x000000018963CC80
		public static bool IsLess(CycleStat cs1, CycleStat cs2) => default; // 0x0000000184D7D6E0-0x0000000184D7D7D0
		// [IDTag] // 0x000000018964B9F0-0x000000018964BA30
		// [XID] // 0x000000018964B9F0-0x000000018964BA30
		public static CycleStat NewPooledCycleStat() => default; // 0x0000000184D7DBF0-0x0000000184D7DC90
		// [IDTag] // 0x0000000189656140-0x0000000189656180
		// [XID] // 0x0000000189656140-0x0000000189656180
		public static CycleStat NewPooledCycleStat(string id, int inStatOwnerType, object inOwner = null) => default; // 0x0000000184D7DC90-0x0000000184D7DD90
		// [XID] // 0x0000000189660780-0x00000001896607A0
		public void Flush() {} // 0x0000000184D7D890-0x0000000184D7D960
		// [XID] // 0x00000001896680E0-0x0000000189668100
		public static CycleStat Clone(CycleStat inCycleStat) => default; // 0x0000000184D7D960-0x0000000184D7DA90
		// [XID] // 0x000000018966FBE0-0x000000018966FC00
		public void ResetTickStatValue(bool bClearHistroyStat) {} // 0x0000000184D7D7D0-0x0000000184D7D890
	}
}
