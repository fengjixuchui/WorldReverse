/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SaveCoopDialogReq : MessageBase, IMessage<SaveCoopDialogReq> // TypeDefIndex: 22747
{
	// Fields
	private static readonly MessageParser<SaveCoopDialogReq> _parser; // 0x00
	public const int MainCoopIdFieldNumber = 1; // Metadata: 0x00B02473
	private uint mainCoopId_; // 0x18
	public const int DialogIdFieldNumber = 2; // Metadata: 0x00B02477
	private uint dialogId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SaveCoopDialogReq> Parser { get => default; } // 0x0000000183618860-0x00000001836188F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183618550-0x00000001836185E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183618240-0x00000001836182C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183617AF0-0x0000000183617B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183618BF0-0x0000000183618CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183618A20-0x0000000183618A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183618680-0x0000000183618770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183618BA0-0x0000000183618BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183618360-0x0000000183618450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MainCoopId { get => default; set {} } // 0x0000000183617DE0-0x0000000183617E80 0x00000001836181A0-0x0000000183618240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DialogId { get => default; set {} } // 0x00000001836185E0-0x0000000183618680 0x0000000183617B50-0x0000000183617BF0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22748
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22749
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1971
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SaveCoopDialogReq() {} // 0x0000000183618FA0-0x0000000183619000
	static SaveCoopDialogReq() {} // 0x0000000183618EE0-0x0000000183618FA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SaveCoopDialogReq Clone() => default; // 0x0000000183618770-0x0000000183618860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SaveCoopDialogReq ShallowCopy() => default; // 0x00000001836182C0-0x0000000183618360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183617D20-0x0000000183617D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183618980-0x00000001836189D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001836189D0-0x0000000183618A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183617D70-0x0000000183617DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183617FA0-0x0000000183618070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SaveCoopDialogReq other) => default; // 0x0000000183617E80-0x0000000183617FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183618450-0x0000000183618550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183618CE0-0x0000000183618EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183618A80-0x0000000183618BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183618070-0x00000001836181A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SaveCoopDialogReq other) {} // 0x0000000183617BF0-0x0000000183617D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001836179F0-0x0000000183617AF0
}

