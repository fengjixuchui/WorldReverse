/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class StoreItemChangeNotify : MessageBase, IMessage<StoreItemChangeNotify> // TypeDefIndex: 23614
{
	// Fields
	private static readonly MessageParser<StoreItemChangeNotify> _parser; // 0x00
	public const int StoreTypeFieldNumber = 1; // Metadata: 0x00B04697
	private StoreType storeType_; // 0x18
	public const int ItemListFieldNumber = 2; // Metadata: 0x00B0469B
	private static readonly FieldCodec<Item> _repeated_itemList_codec; // 0x08
	private readonly RepeatedMessageField<Item> itemList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<StoreItemChangeNotify> Parser { get => default; } // 0x0000000183FE0F50-0x0000000183FE0FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183FE0C80-0x0000000183FE0D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183FE0930-0x0000000183FE09B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183FE01C0-0x0000000183FE0220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183FE1380-0x0000000183FE1470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183FE1190-0x0000000183FE11F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183FE0D70-0x0000000183FE0E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183FE1330-0x0000000183FE1380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183FE0A50-0x0000000183FE0B40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StoreType StoreType { get => default; set {} } // 0x0000000183FE0380-0x0000000183FE0420 0x0000000183FE0550-0x0000000183FE05F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Item> ItemList { get => default; } // 0x0000000183FE0D10-0x0000000183FE0D70 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23615
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23616
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 603
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StoreItemChangeNotify() {} // 0x0000000183FE1760-0x0000000183FE1800
	static StoreItemChangeNotify() {} // 0x0000000183FE1650-0x0000000183FE1760

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StoreItemChangeNotify Clone() => default; // 0x0000000183FE0E60-0x0000000183FE0F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StoreItemChangeNotify ShallowCopy() => default; // 0x0000000183FE09B0-0x0000000183FE0A50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183FE0420-0x0000000183FE0470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183FE1070-0x0000000183FE1100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183FE1100-0x0000000183FE1190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183FE0470-0x0000000183FE0550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183FE0720-0x0000000183FE07F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(StoreItemChangeNotify other) => default; // 0x0000000183FE05F0-0x0000000183FE0720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183FE0B40-0x0000000183FE0C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183FE1470-0x0000000183FE1650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183FE11F0-0x0000000183FE1330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183FE07F0-0x0000000183FE0930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(StoreItemChangeNotify other) {} // 0x0000000183FE0220-0x0000000183FE0380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183FE0070-0x0000000183FE01C0
}

