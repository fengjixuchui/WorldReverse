/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeReunionMissionRewardReq : MessageBase, IMessage<TakeReunionMissionRewardReq> // TypeDefIndex: 24846
{
	// Fields
	private static readonly MessageParser<TakeReunionMissionRewardReq> _parser; // 0x00
	public const int MissionIdFieldNumber = 1; // Metadata: 0x00B075F3
	private uint missionId_; // 0x18
	public const int RewardIdFieldNumber = 2; // Metadata: 0x00B075F7
	private uint rewardId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeReunionMissionRewardReq> Parser { get => default; } // 0x0000000182C80550-0x0000000182C805E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182C801A0-0x0000000182C80230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182C7FE90-0x0000000182C7FF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182C7F880-0x0000000182C7F8E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182C80980-0x0000000182C80A70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182C807B0-0x0000000182C80810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182C802D0-0x0000000182C803C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182C80930-0x0000000182C80980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182C7FFB0-0x0000000182C800A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MissionId { get => default; set {} } // 0x0000000182C7F8E0-0x0000000182C7F980 0x0000000182C80230-0x0000000182C802D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RewardId { get => default; set {} } // 0x0000000182C80710-0x0000000182C807B0 0x0000000182C804B0-0x0000000182C80550

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24847
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24848
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 5064
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeReunionMissionRewardReq() {} // 0x0000000182C80D30-0x0000000182C80D90
	static TakeReunionMissionRewardReq() {} // 0x0000000182C80C70-0x0000000182C80D30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeReunionMissionRewardReq Clone() => default; // 0x0000000182C803C0-0x0000000182C804B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeReunionMissionRewardReq ShallowCopy() => default; // 0x0000000182C7FF10-0x0000000182C7FFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182C7FAB0-0x0000000182C7FB00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C80670-0x0000000182C806C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C806C0-0x0000000182C80710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182C7FB00-0x0000000182C7FB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182C7FB70-0x0000000182C7FC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeReunionMissionRewardReq other) => default; // 0x0000000182C7FC40-0x0000000182C7FD60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182C800A0-0x0000000182C801A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182C80A70-0x0000000182C80C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182C80810-0x0000000182C80930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182C7FD60-0x0000000182C7FE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeReunionMissionRewardReq other) {} // 0x0000000182C7F980-0x0000000182C7FAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182C7F780-0x0000000182C7F880
}

