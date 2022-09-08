/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SignInInfoRsp : MessageBase, IMessage<SignInInfoRsp> // TypeDefIndex: 25452
{
	// Fields
	private static readonly MessageParser<SignInInfoRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B08CBF
	private int retcode_; // 0x18
	public const int SignInInfoListFieldNumber = 2; // Metadata: 0x00B08CC3
	private static readonly FieldCodec<SignInInfo> _repeated_signInInfoList_codec; // 0x08
	private readonly RepeatedMessageField<SignInInfo> signInInfoList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SignInInfoRsp> Parser { get => default; } // 0x00000001825FAE30-0x00000001825FAEC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001825FABC0-0x00000001825FAC50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001825FA8B0-0x00000001825FA930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001825FA0E0-0x00000001825FA140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001825FB260-0x00000001825FB350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001825FB070-0x00000001825FB0D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001825FAC50-0x00000001825FAD40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001825FB210-0x00000001825FB260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001825FA9D0-0x00000001825FAAC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001825FA7B0-0x00000001825FA850 0x00000001825FA3D0-0x00000001825FA470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<SignInInfo> SignInInfoList { get => default; } // 0x00000001825FA850-0x00000001825FA8B0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25453
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25454
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2504
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SignInInfoRsp() {} // 0x00000001825FB640-0x00000001825FB6D0
	static SignInInfoRsp() {} // 0x00000001825FB530-0x00000001825FB640

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SignInInfoRsp Clone() => default; // 0x00000001825FAD40-0x00000001825FAE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SignInInfoRsp ShallowCopy() => default; // 0x00000001825FA930-0x00000001825FA9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001825FA2A0-0x00000001825FA2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001825FAF50-0x00000001825FAFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001825FAFE0-0x00000001825FB070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001825FA2F0-0x00000001825FA3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001825FA470-0x00000001825FA540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SignInInfoRsp other) => default; // 0x00000001825FA540-0x00000001825FA670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001825FAAC0-0x00000001825FABC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001825FB350-0x00000001825FB530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001825FB0D0-0x00000001825FB210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001825FA670-0x00000001825FA7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SignInInfoRsp other) {} // 0x00000001825FA140-0x00000001825FA2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001825F9F80-0x00000001825FA0E0
}

