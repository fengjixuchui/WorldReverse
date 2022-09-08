/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class RechargeReq : MessageBase, IMessage<RechargeReq> // TypeDefIndex: 24693
{
	// Fields
	private static readonly MessageParser<RechargeReq> _parser; // 0x00
	public const int McoinProductFieldNumber = 1; // Metadata: 0x00B0702F
	private ShopMcoinProduct mcoinProduct_; // 0x18
	public const int CardProductFieldNumber = 2; // Metadata: 0x00B07033
	private ShopCardProduct cardProduct_; // 0x20
	public const int PlayProductFieldNumber = 4; // Metadata: 0x00B07037
	private PlayProduct playProduct_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<RechargeReq> Parser { get => default; } // 0x000000018553BCE0-0x000000018553BD70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018553B9D0-0x000000018553BA60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018553B520-0x000000018553B5A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018553A8F0-0x000000018553A950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018553C1E0-0x000000018553C2D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018553BFE0-0x000000018553C040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018553BA60-0x000000018553BB50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018553C190-0x000000018553C1E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018553B640-0x000000018553B730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShopMcoinProduct McoinProduct { get => default; set {} } // 0x000000018553BC40-0x000000018553BCE0 0x000000018553ABA0-0x000000018553AC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShopCardProduct CardProduct { get => default; set {} } // 0x000000018553BF40-0x000000018553BFE0 0x000000018553B480-0x000000018553B520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayProduct PlayProduct { get => default; set {} } // 0x000000018553C2D0-0x000000018553C370 0x000000018553A850-0x000000018553A8F0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24694
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24695
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4101
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RechargeReq() {} // 0x000000018553C660-0x000000018553C6C0
	static RechargeReq() {} // 0x000000018553C5A0-0x000000018553C660

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RechargeReq Clone() => default; // 0x000000018553BB50-0x000000018553BC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RechargeReq ShallowCopy() => default; // 0x000000018553B5A0-0x000000018553B640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018553AC40-0x000000018553ACF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018553BE00-0x000000018553BEA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018553BEA0-0x000000018553BF40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018553ACF0-0x000000018553AF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018553B100-0x000000018553B1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(RechargeReq other) => default; // 0x000000018553AF90-0x000000018553B100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018553B730-0x000000018553B9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018553C370-0x000000018553C5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018553C040-0x000000018553C190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018553B1D0-0x000000018553B480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(RechargeReq other) {} // 0x000000018553A950-0x000000018553ABA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018553A690-0x000000018553A850
}

