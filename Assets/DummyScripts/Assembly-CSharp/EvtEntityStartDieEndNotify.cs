/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtEntityStartDieEndNotify : MessageBase, IMessage<EvtEntityStartDieEndNotify> // TypeDefIndex: 23048
{
	// Fields
	private static readonly MessageParser<EvtEntityStartDieEndNotify> _parser; // 0x00
	public const int ForwardTypeFieldNumber = 1; // Metadata: 0x00B030EF
	private ForwardType forwardType_; // 0x18
	public const int EntityIdFieldNumber = 2; // Metadata: 0x00B030F3
	private uint entityId_; // 0x1C
	public const int ImmediatelyFieldNumber = 3; // Metadata: 0x00B030F7
	private bool immediately_; // 0x20
	public const int DieStateFlagFieldNumber = 4; // Metadata: 0x00B030FB
	private uint dieStateFlag_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtEntityStartDieEndNotify> Parser { get => default; } // 0x00000001828639A0-0x0000000182863A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182863690-0x0000000182863720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001828632E0-0x0000000182863360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001828629E0-0x0000000182862A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182863EF0-0x0000000182863FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182863CA0-0x0000000182863D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182863720-0x0000000182863810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182863EA0-0x0000000182863EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182863400-0x00000001828634F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForwardType ForwardType { get => default; set {} } // 0x0000000182863240-0x00000001828632E0 0x0000000182862CB0-0x0000000182862D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000182863B60-0x0000000182863C00 0x0000000182863FE0-0x0000000182864080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Immediately { get => default; set {} } // 0x00000001828631A0-0x0000000182863240 0x0000000182862BC0-0x0000000182862C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DieStateFlag { get => default; set {} } // 0x0000000182863C00-0x0000000182863CA0 0x0000000182863900-0x00000001828639A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23049
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23050
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 315
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtEntityStartDieEndNotify() {} // 0x0000000182864460-0x00000001828644D0
	static EvtEntityStartDieEndNotify() {} // 0x00000001828643A0-0x0000000182864460

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtEntityStartDieEndNotify Clone() => default; // 0x0000000182863810-0x0000000182863900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtEntityStartDieEndNotify ShallowCopy() => default; // 0x0000000182863360-0x0000000182863400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182862C60-0x0000000182862CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182863AC0-0x0000000182863B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182863B10-0x0000000182863B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182862D50-0x0000000182862DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182862DE0-0x0000000182862EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtEntityStartDieEndNotify other) => default; // 0x0000000182862EB0-0x0000000182863010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001828634F0-0x0000000182863690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182864080-0x00000001828643A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182863D00-0x0000000182863EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182863010-0x00000001828631A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtEntityStartDieEndNotify other) {} // 0x0000000182862A40-0x0000000182862BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001828628C0-0x00000001828629E0
}

