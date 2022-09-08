/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BattlePassMission : MessageBase, IMessage<BattlePassMission> // TypeDefIndex: 22539
{
	// Fields
	private static readonly MessageParser<BattlePassMission> _parser; // 0x00
	public const int MissionIdFieldNumber = 1; // Metadata: 0x00B01D07
	private uint missionId_; // 0x18
	public const int CurProgressFieldNumber = 2; // Metadata: 0x00B01D0B
	private uint curProgress_; // 0x1C
	public const int TotalProgressFieldNumber = 3; // Metadata: 0x00B01D0F
	private uint totalProgress_; // 0x20
	public const int RewardBattlePassPointFieldNumber = 4; // Metadata: 0x00B01D13
	private uint rewardBattlePassPoint_; // 0x24
	public const int MissionTypeFieldNumber = 5; // Metadata: 0x00B01D17
	private uint missionType_; // 0x28
	public const int MissionStatusFieldNumber = 6; // Metadata: 0x00B01D1B
	private Types.MissionStatus missionStatus_; // 0x2C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BattlePassMission> Parser { get => default; } // 0x0000000185603DF0-0x0000000185603E80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185603860-0x00000001856038F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001856033B0-0x0000000185603430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000185602A80-0x0000000185602AE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185604460-0x0000000185604550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001856040F0-0x0000000185604150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185603990-0x0000000185603A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185604410-0x0000000185604460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001856034D0-0x00000001856035C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MissionId { get => default; set {} } // 0x0000000185602B80-0x0000000185602C20 0x00000001856038F0-0x0000000185603990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurProgress { get => default; set {} } // 0x0000000185603CB0-0x0000000185603D50 0x0000000185603D50-0x0000000185603DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TotalProgress { get => default; set {} } // 0x0000000185604370-0x0000000185604410 0x00000001856029E0-0x0000000185602A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RewardBattlePassPoint { get => default; set {} } // 0x0000000185603C10-0x0000000185603CB0 0x0000000185603B70-0x0000000185603C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MissionType { get => default; set {} } // 0x0000000185604000-0x00000001856040A0 0x0000000185603F10-0x0000000185603FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.MissionStatus MissionStatus { get => default; set {} } // 0x00000001856037C0-0x0000000185603860 0x0000000185602AE0-0x0000000185602B80

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22540
	{
		// Nested types
		public enum MissionStatus // TypeDefIndex: 22541
		{
			MissionInvalid = 0,
			MissionUnfinished = 1,
			MissionFinished = 2,
			MissionPointTaken = 3
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassMission() {} // 0x0000000185604A40-0x0000000185604AB0
	static BattlePassMission() {} // 0x0000000185604980-0x0000000185604A40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassMission Clone() => default; // 0x0000000185603A80-0x0000000185603B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassMission ShallowCopy() => default; // 0x0000000185603430-0x00000001856034D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185602DF0-0x0000000185602E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185603FB0-0x0000000185604000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001856040A0-0x00000001856040F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185602E40-0x0000000185602EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185602EF0-0x0000000185602FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BattlePassMission other) => default; // 0x0000000185602FC0-0x0000000185603150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001856035C0-0x00000001856037C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185604550-0x0000000185604980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185604150-0x0000000185604370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185603150-0x00000001856033B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BattlePassMission other) {} // 0x0000000185602C20-0x0000000185602DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185602880-0x00000001856029E0
}

