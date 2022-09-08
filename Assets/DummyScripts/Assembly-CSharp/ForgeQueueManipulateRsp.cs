/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ForgeQueueManipulateRsp : MessageBase, IMessage<ForgeQueueManipulateRsp> // TypeDefIndex: 23721
{
	// Fields
	private static readonly MessageParser<ForgeQueueManipulateRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B04AFB
	private int retcode_; // 0x18
	public const int ManipulateTypeFieldNumber = 2; // Metadata: 0x00B04AFF
	private ForgeQueueManipulateType manipulateType_; // 0x1C
	public const int OutputItemListFieldNumber = 3; // Metadata: 0x00B04B03
	private static readonly FieldCodec<ItemParam> _repeated_outputItemList_codec; // 0x08
	private readonly RepeatedMessageField<ItemParam> outputItemList_; // 0x20
	public const int ReturnItemListFieldNumber = 4; // Metadata: 0x00B04B07
	private static readonly FieldCodec<ItemParam> _repeated_returnItemList_codec; // 0x10
	private readonly RepeatedMessageField<ItemParam> returnItemList_; // 0x28
	public const int ExtraOutputItemListFieldNumber = 5; // Metadata: 0x00B04B0B
	private static readonly FieldCodec<ItemParam> _repeated_extraOutputItemList_codec; // 0x18
	private readonly RepeatedMessageField<ItemParam> extraOutputItemList_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ForgeQueueManipulateRsp> Parser { get => default; } // 0x00000001838F41D0-0x00000001838F4260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001838F3F60-0x00000001838F3FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001838F3B40-0x00000001838F3BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001838F3020-0x00000001838F3080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001838F47A0-0x00000001838F4890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001838F4470-0x00000001838F44D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001838F3FF0-0x00000001838F40E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001838F4750-0x00000001838F47A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001838F3CC0-0x00000001838F3DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001838F3AA0-0x00000001838F3B40 0x00000001838F34F0-0x00000001838F3590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForgeQueueManipulateType ManipulateType { get => default; set {} } // 0x00000001838F44D0-0x00000001838F4570 0x00000001838F3A00-0x00000001838F3AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> OutputItemList { get => default; } // 0x00000001838F3490-0x00000001838F34F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> ReturnItemList { get => default; } // 0x00000001838F3C60-0x00000001838F3CC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> ExtraOutputItemList { get => default; } // 0x00000001838F3080-0x00000001838F30E0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23722
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23723
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 642
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForgeQueueManipulateRsp() {} // 0x00000001838F4D50-0x00000001838F4E30
	static ForgeQueueManipulateRsp() {} // 0x00000001838F4BE0-0x00000001838F4D50

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForgeQueueManipulateRsp Clone() => default; // 0x00000001838F40E0-0x00000001838F41D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForgeQueueManipulateRsp ShallowCopy() => default; // 0x00000001838F3BC0-0x00000001838F3C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001838F32B0-0x00000001838F3300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001838F42F0-0x00000001838F43B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001838F43B0-0x00000001838F4470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001838F3300-0x00000001838F3490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001838F3740-0x00000001838F3810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ForgeQueueManipulateRsp other) => default; // 0x00000001838F3590-0x00000001838F3740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001838F3DB0-0x00000001838F3F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001838F4890-0x00000001838F4BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001838F4570-0x00000001838F4750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001838F3810-0x00000001838F3A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ForgeQueueManipulateRsp other) {} // 0x00000001838F30E0-0x00000001838F32B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001838F2DE0-0x00000001838F3020
}

