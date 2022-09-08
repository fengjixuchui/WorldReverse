/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HideAndSeekSettleNotify : MessageBase, IMessage<HideAndSeekSettleNotify> // TypeDefIndex: 24191
{
	// Fields
	private static readonly MessageParser<HideAndSeekSettleNotify> _parser; // 0x00
	public const int PlayIndexFieldNumber = 1; // Metadata: 0x00B05CFB
	private uint playIndex_; // 0x18
	public const int StageTypeFieldNumber = 2; // Metadata: 0x00B05CFF
	private uint stageType_; // 0x1C
	public const int CostTimeFieldNumber = 3; // Metadata: 0x00B05D03
	private uint costTime_; // 0x20
	public const int WinnerListFieldNumber = 4; // Metadata: 0x00B05D07
	private static readonly FieldCodec<uint> _repeated_winnerList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> winnerList_; // 0x28
	public const int ReasonFieldNumber = 5; // Metadata: 0x00B05D0B
	private Types.SettleReason reason_; // 0x30
	public const int ScoreListFieldNumber = 6; // Metadata: 0x00B05D0F
	private static readonly FieldCodec<ExhibitionDisplayInfo> _repeated_scoreList_codec; // 0x10
	private readonly RepeatedMessageField<ExhibitionDisplayInfo> scoreList_; // 0x38
	public const int SettleInfoListFieldNumber = 7; // Metadata: 0x00B05D13
	private static readonly FieldCodec<HideAndSeekSettleInfo> _repeated_settleInfoList_codec; // 0x18
	private readonly RepeatedMessageField<HideAndSeekSettleInfo> settleInfoList_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HideAndSeekSettleNotify> Parser { get => default; } // 0x0000000181553C40-0x0000000181553CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181553890-0x0000000181553920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001815533C0-0x0000000181553440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181552640-0x00000001815526A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181554270-0x0000000181554360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181553F40-0x0000000181553FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001815539C0-0x0000000181553AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181554220-0x0000000181554270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001815534E0-0x00000001815535D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayIndex { get => default; set {} } // 0x0000000181553320-0x00000001815533C0 0x0000000181553920-0x00000001815539C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StageType { get => default; set {} } // 0x00000001815526A0-0x0000000181552740 0x00000001815537F0-0x0000000181553890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CostTime { get => default; set {} } // 0x0000000181553D60-0x0000000181553E00 0x0000000181552740-0x00000001815527E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> WinnerList { get => default; } // 0x0000000181552D00-0x0000000181552D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.SettleReason Reason { get => default; set {} } // 0x0000000181553BA0-0x0000000181553C40 0x0000000181552AB0-0x0000000181552B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ExhibitionDisplayInfo> ScoreList { get => default; } // 0x00000001815532C0-0x0000000181553320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<HideAndSeekSettleInfo> SettleInfoList { get => default; } // 0x0000000181552A00-0x0000000181552A60 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24192
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24193
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5348
		}

		public enum SettleReason // TypeDefIndex: 24194
		{
			TimeOut = 0,
			SettlePlayEnd = 1,
			SettlePlayerQuit = 2
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HideAndSeekSettleNotify() {} // 0x0000000181554950-0x0000000181554A30
	static HideAndSeekSettleNotify() {} // 0x00000001815547D0-0x0000000181554950

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HideAndSeekSettleNotify Clone() => default; // 0x0000000181553AB0-0x0000000181553BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HideAndSeekSettleNotify ShallowCopy() => default; // 0x0000000181553440-0x00000001815534E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181552A60-0x0000000181552AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181553E00-0x0000000181553EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181553EA0-0x0000000181553F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181552B50-0x0000000181552D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181552D60-0x0000000181552E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HideAndSeekSettleNotify other) => default; // 0x0000000181552E30-0x0000000181553010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001815535D0-0x00000001815537F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181554360-0x00000001815547D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181553FA0-0x0000000181554220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181553010-0x00000001815532C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HideAndSeekSettleNotify other) {} // 0x00000001815527E0-0x0000000181552A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001815523B0-0x0000000181552640
}

