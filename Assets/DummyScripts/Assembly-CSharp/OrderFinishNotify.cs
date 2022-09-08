/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class OrderFinishNotify : MessageBase, IMessage<OrderFinishNotify> // TypeDefIndex: 24699
{
	// Fields
	private static readonly MessageParser<OrderFinishNotify> _parser; // 0x00
	public const int ProductIdFieldNumber = 1; // Metadata: 0x00B07067
	private string productId_; // 0x18
	public const int AddMcoinFieldNumber = 2; // Metadata: 0x00B0706B
	private uint addMcoin_; // 0x20
	public const int CardProductRemainDaysFieldNumber = 3; // Metadata: 0x00B0706F
	private uint cardProductRemainDays_; // 0x24
	public const int OrderIdFieldNumber = 4; // Metadata: 0x00B07073
	private uint orderId_; // 0x28
	public const int ItemListFieldNumber = 5; // Metadata: 0x00B07077
	private static readonly FieldCodec<ItemParam> _repeated_itemList_codec; // 0x08
	private readonly RepeatedMessageField<ItemParam> itemList_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<OrderFinishNotify> Parser { get => default; } // 0x0000000182A8F620-0x0000000182A8F6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182A8F0C0-0x0000000182A8F150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182A8EC60-0x0000000182A8ECE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182A8E350-0x0000000182A8E3B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182A8FC60-0x0000000182A8FD50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182A8F9A0-0x0000000182A8FA00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182A8F250-0x0000000182A8F340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182A8FC10-0x0000000182A8FC60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182A8EE20-0x0000000182A8EF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ProductId { get => default; set {} } // 0x0000000182A8F430-0x0000000182A8F4D0 0x0000000182A8F4D0-0x0000000182A8F580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AddMcoin { get => default; set {} } // 0x0000000182A8F580-0x0000000182A8F620 0x0000000182A8F150-0x0000000182A8F1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CardProductRemainDays { get => default; set {} } // 0x0000000182A8E3B0-0x0000000182A8E450 0x0000000182A8ECE0-0x0000000182A8ED80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OrderId { get => default; set {} } // 0x0000000182A8F7D0-0x0000000182A8F870 0x0000000182A8F900-0x0000000182A8F9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> ItemList { get => default; } // 0x0000000182A8F1F0-0x0000000182A8F250 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24700
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24701
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4103
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OrderFinishNotify() {} // 0x0000000182A901D0-0x0000000182A90270
	static OrderFinishNotify() {} // 0x0000000182A900C0-0x0000000182A901D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OrderFinishNotify Clone() => default; // 0x0000000182A8F340-0x0000000182A8F430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OrderFinishNotify ShallowCopy() => default; // 0x0000000182A8ED80-0x0000000182A8EE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182A8E640-0x0000000182A8E690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182A8F740-0x0000000182A8F7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182A8F870-0x0000000182A8F900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182A8E690-0x0000000182A8E7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182A8E950-0x0000000182A8EA20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(OrderFinishNotify other) => default; // 0x0000000182A8E7A0-0x0000000182A8E950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182A8EF10-0x0000000182A8F0C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182A8FD50-0x0000000182A900C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182A8FA00-0x0000000182A8FC10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182A8EA20-0x0000000182A8EC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(OrderFinishNotify other) {} // 0x0000000182A8E450-0x0000000182A8E640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182A8E190-0x0000000182A8E350
}

