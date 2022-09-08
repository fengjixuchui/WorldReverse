/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SetPlayerBornDataReq : MessageBase, IMessage<SetPlayerBornDataReq> // TypeDefIndex: 24345
{
	// Fields
	private static readonly MessageParser<SetPlayerBornDataReq> _parser; // 0x00
	public const int AvatarIdFieldNumber = 1; // Metadata: 0x00B063E3
	private uint avatarId_; // 0x18
	public const int NickNameFieldNumber = 2; // Metadata: 0x00B063E7
	private string nickName_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SetPlayerBornDataReq> Parser { get => default; } // 0x00000001835B2BA0-0x00000001835B2C30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001835B2930-0x00000001835B29C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001835B25F0-0x00000001835B2670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001835B1D70-0x00000001835B1DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001835B2F50-0x00000001835B3040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001835B2D60-0x00000001835B2DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001835B29C0-0x00000001835B2AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001835B2F00-0x00000001835B2F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001835B2710-0x00000001835B2800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarId { get => default; set {} } // 0x00000001835B24B0-0x00000001835B2550 0x00000001835B2550-0x00000001835B25F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string NickName { get => default; set {} } // 0x00000001835B1E80-0x00000001835B1F20 0x00000001835B1DD0-0x00000001835B1E80

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24346
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24347
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 116
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetPlayerBornDataReq() {} // 0x00000001835B32E0-0x00000001835B3350
	static SetPlayerBornDataReq() {} // 0x00000001835B3220-0x00000001835B32E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetPlayerBornDataReq Clone() => default; // 0x00000001835B2AB0-0x00000001835B2BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetPlayerBornDataReq ShallowCopy() => default; // 0x00000001835B2670-0x00000001835B2710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001835B2070-0x00000001835B20C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835B2CC0-0x00000001835B2D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835B2D10-0x00000001835B2D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001835B20C0-0x00000001835B2140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001835B2140-0x00000001835B2210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SetPlayerBornDataReq other) => default; // 0x00000001835B2210-0x00000001835B2360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001835B2800-0x00000001835B2930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001835B3040-0x00000001835B3220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001835B2DC0-0x00000001835B2F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001835B2360-0x00000001835B24B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SetPlayerBornDataReq other) {} // 0x00000001835B1F20-0x00000001835B2070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001835B1C70-0x00000001835B1D70
}

