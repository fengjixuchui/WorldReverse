/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UpdatePS4BlockListReq : MessageBase, IMessage<UpdatePS4BlockListReq> // TypeDefIndex: 25636
{
	// Fields
	private static readonly MessageParser<UpdatePS4BlockListReq> _parser; // 0x00
	public const int PsnIdListFieldNumber = 1; // Metadata: 0x00B09393
	private static readonly FieldCodec<string> _repeated_psnIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<string> psnIdList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UpdatePS4BlockListReq> Parser { get => default; } // 0x000000018121E880-0x000000018121E910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018121E610-0x000000018121E6A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018121E340-0x000000018121E3C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018121DDA0-0x000000018121DE00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018121EBF0-0x000000018121ECE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018121EA40-0x000000018121EAA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018121E6A0-0x000000018121E790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018121EBA0-0x000000018121EBF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018121E460-0x000000018121E550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<string> PsnIdList { get => default; } // 0x000000018121DE00-0x000000018121DE60 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25637
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25638
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4037
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UpdatePS4BlockListReq() {} // 0x000000018121EF10-0x000000018121EFA0
	static UpdatePS4BlockListReq() {} // 0x000000018121EE30-0x000000018121EF10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UpdatePS4BlockListReq Clone() => default; // 0x000000018121E790-0x000000018121E880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UpdatePS4BlockListReq ShallowCopy() => default; // 0x000000018121E3C0-0x000000018121E460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018121DF70-0x000000018121DFC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018121E9A0-0x000000018121E9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018121E9F0-0x000000018121EA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018121DFC0-0x000000018121E080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018121E180-0x000000018121E250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(UpdatePS4BlockListReq other) => default; // 0x000000018121E080-0x000000018121E180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018121E550-0x000000018121E610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018121ECE0-0x000000018121EE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018121EAA0-0x000000018121EBA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018121E250-0x000000018121E340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(UpdatePS4BlockListReq other) {} // 0x000000018121DE60-0x000000018121DF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018121DC70-0x000000018121DDA0
}

