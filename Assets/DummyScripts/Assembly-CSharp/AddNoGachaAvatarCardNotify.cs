/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AddNoGachaAvatarCardNotify : MessageBase, IMessage<AddNoGachaAvatarCardNotify> // TypeDefIndex: 22528
{
	// Fields
	private static readonly MessageParser<AddNoGachaAvatarCardNotify> _parser; // 0x00
	public const int ItemIdFieldNumber = 1; // Metadata: 0x00B01C87
	private uint itemId_; // 0x18
	public const int IsTransferToItemFieldNumber = 2; // Metadata: 0x00B01C8B
	private bool isTransferToItem_; // 0x1C
	public const int AvatarIdFieldNumber = 3; // Metadata: 0x00B01C8F
	private uint avatarId_; // 0x20
	public const int InitialLevelFieldNumber = 4; // Metadata: 0x00B01C93
	private uint initialLevel_; // 0x24
	public const int InitialPromoteLevelFieldNumber = 5; // Metadata: 0x00B01C97
	private uint initialPromoteLevel_; // 0x28
	public const int TransferItemListFieldNumber = 6; // Metadata: 0x00B01C9B
	private static readonly FieldCodec<AddNoGachaAvatarCardTransferItem> _repeated_transferItemList_codec; // 0x08
	private readonly RepeatedMessageField<AddNoGachaAvatarCardTransferItem> transferItemList_; // 0x30
	public const int ReasonFieldNumber = 7; // Metadata: 0x00B01C9F
	private uint reason_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AddNoGachaAvatarCardNotify> Parser { get => default; } // 0x00000001837A28D0-0x00000001837A2960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001837A24C0-0x00000001837A2550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001837A2030-0x00000001837A20B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001837A1370-0x00000001837A13D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001837A3020-0x00000001837A3110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001837A2C50-0x00000001837A2CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001837A25B0-0x00000001837A26A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001837A2F30-0x00000001837A2F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001837A2150-0x00000001837A2240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ItemId { get => default; set {} } // 0x00000001837A29F0-0x00000001837A2A90 0x00000001837A2F80-0x00000001837A3020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsTransferToItem { get => default; set {} } // 0x00000001837A1B30-0x00000001837A1BD0 0x00000001837A2790-0x00000001837A2830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarId { get => default; set {} } // 0x00000001837A1E50-0x00000001837A1EF0 0x00000001837A1EF0-0x00000001837A1F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint InitialLevel { get => default; set {} } // 0x00000001837A2BB0-0x00000001837A2C50 0x00000001837A13D0-0x00000001837A1470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint InitialPromoteLevel { get => default; set {} } // 0x00000001837A1F90-0x00000001837A2030 0x00000001837A2420-0x00000001837A24C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<AddNoGachaAvatarCardTransferItem> TransferItemList { get => default; } // 0x00000001837A2550-0x00000001837A25B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Reason { get => default; set {} } // 0x00000001837A2830-0x00000001837A28D0 0x00000001837A16E0-0x00000001837A1780

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22529
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22530
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1750
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AddNoGachaAvatarCardNotify() {} // 0x00000001837A36C0-0x00000001837A3750
	static AddNoGachaAvatarCardNotify() {} // 0x00000001837A35B0-0x00000001837A36C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AddNoGachaAvatarCardNotify Clone() => default; // 0x00000001837A26A0-0x00000001837A2790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AddNoGachaAvatarCardNotify ShallowCopy() => default; // 0x00000001837A20B0-0x00000001837A2150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001837A1690-0x00000001837A16E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001837A2A90-0x00000001837A2B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001837A2B20-0x00000001837A2BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001837A1780-0x00000001837A18A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001837A18A0-0x00000001837A1970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AddNoGachaAvatarCardNotify other) => default; // 0x00000001837A1970-0x00000001837A1B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001837A2240-0x00000001837A2420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001837A3110-0x00000001837A35B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001837A2CB0-0x00000001837A2F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001837A1BD0-0x00000001837A1E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AddNoGachaAvatarCardNotify other) {} // 0x00000001837A1470-0x00000001837A1690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001837A1170-0x00000001837A1370
}

