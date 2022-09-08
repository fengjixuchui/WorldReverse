/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class EntityMetaData : ISimplePoolObject // TypeDefIndex: 21394
{
	// Fields
	public const uint DAILY_NPC_SUBKEY = 0; // Metadata: 0x00AFF77B
	private static SimpleObjectPool<EntityMetaData> _pool; // 0x00
	private bool _isBaned; // 0x10
	private bool _isDestroyed; // 0x11
	private bool _hasSetAutoStart; // 0x38
	private bool _isAutoStart; // 0x39
	private bool _hasPosInfo; // 0x3A
	private bool _holdOnReleaseCmd; // 0x54
	private RecycledLinkedList<BaseCommand> _cmdList; // 0x58
	private Dictionary<int, RecycledLinkedList<BaseCommand>> _cmdDic; // 0x60
	private List<BaseCommand> _cmd2Release; // 0x68
	private List<BaseCommand> _handleCmdList; // 0x70

	// Properties
	public bool isBaned { /* [XID] */ /* 0x00000001895F0560-0x00000001895F0580 */ get => default; /* [XID] */ /* 0x0000000189A80BE0-0x0000000189A80C00 */ private set {} } // 0x0000000182D827B0-0x0000000182D82850 0x0000000182D82600-0x0000000182D826B0
	public bool isDestroyed { /* [XID] */ /* 0x000000018960E540-0x000000018960E560 */ get => default; /* [XID] */ /* 0x0000000189615C00-0x0000000189615C20 */ private set {} } // 0x0000000182D82160-0x0000000182D82200 0x0000000182D83D70-0x0000000182D83E20
	public string alias { /* [XID] */ /* 0x000000018962C070-0x000000018962C0B0 */ get; /* [XID] */ /* 0x0000000189636DE0-0x0000000189636E20 */ private set; } // 0x0000000182D82D70-0x0000000182D82DD0 0x0000000182D83BC0-0x0000000182D83C20
	public string metaPath { /* [XID] */ /* 0x00000001896410E0-0x0000000189641120 */ get; /* [XID] */ /* 0x000000018964BCB0-0x000000018964BCF0 */ private set; } // 0x0000000182D82390-0x0000000182D823F0 0x0000000182D83F80-0x0000000182D83FE0
	public uint configId { /* [XID] */ /* 0x000000018965DA50-0x000000018965DA90 */ get; /* [XID] */ /* 0x0000000189668320-0x0000000189668360 */ private set; } // 0x0000000182D834D0-0x0000000182D83530 0x0000000182D83FE0-0x0000000182D84040
	public uint subKeyId { /* [XID] */ /* 0x0000000189672EE0-0x0000000189672F20 */ get; /* [XID] */ /* 0x000000018967D6A0-0x000000018967D6E0 */ private set; } // 0x0000000182D82850-0x0000000182D828B0 0x0000000182D82750-0x0000000182D827B0
	public uint sceneId { /* [XID] */ /* 0x00000001896882C0-0x0000000189688300 */ get; /* [XID] */ /* 0x0000000189692E10-0x0000000189692E50 */ private set; } // 0x0000000182D83810-0x0000000182D83870 0x0000000182D83EC0-0x0000000182D83F20
	public uint roomId { /* [XID] */ /* 0x000000018969D320-0x000000018969D360 */ get; /* [XID] */ /* 0x00000001896A7440-0x00000001896A7480 */ private set; } // 0x0000000182D837B0-0x0000000182D83810 0x0000000182D82490-0x0000000182D824F0
	public bool hasSetAutoStart { /* [XID] */ /* 0x00000001896C00D0-0x00000001896C00F0 */ get => default; } // 0x0000000182D84540-0x0000000182D845E0 
	public bool isAutoStart { /* [XID] */ /* 0x00000001898F3FF0-0x00000001898F4010 */ get => default; /* [XID] */ /* 0x00000001898DD0F0-0x00000001898DD110 */ set {} } // 0x0000000182D826B0-0x0000000182D82750 0x0000000182D82F80-0x0000000182D83030
	public bool hasPosInfo { /* [XID] */ /* 0x00000001896D6480-0x00000001896D64A0 */ get => default; } // 0x0000000182D823F0-0x0000000182D82490 
	public Vector3 pos { /* [XID] */ /* 0x00000001896DDB40-0x00000001896DDB80 */ get; /* [XID] */ /* 0x00000001896E7F00-0x00000001896E7F40 */ private set; } // 0x0000000182D82E70-0x0000000182D82EE0 0x0000000182D82590-0x0000000182D82600
	public Vector3 euler { /* [XID] */ /* 0x00000001896F2290-0x00000001896F22D0 */ get; /* [XID] */ /* 0x00000001896FCEB0-0x00000001896FCEF0 */ private set; } // 0x0000000182D846B0-0x0000000182D84720 0x0000000182D82D00-0x0000000182D82D70
	public RecycledLinkedList<BaseCommand> cmdList { /* [XID] */ /* 0x000000018970ED20-0x000000018970ED40 */ get => default; } // 0x0000000182D82DD0-0x0000000182D82E70 
	public Dictionary<int, RecycledLinkedList<BaseCommand>> cmdDic { /* [XID] */ /* 0x0000000189716120-0x0000000189716140 */ get => default; } // 0x0000000182D83430-0x0000000182D834D0 
	public List<BaseCommand> handleCmdList { /* [XID] */ /* 0x000000018971DB80-0x000000018971DBA0 */ get => default; } // 0x0000000182D83A10-0x0000000182D83BC0 
	public uint runtimeId { /* [XID] */ /* 0x000000018976F8D0-0x000000018976F910 */ get; /* [XID] */ /* 0x000000018977A0A0-0x000000018977A0E0 */ private set; } // 0x0000000182D83F20-0x0000000182D83F80 0x0000000182D83C20-0x0000000182D83C80

	// Constructors
	public EntityMetaData() {} // 0x0000000182D84AE0-0x0000000182D84B70
	static EntityMetaData() {} // 0x0000000182D84A70-0x0000000182D84AE0

	// Methods
	// [XID] // 0x000000018965BB70-0x000000018965BB90
	public static EntityMetaData Get() => default; // 0x0000000182D83350-0x0000000182D83430
	// [XID] // 0x00000001895E8D10-0x00000001895E8D30
	public static void Release(EntityMetaData metaData) {} // 0x0000000182D83C80-0x0000000182D83D70
	// [XID] // 0x00000001895FF390-0x00000001895FF3B0
	public void Ban() {} // 0x0000000182D83970-0x0000000182D83A10
	// [XID] // 0x0000000189606C40-0x0000000189606C60
	public void Free() {} // 0x0000000182D83E20-0x0000000182D83EC0
	// [XID] // 0x0000000189A79470-0x0000000189A79490
	public void Destroy() {} // 0x0000000182D824F0-0x0000000182D82590
	// [XID] // 0x0000000189624910-0x0000000189624930
	public void Create() {} // 0x0000000182D82EE0-0x0000000182D82F80
	// [XID] // 0x0000000189656370-0x0000000189656390
	public bool UpdateAlias(string newAlias, string newMetaPath, out string preAlias) {
		preAlias = default;
		return default;
	} // 0x0000000182D83110-0x0000000182D832B0
	// [XID] // 0x0000000189662E80-0x0000000189662EA0
	public void InitKey(uint newConfigId, uint newSubKeyId, uint newSceneId, uint newRoomId) {} // 0x0000000182D82B30-0x0000000182D82D00
	// [XID] // 0x0000000189A3D130-0x0000000189A3D150
	public bool UpdateKey(uint newConfigId, uint newSubKeyId, uint newSceneId, uint newRoomId) => default; // 0x0000000182D82200-0x0000000182D82390
	// [XID] // 0x00000001896890E0-0x0000000189689100
	public void UpdatePos(Vector3 newPos, Vector3 newEuler) {} // 0x0000000182D83620-0x0000000182D837B0
	// [XID] // 0x0000000189725060-0x0000000189725080
	public void BegainHandleCmd() {} // 0x0000000182D832B0-0x0000000182D83350
	// [XID] // 0x000000018972C780-0x000000018972C7A0
	public void EndHandleCmd() {} // 0x0000000182D83530-0x0000000182D83620
	// [XID] // 0x0000000189733E90-0x0000000189733EB0
	private void ReleaseCmd(BaseCommand cmd) {} // 0x0000000182D842A0-0x0000000182D843B0
	// [XID] // 0x000000018973B610-0x000000018973B630
	public void ResetObject() {} // 0x0000000182D84720-0x0000000182D84A70
	// [XID] // 0x00000001897430C0-0x00000001897430E0
	public void AddCacheCmd(BaseCommand cmd) {} // 0x0000000182D84040-0x0000000182D842A0
	// [XID] // 0x000000018974AC20-0x000000018974AC40
	public BaseCommand GetLastCmd(ActorCommandType cmdType) => default; // 0x0000000182D83870-0x0000000182D83970
	// [XID] // 0x0000000189751CB0-0x0000000189751CD0
	private void ClearGroupCmd(int cType) {} // 0x0000000182D843B0-0x0000000182D84540
	// [XID] // 0x0000000189971F90-0x0000000189971FB0
	public void ClearCacheCmd(ActorCommandType cmdType) {} // 0x0000000182D829F0-0x0000000182D82B30
	// [XID] // 0x0000000189760F70-0x0000000189760F90
	public void ClearAllCacheCmd() {} // 0x0000000182D828B0-0x0000000182D829F0
	// [XID] // 0x00000001896AE130-0x00000001896AE150
	public void PassCmdDic(EntityMetaData oldMetaData) {} // 0x0000000182D845E0-0x0000000182D846B0
	// [XID] // 0x0000000189805E30-0x0000000189805E50
	public void UpdateRuntimeId(uint newRuntimeId) {} // 0x0000000182D83030-0x0000000182D83110
}

