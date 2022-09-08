/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ClientTransmitRsp : MessageBase, IMessage<ClientTransmitRsp> // TypeDefIndex: 25014
{
	// Fields
	private static readonly MessageParser<ClientTransmitRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B07C6F
	private int retcode_; // 0x18
	public const int ReasonFieldNumber = 2; // Metadata: 0x00B07C73
	private TransmitReason reason_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ClientTransmitRsp> Parser { get => default; } // 0x0000000183C2D4A0-0x0000000183C2D530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183C2D190-0x0000000183C2D220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183C2CE30-0x0000000183C2CEB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183C2C6E0-0x0000000183C2C740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183C2D830-0x0000000183C2D920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183C2D660-0x0000000183C2D6C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183C2D220-0x0000000183C2D310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183C2D7E0-0x0000000183C2D830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183C2CF50-0x0000000183C2D040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183C2CD90-0x0000000183C2CE30 0x0000000183C2C9D0-0x0000000183C2CA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TransmitReason Reason { get => default; set {} } // 0x0000000183C2D400-0x0000000183C2D4A0 0x0000000183C2C8C0-0x0000000183C2C960

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25015
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25016
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 241
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientTransmitRsp() {} // 0x0000000183C2DBE0-0x0000000183C2DC50
	static ClientTransmitRsp() {} // 0x0000000183C2DB20-0x0000000183C2DBE0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientTransmitRsp Clone() => default; // 0x0000000183C2D310-0x0000000183C2D400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientTransmitRsp ShallowCopy() => default; // 0x0000000183C2CEB0-0x0000000183C2CF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183C2C870-0x0000000183C2C8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C2D5C0-0x0000000183C2D610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C2D610-0x0000000183C2D660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183C2C960-0x0000000183C2C9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183C2CA70-0x0000000183C2CB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ClientTransmitRsp other) => default; // 0x0000000183C2CB40-0x0000000183C2CC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183C2D040-0x0000000183C2D190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183C2D920-0x0000000183C2DB20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183C2D6C0-0x0000000183C2D7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183C2CC60-0x0000000183C2CD90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ClientTransmitRsp other) {} // 0x0000000183C2C740-0x0000000183C2C870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183C2C5F0-0x0000000183C2C6E0
}

