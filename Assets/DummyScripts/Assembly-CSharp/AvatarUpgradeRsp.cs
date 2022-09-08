/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarUpgradeRsp : MessageBase, IMessage<AvatarUpgradeRsp> // TypeDefIndex: 22435
{
	// Fields
	private static readonly MessageParser<AvatarUpgradeRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0191B
	private int retcode_; // 0x18
	public const int AvatarGuidFieldNumber = 2; // Metadata: 0x00B0191F
	private ulong avatarGuid_; // 0x20
	public const int OldLevelFieldNumber = 3; // Metadata: 0x00B01923
	private uint oldLevel_; // 0x28
	public const int CurLevelFieldNumber = 4; // Metadata: 0x00B01927
	private uint curLevel_; // 0x2C
	public const int OldFightPropMapFieldNumber = 5; // Metadata: 0x00B0192B
	private static readonly MapField<uint, float> _map_oldFightPropMap_codec; // 0x08
	private readonly MapField<uint, float> oldFightPropMap_; // 0x30
	public const int CurFightPropMapFieldNumber = 6; // Metadata: 0x00B0192F
	private static readonly MapField<uint, float> _map_curFightPropMap_codec; // 0x10
	private readonly MapField<uint, float> curFightPropMap_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarUpgradeRsp> Parser { get => default; } // 0x0000000183CE0530-0x0000000183CE05C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183CE0080-0x0000000183CE0110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183CDFC40-0x0000000183CDFCC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183CDF1B0-0x0000000183CDF210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183CE0AD0-0x0000000183CE0BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183CE06F0-0x0000000183CE0750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183CE0210-0x0000000183CE0300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183CE0A80-0x0000000183CE0AD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183CDFD60-0x0000000183CDFE50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183CDFBA0-0x0000000183CDFC40 0x0000000183CDF600-0x0000000183CDF6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x0000000183CE0170-0x0000000183CE0210 0x0000000183CDF3D0-0x0000000183CDF470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OldLevel { get => default; set {} } // 0x0000000183CE0490-0x0000000183CE0530 0x0000000183CE03F0-0x0000000183CE0490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurLevel { get => default; set {} } // 0x0000000183CDF110-0x0000000183CDF1B0 0x0000000183CE07B0-0x0000000183CE0850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, float> OldFightPropMap { get => default; } // 0x0000000183CE0750-0x0000000183CE07B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, float> CurFightPropMap { get => default; } // 0x0000000183CE0110-0x0000000183CE0170 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22436
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22437
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1718
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarUpgradeRsp() {} // 0x0000000183CE1150-0x0000000183CE1200
	static AvatarUpgradeRsp() {} // 0x0000000183CE0FC0-0x0000000183CE1150

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarUpgradeRsp Clone() => default; // 0x0000000183CE0300-0x0000000183CE03F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarUpgradeRsp ShallowCopy() => default; // 0x0000000183CDFCC0-0x0000000183CDFD60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183CDF470-0x0000000183CDF4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183CE0650-0x0000000183CE06A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183CE06A0-0x0000000183CE06F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183CDF4C0-0x0000000183CDF600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183CDF6A0-0x0000000183CDF770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarUpgradeRsp other) => default; // 0x0000000183CDF770-0x0000000183CDF950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183CDFE50-0x0000000183CE0080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183CE0BC0-0x0000000183CE0FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183CE0850-0x0000000183CE0A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183CDF950-0x0000000183CDFBA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarUpgradeRsp other) {} // 0x0000000183CDF210-0x0000000183CDF3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183CDEEF0-0x0000000183CDF110
}

