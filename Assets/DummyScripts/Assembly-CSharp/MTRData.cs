/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class MTRData // TypeDefIndex: 21188
{
	// Fields
	public List<int> minRTT; // 0x10
	public List<int> maxRTT; // 0x18
	public List<int> advRTT; // 0x20
	public List<int> reciveCount; // 0x28
	public List<int> badCount; // 0x30
	public List<int> address; // 0x38
	public string tarIp; // 0x40
	public IPAddress tarIpAddress; // 0x48
	public DateTime startTime; // 0x50
	public MTRReason reason; // 0x60

	// Constructors
	public MTRData() {} // 0x000000018273BD20-0x000000018273BD80

	// Methods
	// [XID] // 0x0000000189AEE140-0x0000000189AEE160
	public void Init(string url, IPAddress ipAddress, DateTime curTime, MTRReason reason) {} // 0x000000018273B1A0-0x000000018273B2A0
	// [XID] // 0x0000000189AF58D0-0x0000000189AF58F0
	public void Clear() {} // 0x000000018273B390-0x000000018273B4B0
	// [XID] // 0x0000000189AFCCD0-0x0000000189AFCCF0
	public override string ToString() => default; // 0x000000018273B760-0x000000018273BD20
	// [XID] // 0x0000000189B04440-0x0000000189B04460
	public void ToJson(JSONClass cBody) {} // 0x000000018273A9C0-0x000000018273B1A0
	// [XID] // 0x0000000189B0BCB0-0x0000000189B0BCD0
	public void AddSuccessRet(int ttl, int rtt, int tarAddr) {} // 0x000000018273B4B0-0x000000018273B760
	// [XID] // 0x0000000189B132A0-0x0000000189B132C0
	public void AddBadRet(int ttl) {} // 0x000000018273B2A0-0x000000018273B390
}

