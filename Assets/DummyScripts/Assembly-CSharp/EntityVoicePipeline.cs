/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class EntityVoicePipeline : VoicePipeline // TypeDefIndex: 11529
{
	// Fields
	private readonly VCBaseAudio _component; // 0x30
	private bool _enabled; // 0x38

	// Properties
	protected override bool isContextActive { /* [XID] */ /* 0x00000001899C0390-0x00000001899C03B0 */ get; } // 0x0000000181242110-0x00000001812421B0 
	public VCBaseAudio component { /* [XID] */ /* 0x00000001899C7C10-0x00000001899C7C30 */ get; } // 0x0000000181242000-0x00000001812420A0 

	// Constructors
	protected EntityVoicePipeline() {} // Dummy constructor
	public EntityVoicePipeline(VCBaseAudio component) {} // 0x00000001812421B0-0x0000000181242220

	// Methods
	// [XID] // 0x00000001899CF3D0-0x00000001899CF3F0
	public virtual void OnEnable() {} // 0x0000000181241E20-0x0000000181241EC0
	// [XID] // 0x00000001899D68D0-0x00000001899D68F0
	public virtual void OnDisable() {} // 0x0000000181241D70-0x0000000181241E20
	// [XID] // 0x00000001899DDEF0-0x00000001899DDF10
	protected override SyncId GetSyncId() => default; // 0x0000000181241EC0-0x0000000181242000
}

