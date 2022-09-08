/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SetFriendRemarkNameRsp : MessageBase, IMessage<SetFriendRemarkNameRsp> // TypeDefIndex: 25657
{
	// Fields
	private static readonly MessageParser<SetFriendRemarkNameRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0944B
	private int retcode_; // 0x18
	public const int UidFieldNumber = 2; // Metadata: 0x00B0944F
	private uint uid_; // 0x1C
	public const int RemarkNameFieldNumber = 3; // Metadata: 0x00B09453
	private string remarkName_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SetFriendRemarkNameRsp> Parser { get => default; } // 0x0000000181E334D0-0x0000000181E33560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181E33120-0x0000000181E331B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181E32DB0-0x0000000181E32E30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181E32530-0x0000000181E32590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181E33960-0x0000000181E33A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181E33690-0x0000000181E336F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181E332F0-0x0000000181E333E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181E33910-0x0000000181E33960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181E32ED0-0x0000000181E32FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181E32C70-0x0000000181E32D10 0x0000000181E327F0-0x0000000181E32890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x0000000181E32D10-0x0000000181E32DB0 0x0000000181E331B0-0x0000000181E33250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string RemarkName { get => default; set {} } // 0x0000000181E33250-0x0000000181E332F0 0x0000000181E336F0-0x0000000181E337A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25658
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25659
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4044
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetFriendRemarkNameRsp() {} // 0x0000000181E33D80-0x0000000181E33DF0
	static SetFriendRemarkNameRsp() {} // 0x0000000181E33CC0-0x0000000181E33D80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetFriendRemarkNameRsp Clone() => default; // 0x0000000181E333E0-0x0000000181E334D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetFriendRemarkNameRsp ShallowCopy() => default; // 0x0000000181E32E30-0x0000000181E32ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181E32710-0x0000000181E32760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E335F0-0x0000000181E33640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E33640-0x0000000181E33690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181E32760-0x0000000181E327F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181E32890-0x0000000181E32960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SetFriendRemarkNameRsp other) => default; // 0x0000000181E32960-0x0000000181E32AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181E32FC0-0x0000000181E33120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181E33A50-0x0000000181E33CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181E337A0-0x0000000181E33910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181E32AD0-0x0000000181E32C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SetFriendRemarkNameRsp other) {} // 0x0000000181E32590-0x0000000181E32710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181E32420-0x0000000181E32530
}

