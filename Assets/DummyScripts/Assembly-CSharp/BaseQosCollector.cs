/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class BaseQosCollector // TypeDefIndex: 26116
{
	// Fields
	public Dictionary<ClientActionType, Action<HttpPacket>> updatePacketInformationDict; // 0x10
	public const uint ERROR_CODE = 4294967295; // Metadata: 0x00B0BD97
	private string _logSerialNumber; // 0x18

	// Constructors
	public BaseQosCollector() {} // 0x000000018430BE40-0x000000018430BF10

	// Methods
	// [XID] // 0x0000000189B61F70-0x0000000189B61F90
	public void FillHttpPacket(HttpPacket packet, ClientActionType type) {} // 0x000000018430B470-0x000000018430B5E0
	// [XID] // 0x0000000189B69BE0-0x0000000189B69C00
	private void FillHead(ClientLogHead head, ClientActionType type) {} // 0x000000018430B950-0x000000018430BA50
	// [XID] // 0x0000000189B71180-0x0000000189B711A0
	private void FillBody(MessageBase body, ClientActionType type) {} // 0x000000018430B340-0x000000018430B470
	// [XID] // 0x0000000189B78790-0x0000000189B787B0
	protected virtual void CollectorHeadInfromation(ClientLogHead head, ClientActionType type) {} // 0x000000018430BA50-0x000000018430BE40
	// [XID] // 0x0000000189B7FD90-0x0000000189B7FDB0
	protected virtual void CollectorLoginInformation(ClientLogBodyLogin body) {} // 0x000000018430B5E0-0x000000018430B6C0
	// [XID] // 0x0000000189B87800-0x0000000189B87820
	protected virtual void CollectorPingInformation(ClientLogBodyPing body) {} // 0x000000018430B7C0-0x000000018430B950
	// [XID] // 0x0000000189B8E970-0x0000000189B8E990
	private string GenerateLogSerialNumber(string time, string uuid) => default; // 0x000000018430B6C0-0x000000018430B7C0
}

