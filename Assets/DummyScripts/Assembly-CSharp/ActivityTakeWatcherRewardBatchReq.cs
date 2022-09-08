/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivityTakeWatcherRewardBatchReq : MessageBase, IMessage<ActivityTakeWatcherRewardBatchReq> // TypeDefIndex: 22255
{
	// Fields
	private static readonly MessageParser<ActivityTakeWatcherRewardBatchReq> _parser; // 0x00
	public const int ActivityIdFieldNumber = 1; // Metadata: 0x00B01287
	private uint activityId_; // 0x18
	public const int WatcherIdListFieldNumber = 2; // Metadata: 0x00B0128B
	private static readonly FieldCodec<uint> _repeated_watcherIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> watcherIdList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ActivityTakeWatcherRewardBatchReq> Parser { get => default; } // 0x0000000183BCA480-0x0000000183BCA510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183BCA210-0x0000000183BCA2A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183BC9F00-0x0000000183BC9F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183BC9820-0x0000000183BC9880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183BCA8D0-0x0000000183BCA9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183BCA6E0-0x0000000183BCA740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183BCA2A0-0x0000000183BCA390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183BCA880-0x0000000183BCA8D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183BCA020-0x0000000183BCA110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ActivityId { get => default; set {} } // 0x0000000183BCA640-0x0000000183BCA6E0 0x0000000183BC9880-0x0000000183BC9920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> WatcherIdList { get => default; } // 0x0000000183BC9AA0-0x0000000183BC9B00 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22256
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22257
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2199
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityTakeWatcherRewardBatchReq() {} // 0x0000000183BCAC80-0x0000000183BCAD10
	static ActivityTakeWatcherRewardBatchReq() {} // 0x0000000183BCABA0-0x0000000183BCAC80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityTakeWatcherRewardBatchReq Clone() => default; // 0x0000000183BCA390-0x0000000183BCA480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityTakeWatcherRewardBatchReq ShallowCopy() => default; // 0x0000000183BC9F80-0x0000000183BCA020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183BC9A50-0x0000000183BC9AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183BCA5A0-0x0000000183BCA5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183BCA5F0-0x0000000183BCA640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183BC9B00-0x0000000183BC9BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183BC9BC0-0x0000000183BC9C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ActivityTakeWatcherRewardBatchReq other) => default; // 0x0000000183BC9C90-0x0000000183BC9DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183BCA110-0x0000000183BCA210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183BCA9C0-0x0000000183BCABA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183BCA740-0x0000000183BCA880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183BC9DC0-0x0000000183BC9F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ActivityTakeWatcherRewardBatchReq other) {} // 0x0000000183BC9920-0x0000000183BC9A50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183BC96B0-0x0000000183BC9820
}

