/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityAppliedModifier : MessageBase, IMessage<AbilityAppliedModifier> // TypeDefIndex: 25998
{
	// Fields
	private static readonly MessageParser<AbilityAppliedModifier> _parser; // 0x00
	public const int ModifierLocalIdFieldNumber = 1; // Metadata: 0x00B0A9B3
	private int modifierLocalId_; // 0x18
	public const int ParentAbilityEntityIdFieldNumber = 2; // Metadata: 0x00B0A9B7
	private uint parentAbilityEntityId_; // 0x1C
	public const int ParentAbilityNameFieldNumber = 3; // Metadata: 0x00B0A9BB
	private AbilityString parentAbilityName_; // 0x20
	public const int ParentAbilityOverrideFieldNumber = 4; // Metadata: 0x00B0A9BF
	private AbilityString parentAbilityOverride_; // 0x28
	public const int InstancedAbilityIdFieldNumber = 5; // Metadata: 0x00B0A9C3
	private uint instancedAbilityId_; // 0x30
	public const int InstancedModifierIdFieldNumber = 6; // Metadata: 0x00B0A9C7
	private uint instancedModifierId_; // 0x34
	public const int ExistDurationFieldNumber = 7; // Metadata: 0x00B0A9CB
	private float existDuration_; // 0x38
	public const int AttachedInstancedModifierFieldNumber = 8; // Metadata: 0x00B0A9CF
	private AbilityAttachedModifier attachedInstancedModifier_; // 0x40
	public const int ApplyEntityIdFieldNumber = 9; // Metadata: 0x00B0A9D3
	private uint applyEntityId_; // 0x48
	public const int IsAttachedParentAbilityFieldNumber = 10; // Metadata: 0x00B0A9D7
	private bool isAttachedParentAbility_; // 0x4C
	public const int ModifierDurabilityFieldNumber = 11; // Metadata: 0x00B0A9DB
	private ModifierDurability modifierDurability_; // 0x50
	public const int SbuffUidFieldNumber = 12; // Metadata: 0x00B0A9DF
	private uint sbuffUid_; // 0x58
	public const int IsServerbuffModifierFieldNumber = 13; // Metadata: 0x00B0A9E3
	private bool isServerbuffModifier_; // 0x5C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityAppliedModifier> Parser { get => default; } // 0x0000000182F64E40-0x0000000182F64ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182F64770-0x0000000182F64800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182F63F40-0x0000000182F63FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182F627C0-0x0000000182F62820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182F65720-0x0000000182F65810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182F65200-0x0000000182F65260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182F64A80-0x0000000182F64B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182F656D0-0x0000000182F65720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182F64100-0x0000000182F641F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int ModifierLocalId { get => default; set {} } // 0x0000000182F64D00-0x0000000182F64DA0 0x0000000182F628C0-0x0000000182F62960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ParentAbilityEntityId { get => default; set {} } // 0x0000000182F649E0-0x0000000182F64A80 0x0000000182F65260-0x0000000182F65300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityString ParentAbilityName { get => default; set {} } // 0x0000000182F633E0-0x0000000182F63480 0x0000000182F64940-0x0000000182F649E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityString ParentAbilityOverride { get => default; set {} } // 0x0000000182F62720-0x0000000182F627C0 0x0000000182F658B0-0x0000000182F65950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint InstancedAbilityId { get => default; set {} } // 0x0000000182F62A00-0x0000000182F62AA0 0x0000000182F659F0-0x0000000182F65A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint InstancedModifierId { get => default; set {} } // 0x0000000182F62820-0x0000000182F628C0 0x0000000182F648A0-0x0000000182F64940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float ExistDuration { get => default; set {} } // 0x0000000182F64DA0-0x0000000182F64E40 0x0000000182F63E00-0x0000000182F63EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityAttachedModifier AttachedInstancedModifier { get => default; set {} } // 0x0000000182F64C60-0x0000000182F64D00 0x0000000182F65950-0x0000000182F659F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ApplyEntityId { get => default; set {} } // 0x0000000182F65160-0x0000000182F65200 0x0000000182F63D60-0x0000000182F63E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAttachedParentAbility { get => default; set {} } // 0x0000000182F63FC0-0x0000000182F64060 0x0000000182F65810-0x0000000182F658B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ModifierDurability ModifierDurability { get => default; set {} } // 0x0000000182F646D0-0x0000000182F64770 0x0000000182F650C0-0x0000000182F65160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SbuffUid { get => default; set {} } // 0x0000000182F63EA0-0x0000000182F63F40 0x0000000182F62960-0x0000000182F62A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsServerbuffModifier { get => default; set {} } // 0x0000000182F64800-0x0000000182F648A0 0x0000000182F62AA0-0x0000000182F62B40

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityAppliedModifier() {} // 0x0000000182F66300-0x0000000182F66360
	static AbilityAppliedModifier() {} // 0x0000000182F66240-0x0000000182F66300

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityAppliedModifier Clone() => default; // 0x0000000182F64B70-0x0000000182F64C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityAppliedModifier ShallowCopy() => default; // 0x0000000182F64060-0x0000000182F64100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182F62F50-0x0000000182F63010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182F64F60-0x0000000182F65010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182F65010-0x0000000182F650C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182F63010-0x0000000182F633E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182F63480-0x0000000182F63550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityAppliedModifier other) => default; // 0x0000000182F63550-0x0000000182F63810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182F641F0-0x0000000182F646D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182F65A90-0x0000000182F66240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182F65300-0x0000000182F656D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182F63810-0x0000000182F63D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityAppliedModifier other) {} // 0x0000000182F62B40-0x0000000182F62F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182F623F0-0x0000000182F62720
}

