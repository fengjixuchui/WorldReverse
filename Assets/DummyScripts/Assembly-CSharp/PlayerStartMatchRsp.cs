/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerStartMatchRsp : MessageBase, IMessage<PlayerStartMatchRsp> // TypeDefIndex: 23828
{
	// Fields
	private static readonly MessageParser<PlayerStartMatchRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B04EAB
	private int retcode_; // 0x18
	public const int MatchTypeFieldNumber = 2; // Metadata: 0x00B04EAF
	private MatchType matchType_; // 0x1C
	public const int ParamFieldNumber = 3; // Metadata: 0x00B04EB3
	private uint param_; // 0x20
	public const int DungeonIdFieldNumber = 11; // Metadata: 0x00B04EB7
	private uint dungeonId_; // 0x24
	public const int MpPlayIdFieldNumber = 12; // Metadata: 0x00B04EBB
	private uint mpPlayId_; // 0x28
	public const int MechanicusDifficultLevelFieldNumber = 13; // Metadata: 0x00B04EBF
	private uint mechanicusDifficultLevel_; // 0x2C
	public const int MatchIdFieldNumber = 14; // Metadata: 0x00B04EC3
	private uint matchId_; // 0x30
	public const int PunishEndTimeFieldNumber = 15; // Metadata: 0x00B04EC7
	private uint punishEndTime_; // 0x34

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerStartMatchRsp> Parser { get => default; } // 0x000000018120B730-0x000000018120B7C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018120B380-0x000000018120B410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018120AD40-0x000000018120ADC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181209FC0-0x000000018120A020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018120BEC0-0x000000018120BFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018120B990-0x000000018120B9F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018120B410-0x000000018120B500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018120BE70-0x000000018120BEC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018120AFA0-0x000000018120B090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018120ACA0-0x000000018120AD40 0x000000018120A5D0-0x000000018120A670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MatchType MatchType { get => default; set {} } // 0x000000018120B690-0x000000018120B730 0x000000018120B8A0-0x000000018120B940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Param { get => default; set {} } // 0x000000018120B9F0-0x000000018120BA90 0x000000018120BA90-0x000000018120BB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonId { get => default; set {} } // 0x000000018120AF00-0x000000018120AFA0 0x000000018120BDD0-0x000000018120BE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MpPlayId { get => default; set {} } // 0x000000018120B2E0-0x000000018120B380 0x000000018120A530-0x000000018120A5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MechanicusDifficultLevel { get => default; set {} } // 0x000000018120B5F0-0x000000018120B690 0x000000018120A0C0-0x000000018120A160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MatchId { get => default; set {} } // 0x000000018120A670-0x000000018120A710 0x000000018120A020-0x000000018120A0C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PunishEndTime { get => default; set {} } // 0x000000018120ADC0-0x000000018120AE60 0x000000018120A380-0x000000018120A420

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23829
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23830
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4152
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerStartMatchRsp() {} // 0x000000018120C5C0-0x000000018120C630
	static PlayerStartMatchRsp() {} // 0x000000018120C500-0x000000018120C5C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerStartMatchRsp Clone() => default; // 0x000000018120B500-0x000000018120B5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerStartMatchRsp ShallowCopy() => default; // 0x000000018120AE60-0x000000018120AF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018120A420-0x000000018120A470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018120B850-0x000000018120B8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018120B940-0x000000018120B990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018120A470-0x000000018120A530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018120A710-0x000000018120A7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerStartMatchRsp other) => default; // 0x000000018120A7E0-0x000000018120A9B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018120B090-0x000000018120B2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018120BFB0-0x000000018120C500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018120BB30-0x000000018120BDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018120A9B0-0x000000018120ACA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerStartMatchRsp other) {} // 0x000000018120A160-0x000000018120A380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181209E20-0x0000000181209FC0
}

