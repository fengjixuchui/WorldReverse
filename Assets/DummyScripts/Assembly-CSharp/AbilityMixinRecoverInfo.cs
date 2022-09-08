/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityMixinRecoverInfo : MessageBase, IMessage<AbilityMixinRecoverInfo> // TypeDefIndex: 26001
{
	// Fields
	private static readonly MessageParser<AbilityMixinRecoverInfo> _parser; // 0x00
	public const int InstancedAbilityIdFieldNumber = 1; // Metadata: 0x00B0A9FF
	public const int InstancedModifierIdFieldNumber = 2; // Metadata: 0x00B0AA03
	public const int LocalIdFieldNumber = 3; // Metadata: 0x00B0AA07
	private uint localId_; // 0x18
	public const int DataListFieldNumber = 4; // Metadata: 0x00B0AA0B
	private static readonly FieldCodec<uint> _repeated_dataList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> dataList_; // 0x20
	public const int IsServerbuffModifierFieldNumber = 5; // Metadata: 0x00B0AA0F
	private bool isServerbuffModifier_; // 0x28
	public const int MassivePropListFieldNumber = 6; // Metadata: 0x00B0AA13
	private static readonly FieldCodec<MassivePropSyncInfo> _repeated_massivePropList_codec; // 0x10
	private readonly RepeatedMessageField<MassivePropSyncInfo> massivePropList_; // 0x30
	private object source_; // 0x38
	private SourceOneofCase sourceCase_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityMixinRecoverInfo> Parser { get => default; } // 0x000000018395D1D0-0x000000018395D260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018395CD50-0x000000018395CDE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018395C9A0-0x000000018395CA20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018395BD40-0x000000018395BDA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018395D810-0x000000018395D900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018395D470-0x000000018395D4D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018395CF90-0x000000018395D080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018395D7C0-0x000000018395D810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018395CAC0-0x000000018395CBB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint InstancedAbilityId { get => default; set {} } // 0x000000018395BEE0-0x000000018395BFB0 0x000000018395D9A0-0x000000018395DA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint InstancedModifierId { get => default; set {} } // 0x000000018395BDA0-0x000000018395BE70 0x000000018395CE80-0x000000018395CF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LocalId { get => default; set {} } // 0x000000018395D720-0x000000018395D7C0 0x000000018395D900-0x000000018395D9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> DataList { get => default; } // 0x000000018395C470-0x000000018395C4D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsServerbuffModifier { get => default; set {} } // 0x000000018395CDE0-0x000000018395CE80 0x000000018395BFB0-0x000000018395C050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<MassivePropSyncInfo> MassivePropList { get => default; } // 0x000000018395D410-0x000000018395D470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SourceOneofCase SourceCase { get => default; } // 0x000000018395CF30-0x000000018395CF90 

	// Nested types
	public enum SourceOneofCase // TypeDefIndex: 26002
	{
		None = 0,
		InstancedAbilityId = 1,
		InstancedModifierId = 2
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinRecoverInfo() {} // 0x000000018395E000-0x000000018395E0C0
	static AbilityMixinRecoverInfo() {} // 0x000000018395DED0-0x000000018395E000

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinRecoverInfo Clone() => default; // 0x000000018395D080-0x000000018395D170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinRecoverInfo ShallowCopy() => default; // 0x000000018395CA20-0x000000018395CAC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018395C280-0x000000018395C2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018395D2F0-0x000000018395D380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018395D380-0x000000018395D410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018395C2D0-0x000000018395C470
	public void resetSource() {} // 0x000000018395BE70-0x000000018395BEE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearSource() {} // 0x000000018395D170-0x000000018395D1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018395C4D0-0x000000018395C5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityMixinRecoverInfo other) => default; // 0x000000018395C5A0-0x000000018395C770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018395CBB0-0x000000018395CD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018395DA50-0x000000018395DED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018395D4D0-0x000000018395D720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018395C770-0x000000018395C9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityMixinRecoverInfo other) {} // 0x000000018395C050-0x000000018395C280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018395BB00-0x000000018395BD40
}

