/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MechanicusCandidateTeamCreateRsp : MessageBase, IMessage<MechanicusCandidateTeamCreateRsp> // TypeDefIndex: 23916
{
	// Fields
	private static readonly MessageParser<MechanicusCandidateTeamCreateRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B051FB
	private int retcode_; // 0x18
	public const int DifficultLevelFieldNumber = 2; // Metadata: 0x00B051FF
	private uint difficultLevel_; // 0x1C
	public const int DungeonIdFieldNumber = 3; // Metadata: 0x00B05203
	private uint dungeonId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MechanicusCandidateTeamCreateRsp> Parser { get => default; } // 0x0000000184449A00-0x0000000184449A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001844496F0-0x0000000184449780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184449310-0x0000000184449390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184448B10-0x0000000184448B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184449E70-0x0000000184449F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184449BC0-0x0000000184449C20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184449820-0x0000000184449910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184449E20-0x0000000184449E70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001844494D0-0x00000001844495C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001844491D0-0x0000000184449270 0x0000000184448DA0-0x0000000184448E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DifficultLevel { get => default; set {} } // 0x0000000184449780-0x0000000184449820 0x0000000184449270-0x0000000184449310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonId { get => default; set {} } // 0x0000000184449430-0x00000001844494D0 0x0000000184449D80-0x0000000184449E20

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23917
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23918
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3916
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MechanicusCandidateTeamCreateRsp() {} // 0x000000018444A2B0-0x000000018444A310
	static MechanicusCandidateTeamCreateRsp() {} // 0x000000018444A1F0-0x000000018444A2B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MechanicusCandidateTeamCreateRsp Clone() => default; // 0x0000000184449910-0x0000000184449A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MechanicusCandidateTeamCreateRsp ShallowCopy() => default; // 0x0000000184449390-0x0000000184449430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184448CD0-0x0000000184448D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184449B20-0x0000000184449B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184449B70-0x0000000184449BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184448D20-0x0000000184448DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184448E40-0x0000000184448F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MechanicusCandidateTeamCreateRsp other) => default; // 0x0000000184448F10-0x0000000184449050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001844495C0-0x00000001844496F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184449F60-0x000000018444A1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184449C20-0x0000000184449D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184449050-0x00000001844491D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MechanicusCandidateTeamCreateRsp other) {} // 0x0000000184448B70-0x0000000184448CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184448A00-0x0000000184448B10
}

