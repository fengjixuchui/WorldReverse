/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityMetaReInitOverrideMap : MessageBase, IMessage<AbilityMetaReInitOverrideMap> // TypeDefIndex: 21752
{
	// Fields
	private static readonly MessageParser<AbilityMetaReInitOverrideMap> _parser; // 0x00
	public const int OverrideMapFieldNumber = 1; // Metadata: 0x00AFFECB
	private static readonly FieldCodec<AbilityScalarValueEntry> _repeated_overrideMap_codec; // 0x08
	private readonly RepeatedMessageField<AbilityScalarValueEntry> overrideMap_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityMetaReInitOverrideMap> Parser { get => default; } // 0x00000001835EE8D0-0x00000001835EE960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001835EE600-0x00000001835EE690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001835EE330-0x00000001835EE3B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001835EDDB0-0x00000001835EDE10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001835EECC0-0x00000001835EEDB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001835EEB10-0x00000001835EEB70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001835EE6F0-0x00000001835EE7E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001835EEC70-0x00000001835EECC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001835EE450-0x00000001835EE540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<AbilityScalarValueEntry> OverrideMap { get => default; } // 0x00000001835EE690-0x00000001835EE6F0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMetaReInitOverrideMap() {} // 0x00000001835EF010-0x00000001835EF0A0
	static AbilityMetaReInitOverrideMap() {} // 0x00000001835EEF00-0x00000001835EF010

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMetaReInitOverrideMap Clone() => default; // 0x00000001835EE7E0-0x00000001835EE8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMetaReInitOverrideMap ShallowCopy() => default; // 0x00000001835EE3B0-0x00000001835EE450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001835EDF40-0x00000001835EDF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835EE9F0-0x00000001835EEA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835EEA80-0x00000001835EEB10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001835EDF90-0x00000001835EE060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001835EE170-0x00000001835EE240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityMetaReInitOverrideMap other) => default; // 0x00000001835EE060-0x00000001835EE170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001835EE540-0x00000001835EE600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001835EEDB0-0x00000001835EEF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001835EEB70-0x00000001835EEC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001835EE240-0x00000001835EE330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityMetaReInitOverrideMap other) {} // 0x00000001835EDE10-0x00000001835EDF40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001835EDC80-0x00000001835EDDB0
}

