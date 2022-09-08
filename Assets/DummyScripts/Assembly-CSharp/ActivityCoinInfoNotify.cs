/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivityCoinInfoNotify : MessageBase, IMessage<ActivityCoinInfoNotify> // TypeDefIndex: 21889
{
	// Fields
	private static readonly MessageParser<ActivityCoinInfoNotify> _parser; // 0x00
	public const int ScheduleIdFieldNumber = 1; // Metadata: 0x00B0045F
	private uint scheduleId_; // 0x18
	public const int ActivityCoinMapFieldNumber = 2; // Metadata: 0x00B00463
	private static readonly MapField<uint, uint> _map_activityCoinMap_codec; // 0x08
	private readonly MapField<uint, uint> activityCoinMap_; // 0x20
	public const int ActivityIdFieldNumber = 3; // Metadata: 0x00B00467
	private uint activityId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ActivityCoinInfoNotify> Parser { get => default; } // 0x000000018478F1A0-0x000000018478F230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018478EF30-0x000000018478EFC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018478EBC0-0x000000018478EC40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018478E370-0x000000018478E3D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018478F6D0-0x000000018478F7C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018478F400-0x000000018478F460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018478EFC0-0x000000018478F0B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018478F680-0x000000018478F6D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018478ECE0-0x000000018478EDD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x000000018478E760-0x000000018478E800 0x000000018478F460-0x000000018478F500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> ActivityCoinMap { get => default; } // 0x000000018478E5D0-0x000000018478E630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ActivityId { get => default; set {} } // 0x000000018478F360-0x000000018478F400 0x000000018478E3D0-0x000000018478E470

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21890
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21891
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2013
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityCoinInfoNotify() {} // 0x000000018478FB60-0x000000018478FBF0
	static ActivityCoinInfoNotify() {} // 0x000000018478FA30-0x000000018478FB60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityCoinInfoNotify Clone() => default; // 0x000000018478F0B0-0x000000018478F1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityCoinInfoNotify ShallowCopy() => default; // 0x000000018478EC40-0x000000018478ECE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018478E630-0x000000018478E680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018478F2C0-0x000000018478F310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018478F310-0x000000018478F360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018478E680-0x000000018478E760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018478E960-0x000000018478EA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ActivityCoinInfoNotify other) => default; // 0x000000018478E800-0x000000018478E960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018478EDD0-0x000000018478EF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018478F7C0-0x000000018478FA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018478F500-0x000000018478F680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018478EA30-0x000000018478EBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ActivityCoinInfoNotify other) {} // 0x000000018478E470-0x000000018478E5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018478E1F0-0x000000018478E370
}

