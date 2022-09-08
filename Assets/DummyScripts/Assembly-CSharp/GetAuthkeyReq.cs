/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetAuthkeyReq : MessageBase, IMessage<GetAuthkeyReq> // TypeDefIndex: 23807
{
	// Fields
	private static readonly MessageParser<GetAuthkeyReq> _parser; // 0x00
	public const int AuthAppidFieldNumber = 1; // Metadata: 0x00B04DD7
	private string authAppid_; // 0x18
	public const int SignTypeFieldNumber = 2; // Metadata: 0x00B04DDB
	private uint signType_; // 0x20
	public const int AuthkeyVerFieldNumber = 3; // Metadata: 0x00B04DDF
	private uint authkeyVer_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetAuthkeyReq> Parser { get => default; } // 0x0000000183213C50-0x0000000183213CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183213940-0x00000001832139D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001832135D0-0x0000000183213650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183212C00-0x0000000183212C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183214040-0x0000000183214130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183213E10-0x0000000183213E70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183213A70-0x0000000183213B60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183213FF0-0x0000000183214040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001832136F0-0x00000001832137E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string AuthAppid { get => default; set {} } // 0x00000001832139D0-0x0000000183213A70 0x0000000183213520-0x00000001832135D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SignType { get => default; set {} } // 0x0000000183212D00-0x0000000183212DA0 0x00000001832130A0-0x0000000183213140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AuthkeyVer { get => default; set {} } // 0x0000000183212C60-0x0000000183212D00 0x0000000183213000-0x00000001832130A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23808
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23809
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1408
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetAuthkeyReq() {} // 0x0000000183214460-0x00000001832144D0
	static GetAuthkeyReq() {} // 0x00000001832143A0-0x0000000183214460

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetAuthkeyReq Clone() => default; // 0x0000000183213B60-0x0000000183213C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetAuthkeyReq ShallowCopy() => default; // 0x0000000183213650-0x00000001832136F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183212F20-0x0000000183212F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183213D70-0x0000000183213DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183213DC0-0x0000000183213E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183212F70-0x0000000183213000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183213140-0x0000000183213210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetAuthkeyReq other) => default; // 0x0000000183213210-0x0000000183213380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001832137E0-0x0000000183213940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183214130-0x00000001832143A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183213E70-0x0000000183213FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183213380-0x0000000183213520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetAuthkeyReq other) {} // 0x0000000183212DA0-0x0000000183212F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183212AF0-0x0000000183212C00
}

