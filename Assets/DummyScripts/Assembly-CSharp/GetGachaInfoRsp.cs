/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetGachaInfoRsp : MessageBase, IMessage<GetGachaInfoRsp> // TypeDefIndex: 23161
{
	// Fields
	private static readonly MessageParser<GetGachaInfoRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B03577
	private int retcode_; // 0x18
	public const int GachaInfoListFieldNumber = 2; // Metadata: 0x00B0357B
	private static readonly FieldCodec<GachaInfo> _repeated_gachaInfoList_codec; // 0x08
	private readonly RepeatedMessageField<GachaInfo> gachaInfoList_; // 0x20
	public const int GachaRandomFieldNumber = 3; // Metadata: 0x00B0357F
	private uint gachaRandom_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetGachaInfoRsp> Parser { get => default; } // 0x00000001833C75E0-0x00000001833C7670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001833C72D0-0x00000001833C7360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001833C6F90-0x00000001833C7010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001833C66D0-0x00000001833C6730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001833C7AB0-0x00000001833C7BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001833C7820-0x00000001833C7880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001833C7360-0x00000001833C7450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001833C7A60-0x00000001833C7AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001833C70B0-0x00000001833C71A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001833C6EF0-0x00000001833C6F90 0x00000001833C6A00-0x00000001833C6AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<GachaInfo> GachaInfoList { get => default; } // 0x00000001833C7A00-0x00000001833C7A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GachaRandom { get => default; set {} } // 0x00000001833C7540-0x00000001833C75E0 0x00000001833C6AA0-0x00000001833C6B40

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23162
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23163
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1502
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetGachaInfoRsp() {} // 0x00000001833C7F20-0x00000001833C7FB0
	static GetGachaInfoRsp() {} // 0x00000001833C7E10-0x00000001833C7F20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetGachaInfoRsp Clone() => default; // 0x00000001833C7450-0x00000001833C7540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetGachaInfoRsp ShallowCopy() => default; // 0x00000001833C7010-0x00000001833C70B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001833C68C0-0x00000001833C6910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001833C7700-0x00000001833C7790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001833C7790-0x00000001833C7820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001833C6910-0x00000001833C6A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001833C6C90-0x00000001833C6D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetGachaInfoRsp other) => default; // 0x00000001833C6B40-0x00000001833C6C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001833C71A0-0x00000001833C72D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001833C7BA0-0x00000001833C7E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001833C7880-0x00000001833C7A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001833C6D60-0x00000001833C6EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetGachaInfoRsp other) {} // 0x00000001833C6730-0x00000001833C68C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001833C6550-0x00000001833C66D0
}

