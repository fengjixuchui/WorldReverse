/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CancelCityReputationRequestReq : MessageBase, IMessage<CancelCityReputationRequestReq> // TypeDefIndex: 24780
{
	// Fields
	private static readonly MessageParser<CancelCityReputationRequestReq> _parser; // 0x00
	public const int CityIdFieldNumber = 1; // Metadata: 0x00B07387
	private uint cityId_; // 0x18
	public const int RequestIdFieldNumber = 2; // Metadata: 0x00B0738B
	private uint requestId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CancelCityReputationRequestReq> Parser { get => default; } // 0x00000001818BE790-0x00000001818BE820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001818BE520-0x00000001818BE5B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001818BE210-0x00000001818BE290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001818BDAC0-0x00000001818BDB20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001818BEBC0-0x00000001818BECB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001818BE9F0-0x00000001818BEA50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001818BE5B0-0x00000001818BE6A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001818BEB70-0x00000001818BEBC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001818BE330-0x00000001818BE420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CityId { get => default; set {} } // 0x00000001818BDD90-0x00000001818BDE30 0x00000001818BE8B0-0x00000001818BE950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RequestId { get => default; set {} } // 0x00000001818BDB20-0x00000001818BDBC0 0x00000001818BDBC0-0x00000001818BDC60

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24781
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24782
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2810
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CancelCityReputationRequestReq() {} // 0x00000001818BEF70-0x00000001818BEFD0
	static CancelCityReputationRequestReq() {} // 0x00000001818BEEB0-0x00000001818BEF70

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CancelCityReputationRequestReq Clone() => default; // 0x00000001818BE6A0-0x00000001818BE790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CancelCityReputationRequestReq ShallowCopy() => default; // 0x00000001818BE290-0x00000001818BE330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001818BDE30-0x00000001818BDE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818BE950-0x00000001818BE9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818BE9A0-0x00000001818BE9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001818BDE80-0x00000001818BDEF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001818BDEF0-0x00000001818BDFC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CancelCityReputationRequestReq other) => default; // 0x00000001818BDFC0-0x00000001818BE0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001818BE420-0x00000001818BE520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001818BECB0-0x00000001818BEEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001818BEA50-0x00000001818BEB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001818BE0E0-0x00000001818BE210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CancelCityReputationRequestReq other) {} // 0x00000001818BDC60-0x00000001818BDD90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001818BD9C0-0x00000001818BDAC0
}

