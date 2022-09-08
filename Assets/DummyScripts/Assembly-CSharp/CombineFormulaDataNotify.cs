/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CombineFormulaDataNotify : MessageBase, IMessage<CombineFormulaDataNotify> // TypeDefIndex: 23779
{
	// Fields
	private static readonly MessageParser<CombineFormulaDataNotify> _parser; // 0x00
	public const int CombineIdFieldNumber = 1; // Metadata: 0x00B04CEB
	private uint combineId_; // 0x18
	public const int IsLockedFieldNumber = 2; // Metadata: 0x00B04CEF
	private bool isLocked_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CombineFormulaDataNotify> Parser { get => default; } // 0x0000000184A81F90-0x0000000184A82020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184A81D20-0x0000000184A81DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184A81A00-0x0000000184A81A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184A812E0-0x0000000184A81340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184A823C0-0x0000000184A824B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184A821F0-0x0000000184A82250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184A81DB0-0x0000000184A81EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184A82370-0x0000000184A823C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184A81B20-0x0000000184A81C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CombineId { get => default; set {} } // 0x0000000184A81670-0x0000000184A81710 0x0000000184A82150-0x0000000184A821F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsLocked { get => default; set {} } // 0x0000000184A815D0-0x0000000184A81670 0x0000000184A81340-0x0000000184A813E0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23780
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23781
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 666
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CombineFormulaDataNotify() {} // 0x0000000184A82770-0x0000000184A827D0
	static CombineFormulaDataNotify() {} // 0x0000000184A826B0-0x0000000184A82770

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CombineFormulaDataNotify Clone() => default; // 0x0000000184A81EA0-0x0000000184A81F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CombineFormulaDataNotify ShallowCopy() => default; // 0x0000000184A81A80-0x0000000184A81B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184A81510-0x0000000184A81560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A820B0-0x0000000184A82100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A82100-0x0000000184A82150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184A81560-0x0000000184A815D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184A81830-0x0000000184A81900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CombineFormulaDataNotify other) => default; // 0x0000000184A81710-0x0000000184A81830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184A81C10-0x0000000184A81D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184A824B0-0x0000000184A826B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184A82250-0x0000000184A82370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184A81900-0x0000000184A81A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CombineFormulaDataNotify other) {} // 0x0000000184A813E0-0x0000000184A81510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184A811E0-0x0000000184A812E0
}

