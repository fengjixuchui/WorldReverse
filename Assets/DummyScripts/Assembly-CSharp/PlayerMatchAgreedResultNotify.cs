/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerMatchAgreedResultNotify : MessageBase, IMessage<PlayerMatchAgreedResultNotify> // TypeDefIndex: 23857
{
	// Fields
	private static readonly MessageParser<PlayerMatchAgreedResultNotify> _parser; // 0x00
	public const int TargetUidFieldNumber = 1; // Metadata: 0x00B04FE3
	private uint targetUid_; // 0x18
	public const int ReasonFieldNumber = 2; // Metadata: 0x00B04FE7
	private Types.Reason reason_; // 0x1C
	public const int MatchTypeFieldNumber = 3; // Metadata: 0x00B04FEB
	private MatchType matchType_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerMatchAgreedResultNotify> Parser { get => default; } // 0x00000001830EDC40-0x00000001830EDCD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001830ED890-0x00000001830ED920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001830ED430-0x00000001830ED4B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001830ECCD0-0x00000001830ECD30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001830EE0B0-0x00000001830EE1A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001830EDEA0-0x00000001830EDF00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001830ED920-0x00000001830EDA10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001830EE060-0x00000001830EE0B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001830ED550-0x00000001830ED640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetUid { get => default; set {} } // 0x00000001830ED7F0-0x00000001830ED890 0x00000001830ED390-0x00000001830ED430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.Reason Reason { get => default; set {} } // 0x00000001830EDB00-0x00000001830EDBA0 0x00000001830ECEE0-0x00000001830ECF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MatchType MatchType { get => default; set {} } // 0x00000001830EDBA0-0x00000001830EDC40 0x00000001830EDDB0-0x00000001830EDE50

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23858
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23859
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4161
		}

		public enum Reason // TypeDefIndex: 23860
		{
			Succ = 0,
			TargetSceneCannotEnter = 1,
			SelfMpUnavailable = 2,
			OtherDataVersionNotLatest = 3,
			DataVersionNotLatest = 4
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerMatchAgreedResultNotify() {} // 0x00000001830EE4F0-0x00000001830EE560
	static PlayerMatchAgreedResultNotify() {} // 0x00000001830EE430-0x00000001830EE4F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerMatchAgreedResultNotify Clone() => default; // 0x00000001830EDA10-0x00000001830EDB00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerMatchAgreedResultNotify ShallowCopy() => default; // 0x00000001830ED4B0-0x00000001830ED550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001830ECE90-0x00000001830ECEE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001830EDD60-0x00000001830EDDB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001830EDE50-0x00000001830EDEA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001830ECF80-0x00000001830ED000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001830ED140-0x00000001830ED210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerMatchAgreedResultNotify other) => default; // 0x00000001830ED000-0x00000001830ED140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001830ED640-0x00000001830ED7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001830EE1A0-0x00000001830EE430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001830EDF00-0x00000001830EE060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001830ED210-0x00000001830ED390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerMatchAgreedResultNotify other) {} // 0x00000001830ECD30-0x00000001830ECE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001830ECBD0-0x00000001830ECCD0
}

