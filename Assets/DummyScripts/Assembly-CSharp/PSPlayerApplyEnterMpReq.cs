/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PSPlayerApplyEnterMpReq : MessageBase, IMessage<PSPlayerApplyEnterMpReq> // TypeDefIndex: 24060
{
	// Fields
	private static readonly MessageParser<PSPlayerApplyEnterMpReq> _parser; // 0x00
	public const int TargetPsnIdFieldNumber = 1; // Metadata: 0x00B05777
	private string targetPsnId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PSPlayerApplyEnterMpReq> Parser { get => default; } // 0x0000000181DFE720-0x0000000181DFE7B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181DFE410-0x0000000181DFE4A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181DFE100-0x0000000181DFE180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181DFDBC0-0x0000000181DFDC20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181DFEA90-0x0000000181DFEB80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181DFE8E0-0x0000000181DFE940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181DFE540-0x0000000181DFE630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181DFEA40-0x0000000181DFEA90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181DFE220-0x0000000181DFE310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string TargetPsnId { get => default; set {} } // 0x0000000181DFE4A0-0x0000000181DFE540 0x0000000181DFEB80-0x0000000181DFEC30

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24061
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24062
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1813
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PSPlayerApplyEnterMpReq() {} // 0x0000000181DFEE40-0x0000000181DFEEB0
	static PSPlayerApplyEnterMpReq() {} // 0x0000000181DFED80-0x0000000181DFEE40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PSPlayerApplyEnterMpReq Clone() => default; // 0x0000000181DFE630-0x0000000181DFE720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PSPlayerApplyEnterMpReq ShallowCopy() => default; // 0x0000000181DFE180-0x0000000181DFE220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181DFDD40-0x0000000181DFDD90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181DFE840-0x0000000181DFE890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181DFE890-0x0000000181DFE8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181DFDD90-0x0000000181DFDE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181DFDE00-0x0000000181DFDED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PSPlayerApplyEnterMpReq other) => default; // 0x0000000181DFDED0-0x0000000181DFE000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181DFE310-0x0000000181DFE410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181DFEC30-0x0000000181DFED80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181DFE940-0x0000000181DFEA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181DFE000-0x0000000181DFE100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PSPlayerApplyEnterMpReq other) {} // 0x0000000181DFDC20-0x0000000181DFDD40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181DFDAE0-0x0000000181DFDBC0
}

