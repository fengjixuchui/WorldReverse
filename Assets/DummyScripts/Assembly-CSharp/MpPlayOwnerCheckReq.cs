/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MpPlayOwnerCheckReq : MessageBase, IMessage<MpPlayOwnerCheckReq> // TypeDefIndex: 24066
{
	// Fields
	private static readonly MessageParser<MpPlayOwnerCheckReq> _parser; // 0x00
	public const int MpPlayIdFieldNumber = 1; // Metadata: 0x00B057AB
	private uint mpPlayId_; // 0x18
	public const int IsSkipMatchFieldNumber = 2; // Metadata: 0x00B057AF
	private bool isSkipMatch_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MpPlayOwnerCheckReq> Parser { get => default; } // 0x000000018301D960-0x000000018301D9F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018301D650-0x000000018301D6E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018301D290-0x000000018301D310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018301CCB0-0x000000018301CD10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018301DD90-0x000000018301DE80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018301DB20-0x000000018301DB80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018301D780-0x000000018301D870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018301DD40-0x000000018301DD90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018301D3B0-0x000000018301D4A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MpPlayId { get => default; set {} } // 0x000000018301D5B0-0x000000018301D650 0x000000018301CF00-0x000000018301CFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsSkipMatch { get => default; set {} } // 0x000000018301DCA0-0x000000018301DD40 0x000000018301D6E0-0x000000018301D780

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24067
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24068
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1815
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpPlayOwnerCheckReq() {} // 0x000000018301E140-0x000000018301E1A0
	static MpPlayOwnerCheckReq() {} // 0x000000018301E080-0x000000018301E140

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpPlayOwnerCheckReq Clone() => default; // 0x000000018301D870-0x000000018301D960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpPlayOwnerCheckReq ShallowCopy() => default; // 0x000000018301D310-0x000000018301D3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018301CE40-0x000000018301CE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018301DA80-0x000000018301DAD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018301DAD0-0x000000018301DB20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018301CE90-0x000000018301CF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018301D0C0-0x000000018301D190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MpPlayOwnerCheckReq other) => default; // 0x000000018301CFA0-0x000000018301D0C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018301D4A0-0x000000018301D5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018301DE80-0x000000018301E080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018301DB80-0x000000018301DCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018301D190-0x000000018301D290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MpPlayOwnerCheckReq other) {} // 0x000000018301CD10-0x000000018301CE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018301CBB0-0x000000018301CCB0
}

