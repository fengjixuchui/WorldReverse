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
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class EntityFactory // TypeDefIndex: 20796
{
    // Fields
    private static bool _isInited; // 0x00
    private static Dictionary<uint, MonsterCreationData> _monsterCreateDataList; // 0x08
    private static Dictionary<uint, GadgetCreationData> _gadgetCreateDataList; // 0x10
    private static Dictionary<uint, AvatarEquipGadgetCreationData> _avatarEquipGadgetCreateDataList; // 0x18
    public static bool CLEAR_ON_BACK_HOME; // 0x20
    public static bool CLEAR_ON_LEVEL_DESTROY; // 0x21
    private const int ENTITY_GAMEOBJECT_POOL_MAX = 40; // Metadata: 0x00AFE426
    private static EntityGameObjectPool _entityGameObjectPool; // 0x28
    private static Queue<EntityGameObjectNode> _entityGameObjectPoolPending; // 0x30
    private static Dictionary<uint, bool> _config2BlackList; // 0x38
    private static Dictionary<uint, EntityGameObjectReUseHandler> _config2EntityGameObjectReUseHandler; // 0x40
    private static Dictionary<int, EntityGameObjectReUseHandler> _entityType2EntityGameObjectReUseHandler; // 0x48

    // Nested types
    private struct MonsterCreationData // TypeDefIndex: 20797
    {
        // Fields
        public uint entityID; // 0x00
        public int currentPoseID; // 0x04
        public LCAIBetaData aiData; // 0x08
        public float scale; // 0x10
        public bool isElite; // 0x14
        public List<uint> affixList; // 0x18

        // Constructors
        public MonsterCreationData(uint entityID, int currentPoseID, LCAIBetaData aiData, float scale, bool isElite, List<uint> affixList)
        {
            this.entityID = default;
            this.currentPoseID = default;
            this.aiData = default;
            this.scale = default;
            this.isElite = default;
            this.affixList = default;
        } // 0x0000000182037970-0x00000001820379B0
    }

    private struct GadgetCreationData // TypeDefIndex: 20798
    {
        // Fields
        public uint entityID; // 0x00
        public BaseEntity owner; // 0x08
        public bool isItemGadget; // 0x10
        public ulong guid; // 0x18
        public TargetType fCampType; // 0x20
        public uint targetRuntimeID; // 0x24
        public uint targetLockPointIndex; // 0x28
        public GadgetDataItem gadgetDataItem; // 0x30
        public ulong linkGuid; // 0x38

        // Constructors
        public GadgetCreationData(uint entityID, BaseEntity owner, bool isItemGadget, ulong guid, TargetType fCampType, uint targetRuntimeID, uint targetLockPointIndex, GadgetDataItem gadgetDataItem, ulong linkGuid)
        {
            this.entityID = default;
            this.owner = default;
            this.isItemGadget = default;
            this.guid = default;
            this.fCampType = default;
            this.targetRuntimeID = default;
            this.targetLockPointIndex = default;
            this.gadgetDataItem = default;
            this.linkGuid = default;
        } // 0x0000000182036F40-0x0000000182036F70
    }

    private struct AvatarEquipGadgetCreationData // TypeDefIndex: 20799
    {
        // Fields
        public uint entityID; // 0x00
        public ulong guid; // 0x08
        public TargetType fCampType; // 0x10
        public ItemConfig equipConfig; // 0x18

        // Constructors
        public AvatarEquipGadgetCreationData(uint entityID, ulong guid, TargetType fCampType, ItemConfig equipConfig)
        {
            this.entityID = default;
            this.guid = default;
            this.fCampType = default;
            this.equipConfig = default;
        } // 0x0000000182037730-0x0000000182037760
    }

    public delegate void EntityGameObjectReUseHandler(BaseEntity entity, GameObject go); // TypeDefIndex: 20800; 0x0000000182037220-0x00000001820374D0

    // Constructors
    public EntityFactory() { } // 0x0000000182031BA0-0x0000000182031CA0
    static EntityFactory() { } // 0x00000001820319A0-0x0000000182031BA0

    // Methods
    // [XID] // 0x00000001899952F0-0x0000000189995310
    public static void Init() { } // 0x0000000182028D90-0x0000000182028F90
                                  // [XID] // 0x000000018999CDB0-0x000000018999CDD0
    public static void ClearCreateDataList() { } // 0x00000001820318A0-0x00000001820319A0
                                                 // [XID] // 0x00000001899A4650-0x00000001899A4670
    public static BaseEntity CreateLocalGadget(uint configId, Vector3 initPos, Vector3 initEuler, bool createComponents) => default; // 0x000000018202AE40-0x000000018202B460
                                                                                                                                     // [XID] // 0x00000001899AC030-0x00000001899AC050
    public static BaseEntity CreateTimelineGadget(GameObject go) => default; // 0x00000001820314E0-0x00000001820318A0
                                                                             // [XID] // 0x00000001899B38A0-0x00000001899B38C0
    private static void SendAvatarConfigHashToServer(uint entityId, string hashString) { } // 0x000000018202F720-0x000000018202F900
                                                                                           // [XID] // 0x00000001899BAD00-0x00000001899BAD20
    public static BaseEntity CreateAvatar(ulong guid, uint entityId, uint configId, uint campID, Vector3 initPos, bool anyncLoad = true /* Metadata: 0x00AFE3D8 */, Action<BaseEntity> loadFinishCallback = null)
    {
        var avatardata = AvatarExcelConfigLoader.GetData(configId);
        AvatarEntity autoAllocRecycleEntity = null;
        if (avatardata != null)
        {
            PlayerModule player = Singleton<PlayerModule>.Instance;
            ulong[] id = new ulong[8];
            id[0] = player.accountData.userId;
            id[1] = entityId;
            id[2] = avatardata.id;
            id[3] = avatardata.prefabPathHash;
            id[4] = avatardata.prefabPathRemoteHash;
            id[5] = avatardata.controllerPathHash;
            id[6] = avatardata.controllerPathRemoteHash;
            id[7] = avatardata.combatConfigHash;
            SendAvatarConfigHashToServer(entityId, "{0}{1}{2}{3}{4}{5}{6}{7}");
            ulong prefabPathHash = avatardata.prefabPathHash;
            autoAllocRecycleEntity = RecycleExtension.AllocateAutoAllocRecycleType<AvatarEntity>();
            autoAllocRecycleEntity.bIgnoreIntervalTick = true;
            autoAllocRecycleEntity.questID = (uint)guid;
            autoAllocRecycleEntity.campID = campID;
            autoAllocRecycleEntity.entityType = EntityType.Avatar;
            autoAllocRecycleEntity.excelConfig = avatardata;
            autoAllocRecycleEntity.Init(entityId, configId, avatardata.scriptDataPathHash);

            bool flag = true;
            if (player.SyncAvatarEntityID == entityId)
            {
                autoAllocRecycleEntity.isAuthority = false;
                flag = false;
            }
            if (!autoAllocRecycleEntity.isAuthority && flag)
            {
                prefabPathHash = avatardata.prefabPathRemoteHash;
            }
            if (autoAllocRecycleEntity.isAuthority)
            {
                loadFinishCallback += (BaseEntity entity) =>
                {
                    entity.GetAnimator().cullingMode = AnimatorCullingMode.AlwaysAnimate;
                };
            }
            CreateSubEntity(autoAllocRecycleEntity, prefabPathHash, initPos, Quaternion.identity, 1.0f, anyncLoad, loadFinishCallback, false, false, null, (BaseEntity entity) =>
            {
                if (entity != null && entity.excelConfig != null)
                {
                    AvatarExcelConfig avatarExcel = entity.excelConfig as AvatarExcelConfig;
                    entity.jsonConfig = AvatarData.GetAvatarConfig(avatarExcel.combatConfigHash);
                    ComponentFactory.CreateAvatarComponents(entity as AvatarEntity, TargetType.Enemy);
                }
            });
        }
        else
        {
            SuperDebug.LogWarning("CreateAvatar config is null:" + configId);
        }
        return autoAllocRecycleEntity;
    }// 0x0000000182023030-0x0000000182023AB0
     // [XID] // 0x00000001899C2710-0x00000001899C2730
    private static void AvatarCreationPostJsonConfigLoaded(BaseEntity entity) { } // 0x000000018202E340-0x000000018202E4D0
                                                                                  // [XID] // 0x00000001899C9D20-0x00000001899C9D40
    public static BaseEntity CreateHeroAvatar(bool isSameAvatar, ulong guid, uint entityId, uint configId, uint campID, Vector3 initPos, bool anyncLoad = true /* Metadata: 0x00AFE3D9 */, Action<BaseEntity> loadFinishCallback = null) => default; // 0x000000018202CAF0-0x000000018202D5E0
                                                                                                                                                                                                                                                     // [XID] // 0x00000001899D15C0-0x00000001899D15E0
    private static void HeroAvatarCreationPostJsonConfigLoaded(BaseEntity entity) { } // 0x0000000182028C00-0x0000000182028D90
                                                                                      // [XID] // 0x00000001899D8B30-0x00000001899D8B50
    public static BaseEntity CreateManekin(uint entityId, uint configId, AvatarDataItem avatarData, bool anyncLoad = true /* Metadata: 0x00AFE3DA */, Action<BaseEntity> loadFinishCallback = null) => default; // 0x000000018202FA40-0x000000018202FF50
                                                                                                                                                                                                                // [XID] // 0x00000001899E01C0-0x00000001899E01E0
    public static BaseEntity CreateMonster(uint entityId, uint configId, Vector3 initPos, float yaw, int currentPoseID, LCAIBetaData aiData, uint? campID, float scale = 1f /* Metadata: 0x00AFE3DB */, bool anyncLoad = true /* Metadata: 0x00AFE3DF */, Action<BaseEntity> loadFinishCallback = null, bool isElite = false /* Metadata: 0x00AFE3E0 */, List<uint> affixList = null, uint authorityPeerId = 0 /* Metadata: 0x00AFE3E1 */, uint ownerRuntimeID = 0 /* Metadata: 0x00AFE3E5 */, MonsterDataItem dataItem = null, AbilitySyncStateInfo abilitySyncInfo = null) => default; // 0x000000018202FF50-0x0000000182030BE0
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         // [XID] // 0x00000001899E7CE0-0x00000001899E7D00
    private static void MonsterCreationPostJsonConfigLoad(BaseEntity entity) { } // 0x000000018202C700-0x000000018202CAF0
                                                                                 // [XID] // 0x00000001897514E0-0x0000000189751500
    public static BaseEntity CreateNpcEntity(uint entityId, uint configId, Vector3 initPos, Vector3 euler, uint roomID = 0 /* Metadata: 0x00AFE3E9 */, uint questID = 0 /* Metadata: 0x00AFE3ED */, bool async = false /* Metadata: 0x00AFE3F1 */) => default; // 0x000000018202BCE0-0x000000018202C280
                                                                                                                                                                                                                                                               // [XID] // 0x00000001899F6AB0-0x00000001899F6AD0
    public static BaseEntity CreatePaimon() => default; // 0x00000001820253F0-0x00000001820259A0
                                                        // [XID] // 0x0000000189B8F980-0x0000000189B8F9A0
    public static GadgetEntity CreateGadget(uint entityId, uint configId, uint? campID, TargetType? campType, Vector3? initPos, Quaternion? initRotation, ulong guid = 0 /* Metadata: 0x00AFE3F2 */, uint ownerRuntimeID = 0 /* Metadata: 0x00AFE3FA */, uint targetRuntimeID = 0 /* Metadata: 0x00AFE3FE */, uint targetLockPointIndex = 0 /* Metadata: 0x00AFE402 */, bool loadPrefabAsync = true /* Metadata: 0x00AFE406 */, Action<BaseEntity> loadFinishCallback = null, bool localGadgetNeedSync = false /* Metadata: 0x00AFE407 */, bool isItemGadget = false /* Metadata: 0x00AFE408 */, GadgetDataItem gadgetDataItem = null, uint authorityPeerId = 0 /* Metadata: 0x00AFE409 */, ulong linkGuid = 0 /* Metadata: 0x00AFE40D */, uint propOwnerRuntimeId = 0 /* Metadata: 0x00AFE415 */, bool sightGroupWithOwner = false /* Metadata: 0x00AFE419 */, AbilitySyncStateInfo abilitySyncInfo = null) => default; // 0x0000000182023BB0-0x0000000182024EC0
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         // [XID] // 0x0000000189A059B0-0x0000000189A059D0
    private static void GadgetCreationPostJsonConfigLoaded(BaseEntity entity) { } // 0x0000000182026E30-0x0000000182027510
                                                                                  // [XID] // 0x0000000189A0CC80-0x0000000189A0CCA0
    public static GadgetEntity CreateAvatarEquip(uint entityId, ulong guid, uint itemId, uint ownerRuntimeID, uint campID, TargetType campType, bool anyncLoad = true /* Metadata: 0x00AFE41A */, Action<BaseEntity> loadFinishCallback = null, bool ignoreLevelTimeScale = false /* Metadata: 0x00AFE41B */) => default; // 0x000000018202D5E0-0x000000018202DEA0
                                                                                                                                                                                                                                                                                                                          // [XID] // 0x0000000189A145C0-0x0000000189A145E0
    private static void AvatarEquipGadgetCreationPostJsonConfigLoaded(BaseEntity entity) { } // 0x0000000182028380-0x0000000182028650
                                                                                             // [XID] // 0x0000000189B66360-0x0000000189B66380
    public static GadgetEntity CreateManekinEquip(uint entityId, ulong guid, ulong linkGuid, uint configId, uint ownerRuntimeID, uint campID, TargetType campType, bool anyncLoad = true /* Metadata: 0x00AFE41C */, Action<BaseEntity> loadFinishCallback = null) => default; // 0x0000000182029AE0-0x0000000182029D20
                                                                                                                                                                                                                                                                               // [XID] // 0x0000000189A23240-0x0000000189A23260
    public static BaseEntity CreateTeamEntity(uint teamEntityId, uint authorityPeerId, bool isLocalEntity) => default; // 0x000000018202A5F0-0x000000018202AC30
                                                                                                                       // [XID] // 0x0000000189A2A460-0x0000000189A2A480
    public static BaseEntity CreatePlayTeamEntity(uint teamEntityId, uint authorityPeerId, uint configId) => default; // 0x000000018202E4D0-0x000000018202E950
                                                                                                                      // [XID] // 0x0000000189A31910-0x0000000189A31930
    public static BaseEntity CreateMPLevelEntity(uint entityId, uint authorityPeerId) => default; // 0x000000018202DEA0-0x000000018202E340
                                                                                                  // [XID] // 0x0000000189A39430-0x0000000189A39450
    public static BaseEntity CreateCamera(bool isMainCamera, BaseEntity lookTarget) => default; // 0x0000000182025C10-0x00000001820260A0
                                                                                                // [XID] // 0x0000000189A40BF0-0x0000000189A40C10
    public static BaseEntity CreateLevelEntity() => default; // 0x000000018202EA90-0x000000018202EEC0
                                                             // [XID] // 0x0000000189A48250-0x0000000189A48270
    public static BaseEntity CreateDummyLevelEntity() => default; // 0x00000001820261E0-0x00000001820264C0
                                                                  // [XID] // 0x0000000189A4FB00-0x0000000189A4FB20
    public static GadgetEntity CreateDummyEntity(bool createGameObject = false /* Metadata: 0x00AFE41D */) => default; // 0x000000018202A2B0-0x000000018202A5F0
                                                                                                                       // [XID] // 0x000000018974D250-0x000000018974D270
    private static void ScenePropGadgetCreationPostJsonConfigLoaded(BaseEntity entity) { } // 0x00000001820259A0-0x0000000182025B80
                                                                                           // [XID] // 0x00000001897201A0-0x00000001897201C0
    public static GrassEntity CreateGrass(Vector3 initPos, float yaw, Vector3 scale, GameObject grassGO = null, bool isCreatedByClient = true /* Metadata: 0x00AFE41E */) => default; // 0x0000000182029D20-0x000000018202A2B0
                                                                                                                                                                                      // [XID] // 0x0000000189A66390-0x0000000189A663B0
    public static void CreateMassiveEntityFromServer(ScenePropEntity scenePropEntity, uint entityId, uint configId) { } // 0x00000001820311A0-0x00000001820314E0
                                                                                                                        // [XID] // 0x0000000189A6DAE0-0x0000000189A6DB00
    public static WaterEntity CreateWater(GameObject waterGO, bool isCreatedByClient = true /* Metadata: 0x00AFE41F */) => default; // 0x0000000182024EC0-0x00000001820253F0
                                                                                                                                    // [XID] // 0x0000000189A75210-0x0000000189A75230
    public static BushEntity CreateBush(uint configId, GameObject bushGO = null) => default; // 0x0000000182030CC0-0x00000001820311A0
                                                                                             // [XID] // 0x0000000189A7CE90-0x0000000189A7CEB0
    public static TreeEntity CreateTree(uint configId, GameObject treeGO = null) => default; // 0x0000000182029570-0x0000000182029A50
                                                                                             // [IDTag] // 0x0000000189A84780-0x0000000189A847C0
                                                                                             // [XID] // 0x0000000189A84780-0x0000000189A847C0
    public static BaseEntity CreateScenePointEntity(uint sceneId, uint pointId) => default; // 0x000000018202F5E0-0x000000018202F720
                                                                                            // [IDTag] // 0x0000000189A8F0B0-0x0000000189A8F0F0
                                                                                            // [XID] // 0x0000000189A8F0B0-0x0000000189A8F0F0
    public static BaseEntity CreateScenePointEntity(ConfigScenePoint configTransPoint, uint sceneId, uint pointId) => default; // 0x000000018202EEC0-0x000000018202F5E0
                                                                                                                               // [XID] // 0x0000000189A99A00-0x0000000189A99A20
    private static void ScenePointEntityCreationPostJsonConfigLoaded(BaseEntity entity) { } // 0x000000018202B460-0x000000018202B7B0
                                                                                            // [XID] // 0x0000000189AA0A60-0x0000000189AA0A80
    public static BaseEntity CreateRiseField(ConfigRiseField config) => default; // 0x0000000182028F90-0x0000000182029460
                                                                                 // [XID] // 0x0000000189AA80E0-0x0000000189AA8100
    private static void CreateLuaGadgetActor(string alias, uint gadgetId, GadgetEntity entity, uint runtimeID) { } // 0x0000000182028650-0x0000000182028A40
                                                                                                                   // [XID] // 0x0000000189AAFCD0-0x0000000189AAFCF0
    public static BaseEntity CreateAirflowField(ConfigAirflowField config, Vector3? pos = default, Quaternion? rot = default, bool useCollider = true /* Metadata: 0x00AFE420 */) => default; // 0x0000000182027D20-0x0000000182028380
                                                                                                                                                                                              // [XID] // 0x0000000189AB7430-0x0000000189AB7450
    public static BaseEntity CreateItemDropEffect(Vector3 pos, uint gadgetID, string effectName) => default; // 0x0000000182026740-0x0000000182026CF0
                                                                                                             // [XID] // 0x0000000189ABEE90-0x0000000189ABEEB0
    public static BaseEntity CreateLoadingDoorEntity(uint id, ConfigLoadingDoor config) => default; // 0x0000000182027510-0x00000001820279B0
                                                                                                    // [XID] // 0x0000000189AC69B0-0x0000000189AC69D0
    private static void CreateSubEntity(BaseEntity entity, ulong prefabPathHash, Vector3 initPos, Quaternion initRotation, float scale, bool loadPrefabAsync = true /* Metadata: 0x00AFE421 */, Action<BaseEntity> loadFinishCallback = null, bool createGameObjectIfDummy = false /* Metadata: 0x00AFE422 */, bool forceDontUseUpdateRigidbody = false /* Metadata: 0x00AFE423 */, GameObject givenGameObject = null, Action<BaseEntity> jsonLoadedCallback = null) { } // 0x00000001820279B0-0x0000000182027D20
                                                                                                                                                                                                                                                                                                                                                                                                                                                                         // [XID] // 0x00000001896D5C60-0x00000001896D5C80
    public static EntityGameObjectNode GetGameObjectNode(uint configId) => default; // 0x0000000182030BE0-0x0000000182030CC0
                                                                                    // [XID] // 0x0000000189AD5F00-0x0000000189AD5F20
    public static void SetGameObjectNode(uint configId, EntityGameObjectNode node, bool isLightActive = true /* Metadata: 0x00AFE424 */) { } // 0x000000018202B7B0-0x000000018202B8E0
                                                                                                                                             // [XID] // 0x0000000189ADD850-0x0000000189ADD870
    public static void TickSetGameObject(bool flushAll = false /* Metadata: 0x00AFE425 */) { } // 0x0000000182028A40-0x0000000182028C00
                                                                                               // [XID] // 0x0000000189AE5000-0x0000000189AE5020
    public static void ClearGameObject(uint configId) { } // 0x0000000182029460-0x0000000182029570
                                                          // [XID] // 0x0000000189AEC680-0x0000000189AEC6A0
    public static void ClearGameObjectAll() { } // 0x000000018202AC30-0x000000018202AE40
                                                // [XID] // 0x0000000189AF4110-0x0000000189AF4130
    private static bool GetEntityGameObjectReUseHandler(BaseEntity entity, out EntityGameObjectReUseHandler handler)
    {
        handler = default;
        return default;
    } // 0x000000018202B8E0-0x000000018202BAE0
      // [XID] // 0x0000000189AFB8C0-0x0000000189AFB8E0
    public static void InitEntityGameObjectReUse() { } // 0x000000018202C370-0x000000018202C700
                                                       // [XID] // 0x0000000189B02F50-0x0000000189B02F70
    private static void RegisterGameObjectBlacklist(uint configId) { } // 0x000000018202C280-0x000000018202C370
                                                                       // [IDTag] // 0x0000000189B0A6E0-0x0000000189B0A720
                                                                       // [XID] // 0x0000000189B0A6E0-0x0000000189B0A720
    private static void RegisterGameObjectReUseHandler(uint configId, EntityGameObjectReUseHandler handler) { } // 0x000000018202BBE0-0x000000018202BCE0
                                                                                                                // [IDTag] // 0x0000000189B14AD0-0x0000000189B14B10
                                                                                                                // [XID] // 0x0000000189B14AD0-0x0000000189B14B10
    private static void RegisterGameObjectReUseHandler(EntityType entityType, EntityGameObjectReUseHandler handler) { } // 0x000000018202BAE0-0x000000018202BBE0
                                                                                                                        // [XID] // 0x0000000189B1F240-0x0000000189B1F260
    private static EntityGameObjectReUseHandler GetGameObjectReUseHandler(uint configId) => default; // 0x0000000182023AB0-0x0000000182023BB0
                                                                                                     // [XID] // 0x0000000189B26A90-0x0000000189B26AB0
    public static bool CheckEntityGameObjectReUse(BaseEntity entity, GameObject go, GameObject offsetDummyObject, GameObject animatorObject) => default; // 0x00000001820264C0-0x0000000182026740
                                                                                                                                                         // [XID] // 0x0000000189B2DC60-0x0000000189B2DC80
    private static void GameObjectReUseHeavyActive(BaseEntity entity, GameObject go) { } // 0x00000001820260A0-0x00000001820261E0
                                                                                         // [XID] // 0x0000000189B350D0-0x0000000189B350F0
    private static void GameObjectReUseGadget(BaseEntity entity, GameObject go) { } // 0x000000018202E950-0x000000018202EA90
                                                                                    // [XID] // 0x0000000189B3C980-0x0000000189B3C9A0
    private static void GameObjectReUseNpc(BaseEntity entity, GameObject go) { } // 0x0000000182026CF0-0x0000000182026E30
                                                                                 // [XID] // 0x0000000189B446F0-0x0000000189B44710
    private static void GameObjectReUseMonster(BaseEntity entity, GameObject go) { } // 0x000000018202F900-0x000000018202FA40
}

