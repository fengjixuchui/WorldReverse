/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerGetForceQuitBanInfoRsp : MessageBase, IMessage<PlayerGetForceQuitBanInfoRsp> // TypeDefIndex: 23873
{
	// Fields
	private static readonly MessageParser<PlayerGetForceQuitBanInfoRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0507B
	private int retcode_; // 0x18
	public const int MatchIdFieldNumber = 2; // Metadata: 0x00B0507F
	private uint matchId_; // 0x1C
	public const int ExpireTimeFieldNumber = 3; // Metadata: 0x00B05083
	private uint expireTime_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerGetForceQuitBanInfoRsp> Parser { get => default; } // 0x00000001831DE870-0x00000001831DE900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001831DE600-0x00000001831DE690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001831DE2C0-0x00000001831DE340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001831DD8E0-0x00000001831DD940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001831DEC40-0x00000001831DED30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001831DEA30-0x00000001831DEA90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001831DE690-0x00000001831DE780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001831DEBF0-0x00000001831DEC40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001831DE3E0-0x00000001831DE4D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001831DE180-0x00000001831DE220 0x00000001831DDCB0-0x00000001831DDD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MatchId { get => default; set {} } // 0x00000001831DDD50-0x00000001831DDDF0 0x00000001831DD940-0x00000001831DD9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ExpireTime { get => default; set {} } // 0x00000001831DE220-0x00000001831DE2C0 0x00000001831DDC10-0x00000001831DDCB0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23874
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23875
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4166
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerGetForceQuitBanInfoRsp() {} // 0x00000001831DF080-0x00000001831DF0E0
	static PlayerGetForceQuitBanInfoRsp() {} // 0x00000001831DEFC0-0x00000001831DF080

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerGetForceQuitBanInfoRsp Clone() => default; // 0x00000001831DE780-0x00000001831DE870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerGetForceQuitBanInfoRsp ShallowCopy() => default; // 0x00000001831DE340-0x00000001831DE3E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001831DDB40-0x00000001831DDB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831DE990-0x00000001831DE9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831DE9E0-0x00000001831DEA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001831DDB90-0x00000001831DDC10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001831DDDF0-0x00000001831DDEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerGetForceQuitBanInfoRsp other) => default; // 0x00000001831DDEC0-0x00000001831DE000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001831DE4D0-0x00000001831DE600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001831DED30-0x00000001831DEFC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001831DEA90-0x00000001831DEBF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001831DE000-0x00000001831DE180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerGetForceQuitBanInfoRsp other) {} // 0x00000001831DD9E0-0x00000001831DDB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001831DD7D0-0x00000001831DD8E0
}

