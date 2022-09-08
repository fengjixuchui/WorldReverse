/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtFaceToDirNotify : MessageBase, IMessage<EvtFaceToDirNotify> // TypeDefIndex: 23016
{
	// Fields
	private static readonly MessageParser<EvtFaceToDirNotify> _parser; // 0x00
	public const int ForwardTypeFieldNumber = 1; // Metadata: 0x00B02F43
	private ForwardType forwardType_; // 0x18
	public const int EvtFaceToDirInfoFieldNumber = 2; // Metadata: 0x00B02F47
	private EvtFaceToDirInfo evtFaceToDirInfo_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtFaceToDirNotify> Parser { get => default; } // 0x00000001813ED500-0x00000001813ED590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001813ED290-0x00000001813ED320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001813ECEC0-0x00000001813ECF40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001813EC650-0x00000001813EC6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001813ED990-0x00000001813EDA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001813ED7C0-0x00000001813ED820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001813ED320-0x00000001813ED410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001813ED940-0x00000001813ED990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001813ECFE0-0x00000001813ED0D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForwardType ForwardType { get => default; set {} } // 0x00000001813ECE20-0x00000001813ECEC0 0x00000001813EC8B0-0x00000001813EC950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtFaceToDirInfo EvtFaceToDirInfo { get => default; set {} } // 0x00000001813EDA80-0x00000001813EDB20 0x00000001813ED620-0x00000001813ED6C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23017
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23018
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 308
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtFaceToDirNotify() {} // 0x00000001813EDDC0-0x00000001813EDE30
	static EvtFaceToDirNotify() {} // 0x00000001813EDD00-0x00000001813EDDC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtFaceToDirNotify Clone() => default; // 0x00000001813ED410-0x00000001813ED500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtFaceToDirNotify ShallowCopy() => default; // 0x00000001813ECF40-0x00000001813ECFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001813EC830-0x00000001813EC8B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001813ED6C0-0x00000001813ED740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001813ED740-0x00000001813ED7C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001813EC950-0x00000001813ECA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001813ECA80-0x00000001813ECB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtFaceToDirNotify other) => default; // 0x00000001813ECB50-0x00000001813ECC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001813ED0D0-0x00000001813ED290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001813EDB20-0x00000001813EDD00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001813ED820-0x00000001813ED940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001813ECC80-0x00000001813ECE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtFaceToDirNotify other) {} // 0x00000001813EC6B0-0x00000001813EC830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001813EC520-0x00000001813EC650
}

