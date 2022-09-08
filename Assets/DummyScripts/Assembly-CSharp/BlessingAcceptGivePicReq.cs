/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BlessingAcceptGivePicReq : MessageBase, IMessage<BlessingAcceptGivePicReq> // TypeDefIndex: 22143
{
	// Fields
	private static readonly MessageParser<BlessingAcceptGivePicReq> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B00E4F
	private uint uid_; // 0x18
	public const int IndexFieldNumber = 2; // Metadata: 0x00B00E53
	private uint index_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BlessingAcceptGivePicReq> Parser { get => default; } // 0x0000000181471D00-0x0000000181471D90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001814719F0-0x0000000181471A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181471640-0x00000001814716C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181470F90-0x0000000181470FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181472090-0x0000000181472180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181471EC0-0x0000000181471F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181471B20-0x0000000181471C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181472040-0x0000000181472090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181471760-0x0000000181471850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x00000001814715A0-0x0000000181471640 0x0000000181471A80-0x0000000181471B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Index { get => default; set {} } // 0x0000000181471500-0x00000001814715A0 0x0000000181471950-0x00000001814719F0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22144
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22145
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2149
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingAcceptGivePicReq() {} // 0x0000000181472440-0x00000001814724A0
	static BlessingAcceptGivePicReq() {} // 0x0000000181472380-0x0000000181472440

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingAcceptGivePicReq Clone() => default; // 0x0000000181471C10-0x0000000181471D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingAcceptGivePicReq ShallowCopy() => default; // 0x00000001814716C0-0x0000000181471760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181471120-0x0000000181471170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181471E20-0x0000000181471E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181471E70-0x0000000181471EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181471170-0x00000001814711E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001814711E0-0x00000001814712B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BlessingAcceptGivePicReq other) => default; // 0x00000001814712B0-0x00000001814713D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181471850-0x0000000181471950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181472180-0x0000000181472380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181471F20-0x0000000181472040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001814713D0-0x0000000181471500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BlessingAcceptGivePicReq other) {} // 0x0000000181470FF0-0x0000000181471120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181470E90-0x0000000181470F90
}

