/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityMixinWindZone : MessageBase, IMessage<AbilityMixinWindZone> // TypeDefIndex: 21777
{
	// Fields
	private static readonly MessageParser<AbilityMixinWindZone> _parser; // 0x00
	public const int EntityIdsFieldNumber = 1; // Metadata: 0x00AFFF9F
	private static readonly FieldCodec<uint> _repeated_entityIds_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> entityIds_; // 0x18
	public const int ZoneIdListFieldNumber = 2; // Metadata: 0x00AFFFA3
	private static readonly FieldCodec<uint> _repeated_zoneIdList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> zoneIdList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityMixinWindZone> Parser { get => default; } // 0x0000000183AB7840-0x0000000183AB78D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183AB75D0-0x0000000183AB7660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183AB72D0-0x0000000183AB7350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183AB6C00-0x0000000183AB6C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183AB7BE0-0x0000000183AB7CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183AB7A00-0x0000000183AB7A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183AB7660-0x0000000183AB7750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183AB7B90-0x0000000183AB7BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183AB73F0-0x0000000183AB74E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> EntityIds { get => default; } // 0x0000000183AB6F60-0x0000000183AB6FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ZoneIdList { get => default; } // 0x0000000183AB6C60-0x0000000183AB6CC0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinWindZone() {} // 0x0000000183AB7F90-0x0000000183AB8040
	static AbilityMixinWindZone() {} // 0x0000000183AB7E90-0x0000000183AB7F90

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinWindZone Clone() => default; // 0x0000000183AB7750-0x0000000183AB7840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinWindZone ShallowCopy() => default; // 0x0000000183AB7350-0x0000000183AB73F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183AB6DF0-0x0000000183AB6E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183AB7960-0x0000000183AB79B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183AB79B0-0x0000000183AB7A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183AB6E40-0x0000000183AB6F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183AB6FC0-0x0000000183AB7090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityMixinWindZone other) => default; // 0x0000000183AB7090-0x0000000183AB71B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183AB74E0-0x0000000183AB75D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183AB7CD0-0x0000000183AB7E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183AB7A60-0x0000000183AB7B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183AB71B0-0x0000000183AB72D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityMixinWindZone other) {} // 0x0000000183AB6CC0-0x0000000183AB6DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183AB6A40-0x0000000183AB6C00
}

