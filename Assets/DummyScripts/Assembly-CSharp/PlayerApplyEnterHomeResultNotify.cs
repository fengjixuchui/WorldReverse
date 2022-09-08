/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerApplyEnterHomeResultNotify : MessageBase, IMessage<PlayerApplyEnterHomeResultNotify> // TypeDefIndex: 23378
{
	// Fields
	private static readonly MessageParser<PlayerApplyEnterHomeResultNotify> _parser; // 0x00
	public const int TargetUidFieldNumber = 1; // Metadata: 0x00B03E43
	private uint targetUid_; // 0x18
	public const int IsAgreedFieldNumber = 2; // Metadata: 0x00B03E47
	private bool isAgreed_; // 0x1C
	public const int ReasonFieldNumber = 3; // Metadata: 0x00B03E4B
	private Types.Reason reason_; // 0x20
	public const int TargetNicknameFieldNumber = 4; // Metadata: 0x00B03E4F
	private string targetNickname_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerApplyEnterHomeResultNotify> Parser { get => default; } // 0x00000001818CC980-0x00000001818CCA10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001818CC670-0x00000001818CC700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001818CC200-0x00000001818CC280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001818CB890-0x00000001818CB8F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001818CCEF0-0x00000001818CCFE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001818CCC90-0x00000001818CCCF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001818CC700-0x00000001818CC7F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001818CCEA0-0x00000001818CCEF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001818CC320-0x00000001818CC410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetUid { get => default; set {} } // 0x00000001818CC5D0-0x00000001818CC670 0x00000001818CC160-0x00000001818CC200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAgreed { get => default; set {} } // 0x00000001818CB8F0-0x00000001818CB990 0x00000001818CCA10-0x00000001818CCAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.Reason Reason { get => default; set {} } // 0x00000001818CC8E0-0x00000001818CC980 0x00000001818CBC20-0x00000001818CBCC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string TargetNickname { get => default; set {} } // 0x00000001818CB990-0x00000001818CBA30 0x00000001818CCBE0-0x00000001818CCC90

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23379
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23380
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4474
		}

		public enum Reason // TypeDefIndex: 23381
		{
			PlayerJudge = 0,
			PlayerEnterOptionRefuse = 1,
			PlayerEnterOptionDirect = 2,
			SystemJudge = 3,
			HostInMatch = 4,
			PsPlayerNotAcceptOthers = 5,
			OpenStateNotOpen = 6
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerApplyEnterHomeResultNotify() {} // 0x00000001818CD3A0-0x00000001818CD420
	static PlayerApplyEnterHomeResultNotify() {} // 0x00000001818CD2E0-0x00000001818CD3A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerApplyEnterHomeResultNotify Clone() => default; // 0x00000001818CC7F0-0x00000001818CC8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerApplyEnterHomeResultNotify ShallowCopy() => default; // 0x00000001818CC280-0x00000001818CC320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001818CBBD0-0x00000001818CBC20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818CCB40-0x00000001818CCB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818CCB90-0x00000001818CCBE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001818CBCC0-0x00000001818CBD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001818CBEE0-0x00000001818CBFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerApplyEnterHomeResultNotify other) => default; // 0x00000001818CBD50-0x00000001818CBEE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001818CC410-0x00000001818CC5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001818CCFE0-0x00000001818CD2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001818CCCF0-0x00000001818CCEA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001818CBFB0-0x00000001818CC160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerApplyEnterHomeResultNotify other) {} // 0x00000001818CBA30-0x00000001818CBBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001818CB770-0x00000001818CB890
}

