/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TowerMonthlyCombatRecord : MessageBase, IMessage<TowerMonthlyCombatRecord> // TypeDefIndex: 25758
{
	// Fields
	private static readonly MessageParser<TowerMonthlyCombatRecord> _parser; // 0x00
	public const int MostRevealAvatarListFieldNumber = 1; // Metadata: 0x00B0982B
	private static readonly FieldCodec<TowerFightRecordPair> _repeated_mostRevealAvatarList_codec; // 0x08
	private readonly RepeatedMessageField<TowerFightRecordPair> mostRevealAvatarList_; // 0x18
	public const int MostKillAvatarPairFieldNumber = 2; // Metadata: 0x00B0982F
	private TowerFightRecordPair mostKillAvatarPair_; // 0x20
	public const int HighestDpsAvatrPairFieldNumber = 3; // Metadata: 0x00B09833
	private TowerFightRecordPair highestDpsAvatrPair_; // 0x28
	public const int MostTakeDamageAvatarPairFieldNumber = 4; // Metadata: 0x00B09837
	private TowerFightRecordPair mostTakeDamageAvatarPair_; // 0x30
	public const int MostCastNormalSkillAvatarPairFieldNumber = 5; // Metadata: 0x00B0983B
	private TowerFightRecordPair mostCastNormalSkillAvatarPair_; // 0x38
	public const int MostCastEnergySkillAvatarPairFieldNumber = 6; // Metadata: 0x00B0983F
	private TowerFightRecordPair mostCastEnergySkillAvatarPair_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TowerMonthlyCombatRecord> Parser { get => default; } // 0x0000000182CD5BA0-0x0000000182CD5C30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182CD57F0-0x0000000182CD5880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182CD5130-0x0000000182CD51B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182CD3E80-0x0000000182CD3EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182CD6330-0x0000000182CD6420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182CD5F20-0x0000000182CD5F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182CD5920-0x0000000182CD5A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182CD6240-0x0000000182CD6290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182CD52F0-0x0000000182CD53E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<TowerFightRecordPair> MostRevealAvatarList { get => default; } // 0x0000000182CD3F80-0x0000000182CD3FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerFightRecordPair MostKillAvatarPair { get => default; set {} } // 0x0000000182CD5250-0x0000000182CD52F0 0x0000000182CD5880-0x0000000182CD5920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerFightRecordPair HighestDpsAvatrPair { get => default; set {} } // 0x0000000182CD3FE0-0x0000000182CD4080 0x0000000182CD6420-0x0000000182CD64C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerFightRecordPair MostTakeDamageAvatarPair { get => default; set {} } // 0x0000000182CD5B00-0x0000000182CD5BA0 0x0000000182CD3EE0-0x0000000182CD3F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerFightRecordPair MostCastNormalSkillAvatarPair { get => default; set {} } // 0x0000000182CD61A0-0x0000000182CD6240 0x0000000182CD6290-0x0000000182CD6330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerFightRecordPair MostCastEnergySkillAvatarPair { get => default; set {} } // 0x0000000182CD4940-0x0000000182CD49E0 0x0000000182CD5E80-0x0000000182CD5F20

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerMonthlyCombatRecord() {} // 0x0000000182CD6960-0x0000000182CD69F0
	static TowerMonthlyCombatRecord() {} // 0x0000000182CD6850-0x0000000182CD6960

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerMonthlyCombatRecord Clone() => default; // 0x0000000182CD5A10-0x0000000182CD5B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerMonthlyCombatRecord ShallowCopy() => default; // 0x0000000182CD51B0-0x0000000182CD5250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182CD43F0-0x0000000182CD44C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182CD5CC0-0x0000000182CD5DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182CD5DA0-0x0000000182CD5E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182CD44C0-0x0000000182CD4940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182CD4BE0-0x0000000182CD4CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TowerMonthlyCombatRecord other) => default; // 0x0000000182CD49E0-0x0000000182CD4BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182CD53E0-0x0000000182CD57F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182CD64C0-0x0000000182CD6850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182CD5F80-0x0000000182CD61A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182CD4CB0-0x0000000182CD5130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TowerMonthlyCombatRecord other) {} // 0x0000000182CD4080-0x0000000182CD43F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182CD3BB0-0x0000000182CD3E80
}

