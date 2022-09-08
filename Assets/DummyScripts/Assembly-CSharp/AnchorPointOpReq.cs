/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AnchorPointOpReq : MessageBase, IMessage<AnchorPointOpReq> // TypeDefIndex: 25811
{
	// Fields
	private static readonly MessageParser<AnchorPointOpReq> _parser; // 0x00
	public const int AnchorPointOpTypeFieldNumber = 1; // Metadata: 0x00B099EF
	private uint anchorPointOpType_; // 0x18
	public const int AnchorPointIdFieldNumber = 2; // Metadata: 0x00B099F3
	private uint anchorPointId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AnchorPointOpReq> Parser { get => default; } // 0x0000000184BC8C90-0x0000000184BC8D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184BC8A20-0x0000000184BC8AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184BC8710-0x0000000184BC8790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184BC7FC0-0x0000000184BC8020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184BC9020-0x0000000184BC9110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184BC8E50-0x0000000184BC8EB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184BC8AB0-0x0000000184BC8BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184BC8FD0-0x0000000184BC9020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184BC8830-0x0000000184BC8920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AnchorPointOpType { get => default; set {} } // 0x0000000184BC8670-0x0000000184BC8710 0x0000000184BC8020-0x0000000184BC80C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AnchorPointId { get => default; set {} } // 0x0000000184BC7E20-0x0000000184BC7EC0 0x0000000184BC82B0-0x0000000184BC8350

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25812
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25813
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4254
		}

		public enum AnchorPointOpType // TypeDefIndex: 25814
		{
			AnchorPointOpNone = 0,
			AnchorPointOpTeleport = 1,
			AnchorPointOpRemove = 2
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnchorPointOpReq() {} // 0x0000000184BC93D0-0x0000000184BC9430
	static AnchorPointOpReq() {} // 0x0000000184BC9310-0x0000000184BC93D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnchorPointOpReq Clone() => default; // 0x0000000184BC8BA0-0x0000000184BC8C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnchorPointOpReq ShallowCopy() => default; // 0x0000000184BC8790-0x0000000184BC8830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184BC81F0-0x0000000184BC8240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184BC8DB0-0x0000000184BC8E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184BC8E00-0x0000000184BC8E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184BC8240-0x0000000184BC82B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184BC8470-0x0000000184BC8540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AnchorPointOpReq other) => default; // 0x0000000184BC8350-0x0000000184BC8470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184BC8920-0x0000000184BC8A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184BC9110-0x0000000184BC9310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184BC8EB0-0x0000000184BC8FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184BC8540-0x0000000184BC8670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AnchorPointOpReq other) {} // 0x0000000184BC80C0-0x0000000184BC81F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184BC7EC0-0x0000000184BC7FC0
}

