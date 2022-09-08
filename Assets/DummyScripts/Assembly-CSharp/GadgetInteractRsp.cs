/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GadgetInteractRsp : MessageBase, IMessage<GadgetInteractRsp> // TypeDefIndex: 23179
{
	// Fields
	private static readonly MessageParser<GadgetInteractRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B036A7
	private int retcode_; // 0x18
	public const int GadgetEntityIdFieldNumber = 2; // Metadata: 0x00B036AB
	private uint gadgetEntityId_; // 0x1C
	public const int InteractTypeFieldNumber = 3; // Metadata: 0x00B036AF
	private InteractType interactType_; // 0x20
	public const int OpTypeFieldNumber = 4; // Metadata: 0x00B036B3
	private InterOpType opType_; // 0x24
	public const int GadgetIdFieldNumber = 5; // Metadata: 0x00B036B7
	private uint gadgetId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GadgetInteractRsp> Parser { get => default; } // 0x0000000184B2CB40-0x0000000184B2CBD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184B2C8D0-0x0000000184B2C960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184B2C360-0x0000000184B2C3E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184B2B850-0x0000000184B2B8B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184B2D030-0x0000000184B2D120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184B2CD00-0x0000000184B2CD60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184B2C960-0x0000000184B2CA50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184B2CFE0-0x0000000184B2D030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184B2C520-0x0000000184B2C610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184B2C2C0-0x0000000184B2C360 0x0000000184B2BD30-0x0000000184B2BDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetEntityId { get => default; set {} } // 0x0000000184B2CD60-0x0000000184B2CE00 0x0000000184B2B8B0-0x0000000184B2B950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InteractType InteractType { get => default; set {} } // 0x0000000184B2BC90-0x0000000184B2BD30 0x0000000184B2C480-0x0000000184B2C520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InterOpType OpType { get => default; set {} } // 0x0000000184B2BB00-0x0000000184B2BBA0 0x0000000184B2B7B0-0x0000000184B2B850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetId { get => default; set {} } // 0x0000000184B2C220-0x0000000184B2C2C0 0x0000000184B2C830-0x0000000184B2C8D0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23180
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23181
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 802
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetInteractRsp() {} // 0x0000000184B2D580-0x0000000184B2D5F0
	static GadgetInteractRsp() {} // 0x0000000184B2D4C0-0x0000000184B2D580

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetInteractRsp Clone() => default; // 0x0000000184B2CA50-0x0000000184B2CB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetInteractRsp ShallowCopy() => default; // 0x0000000184B2C3E0-0x0000000184B2C480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184B2BBA0-0x0000000184B2BBF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B2CC60-0x0000000184B2CCB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B2CCB0-0x0000000184B2CD00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184B2BBF0-0x0000000184B2BC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184B2BF40-0x0000000184B2C010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GadgetInteractRsp other) => default; // 0x0000000184B2BDD0-0x0000000184B2BF40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184B2C610-0x0000000184B2C830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184B2D120-0x0000000184B2D4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184B2CE00-0x0000000184B2CFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184B2C010-0x0000000184B2C220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GadgetInteractRsp other) {} // 0x0000000184B2B950-0x0000000184B2BB00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184B2B670-0x0000000184B2B7B0
}

