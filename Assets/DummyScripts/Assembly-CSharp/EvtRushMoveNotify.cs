/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtRushMoveNotify : MessageBase, IMessage<EvtRushMoveNotify> // TypeDefIndex: 23039
{
	// Fields
	private static readonly MessageParser<EvtRushMoveNotify> _parser; // 0x00
	public const int ForwardTypeFieldNumber = 1; // Metadata: 0x00B0307F
	private ForwardType forwardType_; // 0x18
	public const int EvtRushMoveInfoFieldNumber = 2; // Metadata: 0x00B03083
	private EvtRushMoveInfo evtRushMoveInfo_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtRushMoveNotify> Parser { get => default; } // 0x0000000184FD0760-0x0000000184FD07F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184FD0450-0x0000000184FD04E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184FD0080-0x0000000184FD0100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184FCF770-0x0000000184FCF7D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184FD0B50-0x0000000184FD0C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184FD0980-0x0000000184FD09E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184FD04E0-0x0000000184FD05D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184FD0B00-0x0000000184FD0B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184FD01A0-0x0000000184FD0290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForwardType ForwardType { get => default; set {} } // 0x0000000184FCFFE0-0x0000000184FD0080 0x0000000184FCF9D0-0x0000000184FCFA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtRushMoveInfo EvtRushMoveInfo { get => default; set {} } // 0x0000000184FCFBA0-0x0000000184FCFC40 0x0000000184FD06C0-0x0000000184FD0760

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23040
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23041
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 312
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtRushMoveNotify() {} // 0x0000000184FD0EE0-0x0000000184FD0F50
	static EvtRushMoveNotify() {} // 0x0000000184FD0E20-0x0000000184FD0EE0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtRushMoveNotify Clone() => default; // 0x0000000184FD05D0-0x0000000184FD06C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtRushMoveNotify ShallowCopy() => default; // 0x0000000184FD0100-0x0000000184FD01A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184FCF950-0x0000000184FCF9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184FD0880-0x0000000184FD0900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184FD0900-0x0000000184FD0980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184FCFA70-0x0000000184FCFBA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184FCFC40-0x0000000184FCFD10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtRushMoveNotify other) => default; // 0x0000000184FCFD10-0x0000000184FCFE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184FD0290-0x0000000184FD0450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184FD0C40-0x0000000184FD0E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184FD09E0-0x0000000184FD0B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184FCFE40-0x0000000184FCFFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtRushMoveNotify other) {} // 0x0000000184FCF7D0-0x0000000184FCF950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184FCF640-0x0000000184FCF770
}

