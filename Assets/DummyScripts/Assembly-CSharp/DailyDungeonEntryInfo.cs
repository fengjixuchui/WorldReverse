/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DailyDungeonEntryInfo : MessageBase, IMessage<DailyDungeonEntryInfo> // TypeDefIndex: 22939
{
	// Fields
	private static readonly MessageParser<DailyDungeonEntryInfo> _parser; // 0x00
	public const int DungeonEntryIdFieldNumber = 1; // Metadata: 0x00B02B53
	private uint dungeonEntryId_; // 0x18
	public const int DungeonEntryConfigIdFieldNumber = 2; // Metadata: 0x00B02B57
	private uint dungeonEntryConfigId_; // 0x1C
	public const int RecommendDungeonIdFieldNumber = 3; // Metadata: 0x00B02B5B
	private uint recommendDungeonId_; // 0x20
	public const int RecommendDungeonEntryInfoFieldNumber = 4; // Metadata: 0x00B02B5F
	private DungeonEntryInfo recommendDungeonEntryInfo_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DailyDungeonEntryInfo> Parser { get => default; } // 0x000000018476D360-0x000000018476D3F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018476CF10-0x000000018476CFA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018476CB20-0x000000018476CBA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018476C0D0-0x000000018476C130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018476D910-0x000000018476DA00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018476D580-0x000000018476D5E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018476D040-0x000000018476D130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018476D8C0-0x000000018476D910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018476CC40-0x000000018476CD30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonEntryId { get => default; set {} } // 0x000000018476D680-0x000000018476D720 0x000000018476D2C0-0x000000018476D360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonEntryConfigId { get => default; set {} } // 0x000000018476CA80-0x000000018476CB20 0x000000018476CFA0-0x000000018476D040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RecommendDungeonId { get => default; set {} } // 0x000000018476D5E0-0x000000018476D680 0x000000018476D220-0x000000018476D2C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonEntryInfo RecommendDungeonEntryInfo { get => default; set {} } // 0x000000018476C300-0x000000018476C3A0 0x000000018476C570-0x000000018476C610

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DailyDungeonEntryInfo() {} // 0x000000018476DDC0-0x000000018476DE20
	static DailyDungeonEntryInfo() {} // 0x000000018476DD00-0x000000018476DDC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DailyDungeonEntryInfo Clone() => default; // 0x000000018476D130-0x000000018476D220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DailyDungeonEntryInfo ShallowCopy() => default; // 0x000000018476CBA0-0x000000018476CC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018476C3A0-0x000000018476C420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018476D480-0x000000018476D500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018476D500-0x000000018476D580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018476C420-0x000000018476C570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018476C780-0x000000018476C850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DailyDungeonEntryInfo other) => default; // 0x000000018476C610-0x000000018476C780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018476CD30-0x000000018476CF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018476DA00-0x000000018476DD00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018476D720-0x000000018476D8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018476C850-0x000000018476CA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DailyDungeonEntryInfo other) {} // 0x000000018476C130-0x000000018476C300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018476BF50-0x000000018476C0D0
}

