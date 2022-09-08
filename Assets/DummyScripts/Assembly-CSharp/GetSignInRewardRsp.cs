/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetSignInRewardRsp : MessageBase, IMessage<GetSignInRewardRsp> // TypeDefIndex: 25458
{
	// Fields
	private static readonly MessageParser<GetSignInRewardRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B08CF3
	private int retcode_; // 0x18
	public const int SignInInfoFieldNumber = 2; // Metadata: 0x00B08CF7
	private SignInInfo signInInfo_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetSignInRewardRsp> Parser { get => default; } // 0x0000000181647CA0-0x0000000181647D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181647990-0x0000000181647A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181647600-0x0000000181647680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181646CF0-0x0000000181646D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181648090-0x0000000181648180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181647EC0-0x0000000181647F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181647AC0-0x0000000181647BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181648040-0x0000000181648090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181647720-0x0000000181647810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181647560-0x0000000181647600 0x0000000181647120-0x00000001816471C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SignInInfo SignInInfo { get => default; set {} } // 0x0000000181647A20-0x0000000181647AC0 0x0000000181647080-0x0000000181647120

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25459
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25460
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2506
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetSignInRewardRsp() {} // 0x0000000181648420-0x0000000181648480
	static GetSignInRewardRsp() {} // 0x0000000181648360-0x0000000181648420

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetSignInRewardRsp Clone() => default; // 0x0000000181647BB0-0x0000000181647CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetSignInRewardRsp ShallowCopy() => default; // 0x0000000181647680-0x0000000181647720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181646ED0-0x0000000181646F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181647DC0-0x0000000181647E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181647E40-0x0000000181647EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181646F50-0x0000000181647080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001816472F0-0x00000001816473C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetSignInRewardRsp other) => default; // 0x00000001816471C0-0x00000001816472F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181647810-0x0000000181647990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181648180-0x0000000181648360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181647F20-0x0000000181648040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001816473C0-0x0000000181647560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetSignInRewardRsp other) {} // 0x0000000181646D50-0x0000000181646ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181646BB0-0x0000000181646CF0
}

