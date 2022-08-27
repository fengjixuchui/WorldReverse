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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class ComponentFactory // TypeDefIndex: 20758
{
    // Fields
    protected static Action<EvtEntityReadyPost> _onEntityReadyPostCallback; // 0x00

    // Properties
    public static string MARK_LOCAL_AVATAR_CONFIG_PATH { /* [XID] */ /* 0x00000001898D2F70-0x00000001898D2F90 */ get => default; } // 0x00000001811C7DD0-0x00000001811C7E70 

    // Constructors
    public ComponentFactory() { } // 0x00000001811D1180-0x00000001811D11E0
    static ComponentFactory() { } // 0x00000001811D10B0-0x00000001811D1180

    // Methods
    // [XID] // 0x00000001898CB850-0x00000001898CB870
    public static void AddPreTickCompoent(BaseEntity entity, BaseComponent component) { } // 0x00000001811CBA20-0x00000001811CBB30
                                                                                          // [XID] // 0x00000001898DA920-0x00000001898DA940
    public static void CreateTeamComponents(GadgetEntity entity, ConfigGadget configGadget) { } // 0x00000001811CB1B0-0x00000001811CB570
                                                                                                // [XID] // 0x00000001898E2740-0x00000001898E2760
    public static void CreateMPTeamComponents(GadgetEntity entity, ConfigGadget configGadget) { } // 0x00000001811C84D0-0x00000001811C87C0
                                                                                                  // [XID] // 0x00000001898EA210-0x00000001898EA230
    public static void CreatePlayTeamComponents(GadgetEntity entity, ConfigGadget configGadget) { } // 0x00000001811C5A30-0x00000001811C5B30
                                                                                                    // [XID] // 0x00000001898F1A30-0x00000001898F1A50
    public static void CreateManekinComponents(BaseEntity entity, AvatarDataItem avatarData, ConfigAvatar avatarJsonConfig) { } // 0x00000001811C87C0-0x00000001811C8BA0
                                                                                                                                // [XID] // 0x00000001898F9190-0x00000001898F91B0
    public static void CreateAvatarComponents(AvatarEntity entity, TargetType targetType)
    {
        if (!entity.isAuthority)
        {
            if (GlobalVars.enableBillboard)
            {
                entity.AddComponent(new VCBillboard());
            }
            entity.AddComponent(new VCAvatarCombat());

            var avatarCombat = new LCAvatarCombat();
            entity.AddComponent(avatarCombat);
            ConfigAvatar configAvatar = entity.jsonConfig as ConfigAvatar;
            InitLCCombatComponent(avatarCombat, targetType, configAvatar.combat);

            entity.AddComponent(new VCFlyAttachment());
            entity.AddComponent(new VCAvatarModel());
            entity.AddComponent(new VCBaseEmotion());

            CreateAfterImageComponents(entity);

            entity.AddComponent(new VCCollision());

            BaseComponent ditherComponent;
            if (!entity.isAuthority)
            {
                ditherComponent = new VCSimpleSetDitherValue();
                (ditherComponent as VCSimpleSetDitherValue).DitherAlphaValue = 1f;
            }
            else
            {
                ditherComponent = new VCAvatarSetDitherValue();
            }
            entity.AddComponent(ditherComponent);

            entity.AddComponent(new VCMoveIKController());
            entity.AddComponent(new VCClimbIKController());
            entity.AddComponent(new VCAvatarPerform());

            VCAvatarAudio avatarAudio = new VCAvatarAudio();
            avatarAudio.voiceSwitch = configAvatar.audio.voiceSwitch;
            avatarAudio.bodyTypeSwitch = configAvatar.audio.bodyTypeSwitch;
            entity.AddComponent(avatarAudio);

            if (GlobalVars.useAvatarGrassDisplacement)
            {
                entity.AddComponent(new VCGrassDisplacment());
            }
            if (Miscs.IsAvatarRangeAttack(entity) && entity.isAuthority)
            {
                entity.AddComponent(new LCAvatarShoot());
            }
            entity.AddComponent(new VCAvatarFocus());
            if (entity.isAuthority)
            {
                entity.AddComponent(new LCAvatarAutoPickup());
                entity.AddComponent(new LCBaseInter());
                if (entity.jsonConfig.headControl.useHeadControl)
                {
                    if (GlobalVars.useHeadControl)
                    {
                        entity.AddComponent(new VCAvatarHeadController(entity.jsonConfig.headControl));
                    }
                }
                entity.AddComponent(new VCAvatarTriggerEvent());
                entity.AddComponent(new VCAvatarMoveToTask());
            }
            ConfigCharacter configCharacter = entity.jsonConfig as ConfigCharacter;
            CreateCharacterAnimatorStateComponent(entity, configCharacter.stateLayers);
            CreateAvatarEquipControllerComponent(entity);
            CreateAbilityComponent(entity, configCharacter.abilities);
            CreateTalentComponent(entity);
            if (entity.isAuthority)
            {
                CreateMarkableComponent(entity, MARK_LOCAL_AVATAR_CONFIG_PATH);
            }
            entity.AddComponent(new VCHumanoidMove());

            if (entity.isAuthority)
            {
                entity.AddComponent(new VCLocalInputController());
            }
            else
            {
                entity.AddComponent(new VCLocalInputController());
                entity.AddComponent(new LCSyncMotion());
            }
            entity.AddComponent(new VCSyncAnimator());
            entity.AddComponent(new VCCharacterRendering());

            if (GlobalVars.useRagdoll)
            {
                if (configAvatar.combat.die.useRagDoll)
                {
                    AddPreTickCompoent(entity, new VCRagdollController());
                }
            }
            entity.AddComponent(new VCDynamicBoneController());
        }

    } // 0x00000001811CBB30-0x00000001811CC6A0
      // [XID] // 0x0000000189900B10-0x0000000189900B30
    public static void CreateHeroAvatarComponents(AvatarEntity entity, TargetType targetType) { } // 0x00000001811CABC0-0x00000001811CB1B0
                                                                                                  // [XID] // 0x00000001899082D0-0x00000001899082F0
    public static void CreateMonsterComponents(MonsterEntity entity, TargetType targetType, bool isElite, List<uint> affixList, LCAIBetaData aiData, int currentPoseID) { } // 0x00000001811C5D00-0x00000001811C72A0
                                                                                                                                                                            // [XID] // 0x000000018990FA90-0x000000018990FAB0
    private static void CreateMonsterTriggerCompenent(BaseEntity entity, TargetType campType, ConfigMonster configMonster) { } // 0x00000001811CF9A0-0x00000001811CFE80
                                                                                                                               // [XID] // 0x000000018979C670-0x000000018979C690
    public static void CreateNpcComponents(GadgetEntity entity) { } // 0x00000001811C77A0-0x00000001811C7CF0
                                                                    // [XID] // 0x000000018991EB20-0x000000018991EB40
    public static void CreateAfterImageComponents(BaseEntity entity) { } // 0x00000001811C8FC0-0x00000001811C90F0
                                                                         // [XID] // 0x0000000189926400-0x0000000189926420
    public static void CreateGadgetComponents(ulong guid, GadgetEntity entity, TargetType campType, uint targetRuntimeID, uint targetLockPointIndex, GadgetExcelConfig config, ConfigGadget configGadget, GadgetDataItem gadgetDataItem = null) { } // 0x00000001811CCE80-0x00000001811CF9A0
                                                                                                                                                                                                                                                    // [XID] // 0x000000018992DAB0-0x000000018992DAD0
    public static void CreateScenePropComponents(GadgetEntity entity, TargetType campType, GadgetExcelConfig config, ConfigGadget configGadget) { } // 0x00000001811C7F70-0x00000001811C82E0
                                                                                                                                                    // [XID] // 0x0000000189934F50-0x0000000189934F70
    public static void CreateWeatherComponents(BaseEntity weatherArea) { } // 0x00000001811C82E0-0x00000001811C83C0
                                                                           // [XID] // 0x000000018993CAF0-0x000000018993CB10
    public static void CreateCameraComponents(CameraEntity camera, BaseEntity lookTarget, bool isMainCamera) { } // 0x00000001811C8C80-0x00000001811C8EB0
                                                                                                                 // [XID] // 0x00000001899440E0-0x0000000189944100
    public static void CreateLevelComponents(LevelEntity level) { } // 0x00000001811C90F0-0x00000001811C9420
                                                                    // [XID] // 0x000000018994B690-0x000000018994B6B0
    public static void CreateTransPointComponents(GadgetEntity entity, uint sceneId, uint pointId, SceneTransPoint config) { } // 0x00000001811CFE80-0x00000001811D0B80
                                                                                                                               // [XID] // 0x0000000189952F70-0x0000000189952F90
    protected static void OnEntityReadyPostCallback(EvtEntityReadyPost evt) { } // 0x00000001811C8EB0-0x00000001811C8FC0
                                                                                // [XID] // 0x000000018995A510-0x000000018995A530
    public static void CreateDungeonPointComponents(GadgetEntity entity, uint sceneId, uint pointId, ConfigScenePoint config) { } // 0x00000001811C9530-0x00000001811CA330
                                                                                                                                  // [XID] // 0x0000000189962010-0x0000000189962030
    public static void CreateLocalTriggerComponents(GadgetEntity entity, ConfigLocalTrigger config) { } // 0x00000001811D0D90-0x00000001811D10B0
                                                                                                        // [XID] // 0x0000000189BAD0E0-0x0000000189BAD100
    public static void CreateSpeedupFieldComponents(GadgetEntity entity, ConfigSpeedupField config) { } // 0x00000001811C7E70-0x00000001811C7F70
                                                                                                        // [XID] // 0x00000001899711E0-0x0000000189971200
    public static void CreateCannonFieldComponents(GadgetEntity entity, ConfigCannonField config) { } // 0x00000001811D0B80-0x00000001811D0C80
                                                                                                      // [XID] // 0x0000000189978B30-0x0000000189978B50
    public static void CreateAirflowFieldComponents(GadgetEntity entity, ConfigAirflowField config, bool useCollider, bool isLocalEntity) { } // 0x00000001811CB570-0x00000001811CB6B0
                                                                                                                                              // [XID] // 0x000000018997FBB0-0x000000018997FBD0
    private static void InitLCCombatComponent(LCBaseCombat lCombatCom, TargetType targetType, ConfigCombat configCombat) { } // 0x00000001811C7CF0-0x00000001811C7DD0
                                                                                                                             // [XID] // 0x0000000189987490-0x00000001899874B0
    public static void CreateCharacterAnimatorStateComponent(BaseEntity entity, Dictionary<string, ConfigBaseStateLayer> stateLayers) { } // 0x00000001811CB6B0-0x00000001811CBA20
                                                                                                                                          // [XID] // 0x000000018998F040-0x000000018998F060
    private static void CreateAvatarEquipControllerComponent(BaseEntity entity) { } // 0x00000001811C83C0-0x00000001811C84D0
                                                                                    // [XID] // 0x0000000189996B00-0x0000000189996B20
    private static void CreateManekinEquipControllerComponent(BaseEntity entity) { } // 0x00000001811C9420-0x00000001811C9530
                                                                                     // [XID] // 0x000000018999E6B0-0x000000018999E6D0
    private static void CreateMonsterEquipControllerComponent(BaseEntity entity) { } // 0x00000001811D0C80-0x00000001811D0D90
                                                                                     // [XID] // 0x00000001899A6090-0x00000001899A60B0
    private static void CreateMoveComponent(BaseEntity entity, ConfigMove moveArguments, uint targetRuntimeID, uint tergetLockPointIndex, GadgetDataItem gadgetDataItem = null) { } // 0x00000001811C72A0-0x00000001811C77A0
                                                                                                                                                                                    // [XID] // 0x00000001899AD6A0-0x00000001899AD6C0
    public static VCBulletMove CreateBulletMoveComponent(ConfigBulletMove config, uint targetRuntimeID, uint tergetLockPointIndex) => default; // 0x00000001811CC6A0-0x00000001811CC9A0
                                                                                                                                               // [XID] // 0x00000001899B4F00-0x00000001899B4F20
    public static void CreateAbilityComponent(BaseEntity entity, ConfigEntityAbilityEntry[] allAbilities, bool tickElement = true /* Metadata: 0x00AFE298 */, int abilityElementTickIntervalRatio = 6 /* Metadata: 0x00AFE299 */) { } // 0x00000001811CA330-0x00000001811CA5A0
                                                                                                                                                                                                                                      // [XID] // 0x00000001899BC630-0x00000001899BC650
    private static void CreateTalentComponent(BaseEntity entity) { } // 0x00000001811C8BA0-0x00000001811C8C80
                                                                     // [IDTag] // 0x00000001899C3FC0-0x00000001899C4000
                                                                     // [XID] // 0x00000001899C3FC0-0x00000001899C4000
    public static void CreateMarkableComponent(BaseEntity entity, string cfgPath) { } // 0x00000001811C5B30-0x00000001811C5BE0
                                                                                      // [IDTag] // 0x00000001899CE5B0-0x00000001899CE5F0
                                                                                      // [XID] // 0x00000001899CE5B0-0x00000001899CE5F0
    public static LCBaseMarkable CreateMarkableComponent(BaseEntity entity, MarkType markType, uint identifier) => default; // 0x00000001811C5BE0-0x00000001811C5D00
                                                                                                                            // [XID] // 0x0000000189814C90-0x0000000189814CB0
    private static void CreateGadgetTriggerCompenent(BaseEntity entity, TargetType campType, ConfigGadget configGadget) { } // 0x00000001811CC9A0-0x00000001811CCE80
                                                                                                                            // [XID] // 0x00000001899E01E0-0x00000001899E0200
    private static void CreateNpcCompByCfg(BaseEntity entity, NpcExcelConfig cfg, ConfigNpc configNpc) { } // 0x00000001811CA5A0-0x00000001811CABC0
}

