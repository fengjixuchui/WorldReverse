/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CommandThreadControlFunctionalities : CommandThreadFunctionalities<SharedControlFunctionalities> // TypeDefIndex: 11265
{
	// Fields
	private AudioSuspenseReason _suspenseReason; // 0x20

	// Properties
	public AudioSuspenseReason suspenseReason { /* [XID] */ /* 0x0000000189892320-0x0000000189892340 */ get => default; } // 0x0000000184B82680-0x0000000184B82720 

	// Constructors
	public CommandThreadControlFunctionalities() {} // Dummy constructor
	public CommandThreadControlFunctionalities(CommandThreadContext context, SharedControlFunctionalities shared) {} // 0x0000000184B82A70-0x0000000184B82B00

	// Methods
	// [XID] // 0x0000000189899DD0-0x0000000189899DF0
	public override void Init() {} // 0x0000000184B81F40-0x0000000184B81FE0
	// [XID] // 0x00000001898A0F70-0x00000001898A0F90
	public override void Tick(float deltaTime) {} // 0x0000000184B821D0-0x0000000184B82280
	// [XID] // 0x00000001898A8500-0x00000001898A8520
	public override void EnterHomeWorld(bool firstTime) {} // 0x0000000184B82320-0x0000000184B823D0
	// [XID] // 0x00000001899B7320-0x00000001899B7340
	public override void ExitHomeWorld() {} // 0x0000000184B82720-0x0000000184B827C0
	// [XID] // 0x00000001898B7570-0x00000001898B7590
	public override void ExitGameWorld() {} // 0x0000000184B824B0-0x0000000184B82550
	// [XID] // 0x00000001899CDD90-0x00000001899CDDB0
	public override void CreateLevel() {} // 0x0000000184B81D60-0x0000000184B81E00
	// [XID] // 0x00000001898C65A0-0x00000001898C65C0
	public override void EnterLevel() {} // 0x0000000184B82280-0x0000000184B82320
	// [XID] // 0x0000000189A10CD0-0x0000000189A10CF0
	public override void ExitLevel() {} // 0x0000000184B81EA0-0x0000000184B81F40
	// [XID] // 0x00000001899F33C0-0x00000001899F33E0
	public override void DumpCriticalInfo(StringBuilder builder) {} // 0x0000000184B829C0-0x0000000184B82A70
	// [XID] // 0x00000001898DD030-0x00000001898DD050
	public override void Destroy() {} // 0x0000000184B81E00-0x0000000184B81EA0
	// [XID] // 0x00000001898E4AA0-0x00000001898E4AC0
	public void AddSuspenseReason(AudioSuspenseReason reason) {} // 0x0000000184B827C0-0x0000000184B828C0
	// [XID] // 0x00000001898EC410-0x00000001898EC430
	public void RemoveSuspenseReason(AudioSuspenseReason reason) {} // 0x0000000184B828C0-0x0000000184B829C0
	// [XID] // 0x0000000189859430-0x0000000189859450
	public void StopPlayingId(uint playingId) {} // 0x0000000184B823D0-0x0000000184B824B0
	// [IDTag] // 0x00000001898FB310-0x00000001898FB350
	// [XID] // 0x00000001898FB310-0x00000001898FB350
	public void StopAll(SyncId syncId) {} // 0x0000000184B820C0-0x0000000184B821D0
	// [IDTag] // 0x0000000189905E40-0x0000000189905E80
	// [XID] // 0x0000000189905E40-0x0000000189905E80
	public void StopAll() {} // 0x0000000184B81FE0-0x0000000184B820C0
	// [XID] // 0x00000001899DC860-0x00000001899DC880
	public void StopLocalAvatar() {} // 0x0000000184B82550-0x0000000184B82680
}

