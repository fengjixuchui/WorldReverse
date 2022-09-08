/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GachaTransferItem : MessageBase, IMessage<GachaTransferItem> // TypeDefIndex: 23167
{
	// Fields
	private static readonly MessageParser<GachaTransferItem> _parser; // 0x00
	public const int ItemFieldNumber = 1; // Metadata: 0x00B035BB
	private ItemParam item_; // 0x18
	public const int IsTransferItemNewFieldNumber = 2; // Metadata: 0x00B035BF
	private bool isTransferItemNew_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GachaTransferItem> Parser { get => default; } // 0x0000000185601F60-0x0000000185601FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185601BB0-0x0000000185601C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185601820-0x00000001856018A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000185601120-0x0000000185601180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185602490-0x0000000185602580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001856022C0-0x0000000185602320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185601CE0-0x0000000185601DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185602440-0x0000000185602490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185601940-0x0000000185601A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ItemParam Item { get => default; set {} } // 0x0000000185602080-0x0000000185602120 0x0000000185601EC0-0x0000000185601F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsTransferItemNew { get => default; set {} } // 0x0000000185602120-0x00000001856021C0 0x0000000185601C40-0x0000000185601CE0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GachaTransferItem() {} // 0x0000000185602820-0x0000000185602880
	static GachaTransferItem() {} // 0x0000000185602760-0x0000000185602820

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GachaTransferItem Clone() => default; // 0x0000000185601DD0-0x0000000185601EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GachaTransferItem ShallowCopy() => default; // 0x00000001856018A0-0x0000000185601940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185601310-0x0000000185601390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001856021C0-0x0000000185602240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185602240-0x00000001856022C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185601390-0x00000001856014C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001856015F0-0x00000001856016C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GachaTransferItem other) => default; // 0x00000001856014C0-0x00000001856015F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000185601A30-0x0000000185601BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185602580-0x0000000185602760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185602320-0x0000000185602440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001856016C0-0x0000000185601820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GachaTransferItem other) {} // 0x0000000185601180-0x0000000185601310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185600FF0-0x0000000185601120
}

