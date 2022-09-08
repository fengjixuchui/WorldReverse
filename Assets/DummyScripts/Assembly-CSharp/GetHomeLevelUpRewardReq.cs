/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetHomeLevelUpRewardReq : MessageBase, IMessage<GetHomeLevelUpRewardReq> // TypeDefIndex: 23420
{
	// Fields
	private static readonly MessageParser<GetHomeLevelUpRewardReq> _parser; // 0x00
	public const int LevelFieldNumber = 1; // Metadata: 0x00B03FCB
	private uint level_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetHomeLevelUpRewardReq> Parser { get => default; } // 0x0000000183C2BF20-0x0000000183C2BFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183C2BCB0-0x0000000183C2BD40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183C2B920-0x0000000183C2B9A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183C2B390-0x0000000183C2B3F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183C2C270-0x0000000183C2C360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183C2C0E0-0x0000000183C2C140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183C2BD40-0x0000000183C2BE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183C2C220-0x0000000183C2C270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183C2BAE0-0x0000000183C2BBD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x0000000183C2B500-0x0000000183C2B5A0 0x0000000183C2BA40-0x0000000183C2BAE0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23421
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23422
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4493
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetHomeLevelUpRewardReq() {} // 0x0000000183C2C590-0x0000000183C2C5F0
	static GetHomeLevelUpRewardReq() {} // 0x0000000183C2C4D0-0x0000000183C2C590

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetHomeLevelUpRewardReq Clone() => default; // 0x0000000183C2BE30-0x0000000183C2BF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetHomeLevelUpRewardReq ShallowCopy() => default; // 0x0000000183C2B9A0-0x0000000183C2BA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183C2B5A0-0x0000000183C2B5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C2C040-0x0000000183C2C090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C2C090-0x0000000183C2C0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183C2B5F0-0x0000000183C2B660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183C2B660-0x0000000183C2B730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetHomeLevelUpRewardReq other) => default; // 0x0000000183C2B730-0x0000000183C2B830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183C2BBD0-0x0000000183C2BCB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183C2C360-0x0000000183C2C4D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183C2C140-0x0000000183C2C220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183C2B830-0x0000000183C2B920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetHomeLevelUpRewardReq other) {} // 0x0000000183C2B3F0-0x0000000183C2B500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183C2B2B0-0x0000000183C2B390
}

