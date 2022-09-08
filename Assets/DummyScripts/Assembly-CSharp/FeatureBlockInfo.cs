/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FeatureBlockInfo : MessageBase, IMessage<FeatureBlockInfo> // TypeDefIndex: 26102
{
	// Fields
	private static readonly MessageParser<FeatureBlockInfo> _parser; // 0x00
	public const int FeatureTypeFieldNumber = 1; // Metadata: 0x00B0B223
	private uint featureType_; // 0x18
	public const int EndTimeFieldNumber = 2; // Metadata: 0x00B0B227
	private uint endTime_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FeatureBlockInfo> Parser { get => default; } // 0x000000018140AC10-0x000000018140ACA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018140A860-0x000000018140A8F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018140A550-0x000000018140A5D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181409FE0-0x000000018140A040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018140B040-0x000000018140B130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018140AE70-0x000000018140AED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018140A990-0x000000018140AA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018140AFF0-0x000000018140B040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018140A670-0x000000018140A760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FeatureType { get => default; set {} } // 0x000000018140A8F0-0x000000018140A990 0x000000018140B130-0x000000018140B1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EndTime { get => default; set {} } // 0x000000018140AB70-0x000000018140AC10 0x000000018140ADD0-0x000000018140AE70

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FeatureBlockInfo() {} // 0x000000018140B490-0x000000018140B4F0
	static FeatureBlockInfo() {} // 0x000000018140B3D0-0x000000018140B490

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FeatureBlockInfo Clone() => default; // 0x000000018140AA80-0x000000018140AB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FeatureBlockInfo ShallowCopy() => default; // 0x000000018140A5D0-0x000000018140A670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018140A170-0x000000018140A1C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018140AD30-0x000000018140AD80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018140AD80-0x000000018140ADD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018140A1C0-0x000000018140A230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018140A230-0x000000018140A300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FeatureBlockInfo other) => default; // 0x000000018140A300-0x000000018140A420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018140A760-0x000000018140A860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018140B1D0-0x000000018140B3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018140AED0-0x000000018140AFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018140A420-0x000000018140A550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FeatureBlockInfo other) {} // 0x000000018140A040-0x000000018140A170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181409EE0-0x0000000181409FE0
}

