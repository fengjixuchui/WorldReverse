/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AddNoGachaAvatarCardTransferItem : MessageBase, IMessage<AddNoGachaAvatarCardTransferItem> // TypeDefIndex: 22527
{
	// Fields
	private static readonly MessageParser<AddNoGachaAvatarCardTransferItem> _parser; // 0x00
	public const int ItemIdFieldNumber = 1; // Metadata: 0x00B01C7B
	private uint itemId_; // 0x18
	public const int CountFieldNumber = 2; // Metadata: 0x00B01C7F
	private uint count_; // 0x1C
	public const int IsNewFieldNumber = 3; // Metadata: 0x00B01C83
	private bool isNew_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AddNoGachaAvatarCardTransferItem> Parser { get => default; } // 0x000000018151B020-0x000000018151B0B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018151ADB0-0x000000018151AE40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018151AA70-0x000000018151AAF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018151A340-0x000000018151A3A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018151B5D0-0x000000018151B6C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018151B320-0x000000018151B380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018151AE40-0x000000018151AF30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018151B4E0-0x000000018151B530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018151AB90-0x000000018151AC80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ItemId { get => default; set {} } // 0x000000018151B140-0x000000018151B1E0 0x000000018151B530-0x000000018151B5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Count { get => default; set {} } // 0x000000018151B1E0-0x000000018151B280 0x000000018151A2A0-0x000000018151A340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsNew { get => default; set {} } // 0x000000018151A500-0x000000018151A5A0 0x000000018151A670-0x000000018151A710

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AddNoGachaAvatarCardTransferItem() {} // 0x000000018151BA10-0x000000018151BA70
	static AddNoGachaAvatarCardTransferItem() {} // 0x000000018151B950-0x000000018151BA10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AddNoGachaAvatarCardTransferItem Clone() => default; // 0x000000018151AF30-0x000000018151B020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AddNoGachaAvatarCardTransferItem ShallowCopy() => default; // 0x000000018151AAF0-0x000000018151AB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018151A5A0-0x000000018151A5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018151B280-0x000000018151B2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018151B2D0-0x000000018151B320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018151A5F0-0x000000018151A670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018151A850-0x000000018151A920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AddNoGachaAvatarCardTransferItem other) => default; // 0x000000018151A710-0x000000018151A850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018151AC80-0x000000018151ADB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018151B6C0-0x000000018151B950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018151B380-0x000000018151B4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018151A920-0x000000018151AA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AddNoGachaAvatarCardTransferItem other) {} // 0x000000018151A3A0-0x000000018151A500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018151A190-0x000000018151A2A0
}

