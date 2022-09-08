/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ForgeQueueManipulateReq : MessageBase, IMessage<ForgeQueueManipulateReq> // TypeDefIndex: 23718
{
	// Fields
	private static readonly MessageParser<ForgeQueueManipulateReq> _parser; // 0x00
	public const int ForgeQueueIdFieldNumber = 1; // Metadata: 0x00B04ADF
	private uint forgeQueueId_; // 0x18
	public const int ManipulateTypeFieldNumber = 2; // Metadata: 0x00B04AE3
	private ForgeQueueManipulateType manipulateType_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ForgeQueueManipulateReq> Parser { get => default; } // 0x0000000182356310-0x00000001823563A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001823560A0-0x0000000182356130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182355D40-0x0000000182355DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182355730-0x0000000182355790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182356880-0x0000000182356970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182356610-0x0000000182356670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182356130-0x0000000182356220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182356830-0x0000000182356880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182355E60-0x0000000182355F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ForgeQueueId { get => default; set {} } // 0x00000001823564D0-0x0000000182356570 0x0000000182356570-0x0000000182356610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForgeQueueManipulateType ManipulateType { get => default; set {} } // 0x0000000182356670-0x0000000182356710 0x0000000182355CA0-0x0000000182355D40

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23719
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23720
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 641
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForgeQueueManipulateReq() {} // 0x0000000182356C30-0x0000000182356CA0
	static ForgeQueueManipulateReq() {} // 0x0000000182356B70-0x0000000182356C30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForgeQueueManipulateReq Clone() => default; // 0x0000000182356220-0x0000000182356310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForgeQueueManipulateReq ShallowCopy() => default; // 0x0000000182355DC0-0x0000000182355E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001823558C0-0x0000000182355910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182356430-0x0000000182356480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182356480-0x00000001823564D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182355910-0x0000000182355980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182355AA0-0x0000000182355B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ForgeQueueManipulateReq other) => default; // 0x0000000182355980-0x0000000182355AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182355F50-0x00000001823560A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182356970-0x0000000182356B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182356710-0x0000000182356830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182355B70-0x0000000182355CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ForgeQueueManipulateReq other) {} // 0x0000000182355790-0x00000001823558C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182355640-0x0000000182355730
}

