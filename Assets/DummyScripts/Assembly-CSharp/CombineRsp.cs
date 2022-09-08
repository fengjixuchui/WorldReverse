/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CombineRsp : MessageBase, IMessage<CombineRsp> // TypeDefIndex: 23699
{
	// Fields
	private static readonly MessageParser<CombineRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B04A0F
	private int retcode_; // 0x18
	public const int CombineIdFieldNumber = 2; // Metadata: 0x00B04A13
	private uint combineId_; // 0x1C
	public const int CombineCountFieldNumber = 3; // Metadata: 0x00B04A17
	private uint combineCount_; // 0x20
	public const int AvatarGuidFieldNumber = 4; // Metadata: 0x00B04A1B
	private ulong avatarGuid_; // 0x28
	public const int CostItemListFieldNumber = 5; // Metadata: 0x00B04A1F
	private static readonly FieldCodec<ItemParam> _repeated_costItemList_codec; // 0x08
	private readonly RepeatedMessageField<ItemParam> costItemList_; // 0x30
	public const int ResultItemListFieldNumber = 6; // Metadata: 0x00B04A23
	private static readonly FieldCodec<ItemParam> _repeated_resultItemList_codec; // 0x10
	private readonly RepeatedMessageField<ItemParam> resultItemList_; // 0x38
	public const int TotalRandomItemListFieldNumber = 7; // Metadata: 0x00B04A27
	private static readonly FieldCodec<ItemParam> _repeated_totalRandomItemList_codec; // 0x18
	private readonly RepeatedMessageField<ItemParam> totalRandomItemList_; // 0x40
	public const int TotalReturnItemListFieldNumber = 8; // Metadata: 0x00B04A2B
	private static readonly FieldCodec<ItemParam> _repeated_totalReturnItemList_codec; // 0x20
	private readonly RepeatedMessageField<ItemParam> totalReturnItemList_; // 0x48
	public const int TotalExtraItemListFieldNumber = 9; // Metadata: 0x00B04A2F
	private static readonly FieldCodec<ItemParam> _repeated_totalExtraItemList_codec; // 0x28
	private readonly RepeatedMessageField<ItemParam> totalExtraItemList_; // 0x50

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CombineRsp> Parser { get => default; } // 0x0000000183DF0D20-0x0000000183DF0DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183DF0950-0x0000000183DF09E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183DF0480-0x0000000183DF0500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183DEF5C0-0x0000000183DEF620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183DF1520-0x0000000183DF1610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183DF11A0-0x0000000183DF1200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183DF0AE0-0x0000000183DF0BD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183DF14D0-0x0000000183DF1520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183DF0640-0x0000000183DF0730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183DF02E0-0x0000000183DF0380 0x0000000183DEFC40-0x0000000183DEFCE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CombineId { get => default; set {} } // 0x0000000183DEFBA0-0x0000000183DEFC40 0x0000000183DF1100-0x0000000183DF11A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CombineCount { get => default; set {} } // 0x0000000183DF03E0-0x0000000183DF0480 0x0000000183DF05A0-0x0000000183DF0640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x0000000183DF0A40-0x0000000183DF0AE0 0x0000000183DEF870-0x0000000183DEF910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> CostItemList { get => default; } // 0x0000000183DF0380-0x0000000183DF03E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> ResultItemList { get => default; } // 0x0000000183DF0FA0-0x0000000183DF1000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> TotalRandomItemList { get => default; } // 0x0000000183DF09E0-0x0000000183DF0A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> TotalReturnItemList { get => default; } // 0x0000000183DF0CC0-0x0000000183DF0D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> TotalExtraItemList { get => default; } // 0x0000000183DF0DB0-0x0000000183DF0E10 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23700
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23701
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 635
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CombineRsp() {} // 0x0000000183DF1D30-0x0000000183DF1E50
	static CombineRsp() {} // 0x0000000183DF1B60-0x0000000183DF1D30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CombineRsp Clone() => default; // 0x0000000183DF0BD0-0x0000000183DF0CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CombineRsp ShallowCopy() => default; // 0x0000000183DF0500-0x0000000183DF05A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183DEF910-0x0000000183DEF960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183DF0EA0-0x0000000183DF0FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183DF1000-0x0000000183DF1100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183DEF960-0x0000000183DEFBA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183DEFCE0-0x0000000183DEFDB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CombineRsp other) => default; // 0x0000000183DEFDB0-0x0000000183DEFFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183DF0730-0x0000000183DF0950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183DF1610-0x0000000183DF1B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183DF1200-0x0000000183DF14D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183DEFFF0-0x0000000183DF02E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CombineRsp other) {} // 0x0000000183DEF620-0x0000000183DEF870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183DEF270-0x0000000183DEF5C0
}

