/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GadgetInteractReq : MessageBase, IMessage<GadgetInteractReq> // TypeDefIndex: 23176
{
	// Fields
	private static readonly MessageParser<GadgetInteractReq> _parser; // 0x00
	public const int GadgetEntityIdFieldNumber = 1; // Metadata: 0x00B0367F
	private uint gadgetEntityId_; // 0x18
	public const int OpTypeFieldNumber = 2; // Metadata: 0x00B03683
	private InterOpType opType_; // 0x1C
	public const int GadgetIdFieldNumber = 3; // Metadata: 0x00B03687
	private uint gadgetId_; // 0x20
	public const int IsUseCondenseResinFieldNumber = 4; // Metadata: 0x00B0368B
	private bool isUseCondenseResin_; // 0x24
	public const int ResinCostTypeFieldNumber = 5; // Metadata: 0x00B0368F
	private ResinCostType resinCostType_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GadgetInteractReq> Parser { get => default; } // 0x000000018299F850-0x000000018299F8E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018299F5E0-0x000000018299F670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018299F110-0x000000018299F190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018299E630-0x000000018299E690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018299FD40-0x000000018299FE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018299FA10-0x000000018299FA70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018299F670-0x000000018299F760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018299FCF0-0x000000018299FD40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018299F230-0x000000018299F320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetEntityId { get => default; set {} } // 0x000000018299FA70-0x000000018299FB10 0x000000018299E690-0x000000018299E730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InterOpType OpType { get => default; set {} } // 0x000000018299E980-0x000000018299EA20 0x000000018299E590-0x000000018299E630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetId { get => default; set {} } // 0x000000018299F070-0x000000018299F110 0x000000018299F540-0x000000018299F5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsUseCondenseResin { get => default; set {} } // 0x000000018299EB10-0x000000018299EBB0 0x000000018299E730-0x000000018299E7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ResinCostType ResinCostType { get => default; set {} } // 0x000000018299FE30-0x000000018299FED0 0x000000018299EBB0-0x000000018299EC50

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23177
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23178
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 801
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetInteractReq() {} // 0x00000001829A0330-0x00000001829A03A0
	static GadgetInteractReq() {} // 0x00000001829A0270-0x00000001829A0330

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetInteractReq Clone() => default; // 0x000000018299F760-0x000000018299F850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetInteractReq ShallowCopy() => default; // 0x000000018299F190-0x000000018299F230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018299EA20-0x000000018299EA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018299F970-0x000000018299F9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018299F9C0-0x000000018299FA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018299EA70-0x000000018299EB10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018299EC50-0x000000018299ED20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GadgetInteractReq other) => default; // 0x000000018299ED20-0x000000018299EE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018299F320-0x000000018299F540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018299FED0-0x00000001829A0270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018299FB10-0x000000018299FCF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018299EE90-0x000000018299F070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GadgetInteractReq other) {} // 0x000000018299E7D0-0x000000018299E980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018299E450-0x000000018299E590
}

