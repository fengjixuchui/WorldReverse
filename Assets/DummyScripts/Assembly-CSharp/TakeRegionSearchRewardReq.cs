/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeRegionSearchRewardReq : MessageBase, IMessage<TakeRegionSearchRewardReq> // TypeDefIndex: 24734
{
	// Fields
	private static readonly MessageParser<TakeRegionSearchRewardReq> _parser; // 0x00
	public const int IdFieldNumber = 1; // Metadata: 0x00B071BF
	private uint id_; // 0x18
	public const int SearchIdFieldNumber = 2; // Metadata: 0x00B071C3
	private uint searchId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeRegionSearchRewardReq> Parser { get => default; } // 0x00000001833A9900-0x00000001833A9990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001833A9690-0x00000001833A9720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001833A9380-0x00000001833A9400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001833A8CD0-0x00000001833A8D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001833A9DD0-0x00000001833A9EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001833A9B60-0x00000001833A9BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001833A9720-0x00000001833A9810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001833A9D80-0x00000001833A9DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001833A94A0-0x00000001833A9590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Id { get => default; set {} } // 0x00000001833A92E0-0x00000001833A9380 0x00000001833A9990-0x00000001833A9A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SearchId { get => default; set {} } // 0x00000001833A8E60-0x00000001833A8F00 0x00000001833A9CE0-0x00000001833A9D80

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24735
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24736
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 5603
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeRegionSearchRewardReq() {} // 0x00000001833AA180-0x00000001833AA1E0
	static TakeRegionSearchRewardReq() {} // 0x00000001833AA0C0-0x00000001833AA180

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeRegionSearchRewardReq Clone() => default; // 0x00000001833A9810-0x00000001833A9900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeRegionSearchRewardReq ShallowCopy() => default; // 0x00000001833A9400-0x00000001833A94A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001833A8F00-0x00000001833A8F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001833A9AC0-0x00000001833A9B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001833A9B10-0x00000001833A9B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001833A8F50-0x00000001833A8FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001833A8FC0-0x00000001833A9090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeRegionSearchRewardReq other) => default; // 0x00000001833A9090-0x00000001833A91B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001833A9590-0x00000001833A9690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001833A9EC0-0x00000001833AA0C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001833A9BC0-0x00000001833A9CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001833A91B0-0x00000001833A92E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeRegionSearchRewardReq other) {} // 0x00000001833A8D30-0x00000001833A8E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001833A8BD0-0x00000001833A8CD0
}

