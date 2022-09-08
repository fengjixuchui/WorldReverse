/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AttackHitEffectResult : MessageBase, IMessage<AttackHitEffectResult> // TypeDefIndex: 22986
{
	// Fields
	private static readonly MessageParser<AttackHitEffectResult> _parser; // 0x00
	public const int HitEffLevelFieldNumber = 1; // Metadata: 0x00B02D5B
	private uint hitEffLevel_; // 0x18
	public const int RetreatStrengthFieldNumber = 2; // Metadata: 0x00B02D5F
	private float retreatStrength_; // 0x1C
	public const int AirStrengthFieldNumber = 3; // Metadata: 0x00B02D63
	private float airStrength_; // 0x20
	public const int HitHaltTimeFieldNumber = 4; // Metadata: 0x00B02D67
	private float hitHaltTime_; // 0x24
	public const int HitHaltTimeScaleFieldNumber = 5; // Metadata: 0x00B02D6B
	private float hitHaltTimeScale_; // 0x28
	public const int OriginalHitEffLevelFieldNumber = 6; // Metadata: 0x00B02D6F
	private uint originalHitEffLevel_; // 0x2C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AttackHitEffectResult> Parser { get => default; } // 0x00000001819E0FA0-0x00000001819E1030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001819E0B50-0x00000001819E0BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001819E0750-0x00000001819E07D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001819DFC20-0x00000001819DFC80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001819E1630-0x00000001819E1720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001819E1200-0x00000001819E1260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001819E0C80-0x00000001819E0D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001819E1540-0x00000001819E1590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001819E0870-0x00000001819E0960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint HitEffLevel { get => default; set {} } // 0x00000001819E01F0-0x00000001819E0290 0x00000001819E0F00-0x00000001819E0FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float RetreatStrength { get => default; set {} } // 0x00000001819E06B0-0x00000001819E0750 0x00000001819E1160-0x00000001819E1200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float AirStrength { get => default; set {} } // 0x00000001819DFD20-0x00000001819DFDC0 0x00000001819E0BE0-0x00000001819E0C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float HitHaltTime { get => default; set {} } // 0x00000001819E1260-0x00000001819E1300 0x00000001819DFC80-0x00000001819DFD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float HitHaltTimeScale { get => default; set {} } // 0x00000001819E0150-0x00000001819E01F0 0x00000001819E1590-0x00000001819E1630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OriginalHitEffLevel { get => default; set {} } // 0x00000001819E0E60-0x00000001819E0F00 0x00000001819E0000-0x00000001819E00A0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AttackHitEffectResult() {} // 0x00000001819E1C20-0x00000001819E1C80
	static AttackHitEffectResult() {} // 0x00000001819E1B60-0x00000001819E1C20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AttackHitEffectResult Clone() => default; // 0x00000001819E0D70-0x00000001819E0E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AttackHitEffectResult ShallowCopy() => default; // 0x00000001819E07D0-0x00000001819E0870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001819DFFB0-0x00000001819E0000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001819E10C0-0x00000001819E1110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001819E1110-0x00000001819E1160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001819E00A0-0x00000001819E0150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001819E0290-0x00000001819E0360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AttackHitEffectResult other) => default; // 0x00000001819E0360-0x00000001819E0520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001819E0960-0x00000001819E0B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001819E1720-0x00000001819E1B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001819E1300-0x00000001819E1540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001819E0520-0x00000001819E06B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AttackHitEffectResult other) {} // 0x00000001819DFDC0-0x00000001819DFFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001819DFA90-0x00000001819DFC20
}

