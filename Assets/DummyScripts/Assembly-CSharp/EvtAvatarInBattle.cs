/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtAvatarInBattle : BaseLevelEvent, IAutoAllocRecycle // TypeDefIndex: 20067
{
	// Fields
	public uint avatarId; // 0x34

	// Properties
	public bool inBattle { /* [XID] */ /* 0x000000018976E220-0x000000018976E260 */ get; /* [XID] */ /* 0x0000000189778C40-0x0000000189778C80 */ private set; } // 0x0000000183241290-0x00000001832412F0 0x00000001832410B0-0x0000000183241110

	// Constructors
	public EvtAvatarInBattle() {} // 0x00000001832414D0-0x0000000183241530

	// Methods
	[BlackList] // 0x000000018974F170-0x000000018974F1B0
	// [XID] // 0x000000018974F170-0x000000018974F1B0
	public override void AutoAllocTypeFields() {} // 0x0000000183240E50-0x0000000183240EF0
	[BlackList] // 0x0000000189759580-0x00000001897595C0
	// [XID] // 0x0000000189759580-0x00000001897595C0
	public override void AutoRecycleTypeFields() {} // 0x0000000183240EF0-0x0000000183240FE0
	[BlackList] // 0x0000000189763DA0-0x0000000189763DE0
	// [XID] // 0x0000000189763DA0-0x0000000189763DE0
	public override void ReturnToObjectPool() {} // 0x0000000183241350-0x00000001832413F0
	// [XID] // 0x0000000189783370-0x0000000189783390
	public void Init(uint avatarId, bool inBattle) {} // 0x0000000183241110-0x0000000183241230
	// [XID] // 0x000000018978A9A0-0x000000018978A9C0
	public override string ToString() => default; // 0x00000001832413F0-0x00000001832414D0
}

