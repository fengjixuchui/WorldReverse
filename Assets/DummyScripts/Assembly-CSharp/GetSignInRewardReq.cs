/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetSignInRewardReq : MessageBase, IMessage<GetSignInRewardReq> // TypeDefIndex: 25455
{
	// Fields
	private static readonly MessageParser<GetSignInRewardReq> _parser; // 0x00
	public const int ScheduleIdFieldNumber = 1; // Metadata: 0x00B08CD7
	private uint scheduleId_; // 0x18
	public const int RewardDayFieldNumber = 2; // Metadata: 0x00B08CDB
	private uint rewardDay_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetSignInRewardReq> Parser { get => default; } // 0x0000000184ECE1D0-0x0000000184ECE260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184ECDEC0-0x0000000184ECDF50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184ECDBB0-0x0000000184ECDC30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184ECD500-0x0000000184ECD560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184ECE600-0x0000000184ECE6F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184ECE390-0x0000000184ECE3F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184ECDFF0-0x0000000184ECE0E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184ECE5B0-0x0000000184ECE600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184ECDCD0-0x0000000184ECDDC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x0000000184ECD750-0x0000000184ECD7F0 0x0000000184ECE3F0-0x0000000184ECE490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RewardDay { get => default; set {} } // 0x0000000184ECD7F0-0x0000000184ECD890 0x0000000184ECDF50-0x0000000184ECDFF0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25456
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25457
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2505
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetSignInRewardReq() {} // 0x0000000184ECE9B0-0x0000000184ECEA10
	static GetSignInRewardReq() {} // 0x0000000184ECE8F0-0x0000000184ECE9B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetSignInRewardReq Clone() => default; // 0x0000000184ECE0E0-0x0000000184ECE1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetSignInRewardReq ShallowCopy() => default; // 0x0000000184ECDC30-0x0000000184ECDCD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184ECD690-0x0000000184ECD6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184ECE2F0-0x0000000184ECE340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184ECE340-0x0000000184ECE390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184ECD6E0-0x0000000184ECD750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184ECD9B0-0x0000000184ECDA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetSignInRewardReq other) => default; // 0x0000000184ECD890-0x0000000184ECD9B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184ECDDC0-0x0000000184ECDEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184ECE6F0-0x0000000184ECE8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184ECE490-0x0000000184ECE5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184ECDA80-0x0000000184ECDBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetSignInRewardReq other) {} // 0x0000000184ECD560-0x0000000184ECD690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184ECD400-0x0000000184ECD500
}

