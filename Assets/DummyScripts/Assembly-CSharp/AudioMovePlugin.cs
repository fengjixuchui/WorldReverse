/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class AudioMovePlugin : AudioComponentPlugin // TypeDefIndex: 12020
{
	// Fields
	private ConfigAudioBaseMove _config; // 0x60

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B22DB0-0x0000000189B22DD0 */ get; } // 0x0000000182459200-0x00000001824592A0 
	protected BaseEntity entity { /* [XID] */ /* 0x0000000189B2A400-0x0000000189B2A440 */ get; /* [XID] */ /* 0x0000000189B345F0-0x0000000189B34630 */ set; } // 0x0000000182458E50-0x0000000182458EB0 0x0000000182458AD0-0x0000000182458B30
	protected VCBaseMove moveComponent { /* [XID] */ /* 0x0000000189B3F190-0x0000000189B3F1D0 */ get; /* [XID] */ /* 0x0000000189B49C10-0x0000000189B49C50 */ set; } // 0x0000000182458DF0-0x0000000182458E50 0x0000000182458BB0-0x0000000182458C10

	// Constructors
	protected AudioMovePlugin() {} // Dummy constructor
	public AudioMovePlugin(VCBaseAudio owner) {} // 0x0000000182459180-0x0000000182459200

	// Methods
	// [XID] // 0x0000000189B54180-0x0000000189B541A0
	public override void Init() {} // 0x0000000182458C10-0x0000000182458DF0
	// [XID] // 0x0000000189B5BBE0-0x0000000189B5BC00
	public override void Tick(float deltaTime) {} // 0x00000001824590B0-0x0000000182459180
	// [XID] // 0x0000000189B62FE0-0x0000000189B63000
	protected virtual void TickMoveParameters() {} // 0x0000000182458970-0x0000000182458AD0
	// [XID] // 0x0000000189B6A950-0x0000000189B6A970
	protected virtual void TickMoveStateParameters() {} // 0x0000000182458F20-0x00000001824590B0
}

