/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetReunionMissionInfoReq : MessageBase, IMessage<GetReunionMissionInfoReq> // TypeDefIndex: 24831
{
	// Fields
	private static readonly MessageParser<GetReunionMissionInfoReq> _parser; // 0x00
	public const int MissionIdFieldNumber = 1; // Metadata: 0x00B07573
	private uint missionId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetReunionMissionInfoReq> Parser { get => default; } // 0x00000001818CFDA0-0x00000001818CFE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001818CFA90-0x00000001818CFB20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001818CF7A0-0x00000001818CF820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001818CF210-0x00000001818CF270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001818D00F0-0x00000001818D01E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001818CFF60-0x00000001818CFFC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001818CFBC0-0x00000001818CFCB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001818D00A0-0x00000001818D00F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001818CF8C0-0x00000001818CF9B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MissionId { get => default; set {} } // 0x00000001818CF270-0x00000001818CF310 0x00000001818CFB20-0x00000001818CFBC0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24832
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24833
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 5059
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetReunionMissionInfoReq() {} // 0x00000001818D0410-0x00000001818D0470
	static GetReunionMissionInfoReq() {} // 0x00000001818D0350-0x00000001818D0410

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetReunionMissionInfoReq Clone() => default; // 0x00000001818CFCB0-0x00000001818CFDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetReunionMissionInfoReq ShallowCopy() => default; // 0x00000001818CF820-0x00000001818CF8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001818CF420-0x00000001818CF470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818CFEC0-0x00000001818CFF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818CFF10-0x00000001818CFF60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001818CF470-0x00000001818CF4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001818CF5E0-0x00000001818CF6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetReunionMissionInfoReq other) => default; // 0x00000001818CF4E0-0x00000001818CF5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001818CF9B0-0x00000001818CFA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001818D01E0-0x00000001818D0350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001818CFFC0-0x00000001818D00A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001818CF6B0-0x00000001818CF7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetReunionMissionInfoReq other) {} // 0x00000001818CF310-0x00000001818CF420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001818CF130-0x00000001818CF210
}

