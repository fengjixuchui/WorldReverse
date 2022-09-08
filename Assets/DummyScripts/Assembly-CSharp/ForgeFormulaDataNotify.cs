/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ForgeFormulaDataNotify : MessageBase, IMessage<ForgeFormulaDataNotify> // TypeDefIndex: 23773
{
	// Fields
	private static readonly MessageParser<ForgeFormulaDataNotify> _parser; // 0x00
	public const int ForgeIdFieldNumber = 1; // Metadata: 0x00B04CBF
	private uint forgeId_; // 0x18
	public const int IsLockedFieldNumber = 2; // Metadata: 0x00B04CC3
	private bool isLocked_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ForgeFormulaDataNotify> Parser { get => default; } // 0x00000001815D93B0-0x00000001815D9440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001815D9140-0x00000001815D91D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001815D8E20-0x00000001815D8EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001815D87A0-0x00000001815D8800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001815D97E0-0x00000001815D98D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001815D9610-0x00000001815D9670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001815D91D0-0x00000001815D92C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001815D9790-0x00000001815D97E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001815D8F40-0x00000001815D9030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ForgeId { get => default; set {} } // 0x00000001815D94D0-0x00000001815D9570 0x00000001815D98D0-0x00000001815D9970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsLocked { get => default; set {} } // 0x00000001815D8A90-0x00000001815D8B30 0x00000001815D8800-0x00000001815D88A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23774
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23775
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 664
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForgeFormulaDataNotify() {} // 0x00000001815D9C30-0x00000001815D9C90
	static ForgeFormulaDataNotify() {} // 0x00000001815D9B70-0x00000001815D9C30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForgeFormulaDataNotify Clone() => default; // 0x00000001815D92C0-0x00000001815D93B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForgeFormulaDataNotify ShallowCopy() => default; // 0x00000001815D8EA0-0x00000001815D8F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001815D89D0-0x00000001815D8A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001815D9570-0x00000001815D95C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001815D95C0-0x00000001815D9610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001815D8A20-0x00000001815D8A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001815D8C50-0x00000001815D8D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ForgeFormulaDataNotify other) => default; // 0x00000001815D8B30-0x00000001815D8C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001815D9030-0x00000001815D9140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001815D9970-0x00000001815D9B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001815D9670-0x00000001815D9790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001815D8D20-0x00000001815D8E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ForgeFormulaDataNotify other) {} // 0x00000001815D88A0-0x00000001815D89D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001815D86A0-0x00000001815D87A0
}

