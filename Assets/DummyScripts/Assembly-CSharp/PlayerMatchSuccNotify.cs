/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerMatchSuccNotify : MessageBase, IMessage<PlayerMatchSuccNotify> // TypeDefIndex: 23845
{
	// Fields
	private static readonly MessageParser<PlayerMatchSuccNotify> _parser; // 0x00
	public const int MatchTypeFieldNumber = 1; // Metadata: 0x00B04F67
	private MatchType matchType_; // 0x18
	public const int ConfirmEndTimeFieldNumber = 2; // Metadata: 0x00B04F6B
	private uint confirmEndTime_; // 0x1C
	public const int HostUidFieldNumber = 3; // Metadata: 0x00B04F6F
	private uint hostUid_; // 0x20
	public const int DungeonIdFieldNumber = 11; // Metadata: 0x00B04F73
	private uint dungeonId_; // 0x24
	public const int MpPlayIdFieldNumber = 12; // Metadata: 0x00B04F77
	private uint mpPlayId_; // 0x28
	public const int MechanicusDifficultLevelFieldNumber = 13; // Metadata: 0x00B04F7B
	private uint mechanicusDifficultLevel_; // 0x2C
	public const int GeneralMatchInfoFieldNumber = 14; // Metadata: 0x00B04F7F
	private GeneralMatchInfo generalMatchInfo_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerMatchSuccNotify> Parser { get => default; } // 0x0000000181BA7CF0-0x0000000181BA7D80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181BA7760-0x0000000181BA77F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181BA7180-0x0000000181BA7200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181BA64D0-0x0000000181BA6530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181BA83F0-0x0000000181BA84E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181BA8050-0x0000000181BA80B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181BA77F0-0x0000000181BA78E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181BA83A0-0x0000000181BA83F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181BA7340-0x0000000181BA7430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MatchType MatchType { get => default; set {} } // 0x0000000181BA7C50-0x0000000181BA7CF0 0x0000000181BA7E90-0x0000000181BA7F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ConfirmEndTime { get => default; set {} } // 0x0000000181BA78E0-0x0000000181BA7980 0x0000000181BA68B0-0x0000000181BA6950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint HostUid { get => default; set {} } // 0x0000000181BA6530-0x0000000181BA65D0 0x0000000181BA7BB0-0x0000000181BA7C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonId { get => default; set {} } // 0x0000000181BA72A0-0x0000000181BA7340 0x0000000181BA8300-0x0000000181BA83A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MpPlayId { get => default; set {} } // 0x0000000181BA76C0-0x0000000181BA7760 0x0000000181BA6B40-0x0000000181BA6BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MechanicusDifficultLevel { get => default; set {} } // 0x0000000181BA7B10-0x0000000181BA7BB0 0x0000000181BA65D0-0x0000000181BA6670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GeneralMatchInfo GeneralMatchInfo { get => default; set {} } // 0x0000000181BA7FB0-0x0000000181BA8050 0x0000000181BA7A70-0x0000000181BA7B10

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23846
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23847
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4157
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerMatchSuccNotify() {} // 0x0000000181BA8A40-0x0000000181BA8AB0
	static PlayerMatchSuccNotify() {} // 0x0000000181BA8980-0x0000000181BA8A40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerMatchSuccNotify Clone() => default; // 0x0000000181BA7980-0x0000000181BA7A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerMatchSuccNotify ShallowCopy() => default; // 0x0000000181BA7200-0x0000000181BA72A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181BA6950-0x0000000181BA69D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181BA7E10-0x0000000181BA7E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181BA7F30-0x0000000181BA7FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181BA69D0-0x0000000181BA6B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181BA6BE0-0x0000000181BA6CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerMatchSuccNotify other) => default; // 0x0000000181BA6CB0-0x0000000181BA6E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181BA7430-0x0000000181BA76C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181BA84E0-0x0000000181BA8980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181BA80B0-0x0000000181BA8300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181BA6E80-0x0000000181BA7180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerMatchSuccNotify other) {} // 0x0000000181BA6670-0x0000000181BA68B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181BA6300-0x0000000181BA64D0
}

