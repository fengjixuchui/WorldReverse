/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CommandThreadSpatialFunctionalities : CommandThreadFunctionalities<SharedSpatialFunctionalities> // TypeDefIndex: 11410
{
	// Fields
	private ConfigSpatialAudio _config; // 0x20

	// Properties
	private static string LEVEL_SPATIAL_CONFIG_FOMMAT { /* [XID] */ /* 0x0000000189624020-0x0000000189624040 */ get => default; } // 0x0000000183A6FAA0-0x0000000183A6FB40 
	public bool enabled { /* [XID] */ /* 0x000000018962B7B0-0x000000018962B7F0 */ get; /* [XID] */ /* 0x0000000189636500-0x0000000189636540 */ private set; } // 0x0000000183A719B0-0x0000000183A71A10 0x0000000183A71D70-0x0000000183A71DD0
	public bool workerEnabled { /* [XID] */ /* 0x0000000189640780-0x00000001896407C0 */ get; /* [XID] */ /* 0x000000018964AF80-0x000000018964AFC0 */ private set; } // 0x0000000183A71C70-0x0000000183A71CD0 0x0000000183A6FFF0-0x0000000183A70050

	// Constructors
	public CommandThreadSpatialFunctionalities() {} // Dummy constructor
	public CommandThreadSpatialFunctionalities(CommandThreadContext context, SharedSpatialFunctionalities shared) {} // 0x0000000183A72690-0x0000000183A72740

	// Methods
	// [XID] // 0x0000000189655990-0x00000001896559B0
	public override void Init() {} // 0x0000000183A6FDA0-0x0000000183A6FE40
	// [XID] // 0x0000000189A31140-0x0000000189A31160
	public override void Tick(float deltaTime) {} // 0x0000000183A6FE40-0x0000000183A6FEF0
	// [XID] // 0x0000000189664750-0x0000000189664770
	public override void DumpCriticalInfo(StringBuilder builder) {} // 0x0000000183A72060-0x0000000183A72110
	// [XID] // 0x000000018966BD90-0x000000018966BDB0
	public override void Destroy() {} // 0x0000000183A6FA00-0x0000000183A6FAA0
	// [XID] // 0x0000000189673B20-0x0000000189673B40
	public override void EnterHomeWorld(bool firstTime) {} // 0x0000000183A70570-0x0000000183A70620
	// [XID] // 0x000000018967B240-0x000000018967B260
	public override void EnterLevel() {} // 0x0000000183A70480-0x0000000183A70570
	// [XID] // 0x0000000189841780-0x00000001898417A0
	public override void CreateLevel() {} // 0x0000000183A6F490-0x0000000183A6F580
	// [XID] // 0x0000000189A80DD0-0x0000000189A80DF0
	private bool CheckHashExists(ulong hash) => default; // 0x0000000183A6F6E0-0x0000000183A6F820
	// [XID] // 0x0000000189A3D2F0-0x0000000189A3D310
	private string GetLevelSpatialConfigPath(uint sceneId) => default; // 0x0000000183A6F820-0x0000000183A6F920
	// [XID] // 0x00000001897ECBF0-0x00000001897ECC10
	private void LoadLevelSpatialConfig() {} // 0x0000000183A72110-0x0000000183A724B0
	// [XID] // 0x00000001896A0CC0-0x00000001896A0CE0
	private void ReadLevelSpatialConfig() {} // 0x0000000183A70820-0x0000000183A71910
	// [XID] // 0x00000001896A8210-0x00000001896A8230
	public override void ExitGameWorld() {} // 0x0000000183A71910-0x0000000183A719B0
	// [XID] // 0x0000000189B72400-0x0000000189B72420
	public override void ExitLevel() {} // 0x0000000183A6FB40-0x0000000183A6FC40
	// [XID] // 0x0000000189B79940-0x0000000189B79960
	private void ClearAll() {} // 0x0000000183A6F920-0x0000000183A6FA00
	// [XID] // 0x00000001896BDEE0-0x00000001896BDF00
	private uint GetCurrentSceneId() => default; // 0x0000000183A71BA0-0x0000000183A71C70
	// [XID] // 0x0000000189934750-0x0000000189934770
	public void RegisterEmitter(SyncId syncId) {} // 0x0000000183A6FC40-0x0000000183A6FDA0
	// [XID] // 0x00000001896CCE60-0x00000001896CCE80
	public void UnRegisterlEmitter(SyncId syncId) {} // 0x0000000183A6F580-0x0000000183A6F6E0
	// [XID] // 0x000000018995FDB0-0x000000018995FDD0
	public void RegisterListener(SyncId syncId) {} // 0x0000000183A71F00-0x0000000183A72060
	// [XID] // 0x000000018972A880-0x000000018972A8A0
	public void UnRegisterListener(SyncId syncId) {} // 0x0000000183A6F330-0x0000000183A6F490
	// [XID] // 0x0000000189A8FFD0-0x0000000189A8FFF0
	public void SetWorkerEnabled(bool enable) {} // 0x0000000183A70620-0x0000000183A70700
	// [XID] // 0x00000001896EA720-0x00000001896EA740
	public void SetGlobalRoom(uint roomNameId, ref RoomParams roomParams) {} // 0x0000000183A70050-0x0000000183A701E0
	// [XID] // 0x00000001896F16D0-0x00000001896F16F0
	public void ClearGlobalRoom() {} // 0x0000000183A70700-0x0000000183A70820
	// [XID] // 0x0000000189A40400-0x0000000189A40420
	public void AddRoom(uint roomNameId, ref RoomParams roomParams) {} // 0x0000000183A71A10-0x0000000183A71BA0
	// [XID] // 0x0000000189700B10-0x0000000189700B30
	public void RemoveRoom(uint roomNameId) {} // 0x0000000183A70350-0x0000000183A70480
	// [XID] // 0x00000001897081C0-0x00000001897081E0
	public void AddRoomBoxTrigger(uint roomNameId, Vector3 position, Quaternion rotation, Vector3 size) {} // 0x0000000183A724B0-0x0000000183A72690
	// [XID] // 0x000000018970FC10-0x000000018970FC30
	public void AddRoomSphereTrigger(uint roomNameId, Vector3 position, float radius) {} // 0x0000000183A6F1A0-0x0000000183A6F330
	// [XID] // 0x00000001897F44A0-0x00000001897F44C0
	public void SetRoomPortal(uint portalNameId, ref RoomPortalParams portalParams) {} // 0x0000000183A701E0-0x0000000183A70350
	// [XID] // 0x000000018971E7C0-0x000000018971E7E0
	public void RemovePortal(uint portalNameId) {} // 0x0000000183A71DD0-0x0000000183A71F00
	// [XID] // 0x0000000189BC2580-0x0000000189BC25A0
	public override void ExitHomeWorld() {} // 0x0000000183A71CD0-0x0000000183A71D70
	// [XID] // 0x000000018972D530-0x000000018972D550
	public void SetEnabled(bool enable) {} // 0x0000000183A6FEF0-0x0000000183A6FFF0
}

