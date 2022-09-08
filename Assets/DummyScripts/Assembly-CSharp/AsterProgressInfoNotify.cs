/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AsterProgressInfoNotify : MessageBase, IMessage<AsterProgressInfoNotify> // TypeDefIndex: 22010
{
	// Fields
	private static readonly MessageParser<AsterProgressInfoNotify> _parser; // 0x00
	public const int InfoFieldNumber = 1; // Metadata: 0x00B0092B
	private AsterProgressDetailInfo info_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AsterProgressInfoNotify> Parser { get => default; } // 0x00000001817D47A0-0x00000001817D4830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001817D4530-0x00000001817D45C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001817D41D0-0x00000001817D4250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001817D3AA0-0x00000001817D3B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001817D4BF0-0x00000001817D4CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001817D4A60-0x00000001817D4AC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001817D45C0-0x00000001817D46B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001817D4BA0-0x00000001817D4BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001817D42F0-0x00000001817D43E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterProgressDetailInfo Info { get => default; set {} } // 0x00000001817D3E00-0x00000001817D3EA0 0x00000001817D49C0-0x00000001817D4A60

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22011
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22012
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2063
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterProgressInfoNotify() {} // 0x00000001817D4EF0-0x00000001817D4F50
	static AsterProgressInfoNotify() {} // 0x00000001817D4E30-0x00000001817D4EF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterProgressInfoNotify Clone() => default; // 0x00000001817D46B0-0x00000001817D47A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterProgressInfoNotify ShallowCopy() => default; // 0x00000001817D4250-0x00000001817D42F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001817D3C60-0x00000001817D3CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001817D48C0-0x00000001817D4940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001817D4940-0x00000001817D49C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001817D3CE0-0x00000001817D3E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001817D3EA0-0x00000001817D3F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AsterProgressInfoNotify other) => default; // 0x00000001817D3F70-0x00000001817D4080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001817D43E0-0x00000001817D4530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001817D4CE0-0x00000001817D4E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001817D4AC0-0x00000001817D4BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001817D4080-0x00000001817D41D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AsterProgressInfoNotify other) {} // 0x00000001817D3B00-0x00000001817D3C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001817D3990-0x00000001817D3AA0
}

