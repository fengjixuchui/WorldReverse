/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AnchorPointOpRsp : MessageBase, IMessage<AnchorPointOpRsp> // TypeDefIndex: 25815
{
	// Fields
	private static readonly MessageParser<AnchorPointOpRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B09A17
	private int retcode_; // 0x18
	public const int AnchorPointOpTypeFieldNumber = 2; // Metadata: 0x00B09A1B
	private uint anchorPointOpType_; // 0x1C
	public const int AnchorPointIdFieldNumber = 3; // Metadata: 0x00B09A1F
	private uint anchorPointId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AnchorPointOpRsp> Parser { get => default; } // 0x0000000182E8CE80-0x0000000182E8CF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182E8CC10-0x0000000182E8CCA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182E8C8D0-0x0000000182E8C950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182E8BF90-0x0000000182E8BFF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182E8D250-0x0000000182E8D340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182E8D040-0x0000000182E8D0A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182E8CCA0-0x0000000182E8CD90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182E8D200-0x0000000182E8D250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182E8C9F0-0x0000000182E8CAE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182E8C790-0x0000000182E8C830 0x0000000182E8C360-0x0000000182E8C400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AnchorPointOpType { get => default; set {} } // 0x0000000182E8C830-0x0000000182E8C8D0 0x0000000182E8BFF0-0x0000000182E8C090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AnchorPointId { get => default; set {} } // 0x0000000182E8BDE0-0x0000000182E8BE80 0x0000000182E8C2C0-0x0000000182E8C360

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25816
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25817
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4255
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnchorPointOpRsp() {} // 0x0000000182E8D690-0x0000000182E8D6F0
	static AnchorPointOpRsp() {} // 0x0000000182E8D5D0-0x0000000182E8D690

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnchorPointOpRsp Clone() => default; // 0x0000000182E8CD90-0x0000000182E8CE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnchorPointOpRsp ShallowCopy() => default; // 0x0000000182E8C950-0x0000000182E8C9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182E8C1F0-0x0000000182E8C240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E8CFA0-0x0000000182E8CFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E8CFF0-0x0000000182E8D040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182E8C240-0x0000000182E8C2C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182E8C400-0x0000000182E8C4D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AnchorPointOpRsp other) => default; // 0x0000000182E8C4D0-0x0000000182E8C610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182E8CAE0-0x0000000182E8CC10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182E8D340-0x0000000182E8D5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182E8D0A0-0x0000000182E8D200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182E8C610-0x0000000182E8C790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AnchorPointOpRsp other) {} // 0x0000000182E8C090-0x0000000182E8C1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182E8BE80-0x0000000182E8BF90
}

