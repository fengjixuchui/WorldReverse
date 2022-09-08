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
	public struct CombatSyncTask // TypeDefIndex: 20638
	{
		// Fields
		public MessageBase combatMessage; // 0x00
		public uint clientSequenceId; // 0x08
		public uint subSequenceId; // 0x0C
		public float waitReadyTime; // 0x10
		public bool hasValue; // 0x14
	
		// Methods
		// [XID] // 0x0000000189AA7A50-0x0000000189AA7A70
		public DualClientSequenceId GetClientSequenceId() => default; // 0x0000000181ADD870-0x0000000181ADD930
		// [XID] // 0x0000000189606D00-0x0000000189606D20
		public void SetClientSequenceId(DualClientSequenceId dualId) {} // 0x0000000181ADD930-0x0000000181ADDD30
		// [XID] // 0x000000018960E620-0x000000018960E640
		public bool IsReliable() => default; // 0x0000000181ADD7A0-0x0000000181ADD870
		// [XID] // 0x0000000189615CA0-0x0000000189615CC0
		public override string ToString() => default; // 0x0000000181ADDD30-0x0000000181ADDD60
	}
}
