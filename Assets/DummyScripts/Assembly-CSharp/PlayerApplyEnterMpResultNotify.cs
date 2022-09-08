/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerApplyEnterMpResultNotify : MessageBase, IMessage<PlayerApplyEnterMpResultNotify> // TypeDefIndex: 24030
{
	// Fields
	private static readonly MessageParser<PlayerApplyEnterMpResultNotify> _parser; // 0x00
	public const int TargetUidFieldNumber = 1; // Metadata: 0x00B05627
	private uint targetUid_; // 0x18
	public const int IsAgreedFieldNumber = 2; // Metadata: 0x00B0562B
	private bool isAgreed_; // 0x1C
	public const int ReasonFieldNumber = 3; // Metadata: 0x00B0562F
	private Types.Reason reason_; // 0x20
	public const int TargetNicknameFieldNumber = 4; // Metadata: 0x00B05633
	private string targetNickname_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerApplyEnterMpResultNotify> Parser { get => default; } // 0x0000000183CDA7E0-0x0000000183CDA870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183CDA4D0-0x0000000183CDA560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183CDA060-0x0000000183CDA0E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183CD96F0-0x0000000183CD9750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183CDAD50-0x0000000183CDAE40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183CDAAF0-0x0000000183CDAB50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183CDA560-0x0000000183CDA650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183CDAD00-0x0000000183CDAD50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183CDA180-0x0000000183CDA270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetUid { get => default; set {} } // 0x0000000183CDA430-0x0000000183CDA4D0 0x0000000183CD9FC0-0x0000000183CDA060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAgreed { get => default; set {} } // 0x0000000183CD9750-0x0000000183CD97F0 0x0000000183CDA870-0x0000000183CDA910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.Reason Reason { get => default; set {} } // 0x0000000183CDA740-0x0000000183CDA7E0 0x0000000183CD9A80-0x0000000183CD9B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string TargetNickname { get => default; set {} } // 0x0000000183CD97F0-0x0000000183CD9890 0x0000000183CDAA40-0x0000000183CDAAF0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24031
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24032
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1804
		}

		public enum Reason // TypeDefIndex: 24033
		{
			PlayerJudge = 0,
			SceneCannotEnter = 1,
			PlayerCannotEnterMp = 2,
			SystemJudge = 3,
			AllowEnterPlayerFull = 4,
			WorldLevelLowerThanHost = 5,
			HostInMatch = 6,
			PlayerInBlacklist = 7,
			PsPlayerNotAcceptOthers = 8,
			HostIsBlocked = 9,
			OtherDataVersionNotLatest = 10,
			DataVersionNotLatest = 11,
			PlayerNotInPlayerWorld = 12
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerApplyEnterMpResultNotify() {} // 0x0000000183CDB200-0x0000000183CDB280
	static PlayerApplyEnterMpResultNotify() {} // 0x0000000183CDB140-0x0000000183CDB200

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerApplyEnterMpResultNotify Clone() => default; // 0x0000000183CDA650-0x0000000183CDA740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerApplyEnterMpResultNotify ShallowCopy() => default; // 0x0000000183CDA0E0-0x0000000183CDA180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183CD9A30-0x0000000183CD9A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183CDA9A0-0x0000000183CDA9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183CDA9F0-0x0000000183CDAA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183CD9B20-0x0000000183CD9BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183CD9BB0-0x0000000183CD9C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerApplyEnterMpResultNotify other) => default; // 0x0000000183CD9C80-0x0000000183CD9E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183CDA270-0x0000000183CDA430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183CDAE40-0x0000000183CDB140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183CDAB50-0x0000000183CDAD00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183CD9E10-0x0000000183CD9FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerApplyEnterMpResultNotify other) {} // 0x0000000183CD9890-0x0000000183CD9A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183CD95D0-0x0000000183CD96F0
}

