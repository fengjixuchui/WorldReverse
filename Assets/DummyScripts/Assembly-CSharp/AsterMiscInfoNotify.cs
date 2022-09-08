/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AsterMiscInfoNotify : MessageBase, IMessage<AsterMiscInfoNotify> // TypeDefIndex: 22019
{
	// Fields
	private static readonly MessageParser<AsterMiscInfoNotify> _parser; // 0x00
	public const int AsterCreditFieldNumber = 1; // Metadata: 0x00B00967
	private uint asterCredit_; // 0x18
	public const int AsterTokenFieldNumber = 2; // Metadata: 0x00B0096B
	private uint asterToken_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AsterMiscInfoNotify> Parser { get => default; } // 0x00000001823E7000-0x00000001823E7090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001823E6D90-0x00000001823E6E20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001823E6A80-0x00000001823E6B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001823E6290-0x00000001823E62F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001823E7390-0x00000001823E7480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001823E71C0-0x00000001823E7220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001823E6E20-0x00000001823E6F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001823E7340-0x00000001823E7390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001823E6BA0-0x00000001823E6C90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AsterCredit { get => default; set {} } // 0x00000001823E62F0-0x00000001823E6390 0x00000001823E66C0-0x00000001823E6760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AsterToken { get => default; set {} } // 0x00000001823E6390-0x00000001823E6430 0x00000001823E6620-0x00000001823E66C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22020
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22021
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2066
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterMiscInfoNotify() {} // 0x00000001823E7740-0x00000001823E77A0
	static AsterMiscInfoNotify() {} // 0x00000001823E7680-0x00000001823E7740

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterMiscInfoNotify Clone() => default; // 0x00000001823E6F10-0x00000001823E7000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterMiscInfoNotify ShallowCopy() => default; // 0x00000001823E6B00-0x00000001823E6BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001823E6560-0x00000001823E65B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823E7120-0x00000001823E7170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823E7170-0x00000001823E71C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001823E65B0-0x00000001823E6620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001823E6880-0x00000001823E6950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AsterMiscInfoNotify other) => default; // 0x00000001823E6760-0x00000001823E6880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001823E6C90-0x00000001823E6D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001823E7480-0x00000001823E7680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001823E7220-0x00000001823E7340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001823E6950-0x00000001823E6A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AsterMiscInfoNotify other) {} // 0x00000001823E6430-0x00000001823E6560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001823E6190-0x00000001823E6290
}

