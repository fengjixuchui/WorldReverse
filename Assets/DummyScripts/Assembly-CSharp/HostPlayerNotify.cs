/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HostPlayerNotify : MessageBase, IMessage<HostPlayerNotify> // TypeDefIndex: 23000
{
	// Fields
	private static readonly MessageParser<HostPlayerNotify> _parser; // 0x00
	public const int HostUidFieldNumber = 1; // Metadata: 0x00B02E73
	private uint hostUid_; // 0x18
	public const int HostPeerIdFieldNumber = 2; // Metadata: 0x00B02E77
	private uint hostPeerId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HostPlayerNotify> Parser { get => default; } // 0x0000000183ECEC70-0x0000000183ECED00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183ECE8C0-0x0000000183ECE950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183ECE5B0-0x0000000183ECE630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183ECDF00-0x0000000183ECDF60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183ECF000-0x0000000183ECF0F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183ECEE30-0x0000000183ECEE90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183ECE950-0x0000000183ECEA40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183ECEFB0-0x0000000183ECF000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183ECE6D0-0x0000000183ECE7C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint HostUid { get => default; set {} } // 0x0000000183ECDF60-0x0000000183ECE000 0x0000000183ECEB30-0x0000000183ECEBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint HostPeerId { get => default; set {} } // 0x0000000183ECEBD0-0x0000000183ECEC70 0x0000000183ECE3E0-0x0000000183ECE480

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23001
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23002
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 303
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HostPlayerNotify() {} // 0x0000000183ECF3B0-0x0000000183ECF410
	static HostPlayerNotify() {} // 0x0000000183ECF2F0-0x0000000183ECF3B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HostPlayerNotify Clone() => default; // 0x0000000183ECEA40-0x0000000183ECEB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HostPlayerNotify ShallowCopy() => default; // 0x0000000183ECE630-0x0000000183ECE6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183ECE130-0x0000000183ECE180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183ECED90-0x0000000183ECEDE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183ECEDE0-0x0000000183ECEE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183ECE180-0x0000000183ECE1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183ECE310-0x0000000183ECE3E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HostPlayerNotify other) => default; // 0x0000000183ECE1F0-0x0000000183ECE310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183ECE7C0-0x0000000183ECE8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183ECF0F0-0x0000000183ECF2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183ECEE90-0x0000000183ECEFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183ECE480-0x0000000183ECE5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HostPlayerNotify other) {} // 0x0000000183ECE000-0x0000000183ECE130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183ECDE00-0x0000000183ECDF00
}

