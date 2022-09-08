/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GmTalkReq : MessageBase, IMessage<GmTalkReq> // TypeDefIndex: 23954
{
	// Fields
	private static readonly MessageParser<GmTalkReq> _parser; // 0x00
	public const int MsgFieldNumber = 1; // Metadata: 0x00B05383
	private string msg_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GmTalkReq> Parser { get => default; } // 0x00000001830DB640-0x00000001830DB6D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001830DB3D0-0x00000001830DB460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001830DB020-0x00000001830DB0A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001830DAAE0-0x00000001830DAB40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001830DB9B0-0x00000001830DBAA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001830DB800-0x00000001830DB860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001830DB460-0x00000001830DB550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001830DB960-0x00000001830DB9B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001830DB140-0x00000001830DB230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Msg { get => default; set {} } // 0x00000001830DB330-0x00000001830DB3D0 0x00000001830DBAA0-0x00000001830DBB50

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23955
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23956
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GmTalkReq() {} // 0x00000001830DBD60-0x00000001830DBDD0
	static GmTalkReq() {} // 0x00000001830DBCA0-0x00000001830DBD60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GmTalkReq Clone() => default; // 0x00000001830DB550-0x00000001830DB640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GmTalkReq ShallowCopy() => default; // 0x00000001830DB0A0-0x00000001830DB140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001830DAC60-0x00000001830DACB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001830DB760-0x00000001830DB7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001830DB7B0-0x00000001830DB800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001830DACB0-0x00000001830DAD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001830DAD20-0x00000001830DADF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GmTalkReq other) => default; // 0x00000001830DADF0-0x00000001830DAF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001830DB230-0x00000001830DB330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001830DBB50-0x00000001830DBCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001830DB860-0x00000001830DB960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001830DAF20-0x00000001830DB020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GmTalkReq other) {} // 0x00000001830DAB40-0x00000001830DAC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001830DAA00-0x00000001830DAAE0
}

