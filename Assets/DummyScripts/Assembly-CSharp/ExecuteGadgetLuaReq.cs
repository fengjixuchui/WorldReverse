/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ExecuteGadgetLuaReq : MessageBase, IMessage<ExecuteGadgetLuaReq> // TypeDefIndex: 25179
{
	// Fields
	private static readonly MessageParser<ExecuteGadgetLuaReq> _parser; // 0x00
	public const int SourceEntityIdFieldNumber = 1; // Metadata: 0x00B08267
	private uint sourceEntityId_; // 0x18
	public const int Param1FieldNumber = 2; // Metadata: 0x00B0826B
	private int param1_; // 0x1C
	public const int Param2FieldNumber = 3; // Metadata: 0x00B0826F
	private int param2_; // 0x20
	public const int Param3FieldNumber = 4; // Metadata: 0x00B08273
	private int param3_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ExecuteGadgetLuaReq> Parser { get => default; } // 0x000000018458C2F0-0x000000018458C380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018458C080-0x000000018458C110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018458BC70-0x000000018458BCF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018458B2A0-0x000000018458B300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018458C840-0x000000018458C930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018458C550-0x000000018458C5B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018458C110-0x000000018458C200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018458C7F0-0x000000018458C840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018458BD90-0x000000018458BE80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SourceEntityId { get => default; set {} } // 0x000000018458B300-0x000000018458B3A0 0x000000018458BBD0-0x000000018458BC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Param1 { get => default; set {} } // 0x000000018458C460-0x000000018458C500 0x000000018458BFE0-0x000000018458C080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Param2 { get => default; set {} } // 0x000000018458B6A0-0x000000018458B740 0x000000018458B600-0x000000018458B6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Param3 { get => default; set {} } // 0x000000018458B740-0x000000018458B7E0 0x000000018458C5B0-0x000000018458C650

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25180
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25181
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 293
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExecuteGadgetLuaReq() {} // 0x000000018458CD10-0x000000018458CD70
	static ExecuteGadgetLuaReq() {} // 0x000000018458CC50-0x000000018458CD10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExecuteGadgetLuaReq Clone() => default; // 0x000000018458C200-0x000000018458C2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExecuteGadgetLuaReq ShallowCopy() => default; // 0x000000018458BCF0-0x000000018458BD90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018458B520-0x000000018458B570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018458C410-0x000000018458C460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018458C500-0x000000018458C550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018458B570-0x000000018458B600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018458B930-0x000000018458BA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ExecuteGadgetLuaReq other) => default; // 0x000000018458B7E0-0x000000018458B930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018458BE80-0x000000018458BFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018458C930-0x000000018458CC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018458C650-0x000000018458C7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018458BA00-0x000000018458BBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ExecuteGadgetLuaReq other) {} // 0x000000018458B3A0-0x000000018458B520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018458B170-0x000000018458B2A0
}

