/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtDestroyGadgetNotify : MessageBase, IMessage<EvtDestroyGadgetNotify> // TypeDefIndex: 23009
{
	// Fields
	private static readonly MessageParser<EvtDestroyGadgetNotify> _parser; // 0x00
	public const int ForwardTypeFieldNumber = 1; // Metadata: 0x00B02EFF
	private ForwardType forwardType_; // 0x18
	public const int EntityIdFieldNumber = 2; // Metadata: 0x00B02F03
	private uint entityId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtDestroyGadgetNotify> Parser { get => default; } // 0x0000000181EE25A0-0x0000000181EE2630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181EE2330-0x0000000181EE23C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181EE1FD0-0x0000000181EE2050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181EE1920-0x0000000181EE1980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181EE29D0-0x0000000181EE2AC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181EE2800-0x0000000181EE2860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181EE23C0-0x0000000181EE24B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181EE2980-0x0000000181EE29D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181EE20F0-0x0000000181EE21E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForwardType ForwardType { get => default; set {} } // 0x0000000181EE1F30-0x0000000181EE1FD0 0x0000000181EE1B00-0x0000000181EE1BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000181EE2760-0x0000000181EE2800 0x0000000181EE2AC0-0x0000000181EE2B60

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23010
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23011
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 306
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtDestroyGadgetNotify() {} // 0x0000000181EE2E20-0x0000000181EE2E90
	static EvtDestroyGadgetNotify() {} // 0x0000000181EE2D60-0x0000000181EE2E20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtDestroyGadgetNotify Clone() => default; // 0x0000000181EE24B0-0x0000000181EE25A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtDestroyGadgetNotify ShallowCopy() => default; // 0x0000000181EE2050-0x0000000181EE20F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181EE1AB0-0x0000000181EE1B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181EE26C0-0x0000000181EE2710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181EE2710-0x0000000181EE2760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181EE1BA0-0x0000000181EE1C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181EE1C10-0x0000000181EE1CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtDestroyGadgetNotify other) => default; // 0x0000000181EE1CE0-0x0000000181EE1E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181EE21E0-0x0000000181EE2330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181EE2B60-0x0000000181EE2D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181EE2860-0x0000000181EE2980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181EE1E00-0x0000000181EE1F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtDestroyGadgetNotify other) {} // 0x0000000181EE1980-0x0000000181EE1AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181EE1830-0x0000000181EE1920
}

