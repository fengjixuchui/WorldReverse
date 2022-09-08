/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class StoreWeightLimitNotify : MessageBase, IMessage<StoreWeightLimitNotify> // TypeDefIndex: 23611
{
	// Fields
	private static readonly MessageParser<StoreWeightLimitNotify> _parser; // 0x00
	public const int StoreTypeFieldNumber = 1; // Metadata: 0x00B0466F
	private StoreType storeType_; // 0x18
	public const int WeightLimitFieldNumber = 3; // Metadata: 0x00B04673
	private uint weightLimit_; // 0x1C
	public const int MaterialCountLimitFieldNumber = 4; // Metadata: 0x00B04677
	private uint materialCountLimit_; // 0x20
	public const int WeaponCountLimitFieldNumber = 5; // Metadata: 0x00B0467B
	private uint weaponCountLimit_; // 0x24
	public const int ReliquaryCountLimitFieldNumber = 6; // Metadata: 0x00B0467F
	private uint reliquaryCountLimit_; // 0x28
	public const int FurnitureCountLimitFieldNumber = 7; // Metadata: 0x00B04683
	private uint furnitureCountLimit_; // 0x2C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<StoreWeightLimitNotify> Parser { get => default; } // 0x00000001851C5820-0x00000001851C58B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001851C5470-0x00000001851C5500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001851C5060-0x00000001851C50E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001851C44B0-0x00000001851C4510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001851C5DF0-0x00000001851C5EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001851C5A80-0x00000001851C5AE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001851C5500-0x00000001851C55F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001851C5DA0-0x00000001851C5DF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001851C5180-0x00000001851C5270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StoreType StoreType { get => default; set {} } // 0x00000001851C4820-0x00000001851C48C0 0x00000001851C49C0-0x00000001851C4A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WeightLimit { get => default; set {} } // 0x00000001851C5AE0-0x00000001851C5B80 0x00000001851C5780-0x00000001851C5820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MaterialCountLimit { get => default; set {} } // 0x00000001851C4510-0x00000001851C45B0 0x00000001851C4370-0x00000001851C4410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WeaponCountLimit { get => default; set {} } // 0x00000001851C4A60-0x00000001851C4B00 0x00000001851C59E0-0x00000001851C5A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ReliquaryCountLimit { get => default; set {} } // 0x00000001851C56E0-0x00000001851C5780 0x00000001851C4FC0-0x00000001851C5060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FurnitureCountLimit { get => default; set {} } // 0x00000001851C4410-0x00000001851C44B0 0x00000001851C4780-0x00000001851C4820

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23612
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23613
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 602
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StoreWeightLimitNotify() {} // 0x00000001851C63D0-0x00000001851C64D0
	static StoreWeightLimitNotify() {} // 0x00000001851C6310-0x00000001851C63D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StoreWeightLimitNotify Clone() => default; // 0x00000001851C55F0-0x00000001851C56E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StoreWeightLimitNotify ShallowCopy() => default; // 0x00000001851C50E0-0x00000001851C5180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001851C48C0-0x00000001851C4910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001851C5940-0x00000001851C5990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001851C5990-0x00000001851C59E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001851C4910-0x00000001851C49C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001851C4C90-0x00000001851C4D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(StoreWeightLimitNotify other) => default; // 0x00000001851C4B00-0x00000001851C4C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001851C5270-0x00000001851C5470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001851C5EE0-0x00000001851C6310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001851C5B80-0x00000001851C5DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001851C4D60-0x00000001851C4FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(StoreWeightLimitNotify other) {} // 0x00000001851C45B0-0x00000001851C4780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001851C4210-0x00000001851C4370
}

