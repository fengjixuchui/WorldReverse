/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DropHintNotify : MessageBase, IMessage<DropHintNotify> // TypeDefIndex: 23693
{
	// Fields
	private static readonly MessageParser<DropHintNotify> _parser; // 0x00
	public const int ItemIdListFieldNumber = 1; // Metadata: 0x00B049D7
	private static readonly FieldCodec<uint> _repeated_itemIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> itemIdList_; // 0x18
	public const int PositionFieldNumber = 2; // Metadata: 0x00B049DB
	private Vector position_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DropHintNotify> Parser { get => default; } // 0x00000001832C2EF0-0x00000001832C2F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001832C2B80-0x00000001832C2C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001832C2760-0x00000001832C27E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001832C1FD0-0x00000001832C2030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001832C3300-0x00000001832C33F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001832C3110-0x00000001832C3170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001832C2C10-0x00000001832C2D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001832C32B0-0x00000001832C3300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001832C2920-0x00000001832C2A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ItemIdList { get => default; } // 0x00000001832C2E90-0x00000001832C2EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Position { get => default; set {} } // 0x00000001832C2880-0x00000001832C2920 0x00000001832C2DF0-0x00000001832C2E90

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23694
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23695
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 633
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DropHintNotify() {} // 0x00000001832C3690-0x00000001832C3720
	static DropHintNotify() {} // 0x00000001832C35B0-0x00000001832C3690

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DropHintNotify Clone() => default; // 0x00000001832C2D00-0x00000001832C2DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DropHintNotify ShallowCopy() => default; // 0x00000001832C27E0-0x00000001832C2880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001832C21B0-0x00000001832C2230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001832C3010-0x00000001832C3090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001832C3090-0x00000001832C3110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001832C2230-0x00000001832C23B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001832C23B0-0x00000001832C2480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DropHintNotify other) => default; // 0x00000001832C2480-0x00000001832C25B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001832C2A10-0x00000001832C2B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001832C33F0-0x00000001832C35B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001832C3170-0x00000001832C32B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001832C25B0-0x00000001832C2760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DropHintNotify other) {} // 0x00000001832C2030-0x00000001832C21B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001832C1E30-0x00000001832C1FD0
}

