/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AsterLittleInfoNotify : MessageBase, IMessage<AsterLittleInfoNotify> // TypeDefIndex: 22013
{
	// Fields
	private static readonly MessageParser<AsterLittleInfoNotify> _parser; // 0x00
	public const int InfoFieldNumber = 1; // Metadata: 0x00B0093F
	private AsterLittleDetailInfo info_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AsterLittleInfoNotify> Parser { get => default; } // 0x000000018226EC20-0x000000018226ECB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018226E9B0-0x000000018226EA40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018226E650-0x000000018226E6D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018226DF20-0x000000018226DF80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018226F070-0x000000018226F160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018226EEE0-0x000000018226EF40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018226EA40-0x000000018226EB30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018226F020-0x000000018226F070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018226E770-0x000000018226E860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterLittleDetailInfo Info { get => default; set {} } // 0x000000018226E280-0x000000018226E320 0x000000018226EE40-0x000000018226EEE0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22014
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22015
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2064
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterLittleInfoNotify() {} // 0x000000018226F370-0x000000018226F3D0
	static AsterLittleInfoNotify() {} // 0x000000018226F2B0-0x000000018226F370

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterLittleInfoNotify Clone() => default; // 0x000000018226EB30-0x000000018226EC20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterLittleInfoNotify ShallowCopy() => default; // 0x000000018226E6D0-0x000000018226E770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018226E0E0-0x000000018226E160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018226ED40-0x000000018226EDC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018226EDC0-0x000000018226EE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018226E160-0x000000018226E280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018226E430-0x000000018226E500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AsterLittleInfoNotify other) => default; // 0x000000018226E320-0x000000018226E430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018226E860-0x000000018226E9B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018226F160-0x000000018226F2B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018226EF40-0x000000018226F020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018226E500-0x000000018226E650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AsterLittleInfoNotify other) {} // 0x000000018226DF80-0x000000018226E0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018226DE10-0x000000018226DF20
}

