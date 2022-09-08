/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ClientTransmitReq : MessageBase, IMessage<ClientTransmitReq> // TypeDefIndex: 25011
{
	// Fields
	private static readonly MessageParser<ClientTransmitReq> _parser; // 0x00
	public const int PosFieldNumber = 1; // Metadata: 0x00B07C4B
	private Vector pos_; // 0x18
	public const int RotFieldNumber = 2; // Metadata: 0x00B07C4F
	private Vector rot_; // 0x20
	public const int ReasonFieldNumber = 3; // Metadata: 0x00B07C53
	private TransmitReason reason_; // 0x28
	public const int SceneIdFieldNumber = 4; // Metadata: 0x00B07C57
	private uint sceneId_; // 0x2C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ClientTransmitReq> Parser { get => default; } // 0x000000018100E6C0-0x000000018100E750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018100E310-0x000000018100E3A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018100DE70-0x000000018100DEF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018100D200-0x000000018100D260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018100EC80-0x000000018100ED70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018100E9A0-0x000000018100EA00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018100E440-0x000000018100E530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018100EC30-0x000000018100EC80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018100DF90-0x000000018100E080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x000000018100E900-0x000000018100E9A0 0x000000018100EB90-0x000000018100EC30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Rot { get => default; set {} } // 0x000000018100E3A0-0x000000018100E440 0x000000018100D260-0x000000018100D300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TransmitReason Reason { get => default; set {} } // 0x000000018100E620-0x000000018100E6C0 0x000000018100D5B0-0x000000018100D650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x000000018100D850-0x000000018100D8F0 0x000000018100DDD0-0x000000018100DE70

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25012
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25013
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 240
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientTransmitReq() {} // 0x000000018100F110-0x000000018100F180
	static ClientTransmitReq() {} // 0x000000018100F050-0x000000018100F110

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientTransmitReq Clone() => default; // 0x000000018100E530-0x000000018100E620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientTransmitReq ShallowCopy() => default; // 0x000000018100DEF0-0x000000018100DF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018100D520-0x000000018100D5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018100E7E0-0x000000018100E870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018100E870-0x000000018100E900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018100D650-0x000000018100D850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018100DA70-0x000000018100DB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ClientTransmitReq other) => default; // 0x000000018100D8F0-0x000000018100DA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018100E080-0x000000018100E310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018100ED70-0x000000018100F050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018100EA00-0x000000018100EB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018100DB40-0x000000018100DDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ClientTransmitReq other) {} // 0x000000018100D300-0x000000018100D520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018100D060-0x000000018100D200
}

