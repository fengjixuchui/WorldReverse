/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BuyBattlePassLevelReq : MessageBase, IMessage<BuyBattlePassLevelReq> // TypeDefIndex: 22585
{
	// Fields
	private static readonly MessageParser<BuyBattlePassLevelReq> _parser; // 0x00
	public const int BuyLevelFieldNumber = 1; // Metadata: 0x00B01ECB
	private uint buyLevel_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BuyBattlePassLevelReq> Parser { get => default; } // 0x00000001830DA330-0x00000001830DA3C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001830DA0C0-0x00000001830DA150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001830D9DD0-0x00000001830D9E50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001830D97A0-0x00000001830D9800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001830DA680-0x00000001830DA770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001830DA4F0-0x00000001830DA550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001830DA150-0x00000001830DA240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001830DA630-0x00000001830DA680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001830D9EF0-0x00000001830D9FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BuyLevel { get => default; set {} } // 0x00000001830D98A0-0x00000001830D9940 0x00000001830D9800-0x00000001830D98A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22586
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22587
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2616
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BuyBattlePassLevelReq() {} // 0x00000001830DA9A0-0x00000001830DAA00
	static BuyBattlePassLevelReq() {} // 0x00000001830DA8E0-0x00000001830DA9A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BuyBattlePassLevelReq Clone() => default; // 0x00000001830DA240-0x00000001830DA330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BuyBattlePassLevelReq ShallowCopy() => default; // 0x00000001830D9E50-0x00000001830D9EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001830D9A50-0x00000001830D9AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001830DA450-0x00000001830DA4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001830DA4A0-0x00000001830DA4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001830D9AA0-0x00000001830D9B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001830D9C10-0x00000001830D9CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BuyBattlePassLevelReq other) => default; // 0x00000001830D9B10-0x00000001830D9C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001830D9FE0-0x00000001830DA0C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001830DA770-0x00000001830DA8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001830DA550-0x00000001830DA630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001830D9CE0-0x00000001830D9DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BuyBattlePassLevelReq other) {} // 0x00000001830D9940-0x00000001830D9A50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001830D96C0-0x00000001830D97A0
}

