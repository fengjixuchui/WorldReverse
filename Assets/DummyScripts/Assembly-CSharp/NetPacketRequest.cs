/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class NetPacketRequest : ISimplePoolObject // TypeDefIndex: 26617
{
	// Fields
	private static SimpleObjectPool<NetPacketRequest> _pool; // 0x00
	private SendPacketData _packetData; // 0x10

	// Properties
	public SendPacketData packetData { /* [XID] */ /* 0x00000001899726A0-0x00000001899726C0 */ get => default; } // 0x00000001858ACE40-0x00000001858ACEE0 

	// Constructors
	public NetPacketRequest() {} // 0x00000001858AD380-0x00000001858AD3E0
	static NetPacketRequest() {} // 0x00000001858AD310-0x00000001858AD380

	// Methods
	// [XID] // 0x00000001899635A0-0x00000001899635C0
	public static NetPacketRequest Create(SendPacketData packetData) => default; // 0x00000001858ACF90-0x00000001858AD0A0
	// [XID] // 0x000000018996A900-0x000000018996A920
	public static void Release(NetPacketRequest request) {} // 0x00000001858AD180-0x00000001858AD270
	// [XID] // 0x0000000189979E60-0x0000000189979E80
	public void Init(SendPacketData packetData) {} // 0x00000001858ACEE0-0x00000001858ACF90
	// [XID] // 0x00000001899815D0-0x00000001899815F0
	public void Flush() {} // 0x00000001858AD0A0-0x00000001858AD180
	// [XID] // 0x0000000189988E00-0x0000000189988E20
	public void ResetObject() {} // 0x00000001858AD270-0x00000001858AD310
}

