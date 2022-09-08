/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtBeingHitNotify : MessageBase, IMessage<EvtBeingHitNotify> // TypeDefIndex: 22991
{
	// Fields
	private static readonly MessageParser<EvtBeingHitNotify> _parser; // 0x00
	public const int ForwardTypeFieldNumber = 1; // Metadata: 0x00B02E0F
	private ForwardType forwardType_; // 0x18
	public const int BeingHitInfoFieldNumber = 2; // Metadata: 0x00B02E13
	private EvtBeingHitInfo beingHitInfo_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtBeingHitNotify> Parser { get => default; } // 0x000000018126E6B0-0x000000018126E740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018126E440-0x000000018126E4D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018126E070-0x000000018126E0F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018126D6C0-0x000000018126D720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018126EAA0-0x000000018126EB90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018126E8D0-0x000000018126E930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018126E4D0-0x000000018126E5C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018126EA50-0x000000018126EAA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018126E190-0x000000018126E280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForwardType ForwardType { get => default; set {} } // 0x000000018126DFD0-0x000000018126E070 0x000000018126D9C0-0x000000018126DA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtBeingHitInfo BeingHitInfo { get => default; set {} } // 0x000000018126D8A0-0x000000018126D940 0x000000018126DF30-0x000000018126DFD0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22992
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22993
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 301
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtBeingHitNotify() {} // 0x000000018126EE30-0x000000018126EEA0
	static EvtBeingHitNotify() {} // 0x000000018126ED70-0x000000018126EE30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtBeingHitNotify Clone() => default; // 0x000000018126E5C0-0x000000018126E6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtBeingHitNotify ShallowCopy() => default; // 0x000000018126E0F0-0x000000018126E190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018126D940-0x000000018126D9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018126E7D0-0x000000018126E850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018126E850-0x000000018126E8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018126DA60-0x000000018126DB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018126DCC0-0x000000018126DD90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtBeingHitNotify other) => default; // 0x000000018126DB90-0x000000018126DCC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018126E280-0x000000018126E440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018126EB90-0x000000018126ED70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018126E930-0x000000018126EA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018126DD90-0x000000018126DF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtBeingHitNotify other) {} // 0x000000018126D720-0x000000018126D8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018126D590-0x000000018126D6C0
}

