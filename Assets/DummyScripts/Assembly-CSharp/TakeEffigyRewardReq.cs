/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeEffigyRewardReq : MessageBase, IMessage<TakeEffigyRewardReq> // TypeDefIndex: 22083
{
	// Fields
	private static readonly MessageParser<TakeEffigyRewardReq> _parser; // 0x00
	public const int RewardIndexFieldNumber = 1; // Metadata: 0x00B00C0F
	private uint rewardIndex_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeEffigyRewardReq> Parser { get => default; } // 0x00000001825FC4E0-0x00000001825FC570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001825FC270-0x00000001825FC300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001825FBF80-0x00000001825FC000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001825FB9F0-0x00000001825FBA50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001825FC8D0-0x00000001825FC9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001825FC6A0-0x00000001825FC700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001825FC300-0x00000001825FC3F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001825FC880-0x00000001825FC8D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001825FC0A0-0x00000001825FC190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RewardIndex { get => default; set {} } // 0x00000001825FC7E0-0x00000001825FC880 0x00000001825FBC20-0x00000001825FBCC0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22084
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22085
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2107
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeEffigyRewardReq() {} // 0x00000001825FCBF0-0x00000001825FCC50
	static TakeEffigyRewardReq() {} // 0x00000001825FCB30-0x00000001825FCBF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeEffigyRewardReq Clone() => default; // 0x00000001825FC3F0-0x00000001825FC4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeEffigyRewardReq ShallowCopy() => default; // 0x00000001825FC000-0x00000001825FC0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001825FBB60-0x00000001825FBBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001825FC600-0x00000001825FC650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001825FC650-0x00000001825FC6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001825FBBB0-0x00000001825FBC20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001825FBDC0-0x00000001825FBE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeEffigyRewardReq other) => default; // 0x00000001825FBCC0-0x00000001825FBDC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001825FC190-0x00000001825FC270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001825FC9C0-0x00000001825FCB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001825FC700-0x00000001825FC7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001825FBE90-0x00000001825FBF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeEffigyRewardReq other) {} // 0x00000001825FBA50-0x00000001825FBB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001825FB910-0x00000001825FB9F0
}

