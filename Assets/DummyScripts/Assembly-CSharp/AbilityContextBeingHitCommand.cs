/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityContextBeingHitCommand : AbilityContextCommand // TypeDefIndex: 20574
{
	// Fields
	private uint _attackerId; // 0x10
	private uint _targetId; // 0x14
	private AttackResult _attackResult; // 0x18
	private BaseEntity _targetEntity; // 0x20

	// Properties
	public override CommandType type { /* [XID] */ /* 0x0000000189A528C0-0x0000000189A528E0 */ get => default; } // 0x0000000182E88130-0x0000000182E881D0 
	public uint attackerId { /* [XID] */ /* 0x0000000189A5A240-0x0000000189A5A260 */ get => default; } // 0x0000000182E87BC0-0x0000000182E87C60 
	public uint targetId { /* [XID] */ /* 0x0000000189A61A70-0x0000000189A61A90 */ get => default; } // 0x0000000182E87FF0-0x0000000182E88090 
	public AttackResult attackResult { /* [XID] */ /* 0x0000000189A699D0-0x0000000189A699F0 */ get => default; } // 0x0000000182E87C60-0x0000000182E87D00 

	// Constructors
	public AbilityContextBeingHitCommand() {} // 0x0000000182E881D0-0x0000000182E88270

	// Methods
	// [XID] // 0x0000000189A70CA0-0x0000000189A70CC0
	public BaseEntity GetTargetEntity() => default; // 0x0000000182E88090-0x0000000182E88130
	// [XID] // 0x000000018978E740-0x000000018978E760
	public void Init(uint attackerId, uint targetId, AttackResult attackResult, BaseEntity targetEntity) {} // 0x0000000182E87E00-0x0000000182E87F20
	// [XID] // 0x0000000189A7FB50-0x0000000189A7FB70
	public override void Destroy() {} // 0x0000000182E87D00-0x0000000182E87E00
}

