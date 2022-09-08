/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TowerBriefDataNotify : MessageBase, IMessage<TowerBriefDataNotify> // TypeDefIndex: 25697
{
	// Fields
	private static readonly MessageParser<TowerBriefDataNotify> _parser; // 0x00
	public const int TowerScheduleIdFieldNumber = 1; // Metadata: 0x00B095DF
	private uint towerScheduleId_; // 0x18
	public const int NextScheduleChangeTimeFieldNumber = 2; // Metadata: 0x00B095E3
	private uint nextScheduleChangeTime_; // 0x1C
	public const int TotalStarNumFieldNumber = 3; // Metadata: 0x00B095E7
	private uint totalStarNum_; // 0x20
	public const int LastFloorIndexFieldNumber = 4; // Metadata: 0x00B095EB
	private uint lastFloorIndex_; // 0x24
	public const int LastLevelIndexFieldNumber = 5; // Metadata: 0x00B095EF
	private uint lastLevelIndex_; // 0x28
	public const int IsFinishedEntranceFloorFieldNumber = 6; // Metadata: 0x00B095F3
	private bool isFinishedEntranceFloor_; // 0x2C
	public const int ScheduleStartTimeFieldNumber = 7; // Metadata: 0x00B095F7
	private uint scheduleStartTime_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TowerBriefDataNotify> Parser { get => default; } // 0x00000001819DEC70-0x00000001819DED00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001819DEA00-0x00000001819DEA90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001819DE4D0-0x00000001819DE550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001819DD780-0x00000001819DD7E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001819DF3C0-0x00000001819DF4B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001819DEED0-0x00000001819DEF30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001819DEA90-0x00000001819DEB80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001819DF370-0x00000001819DF3C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001819DE690-0x00000001819DE780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TowerScheduleId { get => default; set {} } // 0x00000001819DE2F0-0x00000001819DE390 0x00000001819DE960-0x00000001819DEA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NextScheduleChangeTime { get => default; set {} } // 0x00000001819DD920-0x00000001819DD9C0 0x00000001819DEDE0-0x00000001819DEE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TotalStarNum { get => default; set {} } // 0x00000001819DD7E0-0x00000001819DD880 0x00000001819DDCA0-0x00000001819DDD40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LastFloorIndex { get => default; set {} } // 0x00000001819DF230-0x00000001819DF2D0 0x00000001819DE390-0x00000001819DE430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LastLevelIndex { get => default; set {} } // 0x00000001819DF2D0-0x00000001819DF370 0x00000001819DE5F0-0x00000001819DE690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsFinishedEntranceFloor { get => default; set {} } // 0x00000001819DD880-0x00000001819DD920 0x00000001819DD9C0-0x00000001819DDA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleStartTime { get => default; set {} } // 0x00000001819DEF30-0x00000001819DEFD0 0x00000001819DE430-0x00000001819DE4D0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25698
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25699
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2401
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerBriefDataNotify() {} // 0x00000001819DFA30-0x00000001819DFA90
	static TowerBriefDataNotify() {} // 0x00000001819DF970-0x00000001819DFA30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerBriefDataNotify Clone() => default; // 0x00000001819DEB80-0x00000001819DEC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerBriefDataNotify ShallowCopy() => default; // 0x00000001819DE550-0x00000001819DE5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001819DDC50-0x00000001819DDCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001819DED90-0x00000001819DEDE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001819DEE80-0x00000001819DEED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001819DDD40-0x00000001819DDE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001819DDFB0-0x00000001819DE080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TowerBriefDataNotify other) => default; // 0x00000001819DDE00-0x00000001819DDFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001819DE780-0x00000001819DE960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001819DF4B0-0x00000001819DF970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001819DEFD0-0x00000001819DF230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001819DE080-0x00000001819DE2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TowerBriefDataNotify other) {} // 0x00000001819DDA60-0x00000001819DDC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001819DD5F0-0x00000001819DD780
}

