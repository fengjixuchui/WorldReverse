/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeAchievementGoalRewardRsp : MessageBase, IMessage<TakeAchievementGoalRewardRsp> // TypeDefIndex: 21846
{
	// Fields
	private static readonly MessageParser<TakeAchievementGoalRewardRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B001FF
	private int retcode_; // 0x18
	public const int IdListFieldNumber = 2; // Metadata: 0x00B00203
	private static readonly FieldCodec<uint> _repeated_idList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> idList_; // 0x20
	public const int ItemListFieldNumber = 3; // Metadata: 0x00B00207
	private static readonly FieldCodec<ItemParam> _repeated_itemList_codec; // 0x10
	private readonly RepeatedMessageField<ItemParam> itemList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeAchievementGoalRewardRsp> Parser { get => default; } // 0x0000000182157D40-0x0000000182157DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182157A70-0x0000000182157B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182157740-0x00000001821577C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182156E90-0x0000000182156EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001821581A0-0x0000000182158290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182157F80-0x0000000182157FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182157B60-0x0000000182157C50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182158150-0x00000001821581A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182157860-0x0000000182157950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001821576A0-0x0000000182157740 0x0000000182157200-0x00000001821572A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> IdList { get => default; } // 0x00000001821572A0-0x0000000182157300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> ItemList { get => default; } // 0x0000000182157B00-0x0000000182157B60 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21847
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21848
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2656
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeAchievementGoalRewardRsp() {} // 0x0000000182158620-0x00000001821586D0
	static TakeAchievementGoalRewardRsp() {} // 0x00000001821584F0-0x0000000182158620

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeAchievementGoalRewardRsp Clone() => default; // 0x0000000182157C50-0x0000000182157D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeAchievementGoalRewardRsp ShallowCopy() => default; // 0x00000001821577C0-0x0000000182157860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182157070-0x00000001821570C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182157E60-0x0000000182157EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182157EF0-0x0000000182157F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001821570C0-0x0000000182157200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182157300-0x00000001821573D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeAchievementGoalRewardRsp other) => default; // 0x00000001821573D0-0x0000000182157520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182157950-0x0000000182157A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182158290-0x00000001821584F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182157FE0-0x0000000182158150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182157520-0x00000001821576A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeAchievementGoalRewardRsp other) {} // 0x0000000182156EF0-0x0000000182157070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182156CB0-0x0000000182156E90
}

