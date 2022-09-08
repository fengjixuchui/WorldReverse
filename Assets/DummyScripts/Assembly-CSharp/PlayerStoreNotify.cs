/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerStoreNotify : MessageBase, IMessage<PlayerStoreNotify> // TypeDefIndex: 23608
{
	// Fields
	private static readonly MessageParser<PlayerStoreNotify> _parser; // 0x00
	public const int StoreTypeFieldNumber = 1; // Metadata: 0x00B04653
	private StoreType storeType_; // 0x18
	public const int ItemListFieldNumber = 2; // Metadata: 0x00B04657
	private static readonly FieldCodec<Item> _repeated_itemList_codec; // 0x08
	private readonly RepeatedMessageField<Item> itemList_; // 0x20
	public const int WeightLimitFieldNumber = 3; // Metadata: 0x00B0465B
	private uint weightLimit_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerStoreNotify> Parser { get => default; } // 0x0000000183A53720-0x0000000183A537B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183A533B0-0x0000000183A53440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183A53030-0x0000000183A530B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183A52810-0x0000000183A52870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183A53C30-0x0000000183A53D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183A53960-0x0000000183A539C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183A534A0-0x0000000183A53590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183A53BE0-0x0000000183A53C30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183A53150-0x0000000183A53240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StoreType StoreType { get => default; set {} } // 0x0000000183A52A00-0x0000000183A52AA0 0x0000000183A52BE0-0x0000000183A52C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Item> ItemList { get => default; } // 0x0000000183A53440-0x0000000183A534A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WeightLimit { get => default; set {} } // 0x0000000183A539C0-0x0000000183A53A60 0x0000000183A53680-0x0000000183A53720

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23609
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23610
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 601
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerStoreNotify() {} // 0x0000000183A540A0-0x0000000183A54140
	static PlayerStoreNotify() {} // 0x0000000183A53F90-0x0000000183A540A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerStoreNotify Clone() => default; // 0x0000000183A53590-0x0000000183A53680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerStoreNotify ShallowCopy() => default; // 0x0000000183A530B0-0x0000000183A53150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183A52AA0-0x0000000183A52AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A53840-0x0000000183A538D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A538D0-0x0000000183A53960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183A52AF0-0x0000000183A52BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183A52DD0-0x0000000183A52EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerStoreNotify other) => default; // 0x0000000183A52C80-0x0000000183A52DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183A53240-0x0000000183A533B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183A53D20-0x0000000183A53F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183A53A60-0x0000000183A53BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183A52EA0-0x0000000183A53030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerStoreNotify other) {} // 0x0000000183A52870-0x0000000183A52A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183A526A0-0x0000000183A52810
}

