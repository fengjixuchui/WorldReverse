/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ExecuteGroupTriggerReq : MessageBase, IMessage<ExecuteGroupTriggerReq> // TypeDefIndex: 25052
{
	// Fields
	private static readonly MessageParser<ExecuteGroupTriggerReq> _parser; // 0x00
	public const int SourceEntityIdFieldNumber = 1; // Metadata: 0x00B07DE3
	private uint sourceEntityId_; // 0x18
	public const int SourceNameFieldNumber = 2; // Metadata: 0x00B07DE7
	private string sourceName_; // 0x20
	public const int TargetEntityIdFieldNumber = 3; // Metadata: 0x00B07DEB
	private uint targetEntityId_; // 0x28
	public const int Param1FieldNumber = 4; // Metadata: 0x00B07DEF
	private int param1_; // 0x2C
	public const int Param2FieldNumber = 5; // Metadata: 0x00B07DF3
	private int param2_; // 0x30
	public const int Param3FieldNumber = 6; // Metadata: 0x00B07DF7
	private int param3_; // 0x34

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ExecuteGroupTriggerReq> Parser { get => default; } // 0x00000001841BC4A0-0x00000001841BC530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001841BC230-0x00000001841BC2C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001841BBDA0-0x00000001841BBE20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001841BB180-0x00000001841BB1E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001841BCC80-0x00000001841BCD70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001841BC7A0-0x00000001841BC800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001841BC2C0-0x00000001841BC3B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001841BCAE0-0x00000001841BCB30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001841BBEC0-0x00000001841BBFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SourceEntityId { get => default; set {} } // 0x00000001841BB1E0-0x00000001841BB280 0x00000001841BBD00-0x00000001841BBDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string SourceName { get => default; set {} } // 0x00000001841BB610-0x00000001841BB6B0 0x00000001841BCB30-0x00000001841BCBE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetEntityId { get => default; set {} } // 0x00000001841BCBE0-0x00000001841BCC80 0x00000001841BC700-0x00000001841BC7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Param1 { get => default; set {} } // 0x00000001841BC610-0x00000001841BC6B0 0x00000001841BC190-0x00000001841BC230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Param2 { get => default; set {} } // 0x00000001841BB6B0-0x00000001841BB750 0x00000001841BB570-0x00000001841BB610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Param3 { get => default; set {} } // 0x00000001841BB750-0x00000001841BB7F0 0x00000001841BC800-0x00000001841BC8A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25053
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25054
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 253
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExecuteGroupTriggerReq() {} // 0x00000001841BD240-0x00000001841BD2B0
	static ExecuteGroupTriggerReq() {} // 0x00000001841BD180-0x00000001841BD240

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExecuteGroupTriggerReq Clone() => default; // 0x00000001841BC3B0-0x00000001841BC4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExecuteGroupTriggerReq ShallowCopy() => default; // 0x00000001841BBE20-0x00000001841BBEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001841BB470-0x00000001841BB4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001841BC5C0-0x00000001841BC610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001841BC6B0-0x00000001841BC700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001841BB4C0-0x00000001841BB570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001841BB7F0-0x00000001841BB8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ExecuteGroupTriggerReq other) => default; // 0x00000001841BB8C0-0x00000001841BBA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001841BBFB0-0x00000001841BC190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001841BCD70-0x00000001841BD180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001841BC8A0-0x00000001841BCAE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001841BBA80-0x00000001841BBD00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ExecuteGroupTriggerReq other) {} // 0x00000001841BB280-0x00000001841BB470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001841BB010-0x00000001841BB180
}

