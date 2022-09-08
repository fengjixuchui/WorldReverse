/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakePlayerLevelRewardRsp : MessageBase, IMessage<TakePlayerLevelRewardRsp> // TypeDefIndex: 24461
{
	// Fields
	private static readonly MessageParser<TakePlayerLevelRewardRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B067C7
	private int retcode_; // 0x18
	public const int LevelFieldNumber = 2; // Metadata: 0x00B067CB
	private uint level_; // 0x1C
	public const int RewardIdFieldNumber = 3; // Metadata: 0x00B067CF
	private uint rewardId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakePlayerLevelRewardRsp> Parser { get => default; } // 0x000000018118B870-0x000000018118B900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018118B560-0x000000018118B5F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018118B180-0x000000018118B200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018118A980-0x000000018118A9E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018118BCE0-0x000000018118BDD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018118BAD0-0x000000018118BB30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018118B5F0-0x000000018118B6E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018118BC90-0x000000018118BCE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018118B340-0x000000018118B430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018118B0E0-0x000000018118B180 0x000000018118ACB0-0x000000018118AD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x000000018118AB40-0x000000018118ABE0 0x000000018118B2A0-0x000000018118B340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RewardId { get => default; set {} } // 0x000000018118BA30-0x000000018118BAD0 0x000000018118B7D0-0x000000018118B870

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24462
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24463
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 153
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakePlayerLevelRewardRsp() {} // 0x000000018118C120-0x000000018118C180
	static TakePlayerLevelRewardRsp() {} // 0x000000018118C060-0x000000018118C120

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakePlayerLevelRewardRsp Clone() => default; // 0x000000018118B6E0-0x000000018118B7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakePlayerLevelRewardRsp ShallowCopy() => default; // 0x000000018118B200-0x000000018118B2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018118ABE0-0x000000018118AC30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018118B990-0x000000018118B9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018118B9E0-0x000000018118BA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018118AC30-0x000000018118ACB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018118AE90-0x000000018118AF60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakePlayerLevelRewardRsp other) => default; // 0x000000018118AD50-0x000000018118AE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018118B430-0x000000018118B560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018118BDD0-0x000000018118C060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018118BB30-0x000000018118BC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018118AF60-0x000000018118B0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakePlayerLevelRewardRsp other) {} // 0x000000018118A9E0-0x000000018118AB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018118A870-0x000000018118A980
}

