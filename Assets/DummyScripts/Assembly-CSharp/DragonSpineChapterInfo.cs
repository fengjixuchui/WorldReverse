/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DragonSpineChapterInfo : MessageBase, IMessage<DragonSpineChapterInfo> // TypeDefIndex: 22046
{
	// Fields
	private static readonly MessageParser<DragonSpineChapterInfo> _parser; // 0x00
	public const int ChapterIdFieldNumber = 1; // Metadata: 0x00B00A7B
	private uint chapterId_; // 0x18
	public const int IsOpenFieldNumber = 2; // Metadata: 0x00B00A7F
	private bool isOpen_; // 0x1C
	public const int ProgressFieldNumber = 3; // Metadata: 0x00B00A83
	private uint progress_; // 0x20
	public const int FinishedMissionNumFieldNumber = 4; // Metadata: 0x00B00A87
	private uint finishedMissionNum_; // 0x24
	public const int OpenTimeFieldNumber = 5; // Metadata: 0x00B00A8B
	private uint openTime_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DragonSpineChapterInfo> Parser { get => default; } // 0x00000001837DC310-0x00000001837DC3A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001837DC000-0x00000001837DC090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001837DBBC0-0x00000001837DBC40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001837DB2C0-0x00000001837DB320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001837DC9E0-0x00000001837DCAD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001837DC610-0x00000001837DC670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001837DC130-0x00000001837DC220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001837DC990-0x00000001837DC9E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001837DBD80-0x00000001837DBE70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChapterId { get => default; set {} } // 0x00000001837DBA80-0x00000001837DBB20 0x00000001837DC430-0x00000001837DC4D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsOpen { get => default; set {} } // 0x00000001837DC670-0x00000001837DC710 0x00000001837DB320-0x00000001837DB3C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Progress { get => default; set {} } // 0x00000001837DC090-0x00000001837DC130 0x00000001837DBCE0-0x00000001837DBD80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FinishedMissionNum { get => default; set {} } // 0x00000001837DB220-0x00000001837DB2C0 0x00000001837DC8F0-0x00000001837DC990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OpenTime { get => default; set {} } // 0x00000001837DBB20-0x00000001837DBBC0 0x00000001837DC570-0x00000001837DC610

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DragonSpineChapterInfo() {} // 0x00000001837DCF30-0x00000001837DCF90
	static DragonSpineChapterInfo() {} // 0x00000001837DCE70-0x00000001837DCF30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DragonSpineChapterInfo Clone() => default; // 0x00000001837DC220-0x00000001837DC310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DragonSpineChapterInfo ShallowCopy() => default; // 0x00000001837DBC40-0x00000001837DBCE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001837DB570-0x00000001837DB5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001837DC4D0-0x00000001837DC520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001837DC520-0x00000001837DC570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001837DB5C0-0x00000001837DB660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001837DB7D0-0x00000001837DB8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DragonSpineChapterInfo other) => default; // 0x00000001837DB660-0x00000001837DB7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001837DBE70-0x00000001837DC000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001837DCAD0-0x00000001837DCE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001837DC710-0x00000001837DC8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001837DB8A0-0x00000001837DBA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DragonSpineChapterInfo other) {} // 0x00000001837DB3C0-0x00000001837DB570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001837DB0D0-0x00000001837DB220
}

