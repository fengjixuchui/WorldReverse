/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UnionCombatInvokeEntry : UnionCmdBase<UnionCombatInvokeEntry, CombatInvokeEntry> // TypeDefIndex: 21719
{
	// Fields
	private MessageBase _combatData; // 0x28

	// Properties
	public MessageBase combatData { /* [XID] */ /* 0x000000018999FA10-0x000000018999FA30 */ get => default; /* [XID] */ /* 0x00000001899A7700-0x00000001899A7720 */ private set {} } // 0x0000000182ED1250-0x0000000182ED1330 0x0000000182ED1160-0x0000000182ED1250

	// Constructors
	public UnionCombatInvokeEntry() {} // 0x0000000182ED21B0-0x0000000182ED2220

	// Methods
	// [XID] // 0x00000001899AEF10-0x00000001899AEF30
	private MessageBase InternalCloneCombatData() => default; // 0x0000000182ED1CE0-0x0000000182ED21B0
	// [XID] // 0x00000001899B6270-0x00000001899B6290
	private MessageBase AllocCombatData() => default; // 0x0000000182ED17B0-0x0000000182ED1C10
	// [XID] // 0x00000001899BDED0-0x00000001899BDEF0
	protected override void internalAfterDeserializeInWorkThread(CodedInputStream inputHelper) {} // 0x0000000182ED1400-0x0000000182ED1590
	// [XID] // 0x00000001899C5650-0x00000001899C5670
	private MessageBase CloneCombatData() => default; // 0x0000000182ED10A0-0x0000000182ED1160
	// [XID] // 0x00000001899CCD60-0x00000001899CCD80
	protected override void InternalMergeFrom(UnionCombatInvokeEntry message) {} // 0x0000000182ED1690-0x0000000182ED17B0
	// [XID] // 0x00000001899D42A0-0x00000001899D42C0
	protected override void internalReset() {} // 0x0000000182ED1590-0x0000000182ED1690
	// [XID] // 0x00000001899DB950-0x00000001899DB970
	protected override void internalDeleteReferenceMask() {} // 0x0000000182ED1330-0x0000000182ED1400
	// [XID] // 0x00000001899E31B0-0x00000001899E31D0
	protected override void internalAddReferenceMask() {} // 0x0000000182ED1C10-0x0000000182ED1CE0
}

