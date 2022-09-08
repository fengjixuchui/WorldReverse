/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetReunionPrivilegeInfoReq : MessageBase, IMessage<GetReunionPrivilegeInfoReq> // TypeDefIndex: 24852
{
	// Fields
	private static readonly MessageParser<GetReunionPrivilegeInfoReq> _parser; // 0x00
	public const int PrivilegeIdFieldNumber = 1; // Metadata: 0x00B0762F
	private uint privilegeId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetReunionPrivilegeInfoReq> Parser { get => default; } // 0x000000018335DE80-0x000000018335DF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018335DC10-0x000000018335DCA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018335D880-0x000000018335D900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018335D2F0-0x000000018335D350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018335E1D0-0x000000018335E2C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018335E040-0x000000018335E0A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018335DCA0-0x000000018335DD90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018335E180-0x000000018335E1D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018335DA40-0x000000018335DB30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PrivilegeId { get => default; set {} } // 0x000000018335D350-0x000000018335D3F0 0x000000018335D900-0x000000018335D9A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24853
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24854
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 5066
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetReunionPrivilegeInfoReq() {} // 0x000000018335E4F0-0x000000018335E550
	static GetReunionPrivilegeInfoReq() {} // 0x000000018335E430-0x000000018335E4F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetReunionPrivilegeInfoReq Clone() => default; // 0x000000018335DD90-0x000000018335DE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetReunionPrivilegeInfoReq ShallowCopy() => default; // 0x000000018335D9A0-0x000000018335DA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018335D500-0x000000018335D550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018335DFA0-0x000000018335DFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018335DFF0-0x000000018335E040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018335D550-0x000000018335D5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018335D5C0-0x000000018335D690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetReunionPrivilegeInfoReq other) => default; // 0x000000018335D690-0x000000018335D790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018335DB30-0x000000018335DC10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018335E2C0-0x000000018335E430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018335E0A0-0x000000018335E180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018335D790-0x000000018335D880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetReunionPrivilegeInfoReq other) {} // 0x000000018335D3F0-0x000000018335D500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018335D210-0x000000018335D2F0
}

