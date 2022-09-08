/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct RecordInvokeEntryContext // TypeDefIndex: 21693
{
	// Fields
	public MPActorAbilityPlugin abilityPlugin; // 0x00
	public MessageBase abilityData; // 0x08
	public string abilityMessageInfo; // 0x10
	public AbilityInvokeArgument argType; // 0x18
	public AbilityInvokeEntry invokeEntry; // 0x20
	public uint instancedAbilityID; // 0x28
	public uint instanceModifierID; // 0x2C
	public int modifierConfigLocalID; // 0x30
	public uint targetID; // 0x34
	public bool isTargetAbilityCommon; // 0x38
	public int localID; // 0x3C
	public uint evtID; // 0x40
	public bool isServerBuff; // 0x44
	public uint serverBuffUid; // 0x48
	public bool muteCheckFlush; // 0x4C
	private bool _isFinished; // 0x4D
	private bool _forwardOnlyServer; // 0x4E
	private bool _sendImmediately; // 0x4F

	// Methods
	// [IDTag] // 0x0000000189945680-0x00000001899456C0
	// [XID] // 0x0000000189945680-0x00000001899456C0
	public void Finish(bool record, bool forwardOnlyServer = false /* Metadata: 0x00AFFC24 */, bool sendImmediately = false /* Metadata: 0x00AFFC25 */, bool remoteToAuthority = false /* Metadata: 0x00AFFC26 */) {} // 0x00000001832AEED0-0x00000001832AEF10
	public void Finish<T>(T abilityMessage, AbilityInvokeArgument argType, bool forwardOnlyServer = false /* Metadata: 0x00AFFC27 */, bool sendImmediately = false /* Metadata: 0x00AFFC28 */, bool remoteToAuthority = false /* Metadata: 0x00AFFC29 */)
		where T : MessageBase {}
	// [IDTag] // 0x000000018994FCB0-0x000000018994FCF0
	// [XID] // 0x000000018994FCB0-0x000000018994FCF0
	public void Finish(AbilityInvokeArgument argType, bool forwardOnlyServer = false /* Metadata: 0x00AFFC2A */, bool sendImmediately = false /* Metadata: 0x00AFFC2B */) {} // 0x00000001832AED50-0x00000001832AEED0
	// [XID] // 0x0000000189A22A20-0x0000000189A22A40
	private void WriteBuilder() {} // 0x00000001832AEBE0-0x00000001832AED50
}

