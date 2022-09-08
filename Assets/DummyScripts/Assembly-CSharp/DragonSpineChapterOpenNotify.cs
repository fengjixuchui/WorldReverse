/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DragonSpineChapterOpenNotify : MessageBase, IMessage<DragonSpineChapterOpenNotify> // TypeDefIndex: 22047
{
	// Fields
	private static readonly MessageParser<DragonSpineChapterOpenNotify> _parser; // 0x00
	public const int ScheduleIdFieldNumber = 1; // Metadata: 0x00B00A8F
	private uint scheduleId_; // 0x18
	public const int ChapterIdFieldNumber = 2; // Metadata: 0x00B00A93
	private uint chapterId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DragonSpineChapterOpenNotify> Parser { get => default; } // 0x00000001820EB5E0-0x00000001820EB670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001820EB370-0x00000001820EB400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001820EB060-0x00000001820EB0E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001820EA9B0-0x00000001820EAA10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001820EBAB0-0x00000001820EBBA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001820EB840-0x00000001820EB8A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001820EB400-0x00000001820EB4F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001820EBA60-0x00000001820EBAB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001820EB180-0x00000001820EB270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x00000001820EAC00-0x00000001820EACA0 0x00000001820EB8A0-0x00000001820EB940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChapterId { get => default; set {} } // 0x00000001820EAFC0-0x00000001820EB060 0x00000001820EB700-0x00000001820EB7A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22048
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22049
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2081
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DragonSpineChapterOpenNotify() {} // 0x00000001820EBE60-0x00000001820EBEC0
	static DragonSpineChapterOpenNotify() {} // 0x00000001820EBDA0-0x00000001820EBE60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DragonSpineChapterOpenNotify Clone() => default; // 0x00000001820EB4F0-0x00000001820EB5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DragonSpineChapterOpenNotify ShallowCopy() => default; // 0x00000001820EB0E0-0x00000001820EB180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001820EAB40-0x00000001820EAB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820EB7A0-0x00000001820EB7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820EB7F0-0x00000001820EB840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001820EAB90-0x00000001820EAC00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001820EACA0-0x00000001820EAD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DragonSpineChapterOpenNotify other) => default; // 0x00000001820EAD70-0x00000001820EAE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001820EB270-0x00000001820EB370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001820EBBA0-0x00000001820EBDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001820EB940-0x00000001820EBA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001820EAE90-0x00000001820EAFC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DragonSpineChapterOpenNotify other) {} // 0x00000001820EAA10-0x00000001820EAB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001820EA8B0-0x00000001820EA9B0
}

