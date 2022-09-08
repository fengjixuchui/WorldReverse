/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MapMarkPoint : MessageBase, IMessage<MapMarkPoint> // TypeDefIndex: 26081
{
	// Fields
	private static readonly MessageParser<MapMarkPoint> _parser; // 0x00
	public const int SceneIdFieldNumber = 1; // Metadata: 0x00B0B0CF
	private uint sceneId_; // 0x18
	public const int NameFieldNumber = 2; // Metadata: 0x00B0B0D3
	private string name_; // 0x20
	public const int PosFieldNumber = 3; // Metadata: 0x00B0B0D7
	private Vector pos_; // 0x28
	public const int PointTypeFieldNumber = 4; // Metadata: 0x00B0B0DB
	private MapMarkPointType pointType_; // 0x30
	public const int MonsterIdFieldNumber = 5; // Metadata: 0x00B0B0DF
	private uint monsterId_; // 0x34
	public const int FromTypeFieldNumber = 6; // Metadata: 0x00B0B0E3
	private MapMarkFromType fromType_; // 0x38
	public const int QuestIdFieldNumber = 7; // Metadata: 0x00B0B0E7
	private uint questId_; // 0x3C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MapMarkPoint> Parser { get => default; } // 0x000000018245AEB0-0x000000018245AF40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018245AA60-0x000000018245AAF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018245A530-0x000000018245A5B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182459620-0x0000000182459680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018245B5D0-0x000000018245B6C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018245B170-0x000000018245B1D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018245AAF0-0x000000018245ABE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018245B580-0x000000018245B5D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018245A650-0x000000018245A740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x0000000182459B70-0x0000000182459C10 0x000000018245A3F0-0x000000018245A490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Name { get => default; set {} } // 0x000000018245A350-0x000000018245A3F0 0x0000000182459C10-0x0000000182459CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x000000018245B0D0-0x000000018245B170 0x000000018245B4E0-0x000000018245B580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapMarkPointType PointType { get => default; set {} } // 0x000000018245AD70-0x000000018245AE10 0x000000018245AE10-0x000000018245AEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MonsterId { get => default; set {} } // 0x000000018245ACD0-0x000000018245AD70 0x0000000182459680-0x0000000182459720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapMarkFromType FromType { get => default; set {} } // 0x000000018245B1D0-0x000000018245B270 0x0000000182459CC0-0x0000000182459D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint QuestId { get => default; set {} } // 0x0000000182459580-0x0000000182459620 0x000000018245A490-0x000000018245A530

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapMarkPoint() {} // 0x000000018245BC10-0x000000018245BC90
	static MapMarkPoint() {} // 0x000000018245BB50-0x000000018245BC10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapMarkPoint Clone() => default; // 0x000000018245ABE0-0x000000018245ACD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapMarkPoint ShallowCopy() => default; // 0x000000018245A5B0-0x000000018245A650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182459980-0x0000000182459A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018245AFD0-0x000000018245B050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018245B050-0x000000018245B0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182459A00-0x0000000182459B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182459F50-0x000000018245A020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MapMarkPoint other) => default; // 0x0000000182459D60-0x0000000182459F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018245A740-0x000000018245AA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018245B6C0-0x000000018245BB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018245B270-0x000000018245B4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018245A020-0x000000018245A350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MapMarkPoint other) {} // 0x0000000182459720-0x0000000182459980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001824593C0-0x0000000182459580
}

