/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetBonusActivityRewardRsp : MessageBase, IMessage<GetBonusActivityRewardRsp> // TypeDefIndex: 25474
{
	// Fields
	private static readonly MessageParser<GetBonusActivityRewardRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B08D6B
	private int retcode_; // 0x18
	public const int BonusActivityInfoListFieldNumber = 2; // Metadata: 0x00B08D6F
	private BonusActivityInfo bonusActivityInfoList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetBonusActivityRewardRsp> Parser { get => default; } // 0x0000000184D2F660-0x0000000184D2F6F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184D2F3F0-0x0000000184D2F480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184D2F060-0x0000000184D2F0E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184D2E6B0-0x0000000184D2E710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184D2FA50-0x0000000184D2FB40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184D2F880-0x0000000184D2F8E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184D2F480-0x0000000184D2F570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184D2FA00-0x0000000184D2FA50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184D2F180-0x0000000184D2F270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184D2EFC0-0x0000000184D2F060 0x0000000184D2EA40-0x0000000184D2EAE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BonusActivityInfo BonusActivityInfoList { get => default; set {} } // 0x0000000184D2EB80-0x0000000184D2EC20 0x0000000184D2EAE0-0x0000000184D2EB80

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25475
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25476
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2516
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetBonusActivityRewardRsp() {} // 0x0000000184D2FDE0-0x0000000184D2FE40
	static GetBonusActivityRewardRsp() {} // 0x0000000184D2FD20-0x0000000184D2FDE0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetBonusActivityRewardRsp Clone() => default; // 0x0000000184D2F570-0x0000000184D2F660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetBonusActivityRewardRsp ShallowCopy() => default; // 0x0000000184D2F0E0-0x0000000184D2F180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184D2E890-0x0000000184D2E910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184D2F780-0x0000000184D2F800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184D2F800-0x0000000184D2F880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184D2E910-0x0000000184D2EA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184D2EC20-0x0000000184D2ECF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetBonusActivityRewardRsp other) => default; // 0x0000000184D2ECF0-0x0000000184D2EE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184D2F270-0x0000000184D2F3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184D2FB40-0x0000000184D2FD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184D2F8E0-0x0000000184D2FA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184D2EE20-0x0000000184D2EFC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetBonusActivityRewardRsp other) {} // 0x0000000184D2E710-0x0000000184D2E890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184D2E570-0x0000000184D2E6B0
}

