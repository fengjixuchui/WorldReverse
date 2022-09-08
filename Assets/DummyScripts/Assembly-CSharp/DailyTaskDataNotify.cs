/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DailyTaskDataNotify : MessageBase, IMessage<DailyTaskDataNotify> // TypeDefIndex: 24439
{
	// Fields
	private static readonly MessageParser<DailyTaskDataNotify> _parser; // 0x00
	public const int ScoreRewardIdFieldNumber = 3; // Metadata: 0x00B0670F
	private uint scoreRewardId_; // 0x18
	public const int IsTakenScoreRewardFieldNumber = 4; // Metadata: 0x00B06713
	private bool isTakenScoreReward_; // 0x1C
	public const int FinishedNumFieldNumber = 5; // Metadata: 0x00B06717
	private uint finishedNum_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DailyTaskDataNotify> Parser { get => default; } // 0x00000001838172C0-0x0000000183817350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183816FB0-0x0000000183817040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183816C70-0x0000000183816CF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001838164B0-0x0000000183816510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001838177D0-0x00000001838178C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183817520-0x0000000183817580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183817040-0x0000000183817130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183817780-0x00000001838177D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183816D90-0x0000000183816E80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScoreRewardId { get => default; set {} } // 0x0000000183817480-0x0000000183817520 0x00000001838176E0-0x0000000183817780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsTakenScoreReward { get => default; set {} } // 0x0000000183816670-0x0000000183816710 0x0000000183816BD0-0x0000000183816C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FinishedNum { get => default; set {} } // 0x0000000183817220-0x00000001838172C0 0x0000000183816710-0x00000001838167B0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24440
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24441
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 146
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DailyTaskDataNotify() {} // 0x0000000183817C10-0x0000000183817C70
	static DailyTaskDataNotify() {} // 0x0000000183817B50-0x0000000183817C10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DailyTaskDataNotify Clone() => default; // 0x0000000183817130-0x0000000183817220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DailyTaskDataNotify ShallowCopy() => default; // 0x0000000183816CF0-0x0000000183816D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001838167B0-0x0000000183816800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001838173E0-0x0000000183817430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183817430-0x0000000183817480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183816800-0x0000000183816880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001838169C0-0x0000000183816A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DailyTaskDataNotify other) => default; // 0x0000000183816880-0x00000001838169C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183816E80-0x0000000183816FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001838178C0-0x0000000183817B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183817580-0x00000001838176E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183816A90-0x0000000183816BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DailyTaskDataNotify other) {} // 0x0000000183816510-0x0000000183816670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001838163A0-0x00000001838164B0
}

