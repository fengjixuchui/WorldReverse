/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarPromoteGetRewardRsp : MessageBase, IMessage<AvatarPromoteGetRewardRsp> // TypeDefIndex: 22534
{
	// Fields
	private static readonly MessageParser<AvatarPromoteGetRewardRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B01CCF
	private int retcode_; // 0x18
	public const int AvatarGuidFieldNumber = 2; // Metadata: 0x00B01CD3
	private ulong avatarGuid_; // 0x20
	public const int PromoteLevelFieldNumber = 3; // Metadata: 0x00B01CD7
	private uint promoteLevel_; // 0x28
	public const int RewardIdFieldNumber = 4; // Metadata: 0x00B01CDB
	private uint rewardId_; // 0x2C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarPromoteGetRewardRsp> Parser { get => default; } // 0x00000001815C4AE0-0x00000001815C4B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001815C4690-0x00000001815C4720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001815C4320-0x00000001815C43A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001815C39D0-0x00000001815C3A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001815C4F90-0x00000001815C5080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001815C4D40-0x00000001815C4DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001815C47C0-0x00000001815C48B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001815C4F40-0x00000001815C4F90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001815C4440-0x00000001815C4530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001815C41E0-0x00000001815C4280 0x00000001815C3D40-0x00000001815C3DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x00000001815C4720-0x00000001815C47C0 0x00000001815C3BC0-0x00000001815C3C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PromoteLevel { get => default; set {} } // 0x00000001815C4280-0x00000001815C4320 0x00000001815C4A40-0x00000001815C4AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RewardId { get => default; set {} } // 0x00000001815C4CA0-0x00000001815C4D40 0x00000001815C49A0-0x00000001815C4A40

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22535
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22536
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1752
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarPromoteGetRewardRsp() {} // 0x00000001815C5460-0x00000001815C54C0
	static AvatarPromoteGetRewardRsp() {} // 0x00000001815C53A0-0x00000001815C5460

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarPromoteGetRewardRsp Clone() => default; // 0x00000001815C48B0-0x00000001815C49A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarPromoteGetRewardRsp ShallowCopy() => default; // 0x00000001815C43A0-0x00000001815C4440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001815C3C60-0x00000001815C3CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001815C4C00-0x00000001815C4C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001815C4C50-0x00000001815C4CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001815C3CB0-0x00000001815C3D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001815C3F40-0x00000001815C4010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarPromoteGetRewardRsp other) => default; // 0x00000001815C3DE0-0x00000001815C3F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001815C4530-0x00000001815C4690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001815C5080-0x00000001815C53A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001815C4DA0-0x00000001815C4F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001815C4010-0x00000001815C41E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarPromoteGetRewardRsp other) {} // 0x00000001815C3A30-0x00000001815C3BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001815C38A0-0x00000001815C39D0
}

