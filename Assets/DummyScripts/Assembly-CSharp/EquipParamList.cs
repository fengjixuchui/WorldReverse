/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EquipParamList : MessageBase, IMessage<EquipParamList> // TypeDefIndex: 25988
{
	// Fields
	private static readonly MessageParser<EquipParamList> _parser; // 0x00
	public const int ItemListFieldNumber = 1; // Metadata: 0x00B0A937
	private static readonly FieldCodec<EquipParam> _repeated_itemList_codec; // 0x08
	private readonly RepeatedMessageField<EquipParam> itemList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EquipParamList> Parser { get => default; } // 0x0000000183AA00A0-0x0000000183AA0130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183A9FDD0-0x0000000183A9FE60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183A9FB00-0x0000000183A9FB80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183A9F580-0x0000000183A9F5E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183AA0490-0x0000000183AA0580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183AA02E0-0x0000000183AA0340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183A9FEC0-0x0000000183A9FFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183AA0440-0x0000000183AA0490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183A9FC20-0x0000000183A9FD10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<EquipParam> ItemList { get => default; } // 0x0000000183A9FE60-0x0000000183A9FEC0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EquipParamList() {} // 0x0000000183AA07E0-0x0000000183AA0870
	static EquipParamList() {} // 0x0000000183AA06D0-0x0000000183AA07E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EquipParamList Clone() => default; // 0x0000000183A9FFB0-0x0000000183AA00A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EquipParamList ShallowCopy() => default; // 0x0000000183A9FB80-0x0000000183A9FC20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183A9F710-0x0000000183A9F760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183AA01C0-0x0000000183AA0250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183AA0250-0x0000000183AA02E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183A9F760-0x0000000183A9F830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183A9F830-0x0000000183A9F900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EquipParamList other) => default; // 0x0000000183A9F900-0x0000000183A9FA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183A9FD10-0x0000000183A9FDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183AA0580-0x0000000183AA06D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183AA0340-0x0000000183AA0440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183A9FA10-0x0000000183A9FB00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EquipParamList other) {} // 0x0000000183A9F5E0-0x0000000183A9F710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183A9F450-0x0000000183A9F580
}

