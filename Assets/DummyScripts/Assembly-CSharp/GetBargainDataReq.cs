/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetBargainDataReq : MessageBase, IMessage<GetBargainDataReq> // TypeDefIndex: 24642
{
	// Fields
	private static readonly MessageParser<GetBargainDataReq> _parser; // 0x00
	public const int BargainIdFieldNumber = 1; // Metadata: 0x00B06E7F
	private uint bargainId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetBargainDataReq> Parser { get => default; } // 0x0000000183E2B650-0x0000000183E2B6E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183E2B3E0-0x0000000183E2B470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183E2B0F0-0x0000000183E2B170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183E2AB60-0x0000000183E2ABC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183E2B9A0-0x0000000183E2BA90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183E2B810-0x0000000183E2B870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183E2B470-0x0000000183E2B560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183E2B950-0x0000000183E2B9A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183E2B210-0x0000000183E2B300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BargainId { get => default; set {} } // 0x0000000183E2BA90-0x0000000183E2BB30 0x0000000183E2AD90-0x0000000183E2AE30

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24643
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24644
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 427
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetBargainDataReq() {} // 0x0000000183E2BD60-0x0000000183E2BDC0
	static GetBargainDataReq() {} // 0x0000000183E2BCA0-0x0000000183E2BD60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetBargainDataReq Clone() => default; // 0x0000000183E2B560-0x0000000183E2B650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetBargainDataReq ShallowCopy() => default; // 0x0000000183E2B170-0x0000000183E2B210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183E2ACD0-0x0000000183E2AD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E2B770-0x0000000183E2B7C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E2B7C0-0x0000000183E2B810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183E2AD20-0x0000000183E2AD90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183E2AE30-0x0000000183E2AF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetBargainDataReq other) => default; // 0x0000000183E2AF00-0x0000000183E2B000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183E2B300-0x0000000183E2B3E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183E2BB30-0x0000000183E2BCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183E2B870-0x0000000183E2B950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183E2B000-0x0000000183E2B0F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetBargainDataReq other) {} // 0x0000000183E2ABC0-0x0000000183E2ACD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183E2AA80-0x0000000183E2AB60
}

