/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class RemoveRandTaskInfoNotify : MessageBase, IMessage<RemoveRandTaskInfoNotify> // TypeDefIndex: 24454
{
	// Fields
	private static readonly MessageParser<RemoveRandTaskInfoNotify> _parser; // 0x00
	public const int RandTaskIdFieldNumber = 1; // Metadata: 0x00B06783
	private uint randTaskId_; // 0x18
	public const int IsSuccFieldNumber = 2; // Metadata: 0x00B06787
	private bool isSucc_; // 0x1C
	public const int ReasonFieldNumber = 3; // Metadata: 0x00B0678B
	private Types.FinishReason reason_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<RemoveRandTaskInfoNotify> Parser { get => default; } // 0x0000000183B075F0-0x0000000183B07680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183B07240-0x0000000183B072D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183B06EB0-0x0000000183B06F30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183B06790-0x0000000183B067F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183B07A60-0x0000000183B07B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183B07850-0x0000000183B078B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183B072D0-0x0000000183B073C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183B07A10-0x0000000183B07A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183B06FD0-0x0000000183B070C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RandTaskId { get => default; set {} } // 0x0000000183B074B0-0x0000000183B07550 0x0000000183B07B50-0x0000000183B07BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsSucc { get => default; set {} } // 0x0000000183B07710-0x0000000183B077B0 0x0000000183B06E10-0x0000000183B06EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.FinishReason Reason { get => default; set {} } // 0x0000000183B07550-0x0000000183B075F0 0x0000000183B069A0-0x0000000183B06A40

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24455
	{
		// Nested types
		public enum FinishReason // TypeDefIndex: 24456
		{
			Default = 0,
			Clear = 1,
			Distance = 2,
			Finish = 3
		}

		public enum CmdId // TypeDefIndex: 24457
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 151
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RemoveRandTaskInfoNotify() {} // 0x0000000183B07F40-0x0000000183B07FB0
	static RemoveRandTaskInfoNotify() {} // 0x0000000183B07E80-0x0000000183B07F40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RemoveRandTaskInfoNotify Clone() => default; // 0x0000000183B073C0-0x0000000183B074B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RemoveRandTaskInfoNotify ShallowCopy() => default; // 0x0000000183B06F30-0x0000000183B06FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183B06950-0x0000000183B069A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B077B0-0x0000000183B07800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B07800-0x0000000183B07850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183B06A40-0x0000000183B06AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183B06AC0-0x0000000183B06B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(RemoveRandTaskInfoNotify other) => default; // 0x0000000183B06B90-0x0000000183B06CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183B070C0-0x0000000183B07240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183B07BF0-0x0000000183B07E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183B078B0-0x0000000183B07A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183B06CD0-0x0000000183B06E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(RemoveRandTaskInfoNotify other) {} // 0x0000000183B067F0-0x0000000183B06950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183B06680-0x0000000183B06790
}

