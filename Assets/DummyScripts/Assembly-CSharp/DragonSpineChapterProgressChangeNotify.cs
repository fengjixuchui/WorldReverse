/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DragonSpineChapterProgressChangeNotify : MessageBase, IMessage<DragonSpineChapterProgressChangeNotify> // TypeDefIndex: 22050
{
	// Fields
	private static readonly MessageParser<DragonSpineChapterProgressChangeNotify> _parser; // 0x00
	public const int ScheduleIdFieldNumber = 1; // Metadata: 0x00B00AA7
	private uint scheduleId_; // 0x18
	public const int ChapterIdFieldNumber = 2; // Metadata: 0x00B00AAB
	private uint chapterId_; // 0x1C
	public const int CurProgressFieldNumber = 3; // Metadata: 0x00B00AAF
	private uint curProgress_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DragonSpineChapterProgressChangeNotify> Parser { get => default; } // 0x0000000181FE9A00-0x0000000181FE9A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181FE9650-0x0000000181FE96E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181FE9310-0x0000000181FE9390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181FE8BB0-0x0000000181FE8C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181FE9F10-0x0000000181FEA000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181FE9C60-0x0000000181FE9CC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181FE96E0-0x0000000181FE97D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181FE9EC0-0x0000000181FE9F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181FE9430-0x0000000181FE9520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x0000000181FE8E40-0x0000000181FE8EE0 0x0000000181FE9CC0-0x0000000181FE9D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChapterId { get => default; set {} } // 0x0000000181FE9270-0x0000000181FE9310 0x0000000181FE9B20-0x0000000181FE9BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurProgress { get => default; set {} } // 0x0000000181FE98C0-0x0000000181FE9960 0x0000000181FE9960-0x0000000181FE9A00

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22051
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22052
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2082
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DragonSpineChapterProgressChangeNotify() {} // 0x0000000181FEA350-0x0000000181FEA3B0
	static DragonSpineChapterProgressChangeNotify() {} // 0x0000000181FEA290-0x0000000181FEA350

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DragonSpineChapterProgressChangeNotify Clone() => default; // 0x0000000181FE97D0-0x0000000181FE98C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DragonSpineChapterProgressChangeNotify ShallowCopy() => default; // 0x0000000181FE9390-0x0000000181FE9430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181FE8D70-0x0000000181FE8DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181FE9BC0-0x0000000181FE9C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181FE9C10-0x0000000181FE9C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181FE8DC0-0x0000000181FE8E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181FE8EE0-0x0000000181FE8FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DragonSpineChapterProgressChangeNotify other) => default; // 0x0000000181FE8FB0-0x0000000181FE90F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181FE9520-0x0000000181FE9650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181FEA000-0x0000000181FEA290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181FE9D60-0x0000000181FE9EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181FE90F0-0x0000000181FE9270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DragonSpineChapterProgressChangeNotify other) {} // 0x0000000181FE8C10-0x0000000181FE8D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181FE8AA0-0x0000000181FE8BB0
}

