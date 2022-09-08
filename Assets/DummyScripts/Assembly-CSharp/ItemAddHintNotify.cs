/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ItemAddHintNotify : MessageBase, IMessage<ItemAddHintNotify> // TypeDefIndex: 23621
{
	// Fields
	private static readonly MessageParser<ItemAddHintNotify> _parser; // 0x00
	public const int ItemListFieldNumber = 1; // Metadata: 0x00B046D3
	private static readonly FieldCodec<ItemHint> _repeated_itemList_codec; // 0x08
	private readonly RepeatedMessageField<ItemHint> itemList_; // 0x18
	public const int PositionFieldNumber = 2; // Metadata: 0x00B046D7
	private Vector position_; // 0x20
	public const int IsPositionValidFieldNumber = 3; // Metadata: 0x00B046DB
	private bool isPositionValid_; // 0x28
	public const int ReasonFieldNumber = 4; // Metadata: 0x00B046DF
	private uint reason_; // 0x2C
	public const int QuestIdFieldNumber = 5; // Metadata: 0x00B046E3
	private uint questId_; // 0x30
	public const int IsTransferedFromAvatarCardFieldNumber = 6; // Metadata: 0x00B046E7
	private bool isTransferedFromAvatarCard_; // 0x34
	public const int OverflowTransformedItemListFieldNumber = 7; // Metadata: 0x00B046EB
	private static readonly FieldCodec<ItemHint> _repeated_overflowTransformedItemList_codec; // 0x10
	private readonly RepeatedMessageField<ItemHint> overflowTransformedItemList_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ItemAddHintNotify> Parser { get => default; } // 0x00000001843DA6C0-0x00000001843DA750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001843DA0D0-0x00000001843DA160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001843D9BC0-0x00000001843D9C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001843D8F70-0x00000001843D8FD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001843DADA0-0x00000001843DAE90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001843DA960-0x00000001843DA9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001843DA1C0-0x00000001843DA2B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001843DAD50-0x00000001843DADA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001843D9D80-0x00000001843D9E70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemHint> ItemList { get => default; } // 0x00000001843DA160-0x00000001843DA1C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Position { get => default; set {} } // 0x00000001843D9CE0-0x00000001843D9D80 0x00000001843DA3A0-0x00000001843DA440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsPositionValid { get => default; set {} } // 0x00000001843DA440-0x00000001843DA4E0 0x00000001843DA9C0-0x00000001843DAA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Reason { get => default; set {} } // 0x00000001843DA580-0x00000001843DA620 0x00000001843D92E0-0x00000001843D9380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint QuestId { get => default; set {} } // 0x00000001843D8ED0-0x00000001843D8F70 0x00000001843D9B20-0x00000001843D9BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsTransferedFromAvatarCard { get => default; set {} } // 0x00000001843DA620-0x00000001843DA6C0 0x00000001843DA4E0-0x00000001843DA580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemHint> OverflowTransformedItemList { get => default; } // 0x00000001843DAA60-0x00000001843DAAC0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23622
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23623
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 605
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ItemAddHintNotify() {} // 0x00000001843DB440-0x00000001843DB4F0
	static ItemAddHintNotify() {} // 0x00000001843DB300-0x00000001843DB440

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ItemAddHintNotify Clone() => default; // 0x00000001843DA2B0-0x00000001843DA3A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ItemAddHintNotify ShallowCopy() => default; // 0x00000001843D9C40-0x00000001843D9CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001843D9260-0x00000001843D92E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843DA7E0-0x00000001843DA8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843DA8A0-0x00000001843DA960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001843D9380-0x00000001843D95B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001843D97A0-0x00000001843D9870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ItemAddHintNotify other) => default; // 0x00000001843D95B0-0x00000001843D97A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001843D9E70-0x00000001843DA0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001843DAE90-0x00000001843DB300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001843DAAC0-0x00000001843DAD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001843D9870-0x00000001843D9B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ItemAddHintNotify other) {} // 0x00000001843D8FD0-0x00000001843D9260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001843D8C50-0x00000001843D8ED0
}

