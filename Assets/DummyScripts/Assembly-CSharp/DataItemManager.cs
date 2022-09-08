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

public sealed class DataItemManager : GlobalManager // TypeDefIndex: 20795
{
	// Fields
	private Dictionary<uint, DataItem> _entityIdDataMap; // 0x10
	public Dictionary<ulong, UniqueDataItem> _guidDataMap; // 0x18
	private Dictionary<uint, Dictionary<int, Dictionary<uint, DataItem>>> _groupDataMap; // 0x20

	// Constructors
	public DataItemManager() {} // 0x0000000182DF9E10-0x0000000182DF9EE0

	// Methods
	// [XID] // 0x000000018981B940-0x000000018981B960
	public override void ReloadRes() {} // 0x0000000182DF9D70-0x0000000182DF9E10
	// [XID] // 0x0000000189751520-0x0000000189751540
	public DataItem GetDataByEntityId(uint entityId) => default; // 0x0000000182DF8930-0x0000000182DF8A20
	// [XID] // 0x000000018982A850-0x000000018982A870
	public void AddDataItemByEntityId(DataItem data) {} // 0x0000000182DF8200-0x0000000182DF8300
	// [XID] // 0x0000000189831C60-0x0000000189831C80
	public void AddGroupEntity(DataItem data, GroupEntityType groupEntityType, uint groupId, uint mapInstId) {} // 0x0000000182DF92B0-0x0000000182DF9890
	// [IDTag] // 0x0000000189839280-0x00000001898392C0
	// [XID] // 0x0000000189839280-0x00000001898392C0
	public DataItem GetDataByGroup(GroupEntityType groupEntityType, uint groupId, uint mapInstId) => default; // 0x0000000182DF9BA0-0x0000000182DF9D70
	// [IDTag] // 0x00000001898439A0-0x00000001898439E0
	// [XID] // 0x00000001898439A0-0x00000001898439E0
	public Dictionary<uint, DataItem> GetDataByGroup(GroupEntityType groupEntityType, uint groupId) => default; // 0x0000000182DF9A70-0x0000000182DF9BA0
	// [XID] // 0x000000018984DF20-0x000000018984DF40
	public void RemoveDataByEntityId(uint entityId) {} // 0x0000000182DF6990-0x0000000182DF6DB0
	public T CreateDataItemByEntityId<T>(uint entityId)
		where T : DataItem, new() => default;
	// [XID] // 0x0000000189854FB0-0x0000000189854FD0
	public UniqueDataItem GetDataByGUID(ulong guid) => default; // 0x0000000182DF8C90-0x0000000182DF8D80
	// [XID] // 0x000000018985C710-0x000000018985C730
	public void AddDataItemByGUID(UniqueDataItem data) {} // 0x0000000182DF8A20-0x0000000182DF8B20
	// [XID] // 0x00000001899C67F0-0x00000001899C6810
	public void RemoveDataByGUID(ulong guid, bool isRemoveEntity = true /* Metadata: 0x00AFE3D5 */) {} // 0x0000000182DF9890-0x0000000182DF9A10
	public T CreateDataItemByGUID<T>(ulong guid, bool unCacheEntity = false /* Metadata: 0x00AFE3D6 */)
		where T : UniqueDataItem, new() => default;
	// [XID] // 0x000000018986B460-0x000000018986B480
	public AvatarDataItem GetAvatarDataByGUID(ulong guid) => default; // 0x0000000182DF68C0-0x0000000182DF6990
	// [IDTag] // 0x00000001898727B0-0x00000001898727F0
	// [XID] // 0x00000001898727B0-0x00000001898727F0
	public AvatarDataItem GetAvatarDataByConfigId(uint configId) => default; // 0x0000000182DF9030-0x0000000182DF92B0
	// [IDTag] // 0x000000018987D370-0x000000018987D3B0
	// [XID] // 0x000000018987D370-0x000000018987D3B0
	public AvatarDataItem GetAvatarDataByConfigId(uint configId, AvatarType[] typeArray) => default; // 0x0000000182DF8D80-0x0000000182DF9030
	// [XID] // 0x0000000189887460-0x0000000189887480
	public uint AvatarGuid2AvatarId(ulong guid) => default; // 0x0000000182DF8040-0x0000000182DF8200
	// [XID] // 0x000000018988E5E0-0x000000018988E600
	public ulong AvatarId2AvatarGuid(uint avatarId) => default; // 0x0000000182DF78F0-0x0000000182DF7A80
	// [XID] // 0x0000000189895C20-0x0000000189895C40
	public override void Init() {} // 0x0000000182DF8890-0x0000000182DF8930
	// [XID] // 0x000000018989D240-0x000000018989D260
	public override void Destroy() {} // 0x0000000182DF7C20-0x0000000182DF7CD0
	// [XID] // 0x00000001898A4BE0-0x00000001898A4C00
	public override void ClearOnDisconnect() {} // 0x0000000182DF7400-0x0000000182DF75C0
	// [XID] // 0x00000001898AC0A0-0x00000001898AC0C0
	public override void ClearOnBackHome(bool forceClear = true /* Metadata: 0x00AFE3D7 */) {} // 0x0000000182DF7300-0x0000000182DF7400
	// [XID] // 0x00000001898B37C0-0x00000001898B37E0
	public override void ClearOnLevelDestroy() {} // 0x0000000182DF75C0-0x0000000182DF78F0
	// [XID] // 0x00000001898BB590-0x00000001898BB5B0
	public void RefreshDataItem() {} // 0x0000000182DF7CD0-0x0000000182DF8040
	// [XID] // 0x0000000189AF3930-0x0000000189AF3950
	private void RemoveEntity(uint entityId) {} // 0x0000000182DF6E80-0x0000000182DF6FF0
	// [XID] // 0x00000001898CA280-0x00000001898CA2A0
	public double GetAccountNormalPropValue(PropType type) => default; // 0x0000000182DF8780-0x0000000182DF8890
	// [XID] // 0x00000001898D19B0-0x00000001898D19D0
	public float GetPlayerStamina() => default; // 0x0000000182DF8540-0x0000000182DF8690
	// [XID] // 0x00000001898D91B0-0x00000001898D91D0
	public float GetPlayerStaminaRatio() => default; // 0x0000000182DF8300-0x0000000182DF8430
	// [XID] // 0x00000001898E0E50-0x00000001898E0E70
	public float GetAccountFightPropValue(FightPropType type) => default; // 0x0000000182DF8430-0x0000000182DF8540
	// [XID] // 0x00000001898E8940-0x00000001898E8960
	public double GetNormalPropValue(uint entityId, PropType type) => default; // 0x0000000182DF8B20-0x0000000182DF8C10
	// [XID] // 0x00000001898F0040-0x00000001898F0060
	public float GetFightPropValue(uint entityId, FightPropType type) => default; // 0x0000000182DF8690-0x0000000182DF8780
	// [XID] // 0x00000001898F7970-0x00000001898F7990
	public void HandleFightPropChange(FightPropType type, float value, PropChangeReason reason) {} // 0x0000000182DF6DB0-0x0000000182DF6E80
	// [XID] // 0x0000000189959AF0-0x0000000189959B10
	public ElementType GetAvatarElementType(ulong avatarGuid) => default; // 0x0000000182DF7A80-0x0000000182DF7B50
	// [XID] // 0x0000000189961490-0x00000001899614B0
	public bool GetAvatarCanChangeElementType(ulong avatarGuid) => default; // 0x0000000182DF7B50-0x0000000182DF7C20
	// [XID] // 0x000000018990E270-0x000000018990E290
	public void ClearDataItemEntityId() {} // 0x0000000182DF6FF0-0x0000000182DF7300
}

