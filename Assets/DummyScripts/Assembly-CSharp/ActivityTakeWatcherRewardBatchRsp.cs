/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivityTakeWatcherRewardBatchRsp : MessageBase, IMessage<ActivityTakeWatcherRewardBatchRsp> // TypeDefIndex: 22258
{
	// Fields
	private static readonly MessageParser<ActivityTakeWatcherRewardBatchRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B012A3
	private int retcode_; // 0x18
	public const int ActivityIdFieldNumber = 2; // Metadata: 0x00B012A7
	private uint activityId_; // 0x1C
	public const int WatcherIdListFieldNumber = 3; // Metadata: 0x00B012AB
	private static readonly FieldCodec<uint> _repeated_watcherIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> watcherIdList_; // 0x20
	public const int ItemListFieldNumber = 4; // Metadata: 0x00B012AF
	private static readonly FieldCodec<ItemParam> _repeated_itemList_codec; // 0x10
	private readonly RepeatedMessageField<ItemParam> itemList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ActivityTakeWatcherRewardBatchRsp> Parser { get => default; } // 0x0000000183CBB040-0x0000000183CBB0D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183CBAD70-0x0000000183CBAE00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183CBAA10-0x0000000183CBAA90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183CBA020-0x0000000183CBA080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183CBB580-0x0000000183CBB670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183CBB320-0x0000000183CBB380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183CBAE60-0x0000000183CBAF50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183CBB530-0x0000000183CBB580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183CBAB30-0x0000000183CBAC20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183CBA970-0x0000000183CBAA10 0x0000000183CBA4D0-0x0000000183CBA570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ActivityId { get => default; set {} } // 0x0000000183CBB280-0x0000000183CBB320 0x0000000183CBA080-0x0000000183CBA120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> WatcherIdList { get => default; } // 0x0000000183CBA320-0x0000000183CBA380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> ItemList { get => default; } // 0x0000000183CBAE00-0x0000000183CBAE60 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22259
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22260
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2200
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityTakeWatcherRewardBatchRsp() {} // 0x0000000183CBBA80-0x0000000183CBBB30
	static ActivityTakeWatcherRewardBatchRsp() {} // 0x0000000183CBB950-0x0000000183CBBA80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityTakeWatcherRewardBatchRsp Clone() => default; // 0x0000000183CBAF50-0x0000000183CBB040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityTakeWatcherRewardBatchRsp ShallowCopy() => default; // 0x0000000183CBAA90-0x0000000183CBAB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183CBA2D0-0x0000000183CBA320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183CBB160-0x0000000183CBB1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183CBB1F0-0x0000000183CBB280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183CBA380-0x0000000183CBA4D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183CBA570-0x0000000183CBA640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ActivityTakeWatcherRewardBatchRsp other) => default; // 0x0000000183CBA640-0x0000000183CBA7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183CBAC20-0x0000000183CBAD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183CBB670-0x0000000183CBB950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183CBB380-0x0000000183CBB530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183CBA7B0-0x0000000183CBA970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ActivityTakeWatcherRewardBatchRsp other) {} // 0x0000000183CBA120-0x0000000183CBA2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183CB9E20-0x0000000183CBA020
}

