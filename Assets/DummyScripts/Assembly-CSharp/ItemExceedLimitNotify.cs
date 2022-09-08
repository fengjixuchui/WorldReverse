/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ItemExceedLimitNotify : MessageBase, IMessage<ItemExceedLimitNotify> // TypeDefIndex: 23782
{
	// Fields
	private static readonly MessageParser<ItemExceedLimitNotify> _parser; // 0x00
	public const int IsMaterialExceedLimitFieldNumber = 1; // Metadata: 0x00B04D03
	private bool isMaterialExceedLimit_; // 0x18
	public const int IsWeaponExceedLimitFieldNumber = 2; // Metadata: 0x00B04D07
	private bool isWeaponExceedLimit_; // 0x19
	public const int IsReliquaryExceedLimitFieldNumber = 3; // Metadata: 0x00B04D0B
	private bool isReliquaryExceedLimit_; // 0x1A
	public const int ItemIdListFieldNumber = 4; // Metadata: 0x00B04D0F
	private static readonly FieldCodec<uint> _repeated_itemIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> itemIdList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ItemExceedLimitNotify> Parser { get => default; } // 0x00000001835921F0-0x0000000183592280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183591D40-0x0000000183591DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183591930-0x00000001835919B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183591180-0x00000001835911E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183592620-0x0000000183592710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001835923B0-0x0000000183592410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183591E70-0x0000000183591F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001835925D0-0x0000000183592620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183591A50-0x0000000183591B40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsMaterialExceedLimit { get => default; set {} } // 0x0000000183591530-0x00000001835915D0 0x0000000183591DD0-0x0000000183591E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsWeaponExceedLimit { get => default; set {} } // 0x0000000183592150-0x00000001835921F0 0x0000000183591CA0-0x0000000183591D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsReliquaryExceedLimit { get => default; set {} } // 0x0000000183592050-0x00000001835920F0 0x00000001835911E0-0x0000000183591280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ItemIdList { get => default; } // 0x00000001835920F0-0x0000000183592150 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23783
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23784
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 667
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ItemExceedLimitNotify() {} // 0x0000000183592AF0-0x0000000183592B80
	static ItemExceedLimitNotify() {} // 0x0000000183592A10-0x0000000183592AF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ItemExceedLimitNotify Clone() => default; // 0x0000000183591F60-0x0000000183592050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ItemExceedLimitNotify ShallowCopy() => default; // 0x00000001835919B0-0x0000000183591A50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183591400-0x0000000183591450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183592310-0x0000000183592360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183592360-0x00000001835923B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183591450-0x0000000183591530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183591730-0x0000000183591800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ItemExceedLimitNotify other) => default; // 0x00000001835915D0-0x0000000183591730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183591B40-0x0000000183591CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183592710-0x0000000183592A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183592410-0x00000001835925D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183591800-0x0000000183591930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ItemExceedLimitNotify other) {} // 0x0000000183591280-0x0000000183591400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183590FE0-0x0000000183591180
}

