/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityMetaModifierChange : MessageBase, IMessage<AbilityMetaModifierChange> // TypeDefIndex: 21755
{
	// Fields
	private static readonly MessageParser<AbilityMetaModifierChange> _parser; // 0x00
	public const int ActionFieldNumber = 1; // Metadata: 0x00AFFEDB
	private ModifierAction action_; // 0x18
	public const int ParentAbilityNameFieldNumber = 2; // Metadata: 0x00AFFEDF
	private AbilityString parentAbilityName_; // 0x20
	public const int ParentAbilityOverrideFieldNumber = 3; // Metadata: 0x00AFFEE3
	private AbilityString parentAbilityOverride_; // 0x28
	public const int AttachedInstancedModifierFieldNumber = 4; // Metadata: 0x00AFFEE7
	private AbilityAttachedModifier attachedInstancedModifier_; // 0x30
	public const int PropertiesFieldNumber = 5; // Metadata: 0x00AFFEEB
	private static readonly FieldCodec<ModifierProperty> _repeated_properties_codec; // 0x08
	private readonly RepeatedMessageField<ModifierProperty> properties_; // 0x38
	public const int ModifierLocalIdFieldNumber = 6; // Metadata: 0x00AFFEEF
	private int modifierLocalId_; // 0x40
	public const int IsMuteRemoteFieldNumber = 7; // Metadata: 0x00AFFEF3
	private bool isMuteRemote_; // 0x44
	public const int ApplyEntityIdFieldNumber = 8; // Metadata: 0x00AFFEF7
	private uint applyEntityId_; // 0x48
	public const int IsAttachedParentAbilityFieldNumber = 9; // Metadata: 0x00AFFEFB
	private bool isAttachedParentAbility_; // 0x4C
	public const int ServerBuffUidFieldNumber = 10; // Metadata: 0x00AFFEFF
	private uint serverBuffUid_; // 0x50

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityMetaModifierChange> Parser { get => default; } // 0x00000001823F9390-0x00000001823F9420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001823F8F40-0x00000001823F8FD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001823F8830-0x00000001823F88B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001823F7470-0x00000001823F74D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001823F9BF0-0x00000001823F9CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001823F9770-0x00000001823F97D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001823F9070-0x00000001823F9160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001823F9BA0-0x00000001823F9BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001823F89F0-0x00000001823F8AE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ModifierAction Action { get => default; set {} } // 0x00000001823F97D0-0x00000001823F9870 0x00000001823F7570-0x00000001823F7610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityString ParentAbilityName { get => default; set {} } // 0x00000001823F7EE0-0x00000001823F7F80 0x00000001823F8FD0-0x00000001823F9070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityString ParentAbilityOverride { get => default; set {} } // 0x00000001823F73D0-0x00000001823F7470 0x00000001823F9D80-0x00000001823F9E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityAttachedModifier AttachedInstancedModifier { get => default; set {} } // 0x00000001823F9250-0x00000001823F92F0 0x00000001823F9E20-0x00000001823F9EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ModifierProperty> Properties { get => default; } // 0x00000001823F8EE0-0x00000001823F8F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int ModifierLocalId { get => default; set {} } // 0x00000001823F92F0-0x00000001823F9390 0x00000001823F74D0-0x00000001823F7570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsMuteRemote { get => default; set {} } // 0x00000001823F7E40-0x00000001823F7EE0 0x00000001823F7DA0-0x00000001823F7E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ApplyEntityId { get => default; set {} } // 0x00000001823F96D0-0x00000001823F9770 0x00000001823F86F0-0x00000001823F8790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAttachedParentAbility { get => default; set {} } // 0x00000001823F88B0-0x00000001823F8950 0x00000001823F9CE0-0x00000001823F9D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ServerBuffUid { get => default; set {} } // 0x00000001823F8790-0x00000001823F8830 0x00000001823F9570-0x00000001823F9610

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMetaModifierChange() {} // 0x00000001823FA5D0-0x00000001823FA670
	static AbilityMetaModifierChange() {} // 0x00000001823FA4C0-0x00000001823FA5D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMetaModifierChange Clone() => default; // 0x00000001823F9160-0x00000001823F9250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMetaModifierChange ShallowCopy() => default; // 0x00000001823F8950-0x00000001823F89F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001823F7990-0x00000001823F7A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823F94B0-0x00000001823F9570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823F9610-0x00000001823F96D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001823F7A40-0x00000001823F7DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001823F7F80-0x00000001823F8050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityMetaModifierChange other) => default; // 0x00000001823F8050-0x00000001823F82A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001823F8AE0-0x00000001823F8EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001823F9EC0-0x00000001823FA4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001823F9870-0x00000001823F9BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001823F82A0-0x00000001823F86F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityMetaModifierChange other) {} // 0x00000001823F7610-0x00000001823F7990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001823F70F0-0x00000001823F73D0
}

