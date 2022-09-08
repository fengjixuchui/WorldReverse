/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GachaItem : MessageBase, IMessage<GachaItem> // TypeDefIndex: 23168
{
	// Fields
	private static readonly MessageParser<GachaItem> _parser; // 0x00
	public const int GachaItem_FieldNumber = 1; // Metadata: 0x00B035C3
	private ItemParam gachaItem_; // 0x18
	public const int TransferItemsFieldNumber = 2; // Metadata: 0x00B035C7
	private static readonly FieldCodec<GachaTransferItem> _repeated_transferItems_codec; // 0x08
	private readonly RepeatedMessageField<GachaTransferItem> transferItems_; // 0x20
	public const int IsFlashCardFieldNumber = 3; // Metadata: 0x00B035CB
	private bool isFlashCard_; // 0x28
	public const int IsGachaItemNewFieldNumber = 4; // Metadata: 0x00B035CF
	private bool isGachaItemNew_; // 0x29
	public const int TokenItemListFieldNumber = 5; // Metadata: 0x00B035D3
	private static readonly FieldCodec<ItemParam> _repeated_tokenItemList_codec; // 0x10
	private readonly RepeatedMessageField<ItemParam> tokenItemList_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GachaItem> Parser { get => default; } // 0x000000018568BCB0-0x000000018568BD40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018568B940-0x000000018568B9D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018568B530-0x000000018568B5B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018568A8F0-0x000000018568A950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018568C2B0-0x000000018568C3A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018568BF50-0x000000018568BFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018568BAD0-0x000000018568BBC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018568C260-0x000000018568C2B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018568B650-0x000000018568B740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ItemParam GachaItem_ { get => default; set {} } // 0x000000018568AEB0-0x000000018568AF50 0x000000018568B9D0-0x000000018568BA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<GachaTransferItem> TransferItems { get => default; } // 0x000000018568BA70-0x000000018568BAD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsFlashCard { get => default; set {} } // 0x000000018568B3F0-0x000000018568B490 0x000000018568B490-0x000000018568B530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsGachaItemNew { get => default; set {} } // 0x000000018568A950-0x000000018568A9F0 0x000000018568C1C0-0x000000018568C260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> TokenItemList { get => default; } // 0x000000018568C3A0-0x000000018568C400 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GachaItem() {} // 0x000000018568C8C0-0x000000018568C970
	static GachaItem() {} // 0x000000018568C760-0x000000018568C8C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GachaItem Clone() => default; // 0x000000018568BBC0-0x000000018568BCB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GachaItem ShallowCopy() => default; // 0x000000018568B5B0-0x000000018568B650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018568AC30-0x000000018568ACB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018568BDD0-0x000000018568BE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018568BE90-0x000000018568BF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018568ACB0-0x000000018568AEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018568AF50-0x000000018568B020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GachaItem other) => default; // 0x000000018568B020-0x000000018568B1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018568B740-0x000000018568B940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018568C400-0x000000018568C760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018568BFB0-0x000000018568C1C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018568B1D0-0x000000018568B3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GachaItem other) {} // 0x000000018568A9F0-0x000000018568AC30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018568A6B0-0x000000018568A8F0
}

