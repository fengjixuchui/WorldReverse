/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DungeonDieOptionReq : MessageBase, IMessage<DungeonDieOptionReq> // TypeDefIndex: 22840
{
	// Fields
	private static readonly MessageParser<DungeonDieOptionReq> _parser; // 0x00
	public const int DieOptionFieldNumber = 1; // Metadata: 0x00B02827
	private PlayerDieOption dieOption_; // 0x18
	public const int IsQuitImmediatelyFieldNumber = 2; // Metadata: 0x00B0282B
	private bool isQuitImmediately_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DungeonDieOptionReq> Parser { get => default; } // 0x0000000182EF4A80-0x0000000182EF4B10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182EF46D0-0x0000000182EF4760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182EF4370-0x0000000182EF43F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182EF3D90-0x0000000182EF3DF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182EF4EB0-0x0000000182EF4FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182EF4C40-0x0000000182EF4CA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182EF4800-0x0000000182EF48F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182EF4E60-0x0000000182EF4EB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182EF4490-0x0000000182EF4580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerDieOption DieOption { get => default; set {} } // 0x0000000182EF42D0-0x0000000182EF4370 0x0000000182EF4CA0-0x0000000182EF4D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsQuitImmediately { get => default; set {} } // 0x0000000182EF49E0-0x0000000182EF4A80 0x0000000182EF4760-0x0000000182EF4800

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22841
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22842
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 912
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonDieOptionReq() {} // 0x0000000182EF5260-0x0000000182EF52D0
	static DungeonDieOptionReq() {} // 0x0000000182EF51A0-0x0000000182EF5260

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonDieOptionReq Clone() => default; // 0x0000000182EF48F0-0x0000000182EF49E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonDieOptionReq ShallowCopy() => default; // 0x0000000182EF43F0-0x0000000182EF4490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182EF3F20-0x0000000182EF3F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182EF4BA0-0x0000000182EF4BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182EF4BF0-0x0000000182EF4C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182EF3F70-0x0000000182EF3FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182EF4100-0x0000000182EF41D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DungeonDieOptionReq other) => default; // 0x0000000182EF3FE0-0x0000000182EF4100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182EF4580-0x0000000182EF46D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182EF4FA0-0x0000000182EF51A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182EF4D40-0x0000000182EF4E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182EF41D0-0x0000000182EF42D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DungeonDieOptionReq other) {} // 0x0000000182EF3DF0-0x0000000182EF3F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182EF3CA0-0x0000000182EF3D90
}

