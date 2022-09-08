/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityAppliedAbility : MessageBase, IMessage<AbilityAppliedAbility> // TypeDefIndex: 25995
{
	// Fields
	private static readonly MessageParser<AbilityAppliedAbility> _parser; // 0x00
	public const int AbilityNameFieldNumber = 1; // Metadata: 0x00B0A987
	private AbilityString abilityName_; // 0x18
	public const int AbilityOverrideFieldNumber = 2; // Metadata: 0x00B0A98B
	private AbilityString abilityOverride_; // 0x20
	public const int OverrideMapFieldNumber = 3; // Metadata: 0x00B0A98F
	private static readonly FieldCodec<AbilityScalarValueEntry> _repeated_overrideMap_codec; // 0x08
	private readonly RepeatedMessageField<AbilityScalarValueEntry> overrideMap_; // 0x28
	public const int InstancedAbilityIdFieldNumber = 4; // Metadata: 0x00B0A993
	private uint instancedAbilityId_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityAppliedAbility> Parser { get => default; } // 0x000000018286F9D0-0x000000018286FA60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018286F660-0x000000018286F6F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018286F210-0x000000018286F290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018286E590-0x000000018286E5F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018286FF50-0x0000000182870040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018286FC50-0x000000018286FCB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018286F750-0x000000018286F840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018286FF00-0x000000018286FF50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018286F330-0x000000018286F420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityString AbilityName { get => default; set {} } // 0x000000018286F840-0x000000018286F8E0 0x000000018286FE60-0x000000018286FF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityString AbilityOverride { get => default; set {} } // 0x000000018286F170-0x000000018286F210 0x000000018286E8E0-0x000000018286E980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<AbilityScalarValueEntry> OverrideMap { get => default; } // 0x000000018286F6F0-0x000000018286F750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint InstancedAbilityId { get => default; set {} } // 0x000000018286E5F0-0x000000018286E690 0x0000000182870040-0x00000001828700E0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityAppliedAbility() {} // 0x00000001828704C0-0x0000000182870550
	static AbilityAppliedAbility() {} // 0x00000001828703B0-0x00000001828704C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityAppliedAbility Clone() => default; // 0x000000018286F8E0-0x000000018286F9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityAppliedAbility ShallowCopy() => default; // 0x000000018286F290-0x000000018286F330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018286E980-0x000000018286EA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018286FAF0-0x000000018286FBA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018286FBA0-0x000000018286FC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018286EA10-0x000000018286EC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018286EE00-0x000000018286EED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityAppliedAbility other) => default; // 0x000000018286EC70-0x000000018286EE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018286F420-0x000000018286F660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001828700E0-0x00000001828703B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018286FCB0-0x000000018286FE60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018286EED0-0x000000018286F170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityAppliedAbility other) {} // 0x000000018286E690-0x000000018286E8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018286E390-0x000000018286E590
}

