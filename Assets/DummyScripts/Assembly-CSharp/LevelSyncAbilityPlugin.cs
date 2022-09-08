/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LevelSyncAbilityPlugin : BaseComponentPlugin // TypeDefIndex: 12122
{
	// Fields
	public const float FLUSH_INTERVAL_SINGLE = 0.5f; // Metadata: 0x00AEB523
	public const float FLUSH_INTERVAL_MULTIPLAYER = 0.1f; // Metadata: 0x00AEB527
	private List<AbilityEntryProxy> _invokeAbilities; // 0x58
	private LevelSyncCombatPlugin syncCombatPlugin; // 0x60
	private const int FORCE_FLUSH_CAP = 20; // Metadata: 0x00AEB52B
	private float _flushTimeAcc; // 0x68

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B51310-0x0000000189B51330 */ get => default; } // 0x0000000181B62E90-0x0000000181B62F30 

	// Constructors
	public LevelSyncAbilityPlugin() {} // 0x0000000181B62E00-0x0000000181B62E90

	// Methods
	// [XID] // 0x0000000189B5D520-0x0000000189B5D540
	public void ClearRecordInvokeEntries() {} // 0x0000000181B62CE0-0x0000000181B62D90
	// [XID] // 0x0000000189A479F0-0x0000000189A47A10
	public void AddInvokeEntry(AbilityEntryProxy entryProxy, bool sendImmediately = false /* Metadata: 0x00AEB51D */, string abilityMessageInfo = "" /* Metadata: 0x00AEB51E */, bool muteCheckFlush = false /* Metadata: 0x00AEB522 */) {} // 0x0000000181B62320-0x0000000181B62A20
	// [XID] // 0x0000000189B67B50-0x0000000189B67B70
	public void OnFrameEndTryFlushInvokes() {} // 0x0000000181B62B30-0x0000000181B62C40
	// [XID] // 0x0000000189B6EDF0-0x0000000189B6EE10
	public void TickFlushTimeAcc() {} // 0x0000000181B62C40-0x0000000181B62CE0
	// [XID] // 0x0000000189B4E490-0x0000000189B4E4B0
	public void FlushRecordInvokeEntriesAndSend() {} // 0x0000000181B62A20-0x0000000181B62B30
}

