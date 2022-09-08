/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeEffigyFirstPassRewardReq : MessageBase, IMessage<TakeEffigyFirstPassRewardReq> // TypeDefIndex: 22077
{
	// Fields
	private static readonly MessageParser<TakeEffigyFirstPassRewardReq> _parser; // 0x00
	public const int ChallengeIdFieldNumber = 1; // Metadata: 0x00B00BDF
	private uint challengeId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeEffigyFirstPassRewardReq> Parser { get => default; } // 0x0000000183C624A0-0x0000000183C62530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183C62190-0x0000000183C62220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183C61E00-0x0000000183C61E80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183C61910-0x0000000183C61970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183C627F0-0x0000000183C628E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183C62660-0x0000000183C626C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183C62220-0x0000000183C62310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183C627A0-0x0000000183C627F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183C61F20-0x0000000183C62010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeId { get => default; set {} } // 0x0000000183C620F0-0x0000000183C62190 0x0000000183C62400-0x0000000183C624A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22078
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22079
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2105
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeEffigyFirstPassRewardReq() {} // 0x0000000183C62B10-0x0000000183C62B70
	static TakeEffigyFirstPassRewardReq() {} // 0x0000000183C62A50-0x0000000183C62B10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeEffigyFirstPassRewardReq Clone() => default; // 0x0000000183C62310-0x0000000183C62400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeEffigyFirstPassRewardReq ShallowCopy() => default; // 0x0000000183C61E80-0x0000000183C61F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183C61A80-0x0000000183C61AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C625C0-0x0000000183C62610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C62610-0x0000000183C62660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183C61AD0-0x0000000183C61B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183C61C40-0x0000000183C61D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeEffigyFirstPassRewardReq other) => default; // 0x0000000183C61B40-0x0000000183C61C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183C62010-0x0000000183C620F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183C628E0-0x0000000183C62A50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183C626C0-0x0000000183C627A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183C61D10-0x0000000183C61E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeEffigyFirstPassRewardReq other) {} // 0x0000000183C61970-0x0000000183C61A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183C61830-0x0000000183C61910
}

