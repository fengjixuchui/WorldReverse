/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BattlePassAllDataNotify : MessageBase, IMessage<BattlePassAllDataNotify> // TypeDefIndex: 22545
{
	// Fields
	private static readonly MessageParser<BattlePassAllDataNotify> _parser; // 0x00
	public const int HaveCurScheduleFieldNumber = 1; // Metadata: 0x00B01D77
	private bool haveCurSchedule_; // 0x18
	public const int CurScheduleFieldNumber = 2; // Metadata: 0x00B01D7B
	private BattlePassSchedule curSchedule_; // 0x20
	public const int MissionListFieldNumber = 3; // Metadata: 0x00B01D7F
	private static readonly FieldCodec<BattlePassMission> _repeated_missionList_codec; // 0x08
	private readonly RepeatedMessageField<BattlePassMission> missionList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BattlePassAllDataNotify> Parser { get => default; } // 0x0000000182A433E0-0x0000000182A43470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182A43070-0x0000000182A43100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182A42CC0-0x0000000182A42D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182A42340-0x0000000182A423A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182A43860-0x0000000182A43950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182A43640-0x0000000182A436A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182A431A0-0x0000000182A43290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182A43810-0x0000000182A43860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182A42DE0-0x0000000182A42ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool HaveCurSchedule { get => default; set {} } // 0x0000000182A43100-0x0000000182A431A0 0x0000000182A420F0-0x0000000182A42190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassSchedule CurSchedule { get => default; set {} } // 0x0000000182A42790-0x0000000182A42830 0x0000000182A42830-0x0000000182A428D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<BattlePassMission> MissionList { get => default; } // 0x0000000182A43380-0x0000000182A433E0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22546
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22547
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2601
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassAllDataNotify() {} // 0x0000000182A43CC0-0x0000000182A43D50
	static BattlePassAllDataNotify() {} // 0x0000000182A43BB0-0x0000000182A43CC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassAllDataNotify Clone() => default; // 0x0000000182A43290-0x0000000182A43380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassAllDataNotify ShallowCopy() => default; // 0x0000000182A42D40-0x0000000182A42DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182A42570-0x0000000182A425F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182A43500-0x0000000182A435A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182A435A0-0x0000000182A43640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182A425F0-0x0000000182A42790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182A42A30-0x0000000182A42B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BattlePassAllDataNotify other) => default; // 0x0000000182A428D0-0x0000000182A42A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182A42ED0-0x0000000182A43070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182A43950-0x0000000182A43BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182A436A0-0x0000000182A43810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182A42B00-0x0000000182A42CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BattlePassAllDataNotify other) {} // 0x0000000182A423A0-0x0000000182A42570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182A42190-0x0000000182A42340
}

