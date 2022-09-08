/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SetPlayerNameRsp : MessageBase, IMessage<SetPlayerNameRsp> // TypeDefIndex: 24360
{
	// Fields
	private static readonly MessageParser<SetPlayerNameRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B06453
	private int retcode_; // 0x18
	public const int NickNameFieldNumber = 2; // Metadata: 0x00B06457
	private string nickName_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SetPlayerNameRsp> Parser { get => default; } // 0x0000000181D5D7B0-0x0000000181D5D840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181D5D540-0x0000000181D5D5D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181D5D200-0x0000000181D5D280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181D5C980-0x0000000181D5C9E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181D5DB60-0x0000000181D5DC50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181D5D970-0x0000000181D5D9D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181D5D5D0-0x0000000181D5D6C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181D5DB10-0x0000000181D5DB60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181D5D320-0x0000000181D5D410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181D5D160-0x0000000181D5D200 0x0000000181D5CD50-0x0000000181D5CDF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string NickName { get => default; set {} } // 0x0000000181D5CA90-0x0000000181D5CB30 0x0000000181D5C9E0-0x0000000181D5CA90

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24361
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24362
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 121
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetPlayerNameRsp() {} // 0x0000000181D5DEF0-0x0000000181D5DF60
	static SetPlayerNameRsp() {} // 0x0000000181D5DE30-0x0000000181D5DEF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetPlayerNameRsp Clone() => default; // 0x0000000181D5D6C0-0x0000000181D5D7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetPlayerNameRsp ShallowCopy() => default; // 0x0000000181D5D280-0x0000000181D5D320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181D5CC80-0x0000000181D5CCD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D5D8D0-0x0000000181D5D920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D5D920-0x0000000181D5D970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181D5CCD0-0x0000000181D5CD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181D5CDF0-0x0000000181D5CEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SetPlayerNameRsp other) => default; // 0x0000000181D5CEC0-0x0000000181D5D010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181D5D410-0x0000000181D5D540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181D5DC50-0x0000000181D5DE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181D5D9D0-0x0000000181D5DB10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181D5D010-0x0000000181D5D160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SetPlayerNameRsp other) {} // 0x0000000181D5CB30-0x0000000181D5CC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181D5C880-0x0000000181D5C980
}

