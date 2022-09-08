/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtFaceToEntityNotify : MessageBase, IMessage<EvtFaceToEntityNotify> // TypeDefIndex: 23012
{
	// Fields
	private static readonly MessageParser<EvtFaceToEntityNotify> _parser; // 0x00
	public const int ForwardTypeFieldNumber = 1; // Metadata: 0x00B02F1B
	private ForwardType forwardType_; // 0x18
	public const int EntityIdFieldNumber = 2; // Metadata: 0x00B02F1F
	private uint entityId_; // 0x1C
	public const int FaceEntityIdFieldNumber = 3; // Metadata: 0x00B02F23
	private uint faceEntityId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtFaceToEntityNotify> Parser { get => default; } // 0x0000000184D4E840-0x0000000184D4E8D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184D4E5D0-0x0000000184D4E660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184D4E250-0x0000000184D4E2D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184D4DA50-0x0000000184D4DAB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184D4ED50-0x0000000184D4EE40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184D4EB40-0x0000000184D4EBA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184D4E660-0x0000000184D4E750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184D4ED00-0x0000000184D4ED50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184D4E370-0x0000000184D4E460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForwardType ForwardType { get => default; set {} } // 0x0000000184D4E1B0-0x0000000184D4E250 0x0000000184D4DC60-0x0000000184D4DD00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000184D4EAA0-0x0000000184D4EB40 0x0000000184D4EE40-0x0000000184D4EEE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FaceEntityId { get => default; set {} } // 0x0000000184D4DF90-0x0000000184D4E030 0x0000000184D4E8D0-0x0000000184D4E970

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23013
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23014
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 307
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtFaceToEntityNotify() {} // 0x0000000184D4F230-0x0000000184D4F2A0
	static EvtFaceToEntityNotify() {} // 0x0000000184D4F170-0x0000000184D4F230

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtFaceToEntityNotify Clone() => default; // 0x0000000184D4E750-0x0000000184D4E840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtFaceToEntityNotify ShallowCopy() => default; // 0x0000000184D4E2D0-0x0000000184D4E370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184D4DC10-0x0000000184D4DC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184D4EA00-0x0000000184D4EA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184D4EA50-0x0000000184D4EAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184D4DD00-0x0000000184D4DD80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184D4DEC0-0x0000000184D4DF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtFaceToEntityNotify other) => default; // 0x0000000184D4DD80-0x0000000184D4DEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184D4E460-0x0000000184D4E5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184D4EEE0-0x0000000184D4F170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184D4EBA0-0x0000000184D4ED00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184D4E030-0x0000000184D4E1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtFaceToEntityNotify other) {} // 0x0000000184D4DAB0-0x0000000184D4DC10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184D4D940-0x0000000184D4DA50
}

