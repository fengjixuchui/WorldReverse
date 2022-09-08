/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DragonSpineChapterFinishNotify : MessageBase, IMessage<DragonSpineChapterFinishNotify> // TypeDefIndex: 22053
{
	// Fields
	private static readonly MessageParser<DragonSpineChapterFinishNotify> _parser; // 0x00
	public const int ScheduleIdFieldNumber = 1; // Metadata: 0x00B00AC3
	private uint scheduleId_; // 0x18
	public const int ChapterIdFieldNumber = 2; // Metadata: 0x00B00AC7
	private uint chapterId_; // 0x1C
	public const int WeaponEnhanceLevelFieldNumber = 3; // Metadata: 0x00B00ACB
	private uint weaponEnhanceLevel_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DragonSpineChapterFinishNotify> Parser { get => default; } // 0x0000000183CED040-0x0000000183CED0D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183CECDD0-0x0000000183CECE60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183CECA90-0x0000000183CECB10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183CEC1F0-0x0000000183CEC250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183CED550-0x0000000183CED640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183CED2A0-0x0000000183CED300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183CECE60-0x0000000183CECF50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183CED500-0x0000000183CED550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183CECBB0-0x0000000183CECCA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x0000000183CEC5C0-0x0000000183CEC660 0x0000000183CED300-0x0000000183CED3A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChapterId { get => default; set {} } // 0x0000000183CEC9F0-0x0000000183CECA90 0x0000000183CED160-0x0000000183CED200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WeaponEnhanceLevel { get => default; set {} } // 0x0000000183CEC2F0-0x0000000183CEC390 0x0000000183CEC250-0x0000000183CEC2F0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22054
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22055
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2083
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DragonSpineChapterFinishNotify() {} // 0x0000000183CED990-0x0000000183CED9F0
	static DragonSpineChapterFinishNotify() {} // 0x0000000183CED8D0-0x0000000183CED990

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DragonSpineChapterFinishNotify Clone() => default; // 0x0000000183CECF50-0x0000000183CED040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DragonSpineChapterFinishNotify ShallowCopy() => default; // 0x0000000183CECB10-0x0000000183CECBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183CEC4F0-0x0000000183CEC540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183CED200-0x0000000183CED250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183CED250-0x0000000183CED2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183CEC540-0x0000000183CEC5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183CEC660-0x0000000183CEC730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DragonSpineChapterFinishNotify other) => default; // 0x0000000183CEC730-0x0000000183CEC870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183CECCA0-0x0000000183CECDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183CED640-0x0000000183CED8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183CED3A0-0x0000000183CED500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183CEC870-0x0000000183CEC9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DragonSpineChapterFinishNotify other) {} // 0x0000000183CEC390-0x0000000183CEC4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183CEC0E0-0x0000000183CEC1F0
}

