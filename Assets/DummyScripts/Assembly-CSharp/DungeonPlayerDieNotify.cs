/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DungeonPlayerDieNotify : MessageBase, IMessage<DungeonPlayerDieNotify> // TypeDefIndex: 22836
{
	// Fields
	private static readonly MessageParser<DungeonPlayerDieNotify> _parser; // 0x00
	public const int DungeonIdFieldNumber = 1; // Metadata: 0x00B027EB
	private uint dungeonId_; // 0x18
	public const int DieTypeFieldNumber = 2; // Metadata: 0x00B027EF
	private PlayerDieType dieType_; // 0x1C
	public const int ReviveCountFieldNumber = 3; // Metadata: 0x00B027F3
	private uint reviveCount_; // 0x20
	public const int WaitTimeFieldNumber = 4; // Metadata: 0x00B027F7
	private uint waitTime_; // 0x24
	public const int MurdererEntityIdFieldNumber = 5; // Metadata: 0x00B027FB
	private uint murdererEntityId_; // 0x28
	public const int MonsterIdFieldNumber = 6; // Metadata: 0x00B027FF
	public const int GadgetIdFieldNumber = 7; // Metadata: 0x00B02803
	public const int StrengthenPointDataMapFieldNumber = 8; // Metadata: 0x00B02807
	private static readonly MapField<uint, StrengthenPointData> _map_strengthenPointDataMap_codec; // 0x08
	private readonly MapField<uint, StrengthenPointData> strengthenPointDataMap_; // 0x30
	private object entity_; // 0x38
	private EntityOneofCase entityCase_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DungeonPlayerDieNotify> Parser { get => default; } // 0x000000018359C000-0x000000018359C090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018359BB10-0x000000018359BBA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018359B440-0x000000018359B4C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018359A600-0x000000018359A660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018359C6F0-0x000000018359C7E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018359C260-0x000000018359C2C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018359BD50-0x000000018359BE40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018359C6A0-0x000000018359C6F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018359B600-0x000000018359B6F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonId { get => default; set {} } // 0x000000018359B560-0x000000018359B600 0x000000018359C560-0x000000018359C600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerDieType DieType { get => default; set {} } // 0x000000018359BA10-0x000000018359BAB0 0x000000018359ABC0-0x000000018359AC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ReviveCount { get => default; set {} } // 0x000000018359BCB0-0x000000018359BD50 0x000000018359C1C0-0x000000018359C260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WaitTime { get => default; set {} } // 0x000000018359BBA0-0x000000018359BC40 0x000000018359C600-0x000000018359C6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MurdererEntityId { get => default; set {} } // 0x000000018359AC60-0x000000018359AD00 0x000000018359B2D0-0x000000018359B370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MonsterId { get => default; set {} } // 0x000000018359BF30-0x000000018359C000 0x000000018359A6C0-0x000000018359A770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetId { get => default; set {} } // 0x000000018359B370-0x000000018359B440 0x000000018359B960-0x000000018359BA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, StrengthenPointData> StrengthenPointDataMap { get => default; } // 0x000000018359A660-0x000000018359A6C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityOneofCase EntityCase { get => default; } // 0x000000018359BAB0-0x000000018359BB10 

	// Nested types
	public enum EntityOneofCase // TypeDefIndex: 22837
	{
		None = 0,
		MonsterId = 6,
		GadgetId = 7
	}

	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22838
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22839
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 911
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonPlayerDieNotify() {} // 0x000000018359CF20-0x000000018359CFC0
	static DungeonPlayerDieNotify() {} // 0x000000018359CDC0-0x000000018359CF20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonPlayerDieNotify Clone() => default; // 0x000000018359BE40-0x000000018359BF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonPlayerDieNotify ShallowCopy() => default; // 0x000000018359B4C0-0x000000018359B560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018359AA20-0x000000018359AA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018359C120-0x000000018359C170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018359C170-0x000000018359C1C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018359AA70-0x000000018359ABC0
	public void resetEntity() {} // 0x000000018359BC40-0x000000018359BCB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearEntity() {} // 0x000000018359A770-0x000000018359A7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018359AD00-0x000000018359ADD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DungeonPlayerDieNotify other) => default; // 0x000000018359ADD0-0x000000018359AFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018359B6F0-0x000000018359B960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018359C7E0-0x000000018359CDC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018359C2C0-0x000000018359C560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018359AFE0-0x000000018359B2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DungeonPlayerDieNotify other) {} // 0x000000018359A7D0-0x000000018359AA20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018359A3F0-0x000000018359A600
}

