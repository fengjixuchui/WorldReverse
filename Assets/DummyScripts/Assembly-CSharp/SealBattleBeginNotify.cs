/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SealBattleBeginNotify : MessageBase, IMessage<SealBattleBeginNotify> // TypeDefIndex: 25088
{
	// Fields
	private static readonly MessageParser<SealBattleBeginNotify> _parser; // 0x00
	public const int SealEntityIdFieldNumber = 1; // Metadata: 0x00B07F4B
	private uint sealEntityId_; // 0x18
	public const int SealRadiusFieldNumber = 2; // Metadata: 0x00B07F4F
	private uint sealRadius_; // 0x1C
	public const int SealMaxProgressFieldNumber = 3; // Metadata: 0x00B07F53
	private uint sealMaxProgress_; // 0x20
	public const int BattleTypeFieldNumber = 4; // Metadata: 0x00B07F57
	private SealBattleType battleType_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SealBattleBeginNotify> Parser { get => default; } // 0x0000000183FF10E0-0x0000000183FF1170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183FF0D30-0x0000000183FF0DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183FF0980-0x0000000183FF0A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183FF0050-0x0000000183FF00B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183FF14F0-0x0000000183FF15E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183FF12A0-0x0000000183FF1300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183FF0DC0-0x0000000183FF0EB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183FF14A0-0x0000000183FF14F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183FF0AA0-0x0000000183FF0B90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SealEntityId { get => default; set {} } // 0x0000000183FF0FA0-0x0000000183FF1040 0x0000000183FF0840-0x0000000183FF08E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SealRadius { get => default; set {} } // 0x0000000183FF08E0-0x0000000183FF0980 0x0000000183FF15E0-0x0000000183FF1680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SealMaxProgress { get => default; set {} } // 0x0000000183FF1040-0x0000000183FF10E0 0x0000000183FF03B0-0x0000000183FF0450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SealBattleType BattleType { get => default; set {} } // 0x0000000183FEFFB0-0x0000000183FF0050 0x0000000183FF00B0-0x0000000183FF0150

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25089
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25090
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 264
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SealBattleBeginNotify() {} // 0x0000000183FF1A60-0x0000000183FF1AD0
	static SealBattleBeginNotify() {} // 0x0000000183FF19A0-0x0000000183FF1A60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SealBattleBeginNotify Clone() => default; // 0x0000000183FF0EB0-0x0000000183FF0FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SealBattleBeginNotify ShallowCopy() => default; // 0x0000000183FF0A00-0x0000000183FF0AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183FF02D0-0x0000000183FF0320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183FF1200-0x0000000183FF1250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183FF1250-0x0000000183FF12A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183FF0320-0x0000000183FF03B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183FF0450-0x0000000183FF0520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SealBattleBeginNotify other) => default; // 0x0000000183FF0520-0x0000000183FF0670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183FF0B90-0x0000000183FF0D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183FF1680-0x0000000183FF19A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183FF1300-0x0000000183FF14A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183FF0670-0x0000000183FF0840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SealBattleBeginNotify other) {} // 0x0000000183FF0150-0x0000000183FF02D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183FEFE90-0x0000000183FEFFB0
}

