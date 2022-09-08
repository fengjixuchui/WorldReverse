/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AddQuestContentProgressReq : MessageBase, IMessage<AddQuestContentProgressReq> // TypeDefIndex: 24581
{
	// Fields
	private static readonly MessageParser<AddQuestContentProgressReq> _parser; // 0x00
	public const int ContentTypeFieldNumber = 1; // Metadata: 0x00B06C1F
	private uint contentType_; // 0x18
	public const int ParamFieldNumber = 2; // Metadata: 0x00B06C23
	private uint param_; // 0x1C
	public const int AddProgressFieldNumber = 3; // Metadata: 0x00B06C27
	private uint addProgress_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AddQuestContentProgressReq> Parser { get => default; } // 0x00000001845B0420-0x00000001845B04B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001845B0110-0x00000001845B01A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001845AFDD0-0x00000001845AFE50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001845AF670-0x00000001845AF6D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001845B09D0-0x00000001845B0AC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001845B0680-0x00000001845B06E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001845B01A0-0x00000001845B0290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001845B0980-0x00000001845B09D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001845AFEF0-0x00000001845AFFE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ContentType { get => default; set {} } // 0x00000001845B05E0-0x00000001845B0680 0x00000001845AFD30-0x00000001845AFDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Param { get => default; set {} } // 0x00000001845B06E0-0x00000001845B0780 0x00000001845B0780-0x00000001845B0820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AddProgress { get => default; set {} } // 0x00000001845AF6D0-0x00000001845AF770 0x00000001845B0290-0x00000001845B0330

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24582
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24583
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 406
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AddQuestContentProgressReq() {} // 0x00000001845B0E10-0x00000001845B0E70
	static AddQuestContentProgressReq() {} // 0x00000001845B0D50-0x00000001845B0E10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AddQuestContentProgressReq Clone() => default; // 0x00000001845B0330-0x00000001845B0420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AddQuestContentProgressReq ShallowCopy() => default; // 0x00000001845AFE50-0x00000001845AFEF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001845AF8D0-0x00000001845AF920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001845B0540-0x00000001845B0590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001845B0590-0x00000001845B05E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001845AF920-0x00000001845AF9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001845AF9A0-0x00000001845AFA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AddQuestContentProgressReq other) => default; // 0x00000001845AFA70-0x00000001845AFBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001845AFFE0-0x00000001845B0110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001845B0AC0-0x00000001845B0D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001845B0820-0x00000001845B0980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001845AFBB0-0x00000001845AFD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AddQuestContentProgressReq other) {} // 0x00000001845AF770-0x00000001845AF8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001845AF560-0x00000001845AF670
}

