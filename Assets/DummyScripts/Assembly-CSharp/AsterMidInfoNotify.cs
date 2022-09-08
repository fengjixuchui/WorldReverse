/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AsterMidInfoNotify : MessageBase, IMessage<AsterMidInfoNotify> // TypeDefIndex: 22016
{
	// Fields
	private static readonly MessageParser<AsterMidInfoNotify> _parser; // 0x00
	public const int InfoFieldNumber = 1; // Metadata: 0x00B00953
	private AsterMidDetailInfo info_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AsterMidInfoNotify> Parser { get => default; } // 0x000000018462B1E0-0x000000018462B270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018462AF70-0x000000018462B000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018462AC10-0x000000018462AC90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018462A4E0-0x000000018462A540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018462B630-0x000000018462B720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018462B4A0-0x000000018462B500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018462B000-0x000000018462B0F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018462B5E0-0x000000018462B630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018462AD30-0x000000018462AE20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterMidDetailInfo Info { get => default; set {} } // 0x000000018462A840-0x000000018462A8E0 0x000000018462B400-0x000000018462B4A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22017
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22018
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2065
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterMidInfoNotify() {} // 0x000000018462B930-0x000000018462B990
	static AsterMidInfoNotify() {} // 0x000000018462B870-0x000000018462B930

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterMidInfoNotify Clone() => default; // 0x000000018462B0F0-0x000000018462B1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterMidInfoNotify ShallowCopy() => default; // 0x000000018462AC90-0x000000018462AD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018462A6A0-0x000000018462A720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018462B300-0x000000018462B380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018462B380-0x000000018462B400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018462A720-0x000000018462A840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018462A9F0-0x000000018462AAC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AsterMidInfoNotify other) => default; // 0x000000018462A8E0-0x000000018462A9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018462AE20-0x000000018462AF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018462B720-0x000000018462B870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018462B500-0x000000018462B5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018462AAC0-0x000000018462AC10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AsterMidInfoNotify other) {} // 0x000000018462A540-0x000000018462A6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018462A3D0-0x000000018462A4E0
}

