/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GachaUpInfo : MessageBase, IMessage<GachaUpInfo> // TypeDefIndex: 23159
{
	// Fields
	private static readonly MessageParser<GachaUpInfo> _parser; // 0x00
	public const int ItemParentTypeFieldNumber = 1; // Metadata: 0x00B03527
	private uint itemParentType_; // 0x18
	public const int ItemIdListFieldNumber = 2; // Metadata: 0x00B0352B
	private static readonly FieldCodec<uint> _repeated_itemIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> itemIdList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GachaUpInfo> Parser { get => default; } // 0x00000001824E6580-0x00000001824E6610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001824E62B0-0x00000001824E6340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001824E5FA0-0x00000001824E6020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001824E5880-0x00000001824E58E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001824E6930-0x00000001824E6A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001824E6740-0x00000001824E67A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001824E6340-0x00000001824E6430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001824E68E0-0x00000001824E6930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001824E60C0-0x00000001824E61B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ItemParentType { get => default; set {} } // 0x00000001824E5F00-0x00000001824E5FA0 0x00000001824E5B20-0x00000001824E5BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ItemIdList { get => default; } // 0x00000001824E6520-0x00000001824E6580 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GachaUpInfo() {} // 0x00000001824E6CE0-0x00000001824E6D70
	static GachaUpInfo() {} // 0x00000001824E6C00-0x00000001824E6CE0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GachaUpInfo Clone() => default; // 0x00000001824E6430-0x00000001824E6520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GachaUpInfo ShallowCopy() => default; // 0x00000001824E6020-0x00000001824E60C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001824E5A10-0x00000001824E5A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001824E66A0-0x00000001824E66F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001824E66F0-0x00000001824E6740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001824E5A60-0x00000001824E5B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001824E5CF0-0x00000001824E5DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GachaUpInfo other) => default; // 0x00000001824E5BC0-0x00000001824E5CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001824E61B0-0x00000001824E62B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001824E6A20-0x00000001824E6C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001824E67A0-0x00000001824E68E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001824E5DC0-0x00000001824E5F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GachaUpInfo other) {} // 0x00000001824E58E0-0x00000001824E5A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001824E5710-0x00000001824E5880
}

