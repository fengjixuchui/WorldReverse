/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CityReputationSimpleInfo : MessageBase, IMessage<CityReputationSimpleInfo> // TypeDefIndex: 24798
{
	// Fields
	private static readonly MessageParser<CityReputationSimpleInfo> _parser; // 0x00
	public const int CityIdFieldNumber = 1; // Metadata: 0x00B07433
	private uint cityId_; // 0x18
	public const int LevelFieldNumber = 2; // Metadata: 0x00B07437
	private uint level_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CityReputationSimpleInfo> Parser { get => default; } // 0x00000001848CE9F0-0x00000001848CEA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001848CE780-0x00000001848CE810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001848CE3D0-0x00000001848CE450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001848CDD20-0x00000001848CDD80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001848CEE20-0x00000001848CEF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001848CEC50-0x00000001848CECB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001848CE810-0x00000001848CE900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001848CEDD0-0x00000001848CEE20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001848CE590-0x00000001848CE680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CityId { get => default; set {} } // 0x00000001848CDEB0-0x00000001848CDF50 0x00000001848CEB10-0x00000001848CEBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x00000001848CDF50-0x00000001848CDFF0 0x00000001848CE4F0-0x00000001848CE590

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityReputationSimpleInfo() {} // 0x00000001848CF1D0-0x00000001848CF230
	static CityReputationSimpleInfo() {} // 0x00000001848CF110-0x00000001848CF1D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityReputationSimpleInfo Clone() => default; // 0x00000001848CE900-0x00000001848CE9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityReputationSimpleInfo ShallowCopy() => default; // 0x00000001848CE450-0x00000001848CE4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001848CDFF0-0x00000001848CE040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001848CEBB0-0x00000001848CEC00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001848CEC00-0x00000001848CEC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001848CE040-0x00000001848CE0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001848CE0B0-0x00000001848CE180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CityReputationSimpleInfo other) => default; // 0x00000001848CE180-0x00000001848CE2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001848CE680-0x00000001848CE780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001848CEF10-0x00000001848CF110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001848CECB0-0x00000001848CEDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001848CE2A0-0x00000001848CE3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CityReputationSimpleInfo other) {} // 0x00000001848CDD80-0x00000001848CDEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001848CDC20-0x00000001848CDD20
}

