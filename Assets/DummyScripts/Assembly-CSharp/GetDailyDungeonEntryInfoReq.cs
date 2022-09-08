/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetDailyDungeonEntryInfoReq : MessageBase, IMessage<GetDailyDungeonEntryInfoReq> // TypeDefIndex: 22940
{
	// Fields
	private static readonly MessageParser<GetDailyDungeonEntryInfoReq> _parser; // 0x00
	public const int SceneIdFieldNumber = 1; // Metadata: 0x00B02B63
	private uint sceneId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetDailyDungeonEntryInfoReq> Parser { get => default; } // 0x0000000181FB27E0-0x0000000181FB2870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181FB2570-0x0000000181FB2600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181FB2280-0x0000000181FB2300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181FB1C50-0x0000000181FB1CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181FB2B30-0x0000000181FB2C20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181FB29A0-0x0000000181FB2A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181FB2600-0x0000000181FB26F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181FB2AE0-0x0000000181FB2B30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181FB23A0-0x0000000181FB2490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x0000000181FB1E80-0x0000000181FB1F20 0x0000000181FB21E0-0x0000000181FB2280

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22941
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22942
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 944
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetDailyDungeonEntryInfoReq() {} // 0x0000000181FB2E50-0x0000000181FB2EB0
	static GetDailyDungeonEntryInfoReq() {} // 0x0000000181FB2D90-0x0000000181FB2E50

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetDailyDungeonEntryInfoReq Clone() => default; // 0x0000000181FB26F0-0x0000000181FB27E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetDailyDungeonEntryInfoReq ShallowCopy() => default; // 0x0000000181FB2300-0x0000000181FB23A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181FB1DC0-0x0000000181FB1E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181FB2900-0x0000000181FB2950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181FB2950-0x0000000181FB29A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181FB1E10-0x0000000181FB1E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181FB1F20-0x0000000181FB1FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetDailyDungeonEntryInfoReq other) => default; // 0x0000000181FB1FF0-0x0000000181FB20F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181FB2490-0x0000000181FB2570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181FB2C20-0x0000000181FB2D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181FB2A00-0x0000000181FB2AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181FB20F0-0x0000000181FB21E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetDailyDungeonEntryInfoReq other) {} // 0x0000000181FB1CB0-0x0000000181FB1DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181FB1B70-0x0000000181FB1C50
}

