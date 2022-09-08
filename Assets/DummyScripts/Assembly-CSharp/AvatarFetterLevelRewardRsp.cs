/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarFetterLevelRewardRsp : MessageBase, IMessage<AvatarFetterLevelRewardRsp> // TypeDefIndex: 22524
{
	// Fields
	private static readonly MessageParser<AvatarFetterLevelRewardRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B01C5B
	private int retcode_; // 0x18
	public const int AvatarGuidFieldNumber = 2; // Metadata: 0x00B01C5F
	private ulong avatarGuid_; // 0x20
	public const int FetterLevelFieldNumber = 3; // Metadata: 0x00B01C63
	private uint fetterLevel_; // 0x28
	public const int RewardIdFieldNumber = 4; // Metadata: 0x00B01C67
	private uint rewardId_; // 0x2C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarFetterLevelRewardRsp> Parser { get => default; } // 0x0000000183DA11F0-0x0000000183DA1280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183DA0E40-0x0000000183DA0ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183DA0A30-0x0000000183DA0AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183DA00E0-0x0000000183DA0140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183DA16A0-0x0000000183DA1790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183DA1450-0x0000000183DA14B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183DA0F70-0x0000000183DA1060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183DA1650-0x0000000183DA16A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183DA0B50-0x0000000183DA0C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183DA0990-0x0000000183DA0A30 0x0000000183DA0450-0x0000000183DA04F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x0000000183DA0ED0-0x0000000183DA0F70 0x0000000183DA02D0-0x0000000183DA0370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FetterLevel { get => default; set {} } // 0x0000000183DA0DA0-0x0000000183DA0E40 0x0000000183DA08F0-0x0000000183DA0990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RewardId { get => default; set {} } // 0x0000000183DA13B0-0x0000000183DA1450 0x0000000183DA1150-0x0000000183DA11F0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22525
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22526
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1749
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarFetterLevelRewardRsp() {} // 0x0000000183DA1B70-0x0000000183DA1BD0
	static AvatarFetterLevelRewardRsp() {} // 0x0000000183DA1AB0-0x0000000183DA1B70

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarFetterLevelRewardRsp Clone() => default; // 0x0000000183DA1060-0x0000000183DA1150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarFetterLevelRewardRsp ShallowCopy() => default; // 0x0000000183DA0AB0-0x0000000183DA0B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183DA0370-0x0000000183DA03C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183DA1310-0x0000000183DA1360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183DA1360-0x0000000183DA13B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183DA03C0-0x0000000183DA0450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183DA0650-0x0000000183DA0720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarFetterLevelRewardRsp other) => default; // 0x0000000183DA04F0-0x0000000183DA0650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183DA0C40-0x0000000183DA0DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183DA1790-0x0000000183DA1AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183DA14B0-0x0000000183DA1650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183DA0720-0x0000000183DA08F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarFetterLevelRewardRsp other) {} // 0x0000000183DA0140-0x0000000183DA02D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183D9FFB0-0x0000000183DA00E0
}

