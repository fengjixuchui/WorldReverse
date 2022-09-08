/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeCompoundOutputRsp : MessageBase, IMessage<TakeCompoundOutputRsp> // TypeDefIndex: 24407
{
	// Fields
	private static readonly MessageParser<TakeCompoundOutputRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B065E7
	private int retcode_; // 0x18
	public const int ItemListFieldNumber = 2; // Metadata: 0x00B065EB
	private static readonly FieldCodec<ItemParam> _repeated_itemList_codec; // 0x08
	private readonly RepeatedMessageField<ItemParam> itemList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeCompoundOutputRsp> Parser { get => default; } // 0x00000001830A0F50-0x00000001830A0FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001830A0C80-0x00000001830A0D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001830A0970-0x00000001830A09F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001830A0200-0x00000001830A0260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001830A1380-0x00000001830A1470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001830A1190-0x00000001830A11F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001830A0D70-0x00000001830A0E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001830A1330-0x00000001830A1380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001830A0A90-0x00000001830A0B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001830A08D0-0x00000001830A0970 0x00000001830A04F0-0x00000001830A0590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> ItemList { get => default; } // 0x00000001830A0D10-0x00000001830A0D70 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24408
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24409
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 136
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeCompoundOutputRsp() {} // 0x00000001830A1760-0x00000001830A17F0
	static TakeCompoundOutputRsp() {} // 0x00000001830A1650-0x00000001830A1760

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeCompoundOutputRsp Clone() => default; // 0x00000001830A0E60-0x00000001830A0F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeCompoundOutputRsp ShallowCopy() => default; // 0x00000001830A09F0-0x00000001830A0A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001830A03C0-0x00000001830A0410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001830A1070-0x00000001830A1100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001830A1100-0x00000001830A1190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001830A0410-0x00000001830A04F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001830A0590-0x00000001830A0660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeCompoundOutputRsp other) => default; // 0x00000001830A0660-0x00000001830A0790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001830A0B80-0x00000001830A0C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001830A1470-0x00000001830A1650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001830A11F0-0x00000001830A1330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001830A0790-0x00000001830A08D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeCompoundOutputRsp other) {} // 0x00000001830A0260-0x00000001830A03C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001830A00A0-0x00000001830A0200
}

