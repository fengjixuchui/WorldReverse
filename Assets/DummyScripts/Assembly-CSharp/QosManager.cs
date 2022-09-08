/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QosManager : GlobalManager // TypeDefIndex: 21271
{
	// Fields
	private BaseQosCollector _collector; // 0x10
	private PacketQueue<string> _packetCache; // 0x18
	private List<ClientActionType> _timerToBeRemove; // 0x28

	// Properties
	public Dictionary<ClientActionType, QosTimer> timerDict { /* [XID] */ /* 0x0000000189818AD0-0x0000000189818B10 */ get; /* [XID] */ /* 0x0000000189822E50-0x0000000189822E90 */ private set; } // 0x00000001823AA4D0-0x00000001823AA530 0x00000001823AA530-0x00000001823AA590

	// Nested types
	private static class Config // TypeDefIndex: 21272
	{
		// Fields
		public static string url; // 0x00
		public static string secretKey; // 0x08
		public static int packetCacheCapacity; // 0x10
		public static float pingInterval; // 0x14

		// Constructors
		static Config() {} // 0x00000001823C68C0-0x00000001823C6990
	}

	// Constructors
	public QosManager() {} // 0x00000001823AB850-0x00000001823AB8C0

	// Methods
	// [XID] // 0x000000018982D500-0x000000018982D520
	public override void ReloadRes() {} // 0x00000001823AB350-0x00000001823AB3F0
	// [XID] // 0x0000000189834C30-0x0000000189834C50
	public override void Tick() {} // 0x00000001823AB3F0-0x00000001823AB850
	// [XID] // 0x000000018983C390-0x000000018983C3B0
	public void StartRecord(ClientActionType type, float? timeSpan = default) {} // 0x00000001823AAEA0-0x00000001823AB1E0
	// [XID] // 0x00000001898438C0-0x00000001898438E0
	public bool IsTimerRunning(ClientActionType type) => default; // 0x00000001823AAD10-0x00000001823AAEA0
	// [XID] // 0x000000018984AE10-0x000000018984AE30
	public void EndRecordAndSendLog(ClientActionType type, Action<HttpPacket> updatePacketInformation = null, bool releaseTimer = true /* Metadata: 0x00AFF3E8 */) {} // 0x00000001823AA590-0x00000001823AA780
	// [XID] // 0x0000000189852110-0x0000000189852130
	private void RequestLogin() {} // 0x00000001823AA780-0x00000001823AA910
	// [XID] // 0x0000000189859B70-0x0000000189859B90
	private void RequestPing() {} // 0x00000001823AB1E0-0x00000001823AB350
	// [XID] // 0x0000000189860C10-0x0000000189860C30
	private void SendHttpPacket(HttpPacket packet, ClientActionType type) {} // 0x00000001823A9DE0-0x00000001823AA170
	// [XID] // 0x00000001898683C0-0x00000001898683E0
	private string SHA1Encrypt(string srcString) => default; // 0x00000001823AABC0-0x00000001823AAD10
	// [XID] // 0x000000018986F840-0x000000018986F860
	private void SendCacheHttpPackets() {} // 0x00000001823AA1D0-0x00000001823AA330
	// [XID] // 0x0000000189876DF0-0x0000000189876E10
	private void HttpRequest(string url, string jsonStr) {} // 0x00000001823AA910-0x00000001823AABC0
	// [XID] // 0x000000018987E900-0x000000018987E920
	public override void ClearOnLevelDestroy() {} // 0x00000001823A9AE0-0x00000001823A9B80
	// [XID] // 0x0000000189885DC0-0x0000000189885DE0
	public override void Init() {} // 0x00000001823AA330-0x00000001823AA4D0
	// [XID] // 0x000000018988D0C0-0x000000018988D0E0
	public override void Destroy() {} // 0x00000001823A9B80-0x00000001823A9DE0
}

