/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class StatueGadgetInfo : MessageBase, IMessage<StatueGadgetInfo> // TypeDefIndex: 26029
{
	// Fields
	private static readonly MessageParser<StatueGadgetInfo> _parser; // 0x00
	public const int OpenedStatueUidListFieldNumber = 1; // Metadata: 0x00B0AC53
	private static readonly FieldCodec<uint> _repeated_openedStatueUidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> openedStatueUidList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<StatueGadgetInfo> Parser { get => default; } // 0x0000000183AC8800-0x0000000183AC8890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183AC8590-0x0000000183AC8620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183AC82C0-0x0000000183AC8340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183AC7D80-0x0000000183AC7DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183AC8B70-0x0000000183AC8C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183AC89C0-0x0000000183AC8A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183AC8620-0x0000000183AC8710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183AC8B20-0x0000000183AC8B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183AC83E0-0x0000000183AC84D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> OpenedStatueUidList { get => default; } // 0x0000000183AC7D20-0x0000000183AC7D80 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StatueGadgetInfo() {} // 0x0000000183AC8E90-0x0000000183AC8F20
	static StatueGadgetInfo() {} // 0x0000000183AC8DB0-0x0000000183AC8E90

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StatueGadgetInfo Clone() => default; // 0x0000000183AC8710-0x0000000183AC8800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StatueGadgetInfo ShallowCopy() => default; // 0x0000000183AC8340-0x0000000183AC83E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183AC7EF0-0x0000000183AC7F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183AC8920-0x0000000183AC8970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183AC8970-0x0000000183AC89C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183AC7F40-0x0000000183AC8000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183AC8100-0x0000000183AC81D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(StatueGadgetInfo other) => default; // 0x0000000183AC8000-0x0000000183AC8100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183AC84D0-0x0000000183AC8590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183AC8C60-0x0000000183AC8DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183AC8A20-0x0000000183AC8B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183AC81D0-0x0000000183AC82C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(StatueGadgetInfo other) {} // 0x0000000183AC7DE0-0x0000000183AC7EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183AC7BE0-0x0000000183AC7D20
}

