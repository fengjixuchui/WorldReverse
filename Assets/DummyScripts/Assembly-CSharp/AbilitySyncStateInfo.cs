/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilitySyncStateInfo : MessageBase, IMessage<AbilitySyncStateInfo> // TypeDefIndex: 26003
{
	// Fields
	private static readonly MessageParser<AbilitySyncStateInfo> _parser; // 0x00
	public const int IsInitedFieldNumber = 1; // Metadata: 0x00B0AA23
	private bool isInited_; // 0x18
	public const int DynamicValueMapFieldNumber = 2; // Metadata: 0x00B0AA27
	private static readonly FieldCodec<AbilityScalarValueEntry> _repeated_dynamicValueMap_codec; // 0x08
	private readonly RepeatedMessageField<AbilityScalarValueEntry> dynamicValueMap_; // 0x20
	public const int AppliedAbilitiesFieldNumber = 3; // Metadata: 0x00B0AA2B
	private static readonly FieldCodec<AbilityAppliedAbility> _repeated_appliedAbilities_codec; // 0x10
	private readonly RepeatedMessageField<AbilityAppliedAbility> appliedAbilities_; // 0x28
	public const int AppliedModifiersFieldNumber = 4; // Metadata: 0x00B0AA2F
	private static readonly FieldCodec<AbilityAppliedModifier> _repeated_appliedModifiers_codec; // 0x18
	private readonly RepeatedMessageField<AbilityAppliedModifier> appliedModifiers_; // 0x30
	public const int MixinRecoverInfosFieldNumber = 5; // Metadata: 0x00B0AA33
	private static readonly FieldCodec<AbilityMixinRecoverInfo> _repeated_mixinRecoverInfos_codec; // 0x20
	private readonly RepeatedMessageField<AbilityMixinRecoverInfo> mixinRecoverInfos_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilitySyncStateInfo> Parser { get => default; } // 0x0000000183271C50-0x0000000183271CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183271940-0x00000001832719D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183271560-0x00000001832715E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183270C10-0x0000000183270C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001832722B0-0x00000001832723A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183271F90-0x0000000183271FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183271A70-0x0000000183271B60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183272260-0x00000001832722B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183271680-0x0000000183271770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsInited { get => default; set {} } // 0x00000001832719D0-0x0000000183271A70 0x00000001832721C0-0x0000000183272260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<AbilityScalarValueEntry> DynamicValueMap { get => default; } // 0x0000000183270C70-0x0000000183270CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<AbilityAppliedAbility> AppliedAbilities { get => default; } // 0x00000001832718E0-0x0000000183271940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<AbilityAppliedModifier> AppliedModifiers { get => default; } // 0x00000001832710C0-0x0000000183271120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<AbilityMixinRecoverInfo> MixinRecoverInfos { get => default; } // 0x0000000183271F30-0x0000000183271F90 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilitySyncStateInfo() {} // 0x00000001832728E0-0x00000001832729E0
	static AbilitySyncStateInfo() {} // 0x00000001832726E0-0x00000001832728E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilitySyncStateInfo Clone() => default; // 0x0000000183271B60-0x0000000183271C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilitySyncStateInfo ShallowCopy() => default; // 0x00000001832715E0-0x0000000183271680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183270EA0-0x0000000183270EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183271D70-0x0000000183271E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183271E50-0x0000000183271F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183270EF0-0x00000001832710C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001832712E0-0x00000001832713B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilitySyncStateInfo other) => default; // 0x0000000183271120-0x00000001832712E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183271770-0x00000001832718E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001832723A0-0x00000001832726E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183271FF0-0x00000001832721C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001832713B0-0x0000000183271560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilitySyncStateInfo other) {} // 0x0000000183270CD0-0x0000000183270EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183270980-0x0000000183270C10
}

