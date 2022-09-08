/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EffigyDailyInfo : MessageBase, IMessage<EffigyDailyInfo> // TypeDefIndex: 22062
{
	// Fields
	private static readonly MessageParser<EffigyDailyInfo> _parser; // 0x00
	public const int DayIndexFieldNumber = 1; // Metadata: 0x00B00B17
	private uint dayIndex_; // 0x18
	public const int BeginTimeFieldNumber = 2; // Metadata: 0x00B00B1B
	private uint beginTime_; // 0x1C
	public const int ChallengeIdFieldNumber = 3; // Metadata: 0x00B00B1F
	private uint challengeId_; // 0x20
	public const int ChallengeCountFieldNumber = 4; // Metadata: 0x00B00B23
	private uint challengeCount_; // 0x24
	public const int ChallengeMaxScoreFieldNumber = 5; // Metadata: 0x00B00B27
	private uint challengeMaxScore_; // 0x28
	public const int IsFirstPassRewardTakenFieldNumber = 6; // Metadata: 0x00B00B2B
	private bool isFirstPassRewardTaken_; // 0x2C
	public const int ChallengeTotalScoreFieldNumber = 7; // Metadata: 0x00B00B2F
	private uint challengeTotalScore_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EffigyDailyInfo> Parser { get => default; } // 0x0000000183C17240-0x0000000183C172D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183C16CB0-0x0000000183C16D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183C16820-0x0000000183C168A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183C15D50-0x0000000183C15DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183C17990-0x0000000183C17A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183C175E0-0x0000000183C17640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183C16DE0-0x0000000183C16ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183C17940-0x0000000183C17990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183C16940-0x0000000183C16A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DayIndex { get => default; set {} } // 0x0000000183C17100-0x0000000183C171A0 0x0000000183C171A0-0x0000000183C17240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BeginTime { get => default; set {} } // 0x0000000183C178A0-0x0000000183C17940 0x0000000183C17540-0x0000000183C175E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeId { get => default; set {} } // 0x0000000183C16C10-0x0000000183C16CB0 0x0000000183C17060-0x0000000183C17100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeCount { get => default; set {} } // 0x0000000183C161F0-0x0000000183C16290 0x0000000183C16FC0-0x0000000183C17060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeMaxScore { get => default; set {} } // 0x0000000183C16D40-0x0000000183C16DE0 0x0000000183C17360-0x0000000183C17400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsFirstPassRewardTaken { get => default; set {} } // 0x0000000183C16040-0x0000000183C160E0 0x0000000183C15DB0-0x0000000183C15E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeTotalScore { get => default; set {} } // 0x0000000183C16290-0x0000000183C16330 0x0000000183C17450-0x0000000183C174F0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EffigyDailyInfo() {} // 0x0000000183C18000-0x0000000183C18060
	static EffigyDailyInfo() {} // 0x0000000183C17F40-0x0000000183C18000

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EffigyDailyInfo Clone() => default; // 0x0000000183C16ED0-0x0000000183C16FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EffigyDailyInfo ShallowCopy() => default; // 0x0000000183C168A0-0x0000000183C16940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183C160E0-0x0000000183C16130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C17400-0x0000000183C17450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C174F0-0x0000000183C17540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183C16130-0x0000000183C161F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183C16330-0x0000000183C16400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EffigyDailyInfo other) => default; // 0x0000000183C16400-0x0000000183C165B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183C16A30-0x0000000183C16C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183C17A80-0x0000000183C17F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183C17640-0x0000000183C178A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183C165B0-0x0000000183C16820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EffigyDailyInfo other) {} // 0x0000000183C15E50-0x0000000183C16040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183C15BC0-0x0000000183C15D50
}

