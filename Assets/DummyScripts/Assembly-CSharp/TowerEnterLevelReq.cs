/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TowerEnterLevelReq : MessageBase, IMessage<TowerEnterLevelReq> // TypeDefIndex: 25722
{
	// Fields
	private static readonly MessageParser<TowerEnterLevelReq> _parser; // 0x00
	public const int EnterPointIdFieldNumber = 1; // Metadata: 0x00B096FB
	private uint enterPointId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TowerEnterLevelReq> Parser { get => default; } // 0x0000000181AF1A30-0x0000000181AF1AC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181AF1680-0x0000000181AF1710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181AF1390-0x0000000181AF1410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181AF0EA0-0x0000000181AF0F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181AF1D80-0x0000000181AF1E70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181AF1BF0-0x0000000181AF1C50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181AF1710-0x0000000181AF1800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181AF1D30-0x0000000181AF1D80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181AF14B0-0x0000000181AF15A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EnterPointId { get => default; set {} } // 0x0000000181AF1990-0x0000000181AF1A30 0x0000000181AF18F0-0x0000000181AF1990

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25723
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25724
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2411
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerEnterLevelReq() {} // 0x0000000181AF20A0-0x0000000181AF2100
	static TowerEnterLevelReq() {} // 0x0000000181AF1FE0-0x0000000181AF20A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerEnterLevelReq Clone() => default; // 0x0000000181AF1800-0x0000000181AF18F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerEnterLevelReq ShallowCopy() => default; // 0x0000000181AF1410-0x0000000181AF14B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181AF1010-0x0000000181AF1060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181AF1B50-0x0000000181AF1BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181AF1BA0-0x0000000181AF1BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181AF1060-0x0000000181AF10D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181AF10D0-0x0000000181AF11A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TowerEnterLevelReq other) => default; // 0x0000000181AF11A0-0x0000000181AF12A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181AF15A0-0x0000000181AF1680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181AF1E70-0x0000000181AF1FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181AF1C50-0x0000000181AF1D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181AF12A0-0x0000000181AF1390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TowerEnterLevelReq other) {} // 0x0000000181AF0F00-0x0000000181AF1010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181AF0DC0-0x0000000181AF0EA0
}

