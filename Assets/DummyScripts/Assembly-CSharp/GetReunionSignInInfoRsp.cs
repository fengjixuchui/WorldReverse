/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetReunionSignInInfoRsp : MessageBase, IMessage<GetReunionSignInInfoRsp> // TypeDefIndex: 24822
{
	// Fields
	private static readonly MessageParser<GetReunionSignInInfoRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B07527
	private int retcode_; // 0x18
	public const int SignInInfoFieldNumber = 2; // Metadata: 0x00B0752B
	private ReunionSignInInfo signInInfo_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetReunionSignInInfoRsp> Parser { get => default; } // 0x0000000182FB5A40-0x0000000182FB5AD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182FB5730-0x0000000182FB57C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182FB53A0-0x0000000182FB5420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182FB4A90-0x0000000182FB4AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182FB5E30-0x0000000182FB5F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182FB5C60-0x0000000182FB5CC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182FB5860-0x0000000182FB5950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182FB5DE0-0x0000000182FB5E30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182FB54C0-0x0000000182FB55B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182FB5300-0x0000000182FB53A0 0x0000000182FB4EC0-0x0000000182FB4F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionSignInInfo SignInInfo { get => default; set {} } // 0x0000000182FB57C0-0x0000000182FB5860 0x0000000182FB4E20-0x0000000182FB4EC0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24823
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24824
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5056
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetReunionSignInInfoRsp() {} // 0x0000000182FB61C0-0x0000000182FB6220
	static GetReunionSignInInfoRsp() {} // 0x0000000182FB6100-0x0000000182FB61C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetReunionSignInInfoRsp Clone() => default; // 0x0000000182FB5950-0x0000000182FB5A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetReunionSignInInfoRsp ShallowCopy() => default; // 0x0000000182FB5420-0x0000000182FB54C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182FB4C70-0x0000000182FB4CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182FB5B60-0x0000000182FB5BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182FB5BE0-0x0000000182FB5C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182FB4CF0-0x0000000182FB4E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182FB5090-0x0000000182FB5160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetReunionSignInInfoRsp other) => default; // 0x0000000182FB4F60-0x0000000182FB5090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182FB55B0-0x0000000182FB5730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182FB5F20-0x0000000182FB6100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182FB5CC0-0x0000000182FB5DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182FB5160-0x0000000182FB5300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetReunionSignInInfoRsp other) {} // 0x0000000182FB4AF0-0x0000000182FB4C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182FB4950-0x0000000182FB4A90
}

