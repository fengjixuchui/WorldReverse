/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerPreEnterMpNotify : MessageBase, IMessage<PlayerPreEnterMpNotify> // TypeDefIndex: 24044
{
	// Fields
	private static readonly MessageParser<PlayerPreEnterMpNotify> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B056EF
	private uint uid_; // 0x18
	public const int StateFieldNumber = 2; // Metadata: 0x00B056F3
	private Types.State state_; // 0x1C
	public const int NicknameFieldNumber = 3; // Metadata: 0x00B056F7
	private string nickname_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerPreEnterMpNotify> Parser { get => default; } // 0x00000001824E88F0-0x00000001824E8980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001824E8540-0x00000001824E85D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001824E8190-0x00000001824E8210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001824E7860-0x00000001824E78C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001824E8CD0-0x00000001824E8DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001824E8AB0-0x00000001824E8B10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001824E8710-0x00000001824E8800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001824E8C80-0x00000001824E8CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001824E82B0-0x00000001824E83A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x00000001824E80F0-0x00000001824E8190 0x00000001824E85D0-0x00000001824E8670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.State State { get => default; set {} } // 0x00000001824E7FB0-0x00000001824E8050 0x00000001824E8050-0x00000001824E80F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Nickname { get => default; set {} } // 0x00000001824E8670-0x00000001824E8710 0x00000001824E7B20-0x00000001824E7BD0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24045
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24046
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1808
		}

		public enum State // TypeDefIndex: 24047
		{
			Invalid = 0,
			Start = 1,
			Timeout = 2
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerPreEnterMpNotify() {} // 0x00000001824E90F0-0x00000001824E9170
	static PlayerPreEnterMpNotify() {} // 0x00000001824E9030-0x00000001824E90F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerPreEnterMpNotify Clone() => default; // 0x00000001824E8800-0x00000001824E88F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerPreEnterMpNotify ShallowCopy() => default; // 0x00000001824E8210-0x00000001824E82B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001824E7A40-0x00000001824E7A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001824E8A10-0x00000001824E8A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001824E8A60-0x00000001824E8AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001824E7A90-0x00000001824E7B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001824E7BD0-0x00000001824E7CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerPreEnterMpNotify other) => default; // 0x00000001824E7CA0-0x00000001824E7E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001824E83A0-0x00000001824E8540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001824E8DC0-0x00000001824E9030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001824E8B10-0x00000001824E8C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001824E7E10-0x00000001824E7FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerPreEnterMpNotify other) {} // 0x00000001824E78C0-0x00000001824E7A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001824E7750-0x00000001824E7860
}

