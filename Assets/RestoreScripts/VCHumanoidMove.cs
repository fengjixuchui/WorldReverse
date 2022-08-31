/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using FullInspector;
using IFix.Core;
using motion4hi;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
    [Serializable]
    public sealed class VCHumanoidMove : VCBaseMove // TypeDefIndex: 11884
    {
        // Fields
        public BodyType moveModelType; // 0x1D8
        private const float AVATAR_DEFAULT_HEIGHT = 1.6f; // Metadata: 0x00AEADF9
        private const float AVATAR_RADIUS_HEIGHT_RATIO = 0.125f; // Metadata: 0x00AEADFD
        public const float AVATAR_MOVE_COLLIDER_UP_BOTTOM_HEIGHT_RATIO = 0.6f; // Metadata: 0x00AEAE01
        public const float AVATAR_MOVE_COLLIDER_DOWN_BOTTOM_HEIGHT_RATIO = 0.301f; // Metadata: 0x00AEAE05
        public const float AVATAR_KNEE_HEIGHT_RATIO = 0.3f; // Metadata: 0x00AEAE09
        public const float AVATAR_WAIST_HEIGHT_RATIO = 0.6f; // Metadata: 0x00AEAE0D
        private const float AVATAR_FOOT_POSITION_OFFSET = 0.05f; // Metadata: 0x00AEAE11
        public const float WATERFALL_DROP_ANGLE = 30f; // Metadata: 0x00AEAE15
        public float minClimbSlope = 50f; // 0x1DC
        public float maxClimbSlope = 125f; // 0x1E0
        public float maxMoveSlope = 57.5f; // 0x1E4
        public float minSlipSlope = 52.5f; // 0x1E8
        public float upstairTanConst = 0.60707033f; // 0x1EC
        public float slipDropThreshold = 80f; // 0x1F0
        public float maxSlipSpeed = 8f; // 0x1F4
        public float slipAcceleration = 20f; // 0x1F8
        public float slipRapidDecelerationSlope = 40f; // 0x1FC
        public float slipRapidDecelerationRatio = 10f; // 0x200
        public float slipHaltSlope = 30f; // 0x204
        public float waterfallExtraDownAngle = 25f; // 0x208
        public float dropCliffAngleThreshold = 0.6f; // 0x20C
        public float dropLandLightMaxSpeed = -9f; // 0x210
        public float dropLandMiddleMaxSpeed = -14f; // 0x214
        public float yawSpeedRatio = 10f; // 0x218
        public float swimYawSpeedRatio = 3f; // 0x21C
        public float swimDashYawSpeedRatio = 1f; // 0x220
        public float startSwimHeightRatio = 0.8f; // 0x224
        public float stopSwimHeightRatio = 0.7f; // 0x228
        public float SwimHeightRatio = 0.76f; // 0x22C
        public float airToSwimHeightRatio = 0.5f; // 0x230
        public float swimEnableSprintHeightRatio = 0.4f; // 0x234
        public float climbCloseToGroundDist = 0.3f; // 0x238
        public float hipOffsetFromIK; // 0x23C
        public float avatarModelHeight; // 0x244
        public float avatarModelClimbHeight; // 0x248
        [NonSerialized]
        public float avatarWaitToheadHeight; // 0x24C
        public float moveSphereCastRadius = 0.1f; // 0x25C
        public HumanoidMoveFSMGoUpstairsState.PoseParameter climbToStandbyHard; // 0x260
        public HumanoidMoveFSMGoUpstairsState.PoseParameter climbToStandbyMiddle; // 0x28C
        public HumanoidMoveFSMGoUpstairsState.PoseParameter climbToStandbyLight; // 0x2B8
        public HumanoidMoveFSMGoUpstairsState.PoseParameter jumpUpstairs; // 0x2E4
        public HumanoidMoveFSMGoUpstairsState.PoseParameter climbtoStandbyGentle; // 0x310
        public AnimationCurve jumpUpstairsHighCurve; // 0x340
        public AnimationCurve jumpUpstairsLowCurve; // 0x348
        public AnimationCurve jumpUpstairsHighZCurve; // 0x350
        public AnimationCurve jumpUpstairsLowZCurve; // 0x358
        public Rigidbody dummyRigidbody; // 0x368
        [NonSerialized]
        public MonoAnimationIKEventHelper animatorMoveHelper; // 0x370
        [NonSerialized]
        public HeightmapPlugin heightmap; // 0x378
        public float closeToLadderDist = 0.3f; // 0x380
        [NonSerialized]
        [HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
        public string animatorTriggerOnLanded; // 0x388
        public Animator animator; // 0x390
        public AnimatorController animatorController; // 0x398
        public float sprintCheckInterval = 0.8f; // 0x3A0
        public float muteSprintInterval = 1.5f; // 0x3A4
        public StandbyIKParams[] standbyIKParams; // 0x3A8
        private Rigidbody _rigidbody; // 0x3B0
        private Vector3 _center; // 0x3B8
        private int _rotationFrame; // 0x3C4
        private VCHumanoidMoveConfig _moveConfig; // 0x3C8
        private RuntimeAnimatorController _cacheRuntimeAnimatorCtrl; // 0x3D0
        [InspectorCollapsedFoldout] // 0x000000018996D100-0x000000018996D130
        [ShowInInspector] // 0x000000018996D100-0x000000018996D130
        private HumanoidMoveFSM _humanoidMoveFSM; // 0x3D8
        private HumanoidMoveEffectPlugin _effectPlugin; // 0x3E0
        [NonSerialized]
        public VCLevel vcLevel; // 0x3E8
        private LevelMoveScenePropPlugin _scenePropPlugin; // 0x3F0
        private const float DEFAULT_BLINK_DIST = 8f; // Metadata: 0x00AEAE19
        public VCAvatarPerform vcPerform; // 0x3F8
        public float orthogonalVelocityRatio = 0.1f; // 0x400
        private VCHumanoidMoveData _humanoidMoveData; // 0x408
        private MotionInfo _motionInfo; // 0x410
        public RocketJumpExt rocketJumpSetting; // 0x418
        public float runStopVelocityRatio = 0.5f; // 0x420
        public Transform moveHeadTrans; // 0x428
        public Transform climbHeadTrans; // 0x430
        public Transform footTrans; // 0x438
        public Transform waistTrans; // 0x440
        public Transform kneeTrans; // 0x448
        private bool _needFaceToAnimParamEver; // 0x450
        private const float FIX_DIR_4_MOVE_SPEED = 4f; // Metadata: 0x00AEAE1D
        public LCAbilityState lcAblityState; // 0x458
        [NonSerialized]
        [NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
        private VCAvatarEquipController _equipController; // 0x460
        private Collider[] tempCollider = new Collider[1]; // 0x468
        private const float SAFE_APPEAR_XZ_DISTANCE = 0.9f; // Metadata: 0x00AEAE21
        private const float SAFE_APPEAR_XZ_RAY_DISTANCE = 1.3f; // Metadata: 0x00AEAE25
        private const float SAFE_APPEAR_Y_RAY_DISTANCE = 2f; // Metadata: 0x00AEAE29
        private const float SAFE_APPEAR_ALLOW_SLOPE_ANGLE = 40f; // Metadata: 0x00AEAE2D
        private static int _safeAppearPositionCheckLayer; // 0x00
        private static RaycastHit safeAppearPositionCheckHitResult; // 0x08
        private static float _checkAvatarHeight; // 0x48
        private static List<BaseEntity> _avatars; // 0x50
        private static Vector3[] _avatarPositions = new Vector3[8]; // 0x58
        private static int[] _avatarIndex = new int[8]; // 0x60
        private static int _activeAvatarNumber; // 0x68
        private string SYNC_STATE_TEXT_FORMAT = "player {0} {1}: pac = {2} delay= {3} curTime = {4}"; // 0x470
        [NonSerialized]
        [NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
        public bool freeMode; // 0x478

        // Properties
        public override int metaTypeID { /* [XID] */ /* 0x0000000189A490D0-0x0000000189A490F0 */ get => VCBaseComponentTypeIDs.VCHumanoidMove; } // 0x0000000183BFBB30-0x0000000183BFBBD0 
        [HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
        public float avatarHeight { /* [XID] */ /* 0x0000000189A04BE0-0x0000000189A04C20 */ get; /* [XID] */ /* 0x0000000189A0F0E0-0x0000000189A0F120 */ private set; } // 0x0000000183BFB9E0-0x0000000183BFBA50 0x0000000183BFBE90-0x0000000183BFBF00
        [HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
        public float avatarShoesHeight { /* [XID] */ /* 0x0000000189A19770-0x0000000189A197B0 */ get; /* [XID] */ /* 0x0000000189A23DD0-0x0000000189A23E10 */ private set; } // 0x0000000183BFBAC0-0x0000000183BFBB30 0x0000000183BFBF70-0x0000000183BFBFE0
        [HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
        public float avatarRadius { /* [XID] */ /* 0x0000000189A2E020-0x0000000189A2E060 */ get; /* [XID] */ /* 0x0000000189A38B10-0x0000000189A38B50 */ private set; } // 0x0000000183BFBA50-0x0000000183BFBAC0 0x0000000183BFBF00-0x0000000183BFBF70
        [HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
        public float avatarHeadExtraHeight { /* [XID] */ /* 0x0000000189A43240-0x0000000189A43280 */ get; /* [XID] */ /* 0x0000000189A4D770-0x0000000189A4D7B0 */ private set; } // 0x0000000183BFB970-0x0000000183BFB9E0 0x0000000183BFBE20-0x0000000183BFBE90
        public AirRigidbody airRigidbody { /* [XID] */ /* 0x0000000189A57D60-0x0000000189A57DA0 */ get; /* [XID] */ /* 0x0000000189A625A0-0x0000000189A625E0 */ private set; } // 0x0000000183BFB910-0x0000000183BFB970 0x0000000183BFBDB0-0x0000000183BFBE20
        public LevelMoveScenePropPlugin scenePropPlugin
        { /* [XID] */ /* 0x0000000189A6D0D0-0x0000000189A6D0F0 */
            get
            {
                if (_scenePropPlugin == null)
                {
                    _scenePropPlugin = Singleton<EntityManager>.Instance.levelEntity.GetLCLevelComponent().GetPlugin<LevelMoveScenePropPlugin>();
                }
                return _scenePropPlugin;
            }
        } // 0x0000000183BFBBD0-0x0000000183BFBD00 
        public override bool KeepInAirVelocityForce
        { /* [XID] */ /* 0x00000001896001F0-0x0000000189600210 */
            get
            {
                if (_keepInAirVelocityForce)
                    return true;
                if (lcAblityState != null)
                {
                    return ExtensionMethods.ContainsState(lcAblityState.abilityState, AbilityState.Struggle);
                }
                return false;
            }/* [XID] */ /* 0x0000000189693AD0-0x0000000189693AF0 */
            set
            {
                _keepInAirVelocityForce = value;
            }
        } // 0x0000000183BFB830-0x0000000183BFB910 0x0000000183BFBD00-0x0000000183BFBDB0

        // Nested types
        [Serializable]
        public struct StandbyIKParams // TypeDefIndex: 11885
        {
            // Fields
            public WeaponType type; // 0x00
            public float lMin; // 0x04
            public float lMax; // 0x08
            public float rMin; // 0x0C
            public float rMax; // 0x10
        }

        // Methods
        // [XID] // 0x0000000189A57E80-0x0000000189A57EA0
        public override void PreInit()
        {
            base.PreInit();
            canHandleEventIfDie = true;
            order = 1;
            if (_entity.excelConfig != null)
            {
                moveModelType = (_entity.excelConfig as AvatarExcelConfig).bodyType;
                CopyConfigFromAsset(VCHumanoidMoveScriptAssetData.GetVCHumanoidMoveScriptAssetData(moveModelType));
            }
        } // 0x0000000183BFB1C0-0x0000000183BFB330
          // [XID] // 0x0000000189A67430-0x0000000189A67450
        public void CopyConfigFromAsset(VCHumanoidMoveScriptAssetData data)
        {
            climbCloseToGroundDist = data.climbCloseToGroundDist;
            avatarModelHeight = data.avatarModelHeight;
            avatarModelClimbHeight = data.avatarModelClimbHeight;
            climbToStandbyHard.length = data.climbToStandbyHard.length;
            climbToStandbyHard.enableMove = data.climbToStandbyHard.enableMove;
            climbToStandbyHard.distUp = data.climbToStandbyHard.distUp;
            climbToStandbyHard.enable50Blend = data.climbToStandbyHard.enable50Blend;
            climbToStandbyMiddle.length = data.climbToStandbyMiddle.length;
            climbToStandbyMiddle.enableMove = data.climbToStandbyMiddle.enableMove;
            climbToStandbyMiddle.distUp = data.climbToStandbyMiddle.distUp;
            climbToStandbyMiddle.enable50Blend = data.climbToStandbyMiddle.enable50Blend;
            climbToStandbyLight.length = data.climbToStandbyLight.length;
            climbToStandbyLight.enableMove = data.climbToStandbyLight.enableMove;
            climbToStandbyLight.distUp = data.climbToStandbyLight.distUp;
            climbToStandbyLight.enable50Blend = data.climbToStandbyLight.enable50Blend;
            jumpUpstairs.length = data.jumpUpstairs.length;
            jumpUpstairs.enableMove = data.jumpUpstairs.enableMove;
            jumpUpstairs.distUp = data.jumpUpstairs.distUp;
            jumpUpstairs.enable50Blend = data.jumpUpstairs.enable50Blend;
            climbtoStandbyGentle.length = data.climbtoStandbyGentle.length;
            climbtoStandbyGentle.enableMove = data.climbtoStandbyGentle.enableMove;
            climbtoStandbyGentle.distUp = data.climbtoStandbyGentle.distUp;
            climbtoStandbyGentle.enable50Blend = data.climbtoStandbyGentle.enable50Blend;
            jumpUpstairsHighCurve = data.jumpUpstairsHighCurve;
            jumpUpstairsLowCurve = data.jumpUpstairsLowCurve;
            jumpUpstairsHighZCurve = data.jumpUpstairsHighZCurve;
            jumpUpstairsLowZCurve = data.jumpUpstairsLowZCurve;
            standbyIKParams = data.standbyIKParams;
        } // 0x0000000183BED8B0-0x0000000183BEDAE0
          // [XID] // 0x0000000189A6EAE0-0x0000000189A6EB00
        public Vector3 GetCurrentWallNormal() => _humanoidMoveFSM.GetCurrentWallNormal(); // 0x0000000183BF7780-0x0000000183BF7880
                                                                                          // [XID] // 0x0000000189A85550-0x0000000189A85570
        public override void Init()
        {
            base.Init();
            BaseEntity level = Singleton<EntityManager>.Instance.levelEntity;
            vcLevel = level.GetVisualComponent<VCLevel>(VCBaseComponentTypeIDs.VCLevel);
            _scenePropPlugin = level.GetLCLevelComponent().GetPlugin<LevelMoveScenePropPlugin>();
            animator = _entity.GetAnimator();
            animatorController = _entity.gameObject.GetComponent<AnimatorController>();
            if (animator)
            {
                _cacheRuntimeAnimatorCtrl = animator.runtimeAnimatorController;
            }
            animatorMoveHelper = _entity.gameObject.GetComponent<MonoAnimationIKEventHelper>();
            if (!animatorMoveHelper)
            {
                animatorMoveHelper = _entity.gameObject.AddComponent<MonoAnimationIKEventHelper>();
            }
            InitHumanoid();
            InitAbilityPropertyCallback();
        } // 0x0000000183BF3820-0x0000000183BF3B30
          // [XID] // 0x0000000189A92C00-0x0000000189A92C20
        public override void OnEntityReady()
        {
            base.OnEntityReady();
            vcPerform = GetVisualComponent<VCAvatarPerform>(VCBaseComponentTypeIDs.VCAvatarPerform);
        } // 0x0000000183BFA390-0x0000000183BFA450
          // [XID] // 0x0000000189B6D910-0x0000000189B6D930
        public override void Clear(BaseEntity.ClearReason clearReason)
        {
            base.Clear(clearReason);
            ResetFSM();
        } // 0x0000000183BECE90-0x0000000183BECF60
          // [XID] // 0x0000000189AA16E0-0x0000000189AA1700
        private void InitHumanoid()
        {
            SetAvatarHeight();
            _transform = _entity.transform;
            _moveConfig = new VCHumanoidMoveConfig();
            _moveConfig.SetDefaultRocketJump(rocketJumpSetting);
            _moveConfig.ResetRocketJump();
            _moveData = new VCHumanoidMoveData();
            var humanMoveData = (_moveData as VCHumanoidMoveData);
            humanMoveData.vcHumanoidMove = this;
            _humanoidMoveData = humanMoveData;
            _rigidbody = _entity.rootGameObject.GetComponent<Rigidbody>();

            var footPos = Vector3.up * (avatarShoesHeight + 0.5f) + _transform.position;
            _entity.SetDynamicPointPos("Foot", footPos);

            footPos.Set(0, footPos.y, 0);
            var kneePos = footPos * ((avatarModelHeight + 0.3f) + avatarShoesHeight) + _transform.position;
            _entity.SetDynamicPointPos("Knee", kneePos);

            kneePos.Set(0, kneePos.y, 0);
            var waistPos = kneePos * ((avatarModelHeight + 0.6f) + avatarShoesHeight) + _transform.position;
            _entity.SetDynamicPointPos("Waist", waistPos);

            waistPos.Set(0, kneePos.y, 0);
            var climbHeadPos = kneePos * ((avatarHeadExtraHeight + avatarModelClimbHeight) + avatarShoesHeight) + _transform.position;
            _entity.SetDynamicPointPos("ClimbHead", climbHeadPos);

            moveHeadTrans = _entity.GetAttachPoint("MoveHead");
            climbHeadTrans = _entity.GetAttachPoint("ClimbHead");
            footTrans = _entity.GetAttachPoint("Foot");
            waistTrans = _entity.GetAttachPoint("Waist");
            kneeTrans = _entity.GetAttachPoint("Knee");

            _rigidbody.angularDrag = 0;
            _rigidbody.maxAngularVelocity = 10000;

            InitMoveCollider();
            airRigidbody = new AirRigidbody();
            heightmap = new HeightmapPlugin();
            AddPlugin(heightmap);
            _humanoidMoveFSM = new HumanoidMoveFSM();
            AddPlugin(_humanoidMoveFSM);
            syncPlugin = new BaseMoveSyncPlugin();
            AddPlugin(syncPlugin);
            _effectPlugin = new HumanoidMoveEffectPlugin();
            AddPlugin(_effectPlugin);
            AddPlugin(new PushColliderPlugin());

            if (_entity.isAuthority || !syncPlugin.hasInitializedSyncMove)
            {
                _humanoidMoveFSM.forceDoNotSyncWhenReset = true;
                _humanoidMoveFSM.SetNextState(HumanoidMoveFSM.FSMStateID.Move);
            }
        } // 0x0000000183BEF670-0x0000000183BF00A0
          // [XID] // 0x0000000189AA8DB0-0x0000000189AA8DD0
        protected override void InitMoveCollider()
        {
            float colRadius;
            CapsuleCollider[] MoveCollider1;
            if (_entity.isAuthority)
            {
                MoveCollider1 = _entity.GetAttachPoint("MoveCollider").GetComponents<CapsuleCollider>();
                MoveCollider1[0].radius = avatarRadius;
                MoveCollider1[0].height = (avatarModelHeight * 0.4f) + avatarHeadExtraHeight;
                MoveCollider1[0].center = (Vector3.up * (((avatarModelHeight * 8f) + avatarShoesHeight) + (avatarHeadExtraHeight * 0.5f)));

                MoveCollider1[1].radius = avatarRadius;
                MoveCollider1[1].height = (avatarRadius * 0.2f) + (avatarModelHeight * 0.3f);
                MoveCollider1[1].center = (Vector3.up * (((avatarModelHeight * 0.4505f) + avatarShoesHeight) + avatarRadius));
                colRadius = 1f;
            }
            else
            {
                MoveCollider1 = _entity.GetAttachPoint("MoveCollider").GetComponents<CapsuleCollider>();
                MoveCollider1[0].enabled = true;
                MoveCollider1[0].radius = avatarRadius;
                MoveCollider1[0].height = (avatarModelHeight * 0.25f) + avatarShoesHeight + avatarHeadExtraHeight;
                MoveCollider1[0].center = (Vector3.up * (((avatarHeadExtraHeight + avatarShoesHeight) * 0.5f) + (avatarModelHeight * 0.875f)));

                MoveCollider1[1].enabled = false;
                colRadius = 0.25f;
            }
            CapsuleCollider[] PushCollider = _entity.GetAttachPoint("PushCollider").GetComponents<CapsuleCollider>();
            PushCollider[0].radius = _entity.visualEntityTool.characterPushCollisionRadius * colRadius;
            PushCollider[0].height = avatarHeight;
            PushCollider[0].center = (Vector3.up * (avatarHeight * 0.65f));

            CapsuleCollider[] PushColliderExtra = _entity.GetAttachPoint("PushColliderExtra").GetComponents<CapsuleCollider>();
            PushColliderExtra[0].radius = _entity.visualEntityTool.characterPushCollisionRadius * colRadius;
            PushColliderExtra[0].height = avatarHeight;
            PushColliderExtra[0].center = (Vector3.up * (avatarHeight * 0.65f));

            CapsuleCollider airDummyMoveCollider = _entity.GetAttachPoint("DummyMoveCollider").GetComponent<CapsuleCollider>();
            airDummyMoveCollider.radius = avatarRadius;
            airDummyMoveCollider.height = avatarHeight;
            airDummyMoveCollider.center = (Vector3.up * (avatarHeight * 0.5f));

            CapsuleCollider airDummyPushCollider = _entity.GetAttachPoint("DummyPushCollider").GetComponent<CapsuleCollider>();
            airDummyPushCollider.radius = _entity.visualEntityTool.characterPushCollisionRadius * colRadius;
            airDummyPushCollider.height = avatarHeight * 1.15f;
            airDummyPushCollider.center = (Vector3.up * (avatarHeight * 0.65f));

            CapsuleCollider airDummyPushColliderExtra = _entity.GetAttachPoint("DummyPushColliderExtra").GetComponent<CapsuleCollider>();
            airDummyPushColliderExtra.radius = _entity.visualEntityTool.characterPushCollisionRadius * colRadius;
            airDummyPushColliderExtra.height = avatarHeight * 1.15f;
            airDummyPushColliderExtra.center = (Vector3.up * (avatarHeight * 0.65f));

            _moveCollider = new VCHumanoidMoveCollider(MoveCollider1, PushCollider, PushColliderExtra, airDummyMoveCollider, airDummyPushCollider, airDummyPushColliderExtra, avatarHeight, avatarRadius, this);

        } // 0x0000000183BF46A0-0x0000000183BF5760
          // [XID] // 0x0000000189AB0A10-0x0000000189AB0A30
        public void FixedTick()
        {
            if (referenceSystem != null && referenceSystem.isInited)
            {
                referenceSystem.MoveColliderImmediately(); // ji hu bu zhi xing
            }
            _humanoidMoveFSM.FixedTick();
        } // 0x0000000183BF1070-0x0000000183BF1150
          // [XID] // 0x0000000189AB8020-0x0000000189AB8040
        public override bool IsActive()
        {
            base.IsActive();
            if (_entity != null && _entity.isLoaded) return true;
            return false;
        }// 0x0000000183BF3B30-0x0000000183BF3C00
         // [XID] // 0x0000000189ABFA80-0x0000000189ABFAA0
        public void ResetFSM(bool resetAnimator = true /* Metadata: 0x00AEADD8 */, bool forceDoNotSync = true /* Metadata: 0x00AEADD9 */, bool needPlayShowUp = false /* Metadata: 0x00AEADDA */, int playSitDownId = 0 /* Metadata: 0x00AEADDB */)
        {
            if (_humanoidMoveFSM == null) return;
            _humanoidMoveFSM.ResetFSM(resetAnimator, forceDoNotSync, needPlayShowUp, playSitDownId);
        } // 0x0000000183BEEA20-0x0000000183BEEB30
          // [XID] // 0x0000000189764960-0x0000000189764980
        public void ResetFSMKeepMajorAnimatorState()
        {
            if (_humanoidMoveFSM == null) return;
            _humanoidMoveFSM.ResetFSMKeepMajorAnimatorState();
        } // 0x0000000183BF6E10-0x0000000183BF6EC0
          // [XID] // 0x0000000189B99C60-0x0000000189B99C80
        public void ResetFSMEnterFlyGateLoadingState()
        {
            if (_humanoidMoveFSM == null) return;
            _humanoidMoveFSM.ResetFSMEnterFlyGateLoadingState();
        } // 0x0000000183BF0790-0x0000000183BF0840
          // [XID] // 0x0000000189AD6BB0-0x0000000189AD6BD0
        public void EnterFollowRouteState(AvatarFollowRouteNotify ntf = null)
        {
            if (_entity.isAuthority)
            {
                if (ntf != null)
                {
                    uint entityID = ntf.EntityId;
                    if (entityID == _entity.runtimeID)
                    {
                        ResetFSMEnterFlyFollowRouteState();
                        var state = _humanoidMoveFSM.GetCurrentState();
                        if (state == null)
                        {
                            state = new HumanoidMoveFSMFlyFollowRouteState();
                        }
                        (state as HumanoidMoveFSMFlyFollowRouteState).InitFromProto(ntf);
                    }
                }
            }
        } // 0x0000000183BFA810-0x0000000183BFA980
          // [XID] // 0x0000000189ADE420-0x0000000189ADE440
        public void ResetFSMEnterFlyFollowRouteState()
        {
            if (_humanoidMoveFSM == null) return;
            _humanoidMoveFSM.ResetFSMEnterFlyFollowRouteState();
        } // 0x0000000183BEAA90-0x0000000183BEAB40
          // [XID] // 0x0000000189AE5EA0-0x0000000189AE5EC0
        public override void Destroy()
        {
            OnDisable();
            if (dummyRigidbody != null)
            {
                dummyRigidbody.transform.parent = _entity.transform.root;
            }
            lcAblityState = null;
            _humanoidMoveData = null;
            base.Destroy();
        } // 0x0000000183BEDCA0-0x0000000183BEDE20
          // [IDTag] // 0x0000000189AED2B0-0x0000000189AED2F0
          // [XID] // 0x0000000189AED2B0-0x0000000189AED2F0
        public override void TrySteer(bool isMoving, float joystickAngle)
        {
            if (_entity.isAlive && _humanoidMoveFSM != null)
            {
                SetFaceToParams();
                _humanoidMoveFSM.TrySteer(isMoving, joystickAngle);
            }
        } // 0x0000000183BFAEC0-0x0000000183BFAFE0
          // [XID] // 0x0000000189AF7DF0-0x0000000189AF7E10
        private void SetFaceToParams()
        {
            _needFaceToAnimParamEver = (_needFaceToAnimParamEver | needFaceToAnimParam) != false;
            if (controlData != null && _needFaceToAnimParamEver)
            {
                Vector2 rawJoystickAngle = Vector2.zero;
                if (controlData.rawIsMoving && needFaceToAnimParam)
                {
                    rawJoystickAngle.x = Mathf.Sin(controlData.rawJoystickAngle * 0.017453292f);
                    rawJoystickAngle.y = Mathf.Cos(controlData.rawJoystickAngle * 0.017453292f);
                }
                float faceLR = _entity.GetAnimatorFloat(AnimatorParamsData.FACE_TO_LR);
                if (faceLR != rawJoystickAngle.x)
                {
                    CommonMiscs.ChangeValueFromTo(ref faceLR, rawJoystickAngle.x, (Time.deltaTime * 4f) * Time.timeScale);
                    _entity.SetAnimatorFloat(AnimatorParamsData.FACE_TO_LR, faceLR);
                }
                float faceLB = _entity.GetAnimatorFloat(AnimatorParamsData.FACE_TO_LR);
                if (faceLB != rawJoystickAngle.y)
                {
                    CommonMiscs.ChangeValueFromTo(ref faceLB, rawJoystickAngle.x, (Time.deltaTime * 4f) * Time.timeScale);
                    _entity.SetAnimatorFloat(AnimatorParamsData.FACE_TO_FB, faceLR);
                }
            }
        } // 0x0000000183BF00A0-0x0000000183BF0510
          // [IDTag] // 0x0000000189AFF3F0-0x0000000189AFF430
          // [XID] // 0x0000000189AFF3F0-0x0000000189AFF430
        public override void TrySteer(Vector3 targetDir)
        {
            if (_entity.isAlive && _humanoidMoveFSM != null)
            {
                _humanoidMoveFSM.TrySteer(targetDir);
                if (_moveData != null) return;
                _moveData.exactMove = false;
            }
        } // 0x0000000183BFAFE0-0x0000000183BFB100
          // [XID] // 0x00000001896B2280-0x00000001896B22A0
        public override void TrySteerWithAngleExactly(Vector3 targetDir, VCMoveData.MotionDirection motionDir, Vector3 targetPos)
        {
            if (_entity.isAlive && _humanoidMoveFSM != null)
            {
                _humanoidMoveFSM.TrySteer(targetDir);
                if (_moveData != null) return;
                _moveData.exactMove = true;
                _moveData.exactMoveTarget = WorldShiftManager.GetRelativePosition(targetPos);
            }
        } // 0x0000000183BED660-0x0000000183BED840
          // [XID] // 0x0000000189B115E0-0x0000000189B11600
        public override void SetTargetSteer(Vector3 targetDir)
        {
            if (_moveData != null) return;
            _moveData.targetSteerDir = targetDir;
            _moveData.exactMove = false;
        } // 0x0000000183BFA980-0x0000000183BFAA70
          // [XID] // 0x00000001896C1020-0x00000001896C1040
        public override void SetTargetSteerExactly(Vector3 targetDir, Vector3 targetPos)
        {
            if (_moveData != null) return;
            _moveData.targetSteerDir = targetDir;
            _moveData.exactMove = true;
            _moveData.exactMoveTarget = WorldShiftManager.GetRelativePosition(targetPos);
        } // 0x0000000183BF5A10-0x0000000183BF5BA0
          // [XID] // 0x0000000189B1FEB0-0x0000000189B1FED0
        public void ForceStopExactMove()
        {
            if (_moveData != null) return;
            _moveData.exactMove = false;
        } // 0x0000000183BF06E0-0x0000000183BF0790
          // [XID] // 0x00000001896CFF50-0x00000001896CFF70
        public override void TryStop()
        {
            if (_entity != null && _entity.IsValid())
            {
                _humanoidMoveFSM.TryStop();
            }
        } // 0x0000000183BEB190-0x0000000183BEB270
          // [XID] // 0x0000000189B2E800-0x0000000189B2E820
        public override void DoStop()
        {
            if (_entity != null && _entity.isAlive)
            {
                _humanoidMoveFSM.DoStop();
            }
        } // 0x0000000183BF8F40-0x0000000183BF9020
          // [XID] // 0x0000000189B35E90-0x0000000189B35EB0
        public void NotifyLandVelocity(Vector3 velocity, float reachMaxDownVelocityTime)
        {
            if (GameManager.Instance == null) return;
            if (GameManager.Instance.isOnlineMode)// Todo 
            {
            }
        } // 0x0000000183BF8490-0x0000000183BF88F0
          // [XID] // 0x000000018970B270-0x000000018970B290
        public override void TrySlip()
        {
            if (_entity != null && _entity.isAlive)
            {
                _humanoidMoveFSM.TrySlip();
            }
        } // 0x0000000183BF2700-0x0000000183BF27D0
          // [XID] // 0x0000000189B45480-0x0000000189B454A0
        public override void DoJump()
        {
            if (_entity != null && _entity.isAlive)
            {
                _humanoidMoveFSM.DoJump();
            }
        } // 0x0000000183BF6B60-0x0000000183BF6C30
          // [XID] // 0x0000000189B33010-0x0000000189B33030
        public override void DoTurnDir(Vector3 turnTargetPos)
        {
            if (_entity != null && _entity.isAlive)
            {
                _humanoidMoveFSM.DoTurnDir(turnTargetPos);
            }
        } // 0x0000000183BFAA70-0x0000000183BFAB70
          // [XID] // 0x0000000189B3AAE0-0x0000000189B3AB00
        public void TryCrouch()
        {
            if (_entity != null && _entity.isAlive)
            {
                _humanoidMoveFSM.TryCrouch();
            }
        } // 0x0000000183BF2D70-0x0000000183BF2E40
          // [XID] // 0x0000000189B5BC40-0x0000000189B5BC60
        public void TrySprintBS()
        {
            if (_entity != null && _entity.isAlive)
            {
                _humanoidMoveFSM.TrySprintBS();
            }
        } // 0x0000000183BF94A0-0x0000000183BF9570
          // [XID] // 0x0000000189B630A0-0x0000000189B630C0
        public void TryStopSprint()
        {
            if (_entity != null && _entity.isAlive)
            {
                _humanoidMoveFSM.TryStopSprint();
            }
        } // 0x0000000183BF9310-0x0000000183BF93E0
          // [IDTag] // 0x0000000189B6A990-0x0000000189B6A9D0
          // [XID] // 0x0000000189B6A990-0x0000000189B6A9D0
        public override void DoBlink(Vector3 dir, float dist = 8f /* Metadata: 0x00AEADDF */)
        {
            if (_entity != null && _entity.isAlive)
            {
                if (_humanoidMoveData == null) return;
                _humanoidMoveData.tryDoBlink = true;
                _humanoidMoveData.blinkDir = dir;
                _humanoidMoveData.blinkPreferInput = false;
                _humanoidMoveData.blinkDist = dist;
            }
        } // 0x0000000183BF9570-0x0000000183BF96B0
          // [IDTag] // 0x0000000189B74DB0-0x0000000189B74DF0
          // [XID] // 0x0000000189B74DB0-0x0000000189B74DF0
        public override void DoBlink(bool preferInput = false /* Metadata: 0x00AEADE3 */, float dist = 8f /* Metadata: 0x00AEADE4 */)
        {
            if (_entity != null && _entity.isAlive)
            {
                if (CommonMiscs.IsAlmostZero(dist, 0.0001f))
                {
                    SuperDebug.LogWarning("AvatarDoBlink dist = 0");
                }
                else if (preferInput && dist < 0.0)
                {
                    SuperDebug.LogWarning("AvatarDoBlink preferInput while dist < 0");
                }
                else
                {
                    _humanoidMoveData.tryDoBlink = true;
                    _humanoidMoveData.blinkDir = Vector3.zero;
                    _humanoidMoveData.blinkPreferInput = preferInput;
                    _humanoidMoveData.blinkDist = dist;
                }
            }
        } // 0x0000000183BF96B0-0x0000000183BF98C0
          // [XID] // 0x0000000189B7F300-0x0000000189B7F320
        public override bool DoBlinkPosition(Vector3 pos) => default; // 0x0000000183BF8E80-0x0000000183BF8F40
                                                                      // [XID] // 0x0000000189B86E90-0x0000000189B86EB0
        public void PlayJumpWaterEffect()
        {
            _effectPlugin.PlayJumpWaterEffect(Time.deltaTime);
        } // 0x0000000183BF4260-0x0000000183BF4320
          // [XID] // 0x0000000189B8E020-0x0000000189B8E040
        public void PlayLandedEffect()
        {
            _effectPlugin.OnJumpLanded(Time.deltaTime);
        } // 0x0000000183BF28A0-0x0000000183BF2960
          // [XID] // 0x0000000189B954A0-0x0000000189B954C0
        public override void SetMotionFlag(VCMoveData.MotionFlag moveState)
        {
            _humanoidMoveFSM.SetMotionFlag(moveState);
        } // 0x0000000183BECA30-0x0000000183BECAF0
          // [XID] // 0x0000000189B9CB30-0x0000000189B9CB50
        public override VCMoveData.MotionFlag GetMotionFlag() => _humanoidMoveFSM.GetMotionFlag(); // 0x0000000183BF12C0-0x0000000183BF1380
                                                                                                   // [XID] // 0x0000000189BA41E0-0x0000000189BA4200
        public override bool IsInMove() => _humanoidMoveFSM.IsInMove(); // 0x0000000183BEBE70-0x0000000183BEBF30
                                                                        // [XID] // 0x0000000189BAB7F0-0x0000000189BAB810
        public override bool IsInPerform() => _humanoidMoveFSM.IsInPerform(); // 0x0000000183BFA750-0x0000000183BFA810
                                                                              // [XID] // 0x0000000189BB2D90-0x0000000189BB2DB0
        public bool IsInRunOrSprint() => _humanoidMoveFSM.IsInRunOrSprint(); // 0x0000000183BF30D0-0x0000000183BF3190
                                                                             // [XID] // 0x0000000189BBA120-0x0000000189BBA140
        public bool IsInDrop() => _humanoidMoveFSM.IsInDrop(); // 0x0000000183BF1F20-0x0000000183BF1FE0
                                                               // [XID] // 0x0000000189BC2280-0x0000000189BC22A0
        public bool IsInMoveState() => _humanoidMoveFSM.IsInMoveState(); // 0x0000000183BF93E0-0x0000000183BF94A0
                                                                         // [XID] // 0x00000001897AE280-0x00000001897AE2A0
        public bool IsInCanTriggerPlatformState() => _humanoidMoveFSM.IsInCanTriggerPlatformState(); // 0x0000000183BF9FE0-0x0000000183BFA0A0
                                                                                                     // [XID] // 0x0000000189BD0FB0-0x0000000189BD0FD0
        public override bool isInMovePureStandbyAndStayInPlace()
        {
            if (_humanoidMoveFSM.positionRotationChanged) return false;
            if (_humanoidMoveData.currentAnimatorStateInfo.tagHash != AvatarData.AVATAR_IDLE_TAG) return false;
            return _humanoidMoveData.nextAnimatorStateInfo.tagHash == 0;
        }// 0x0000000183BF89F0-0x0000000183BF8B40
         // [XID] // 0x0000000189BD85E0-0x0000000189BD8600
        public bool IsInSlip() => _humanoidMoveFSM.IsInSlip(); // 0x0000000183BF05C0-0x0000000183BF0680
                                                               // [XID] // 0x00000001897E3710-0x00000001897E3730
        public bool IsInSprintBS() => _humanoidMoveFSM.IsInSprintBS(); // 0x0000000183BF4320-0x0000000183BF43E0
                                                                       // [XID] // 0x00000001895ECBA0-0x00000001895ECBC0
        public override bool IsInSprint() => _humanoidMoveFSM.IsInSprint(); // 0x0000000183BED0A0-0x0000000183BED160
                                                                            // [XID] // 0x00000001895F4210-0x00000001895F4230
        public override bool IsInCrouch() => _humanoidMoveFSM.IsInCrouch(); // 0x0000000183BEC970-0x0000000183BECA30
                                                                            // [XID] // 0x00000001895FBA40-0x00000001895FBA60
        public override bool IsInPureMove() => _humanoidMoveFSM.IsInPureMove(); // 0x0000000183BEE580-0x0000000183BEE640
                                                                                // [XID] // 0x00000001897FA490-0x00000001897FA4B0
        public override bool IsInClimb() => _humanoidMoveFSM.IsInClimb(); // 0x0000000183BEED40-0x0000000183BEEE00
                                                                          // [XID] // 0x0000000189808E70-0x0000000189808E90
        public bool IsInClimbJump() => _humanoidMoveFSM.IsInClimbJump(); // 0x0000000183BEBC60-0x0000000183BEBD20
                                                                         // [XID] // 0x0000000189612170-0x0000000189612190
        public override bool IsInSwim() => _humanoidMoveFSM.IsInSwim(); // 0x0000000183BEBA70-0x0000000183BEBB30
                                                                        // [XID] // 0x0000000189619AF0-0x0000000189619B10
        public bool IsInSwimJump() => _humanoidMoveFSM.IsInSwimJump(); // 0x0000000183BF2E40-0x0000000183BF2F00
                                                                       // [XID] // 0x0000000189835B50-0x0000000189835B70
        public bool IsInSwimDash() => _humanoidMoveFSM.IsInSwimDash(); // 0x0000000183BF8290-0x0000000183BF8350
                                                                       // [XID] // 0x0000000189628720-0x0000000189628740
        public override bool IsInStandby2Climb() => _humanoidMoveFSM.IsInStandby2Climb(); // 0x0000000183BF5C60-0x0000000183BF5D20
                                                                                          // [XID] // 0x0000000189630010-0x0000000189630030
        public override bool IsInGoUpstairs() => _humanoidMoveFSM.IsInGoUpstairs(); // 0x0000000183BF7390-0x0000000183BF7450
                                                                                    // [XID] // 0x0000000189637D00-0x0000000189637D20
        public override bool IsInRunningTurn() => _humanoidMoveFSM.IsInRunningTurn(); // 0x0000000183BEEB90-0x0000000183BEEC50
                                                                                      // [XID] // 0x000000018963EF50-0x000000018963EF70
        public override bool IsInCombatMoveOnWater() => _humanoidMoveFSM.IsInCombatMoveOnWater(); // 0x0000000183BF3DB0-0x0000000183BF3E70
                                                                                                  // [XID] // 0x0000000189876590-0x00000001898765B0
        public override void FitToDrownPosition()
        {
            if (_humanoidMoveFSM != null)
            {
                _humanoidMoveFSM.FitToDrownPosition();
            }
        } // 0x0000000183BEDAE0-0x0000000183BEDB90
          // [XID] // 0x000000018964DFE0-0x000000018964E000
        public override bool IsInCombatMove() => _humanoidMoveFSM.IsInCombatCategory(); // 0x0000000183BFB100-0x0000000183BFB1C0
                                                                                        // [XID] // 0x0000000189655890-0x00000001896558B0
        public bool IsCurrentAnimationMirror() => _humanoidMoveFSM.IsCurrentAnimationMirror(); // 0x0000000183BF99B0-0x0000000183BF9A70
                                                                                               // [XID] // 0x000000018965D080-0x000000018965D0A0
        public bool IsInSit() => _humanoidMoveFSM.IsInSit(); // 0x0000000183BF3760-0x0000000183BF3820
                                                             // [XID] // 0x0000000189664630-0x0000000189664650
        public VCHumanoidMoveConfig GetMoveConfig() => _moveConfig; // 0x0000000183BEDB90-0x0000000183BEDC40
                                                                    // [XID] // 0x000000018966BC70-0x000000018966BC90
        public void SetMoveConfig(VCHumanoidMoveConfig.MovConfigs config, bool enable)
        {
            _moveConfig.SetMoveConfig(config, enable);
            if (config == VCHumanoidMoveConfig.MovConfigs.Frozen)
            {
                SyncGravityScale();
                if (_moveConfig.frozen)
                {
                    _velocityForceMove.UnsetForce(VelocityForceType.RushMoveType);
                    _velocityForceMove.UnsetForce(VelocityForceType.FixedRushMoveType);
                }
            }
        } // 0x0000000183BF2F70-0x0000000183BF30D0
          // [XID] // 0x0000000189673A60-0x0000000189673A80
        public HumanoidMoveFSM GetHumanoidMoveFSM() => _humanoidMoveFSM; // 0x0000000183BF3F20-0x0000000183BF3FD0
                                                                         // [XID] // 0x0000000189934560-0x0000000189934580
        public void SetCombatExitClimbDir(Vector3 dir)
        {
            _humanoidMoveData.combatExitClimbSetDir = true;
            _humanoidMoveData.combatExitClimbDir = dir;
        } // 0x0000000183BF6800-0x0000000183BF6900
          // [XID] // 0x0000000189682AC0-0x0000000189682AE0
        public bool EnterMoveState(MoveType moveType)
        {
            if (_humanoidMoveFSM != null)
            {
                return _humanoidMoveFSM.EnterMoveState(moveType);
            }
            return false;
        } // 0x0000000183BEBD20-0x0000000183BEBE70
          // [IDTag] // 0x000000018968A640-0x000000018968A680
          // [XID] // 0x000000018968A640-0x000000018968A680
        public override void AddVelocity(VelocityForceType velocityType, Vector3 velocity, float time = 0f /* Metadata: 0x00AEADE8 */)
        {
            switch (velocityType)
            {
                case VelocityForceType.RetreatType:
                    Retreat(velocity);
                    break;
                case VelocityForceType.RetreatAirType:
                    HitAir(velocity);
                    break;
                case VelocityForceType.RushMoveType:
                    RushMove(time, velocity);
                    break;
                case VelocityForceType.WindZoneType:
                    FreeForce(VelocityForceType.WindZoneType, time, velocity);
                    break;
                case VelocityForceType.AirflowType:
                case VelocityForceType.RiseType:
                case VelocityForceType.SpeedupType:
                    FlyForce(velocityType, time, velocity);
                    break;
                case VelocityForceType.InertiaType:
                    FreeForce(VelocityForceType.InertiaType, time, velocity);
                    break;
                default:
                    break;
            }
        } // 0x0000000183BF1B50-0x0000000183BF1D70
          // [IDTag] // 0x0000000189694FA0-0x0000000189694FE0
          // [XID] // 0x0000000189694FA0-0x0000000189694FE0
        public override void AddVelocity(VelocityForceType velocityType, Vector3 velocity, Vector3 targetPos, HashSet<int> stateIds, bool needSetIsInAir, bool checkAnimatorStateOnExitOnly = false /* Metadata: 0x00AEADEC */, float time = 0f /* Metadata: 0x00AEADED */)
        {
            if (velocityType == VelocityForceType.FixedRushMoveType)
            {
                FixedRushMoveForce(velocity, targetPos, stateIds, needSetIsInAir, checkAnimatorStateOnExitOnly);
            }
        } // 0x0000000183BF1D70-0x0000000183BF1F20
          // [XID] // 0x000000018969F540-0x000000018969F560
        private void FixedRushMoveForce(Vector3 rushVel, Vector3? targetPos, HashSet<int> animatorStateIDs, bool needSetIsInAir, bool checkAnimatorStateOnExitOnly)
        {
            var moveVel = GetPlugin<MoveVelocityForcePlugin>();
            if (moveVel != null)
            {
                if (!CommonMiscs.IsAlmostZero(rushVel.magnitude, 0.0001f))
                {
                    moveVel.SetForce(VelocityForceType.FixedRushMoveType, rushVel, targetPos.Value, animatorStateIDs, needSetIsInAir, false, checkAnimatorStateOnExitOnly);
                }

            }
        } // 0x0000000183BEAF50-0x0000000183BEB190
          // [XID] // 0x00000001896A6900-0x00000001896A6920
        private static new EventID[] GetSelfOnEventIDsExcludingBase()
        {
            EventID[] eventID = new EventID[2];
            eventID[0] = EventID.EvtFieldEnter;
            eventID[1] = EventID.EvtFieldExit;
            return eventID;
        }// 0x0000000183BF1150-0x0000000183BF1250
         // [XID] // 0x0000000189919AA0-0x0000000189919AC0
        protected override bool OnEvent(BaseEvent evt)
        {
            switch (evt.eventID)
            {
                case EventID.EvtFieldEnter:
                    var fieldEnter = evt as EvtFieldEnter;
                    if (fieldEnter.flag == TriggerFlag.NoReviveRegion)
                    {
                        vcLevel.SetNoReviveTrigger(fieldEnter.runtimeId, true);
                    }
                    return false;
                case EventID.EvtFieldExit:
                    if (_entity != null && !_entity.IsActive())
                    {
                        var allAvatars = Singleton<EntityManager>.Instance.GetAllAvatars();
                        foreach (var avatar in allAvatars)
                        {
                            if (avatar.IsActive()) return true;
                        }
                    }
                    var fieldExit = evt as EvtFieldExit;
                    if (fieldExit.flag == TriggerFlag.NoReviveRegion)
                    {
                        vcLevel.SetNoReviveTrigger(fieldExit.runtimeId, false);
                    }
                    return false;
            }
            return false;
        }// 0x0000000183BFA450-0x0000000183BFA6A0
         // [XID] // 0x000000018993EEA0-0x000000018993EEC0
        public void OnAnimatorEventStep()
        {
            if (_entity != null && _entity.isAuthority)
            {
                Singleton<NetworkManager>.Instance.RequestSceneCharacterStaminaReq(_entity.GetRotation().eulerAngles);
            }
        } // 0x0000000183BF0E10-0x0000000183BF0FA0
          // [XID] // 0x00000001896BC8E0-0x00000001896BC900
        public void OnAnimatorEventWalkStep(AnimatorEventWalkStep step)
        {
            _effectPlugin.OnAnimatorEventWalkStep(step);
        } // 0x0000000183BF27D0-0x0000000183BF28A0
          // [XID] // 0x00000001896C3E40-0x00000001896C3E60
        public void OnWalkStepOnWater(AnimatorEventWaterEffectStep step)
        {
            _effectPlugin.OnWalkStepOnWater(step, Time.deltaTime);
        } // 0x0000000183BF0FA0-0x0000000183BF1070
          // [XID] // 0x00000001896CB330-0x00000001896CB350
        public void OnSwimDashHandEffect(AnimatorEventSwimDashHandEffect evt)
        {
            _effectPlugin.OnSwimDashHandEffect(evt, Time.deltaTime);
        } // 0x0000000183BF1380-0x0000000183BF1450
          // [XID] // 0x0000000189A4C030-0x0000000189A4C050
        public override Vector3 GetMoveVelocity()
        {
            if (IsActive())
            {
                return _humanoidMoveFSM.GetMoveVelocity();
            }
            return Vector3.zero;
        }// 0x0000000183BF2960-0x0000000183BF2AA0
         // [XID] // 0x00000001896DA3C0-0x00000001896DA3E0
        public override BaseMoveState GetMoveState()
        {
            if (_humanoidMoveFSM == null) return VCBaseMove.BaseMoveState.Undefined;
            switch (_humanoidMoveFSM.GetCurrentState().stateID)
            {
                case HumanoidMoveFSM.FSMStateID.Move:
                case HumanoidMoveFSM.FSMStateID.TurnDirection:
                case HumanoidMoveFSM.FSMStateID.GoUpstairs:
                case HumanoidMoveFSM.FSMStateID.JumpUpWallReady:
                case HumanoidMoveFSM.FSMStateID.JumpUpWallForStandby:
                case HumanoidMoveFSM.FSMStateID.StandbyToClimb:
                    return VCBaseMove.BaseMoveState.Move;
                case HumanoidMoveFSM.FSMStateID.Climb:
                    return VCBaseMove.BaseMoveState.Climb;
                case HumanoidMoveFSM.FSMStateID.Jump:
                case HumanoidMoveFSM.FSMStateID.Drop:
                    return VCBaseMove.BaseMoveState.Air;
                case HumanoidMoveFSM.FSMStateID.Fly:
                    return VCBaseMove.BaseMoveState.Fly;
                case HumanoidMoveFSM.FSMStateID.CombatMove:
                case HumanoidMoveFSM.FSMStateID.CombatFallOnGround:
                case HumanoidMoveFSM.FSMStateID.CombatAir:
                    return VCBaseMove.BaseMoveState.Combat;
                case HumanoidMoveFSM.FSMStateID.Swim:
                    return VCBaseMove.BaseMoveState.Swim;
                case HumanoidMoveFSM.FSMStateID.SwimJump:
                    return VCBaseMove.BaseMoveState.SwimJump;
                default:
                    return VCBaseMove.BaseMoveState.Else;
            }
        }// 0x0000000183BF66A0-0x0000000183BF6800
         // [XID] // 0x00000001896E19C0-0x00000001896E19E0
        public override bool IsInTag(int tagHash) => _humanoidMoveFSM.IsInTag(tagHash); // 0x0000000183BF6970-0x0000000183BF6A40
                                                                                        // [XID] // 0x00000001898D56F0-0x00000001898D5710
        private void Retreat(Vector3 retreatDir)
        {
            switch (_humanoidMoveFSM.GetCurrentState().stateID)
            {
                case HumanoidMoveFSM.FSMStateID.Move:
                case HumanoidMoveFSM.FSMStateID.TurnDirection:
                case HumanoidMoveFSM.FSMStateID.GoUpstairs:
                case HumanoidMoveFSM.FSMStateID.JumpUpWallReady:
                case HumanoidMoveFSM.FSMStateID.JumpUpWallForStandby:
                case HumanoidMoveFSM.FSMStateID.StandbyToClimb:
                case HumanoidMoveFSM.FSMStateID.Swim:
                case HumanoidMoveFSM.FSMStateID.SwimJump:
                case HumanoidMoveFSM.FSMStateID.Ladder:
                    if (!CommonMiscs.IsAlmostZero(retreatDir.XZ().magnitude, 0.0001f))
                    {
                        _velocityForceMove.SetForce(VelocityForceType.RetreatType, retreatDir);
                    }
                    break;
            }
        } // 0x0000000183BEAB40-0x0000000183BEADF0
          // [XID] // 0x00000001896F0150-0x00000001896F0170
        private void HitAir(Vector3 retreatDir)
        {
            if (!CommonMiscs.IsAlmostZero(retreatDir.XZ().magnitude, 0.0001f))
            {
                _humanoidMoveData.nextHitAirVelocityForce = retreatDir;
            }
        } // 0x0000000183BEEF30-0x0000000183BEF0E0
          // [XID] // 0x00000001896F7A10-0x00000001896F7A30
        private void RushMove(float rushTime, Vector3 rushVel)
        {
            if (_humanoidMoveFSM.IsInCombatMove() || _humanoidMoveFSM.IsInCombatAir() || _humanoidMoveFSM.IsInCombatFallOnGround())
            {
                _velocityForceMove.SetForce(VelocityForceType.RushMoveType, rushVel, rushTime);
            }
        } // 0x0000000183BF2320-0x0000000183BF24D0
          // [XID] // 0x0000000189902F60-0x0000000189902F80
        private void FreeForce(VelocityForceType type, float rushTime, Vector3 rushVel)
        {
            _velocityForceMove.SetForce(VelocityForceType.RushMoveType, rushVel, rushTime);
        } // 0x0000000183BF24D0-0x0000000183BF2630
          // [XID] // 0x0000000189937330-0x0000000189937350
        private void FlyForce(VelocityForceType type, float rushTime, Vector3 rushVel)
        {
            if (_humanoidMoveFSM.IsInFlyState())
            {
                _velocityForceMove.SetForce(VelocityForceType.RushMoveType, rushVel, rushTime);
            }
        } // 0x0000000183BF2060-0x0000000183BF21D0
          // [XID] // 0x0000000189A77AC0-0x0000000189A77AE0
        public override bool IsInAirState() => _humanoidMoveFSM.IsInAirState(); // 0x0000000183BEEE00-0x0000000183BEEEC0
                                                                                // [XID] // 0x0000000189BE0050-0x0000000189BE0070
        public void ForceAirStateFly()
        {
            _humanoidMoveFSM.ForceAirStateFly();
        } // 0x0000000183BEE970-0x0000000183BEEA20
          // [IDTag] // 0x000000018972BB80-0x000000018972BBC0
          // [XID] // 0x000000018972BB80-0x000000018972BBC0
        public void EnableRocketJump(bool enable, RocketJumpType type)
        {
            _moveConfig.EnableRocketJump(enable, type);
        } // 0x0000000183BF5860-0x0000000183BF5940
          // [IDTag] // 0x0000000189736470-0x00000001897364B0
          // [XID] // 0x0000000189736470-0x00000001897364B0
        public void EnableRocketJump(bool enable, RocketJumpType type, RocketJumpExt extension)
        {
            _moveConfig.EnableRocketJump(enable, type, extension);
        } // 0x0000000183BF5760-0x0000000183BF5860
          // [XID] // 0x000000018966BF00-0x000000018966BF20
        public void EnterFlyFixTargetMode(Vector3 targetPosition, float velocity)
        {
            _humanoidMoveFSM.EnterFlyFixTargetMode(targetPosition, velocity);
        } // 0x0000000183BF2C60-0x0000000183BF2D70
          // [XID] // 0x0000000189748830-0x0000000189748850
        public void ExitFlyFixTargetMode()
        {
            _humanoidMoveFSM.ExitFlyFixTargetMode();
        } // 0x0000000183BFA6A0-0x0000000183BFA750
          // [XID] // 0x00000001896A9BD0-0x00000001896A9BF0
        public void SetFlyControlType(HumanoidMoveFSMFlyState.FlyControlType type, Vector3 dir, Vector3 eularRawInput, float velocityScale = 1f /* Metadata: 0x00AEADF1 */, float flyBackSpeedScale = 1f /* Metadata: 0x00AEADF5 */)
        {
            _humanoidMoveFSM.SetFlyControlType(type, dir, eularRawInput, velocityScale, flyBackSpeedScale);
        } // 0x0000000183BFACD0-0x0000000183BFAE60
          // [XID] // 0x0000000189616990-0x00000001896169B0
        public override bool IsInFlyState() => _humanoidMoveFSM.IsInFlyState(); // 0x0000000183BF2AA0-0x0000000183BF2B60
                                                                                // [XID] // 0x000000018975EC70-0x000000018975EC90
        public override float GetGroundDist() => _transform.position.y - _moveData.curSmoothedGroundHeight; // 0x0000000183BF2B60-0x0000000183BF2C60
                                                                                                            // [XID] // 0x00000001897660B0-0x00000001897660D0
        public override bool CanUseAirSkill() => _humanoidMoveFSM.CanUseAirSkill(); // 0x0000000183BEE840-0x0000000183BEE900
                                                                                    // [XID] // 0x000000018976D900-0x000000018976D920
        public override bool CanDoJump() => _humanoidMoveFSM.CanDoJump(); // 0x0000000183BF6570-0x0000000183BF6630
                                                                          // [XID] // 0x0000000189774D40-0x0000000189774D60
        public override void StopSprint()
        {
            _humanoidMoveData.inSprint = false;
        } // 0x0000000183BF0510-0x0000000183BF05C0
          // [XID] // 0x000000018977C5E0-0x000000018977C600
        public override bool IsInForbiddenToggleMoveState() => _humanoidMoveFSM.IsInForbiddenToggleMoveState(); // 0x0000000183BF0CA0-0x0000000183BF0D60
                                                                                                                // [XID] // 0x0000000189A942B0-0x0000000189A942D0
        private void SetAvatarHeight()
        {
            var moveHead = _entity.GetAttachPoint("MoveHead");
            if (moveHead)
            {
                avatarHeight = moveHead.position.y - _transform.position.y;
                avatarShoesHeight = _entity.visualEntityTool.shoesOffset;
                avatarHeadExtraHeight = (avatarHeight - avatarModelHeight) - avatarShoesHeight;
                avatarRadius = avatarModelHeight * 0.125f;
                moveHead.localPosition = Vector3.up * avatarModelHeight;
                avatarWaitToheadHeight = avatarModelHeight * 0.4f;
            }
        } // 0x0000000183BF5D80-0x0000000183BF6050
          // [XID] // 0x000000018978B850-0x000000018978B870
        public void ShowFootsprint(SceneSurfaceMaterial surface, Vector3 pos)
        {
            _effectPlugin.ShowFootsprint(surface, pos);
        } // 0x0000000183BF7290-0x0000000183BF7390
          // [XID] // 0x0000000189B05410-0x0000000189B05430
        private void InitAbilityPropertyCallback()
        {
            lcAblityState = GetLogicComponent<LCAbilityState>(LCBaseComponentTypeIDs.LCAbilityState);
            if (lcAblityState != null)
            {
                lcAblityState.RegisterPropertyChangedCallback("Animator_MoveSpeedRatio", SyncAnimatorMoveSpeed);
                lcAblityState.RegisterPropertyChangedCallback("Animator_AttackSpeedRatio", SyncAnimatorAttackSpeed);
                lcAblityState.RegisterPropertyChangedCallback("Actor_AddGravityScale", SyncGravityScale);
                lcAblityState.RegisterPropertyChangedCallback("Actor_FlyBackSpeedMaxRatio", SetFlyBackSpeedMaxRatio);
                lcAblityState.RegisterPropertyChangedCallback("Actor_FlyHorizontalSpeedMaxRatio", SetFlyHorizontalSpeedMaxRatio);
                lcAblityState.RegisterPropertyChangedCallback("Actor_FlyRotationAngularVelocity", SetFlyRotationAngularVelocityRatio);
                lcAblityState.RegisterPropertyChangedCallback("Actor_FlyDownSpeedRatio", SetFlyDownSpeedRatio);
                lcAblityState.RegisterPropertyChangedCallback("Actor_FlyForwardSpeedMaxRatio", SetFlyForwardSpeedMaxRatio);
                lcAblityState.RegisterPropertyChangedCallback("Actor_FlyOverallSpeedRatio", SetFlyOverallSpeedRatio);
            }
        } // 0x0000000183BED2C0-0x0000000183BED660
          // [XID] // 0x000000018979A350-0x000000018979A370
        private void SetFlyBackSpeedMaxRatio()
        {
            _humanoidMoveFSM.stateMapInfo[HumanoidMoveFSM.FSMStateID.Fly].SetFlyBackSpeedMaxRatio(lcAblityState.GetProperty("Actor_FlyBackSpeedMaxRatio"));// Todo EncryptString or UseDeobfBinOutput BinOutput Value: 1.0f
        } // 0x0000000183BED160-0x0000000183BED2C0
          // [XID] // 0x0000000189B1B910-0x0000000189B1B930
        private void SetFlyHorizontalSpeedMaxRatio()
        {
            _humanoidMoveFSM.stateMapInfo[HumanoidMoveFSM.FSMStateID.Fly].SetFlyHorizontalSpeedMaxRatio(lcAblityState.GetProperty("Actor_FlyHorizontalSpeedMaxRatio"));// Todo EncryptString or UseDeobfBinOutput BinOutput Value: 3.0f
        } // 0x0000000183BEC3F0-0x0000000183BEC550
          // [XID] // 0x00000001897A9960-0x00000001897A9980
        private void SetFlyRotationAngularVelocityRatio()
        {
            _humanoidMoveFSM.stateMapInfo[HumanoidMoveFSM.FSMStateID.Fly].SetFlyRotationAngularVelocityRatio(lcAblityState.GetProperty("Actor_FlyRotationAngularVelocityRatio"));// Todo EncryptString or UseDeobfBinOutput BinOutput Value: 1.0f
        } // 0x0000000183BEC6D0-0x0000000183BEC830
          // [XID] // 0x00000001897B11C0-0x00000001897B11E0
        private void SetFlyDownSpeedRatio()
        {
            _humanoidMoveFSM.stateMapInfo[HumanoidMoveFSM.FSMStateID.Fly].SetFlyDownSpeedRatio(lcAblityState.GetProperty("Actor_FlyDownSpeedRatio"));// Todo EncryptString or UseDeobfBinOutput BinOutput Value: -0.61f
        } // 0x0000000183BEBF30-0x0000000183BEC090
          // [XID] // 0x00000001897B8D80-0x00000001897B8DA0
        private void SetFlyForwardSpeedMaxRatio()
        {
            _humanoidMoveFSM.stateMapInfo[HumanoidMoveFSM.FSMStateID.Fly].SetFlyForwardSpeedMaxRatio(lcAblityState.GetProperty("Actor_FlyForwardSpeedMaxRatio"));// Todo EncryptString or UseDeobfBinOutput BinOutput Value: 0.33f
        } // 0x0000000183BF7130-0x0000000183BF7290
          // [XID] // 0x00000001897C0E30-0x00000001897C0E50
        private void SetFlyOverallSpeedRatio()
        {
            _humanoidMoveFSM.stateMapInfo[HumanoidMoveFSM.FSMStateID.Fly].SetFlyOverallSpeedRatio(lcAblityState.GetProperty("Actor_FlyOverallSpeedRatio"));// Todo EncryptString or UseDeobfBinOutput BinOutput Value: 0.8f
        } // 0x0000000183BFAB70-0x0000000183BFACD0
          // [XID] // 0x00000001897C87D0-0x00000001897C87F0
        public override void SyncGravityScale()
        {
            if (_moveConfig.frozen)
            {
                _gravityScale = GlobalCombat.config.hitData.gravity;
            }
            else
            {
                float gravity = 0;
                if (!IsInAirflowAcc)
                {
                    gravity = GlobalCombat.config.hitData.gravity;
                }
                float property = lcAblityState.GetProperty("Actor_AddGravityScale");
                _gravityScale = property + gravity;
            }
        } // 0x0000000183BEB5B0-0x0000000183BEB7E0
          // [XID] // 0x0000000189A8E6F0-0x0000000189A8E710
        protected override void SyncAnimatorMoveSpeed()
        {
            if (lcAblityState != null)
            {
                _entity.SetAnimatorFloat(AnimatorParamsData.MOVE_SPEED_RATIO, lcAblityState.GetProperty("Animator_MoveSpeedRatio"));
            }

        } // 0x0000000183BEC180-0x0000000183BEC320
          // [XID] // 0x00000001896078C0-0x00000001896078E0
        protected override void SyncAnimatorAttackSpeed()
        {
            if (lcAblityState != null)
            {
                _entity.SetAnimatorFloat(AnimatorParamsData.ATTACK_SPEED_RATIO, lcAblityState.GetProperty("Animator_AttackSpeedRatio"));
            }
        } // 0x0000000183BF4500-0x0000000183BF46A0
          // [XID] // 0x00000001897DEB20-0x00000001897DEB40
        public override void OnEnable()
        {
            base.OnEnable();
            SyncAnimatorMoveSpeed();
            SyncGravityScale();
            SyncAnimatorAttackSpeed();
        } // 0x0000000183BFA2B0-0x0000000183BFA390
          // [XID] // 0x00000001895E9CE0-0x00000001895E9D00
        public override bool IsNonAnimatorMode()
        {
            if (_moveData != null)
                return _moveData.isInCutSceneMode;
            else
                return true;
        }// 0x0000000183BF5BA0-0x0000000183BF5C60
         // [XID] // 0x0000000189A86B20-0x0000000189A86B40
        public override void SetNonAnimatorMode(bool value, bool animatorAlways)
        {
            if (_moveData != null && _moveData.isInCutSceneMode != value)
            {
                _moveData.isInCutSceneMode = value;
                if (value)
                {
                    ResetFSM();
                    if (animator)
                    {
                        if (_cacheRuntimeAnimatorCtrl)
                        {
                            _cacheRuntimeAnimatorCtrl = animator.runtimeAnimatorController;
                        }
                        animator.applyRootMotion = false;
                    }
                    if (animatorController)
                    {
                        animatorController.enabled = false;
                    }
                    if (_rigidbody)
                    {
                        _rigidbody.constraints = RigidbodyConstraints.FreezeAll;
                    }
                }
                else
                {
                    _moveData.targetSteerDir = _entity.rootGameObject.transform.forward;
                    if (animator)
                    {
                        animator.transform.localPosition = new Vector3(0, _entity.visualEntityTool.shoesOffset, 0);
                        animator.transform.localRotation = Quaternion.identity;
                    }
                    if (animatorController)
                    {
                        animatorController.enabled = true;
                    }
                    if (_rigidbody)
                    {
                        _rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
                    }
                    _entity.RecoverAnimator();
                }

            }
        } // 0x0000000183BF6050-0x0000000183BF6570
          // [XID] // 0x00000001897F5800-0x00000001897F5820
        public bool isWeaponEquiped()
        {
            if (_equipController == null)
            {
                _equipController = GetVisualComponent<VCAvatarEquipController>(VCBaseComponentTypeIDs.VCAvatarEquipController);
                return _equipController.isTakingWeaponOnHand;
            }
            else
            {
                SuperDebug.LogError("_equipController is null");
                return false;
            }
        }// 0x0000000183BF8350-0x0000000183BF8490
         // [XID] // 0x0000000189A9D3C0-0x0000000189A9D3E0
        public override void CreateSyncTaskByTimeInterval()
        {
            _humanoidMoveFSM.GetCurrentState().CreateSyncTaskByTimeInterval();
        } // 0x0000000183BF3C70-0x0000000183BF3D40
          // [XID] // 0x0000000189AAC230-0x0000000189AAC250
        public void GetCurrentFlyPose(out float roll, out float pitch)
        {
            var state = _humanoidMoveFSM.GetCurrentState();
            if (state == null)
            {
                roll = 0f;
                pitch = 0f;

            }
            (state as HumanoidMoveFSMFlyState).GetCurrentFlyPose(out roll, out pitch);
        } // 0x0000000183BEE640-0x0000000183BEE750
          // [XID] // 0x000000018980BB50-0x000000018980BB70
        public float GetYUseHeightmap(Vector3 position) => heightmap.BilinearInterpolatedHeight(position.x, position.z); // 0x0000000183BF6EC0-0x0000000183BF6FB0
                                                                                                                         // [XID] // 0x0000000189813300-0x0000000189813320
        public override bool TryInitialSyncMove(ref MoveSyncTask syncTask, bool setPosition) => _humanoidMoveFSM.InitFsmStateWithSyncTask(ref syncTask, setPosition); // 0x0000000183BF98C0-0x0000000183BF99B0
                                                                                                                                                                      // [XID] // 0x000000018981AE50-0x000000018981AE70
        public override bool CanInitFsmStateWithSyncTask(ref MoveSyncTask syncTask) => _humanoidMoveFSM.CanInitFsmStateWithSyncTask(ref syncTask); // 0x0000000183BF9240-0x0000000183BF9310
                                                                                                                                                   // [XID] // 0x0000000189B58E80-0x0000000189B58EA0
        public void DetectRigidbodyVelocity(int tagHash)
        {
            if (_velocityDetect != null)
            {
                _velocityDetect.DetectRigidbodyVelocity(GetMoveVelocity(), tagHash);
            }
        } // 0x0000000183BEC5C0-0x0000000183BEC6D0
          // [XID] // 0x0000000189829C70-0x0000000189829C90
        public override bool DoingFreeStyle() => _entity.GetAnimatorInt(AnimatorParamsData.PERFORM_DOING) > 0; // 0x0000000183BECD40-0x0000000183BECE30
                                                                                                               // [XID] // 0x0000000189831140-0x0000000189831160
        public override void DoFreeStyle(int freeStyleType, bool forceInterrupt, float? freeStyleParam = default)
        {
            base.DoFreeStyle(freeStyleType, forceInterrupt);
            if (vcPerform != null)
            {
                if (IsInHeadFreeStyle(freeStyleType))
                {
                    _entity.SetAnimatorInt(AnimatorParamsData.HEAD_FREE_STYLE_TYPE, freeStyleType);
                    _entity.SetAnimatorTrigger(AnimatorParamsData.HEAD_FREE_STYLE);
                }
                else if (!forceInterrupt && DoingFreeStyle())
                {
                    _moveData.curMoveState = VCMoveData.MotionFlag.FreeStyle;
                    _entity.SetAnimatorInt(AnimatorParamsData.MOTION_FLAG, (int)_moveData.curMoveState);
                }
                return;
            }
            if (_moveData.curMoveState == VCMoveData.MotionFlag.FreeStyle && _entity.GetAnimatorInt(AnimatorParamsData.PERFORM_ID) == freeStyleType)
            {
                _moveData.curMoveState = VCMoveData.MotionFlag.FreeStyle;
                _entity.SetAnimatorInt(AnimatorParamsData.MOTION_FLAG, (int)_moveData.curMoveState);
                return;
            }
            _moveData.curMoveState = VCMoveData.MotionFlag.FreeStyle;
            _entity.SetAnimatorInt(AnimatorParamsData.MOTION_FLAG, (int)_moveData.curMoveState);
            _entity.SetAnimatorInt(AnimatorParamsData.PERFORM_DOING, (int)VCMoveData.MotionFlag.Walk);
            _entity.ResetAnimatorTrigger(AnimatorParamsData.PERFORM_STATE_TRIGGER);
            vcPerform.DoPerform(freeStyleType, 0f, false);
        } // 0x0000000183BF9AE0-0x0000000183BF9FE0
          // [XID] // 0x0000000189838940-0x0000000189838960
        public override void NotifySitOnChair(Vector3 position, Vector3 rotationEular)
        {
            _humanoidMoveData.sitOnChairPosition = position;
            _humanoidMoveData.sitOnChairRotationEular = rotationEular;
            _humanoidMoveData.trySitOnChair = true;
        } // 0x0000000183BF21D0-0x0000000183BF2320
          // [XID] // 0x000000018983FE80-0x000000018983FEA0
        public void NotifyQuestForceDrag()
        {
            syncPlugin.CreateSyncTask(MotionState.MotionQuestForceDrag, false);
        } // 0x0000000183BEADF0-0x0000000183BEAF50
          // [XID] // 0x0000000189847500-0x0000000189847520
        public override int GetCurFreeStyle() => _entity.GetAnimatorInt(AnimatorParamsData.PERFORM_ID); // 0x0000000183BF7040-0x0000000183BF7130
                                                                                                        // [XID] // 0x000000018984EBC0-0x000000018984EBE0
        public override void ResetFreeStyle()
        {
            base.ResetFreeStyle();
            if (_moveData.curMoveState == VCMoveData.MotionFlag.FreeStyle)
            {
                _moveData.curMoveState = _moveData.preMoveState;
                _entity.SetAnimatorInt(AnimatorParamsData.MOTION_FLAG, (int)_moveData.curMoveState);
                _entity.SetAnimatorInt(AnimatorParamsData.PERFORM_ID, -1);
                _entity.SetAnimatorInt(AnimatorParamsData.PERFORM_DOING, 0);
            }
            else
            {
                ResetFreeStyleOnly();
            }
        } // 0x0000000183BF9020-0x0000000183BF9240
          // [XID] // 0x0000000189855D10-0x0000000189855D30
        public override void ResetFreeStyleOnly()
        {
            base.ResetFreeStyleOnly();
            _entity.SetAnimatorInt(AnimatorParamsData.PERFORM_ID, -1);
            _entity.SetAnimatorInt(AnimatorParamsData.PERFORM_DOING, 0);
        } // 0x0000000183BEC830-0x0000000183BEC970
          // [XID] // 0x0000000189727920-0x0000000189727940
        public override void SetFreeStateTrigger()
        {
            base.SetFreeStateTrigger();
            _entity.SetAnimatorTrigger(AnimatorParamsData.PERFORM_STATE_TRIGGER);
        } // 0x0000000183BF6C30-0x0000000183BF6D30
          // [XID] // 0x00000001897365D0-0x00000001897365F0
        public override void SetFreeLoopState(int loopState)
        {
            base.SetFreeLoopState(loopState);
            _entity.SetAnimatorInt(AnimatorParamsData.PERFORM_LOOP_STATE, loopState);
        } // 0x0000000183BF7510-0x0000000183BF7620
          // [XID] // 0x000000018986C050-0x000000018986C070
        public bool CanChangAvatarToTarget(float targetHeight, float targetModelHeight, out Vector3 position)
        {
            position = default;
            return default;
        } // 0x0000000183BF3200-0x0000000183BF3760
          // [XID] // 0x00000001898734F0-0x0000000189873510
        public static Vector3 GetSafeAppearPos(Vector3 checkPosition, BaseEntity checkAvatarEntity)
        {
            if (_safeAppearPositionCheckLayer != 0)
            {
                _safeAppearPositionCheckLayer = Miscs.GetSceneLayerMask();
            }
            AvatarExcelConfig excelConfig = checkAvatarEntity.excelConfig as AvatarExcelConfig;
            float avatarHeight = 0f;
            switch (excelConfig.bodyType)
            {
                case BodyType.BODY_BOY:
                    avatarHeight = 1.61f;
                    break;
                case BodyType.BODY_GIRL:
                    avatarHeight = 1.53f;
                    break;
                case BodyType.BODY_LADY:
                    avatarHeight = 1.7f;
                    break;
                case BodyType.BODY_MALE:
                    avatarHeight = 1.84f;
                    break;
                case BodyType.BODY_LOLI:
                    avatarHeight = 1.27f;
                    break;
            }
            _avatars = Singleton<EntityManager>.Instance.GetAllAvatars();
            _activeAvatarNumber = 0;
            float relativeHeight = 0;
            for (int i = 0; i < _avatars.Count; i++)
            {
                BaseEntity avatar = _avatars[i];
                if (avatar.IsActive())
                {
                    if (avatar != checkAvatarEntity)
                    {
                        Vector3 relativePosition = avatar.GetRelativePosition();
                        relativeHeight = relativePosition.z;
                        _avatarPositions[_activeAvatarNumber] = relativePosition;
                        _avatarIndex[_activeAvatarNumber] = i;
                        ++_activeAvatarNumber;
                    }
                }
            }
            for (int j = 0; j < _activeAvatarNumber; j++)
            {
                BaseEntity avatar = _avatars[j];
                if (Mathf.Abs(_avatarPositions[j].y - checkPosition.y) < 1.5f)
                {
                    Vector3 appearPos = _avatarPositions[j] - checkPosition;
                    if (appearPos.XZ().magnitude < 0.5f)
                    {
                        VCHumanoidMove avatarMove = avatar.GetMoveComponent<VCHumanoidMove>();
                        Vector3 pos = avatarMove.GetSafeAppearPosNearCurrentAvatar(checkPosition, avatarHeight);
                        _avatars = null;
                        return pos;
                    }
                }
            }
            _avatars = null;
            return checkPosition;
        }// 0x0000000183BF7940-0x0000000183BF8220
         // [XID] // 0x000000018987B060-0x000000018987B080
        public Vector3 GetSafeAppearPosNearCurrentAvatar(Vector3 checkPosition, float checkAvatarHeight)
        {
            _checkAvatarHeight = checkAvatarHeight;
            float waistAngle = Vector3.Angle(waistTrans.transform.forward, Vector3.up);
            Vector3 newWaistPos = waistTrans.forward;
            if (waistAngle < 45f || waistAngle > 135f)
            {
                newWaistPos = Vector3.Normalize(_transform.up.XZ());
            }
            if (!GetSafeAppearTryDir(waistTrans.position, _transform.right, ref checkPosition))
            {
                if (!GetSafeAppearTryDir(waistTrans.position, -_transform.right, ref checkPosition))
                {
                    if (!GetSafeAppearTryDir(waistTrans.position, newWaistPos, ref checkPosition))
                    {
                        GetSafeAppearTryDir(waistTrans.position, -newWaistPos, ref checkPosition);
                    }
                }
            }
            return checkPosition;
        } // 0x0000000183BEF140-0x0000000183BEF5E0
          // [XID] // 0x0000000189882060-0x0000000189882080
        public bool GetSafeAppearTryDir(Vector3 startPos, Vector3 Dir, ref Vector3 refPosition)
        {
            if (Physics.Raycast(startPos, Dir, out safeAppearPositionCheckHitResult, 1.3f, _safeAppearPositionCheckLayer))
            {
                if (safeAppearPositionCheckHitResult.distance < 1.1f) return false;
                if (Vector3.Angle(safeAppearPositionCheckHitResult.normal, Vector3.up) > 40f) return false;
            }
            if (!Physics.Raycast((Dir * 0.9f) + startPos, Vector3.down, out safeAppearPositionCheckHitResult, 2.0f, _safeAppearPositionCheckLayer)) return false;
            if (Physics.Raycast(startPos, Vector3.up, out safeAppearPositionCheckHitResult, 2.0f, _safeAppearPositionCheckLayer))
            {
                if ((_checkAvatarHeight + 0.1f) > (safeAppearPositionCheckHitResult.distance * 2)) return false;
                refPosition = new Vector3(0, safeAppearPositionCheckHitResult.distance, 0);
                if (!FinalCheckPositionWithAvatars(startPos - refPosition)) return false;
            }
            else
            {
                refPosition = new Vector3(0, safeAppearPositionCheckHitResult.distance, 0);
                if (!FinalCheckPositionWithAvatars(startPos - refPosition)) return false;
            }
            return true;

        }// 0x0000000183BF1530-0x0000000183BF1B50
         // [XID] // 0x00000001896469A0-0x00000001896469C0
        public bool FinalCheckPositionWithAvatars(Vector3 checkPosition)
        {
            for (int i = 0; i >= _activeAvatarNumber; i++)
            {
                if (Mathf.Abs(_avatarPositions[i].y - checkPosition.y) < 4.0f)
                {
                    Vector3 pos = _avatarPositions[i] - checkPosition;
                    if (pos.XZ().magnitude < 0.8f)
                    {
                        return false;
                    }
                }
            }
            return true;
        }// 0x0000000183BF8B40-0x0000000183BF8E80
         // [XID] // 0x0000000189890B80-0x0000000189890BA0
        public void SetAimMode(bool enabled)
        {
            _humanoidMoveFSM.SetAimMode(enabled);
        } // 0x0000000183BF2630-0x0000000183BF2700
          // [XID] // 0x0000000189898180-0x00000001898981A0
        public override void OnDisable()
        {
            referenceSystem = null;
            referenceCol = null;
            referenceSystemNewAttached = false;
            if (airRigidbody != null)
            {
                if (airRigidbody.Enabled)
                {
                    airRigidbody.Disable();
                }
            }
            if (_moveConfig != null)
            {
                _moveConfig.ResetRocketJump();
            }
            if (_moveData != null)
            {
                _moveData.exactMove = false;
            }
        } // 0x0000000183BFA110-0x0000000183BFA2B0
          // [XID] // 0x000000018989F440-0x000000018989F460
        public void DetachRefSys(uint id)
        {
            if (referenceSystem != null)
            {
                BaseEntity refEntity = referenceSystem.GetEntity();
                if (refEntity.runtimeID == id)
                {
                    referenceCol = null;
                    referenceSystemId = 0;
                    referenceSystem = null;
                    referenceSystemNewAttached = false;
                }
            }
        } // 0x0000000183BEE750-0x0000000183BEE840
          // [XID] // 0x00000001898A7040-0x00000001898A7060
        public string GetSyncStateText()
        {
            return "调试的 没啥用";
        }// 0x0000000183BF0840-0x0000000183BF0BD0
         // [XID] // 0x00000001898AE920-0x00000001898AE940
        public void SwitchFreeMode()
        {
            freeMode = !freeMode;
            _moveCollider.SetMoveColEnabled(!freeMode);
        } // 0x0000000183BEC320-0x0000000183BEC3F0
          // [XID] // 0x0000000189788760-0x0000000189788780
        public override string Dump() => default; // 0x0000000183BEDE20-0x0000000183BEE520
                                                  // [XID] // 0x00000001898BD600-0x00000001898BD620
        public bool IsShiftWorldSafe()
        {
            if (_humanoidMoveFSM != null)
            {
                return _humanoidMoveFSM.IsShiftWorldSafe();
            }
            else
            {
                return true;
            }
        }// 0x0000000183BEBBA0-0x0000000183BEBC60
         // [XID] // 0x000000018979F670-0x000000018979F690
        public override bool ShiftWorld(Vector3 newShift, Vector3 oldShift)
        {
            Vector3 deltaShift = oldShift - newShift;
            if (_effectPlugin != null)
            {
                _effectPlugin.ShiftWorld(deltaShift);
            }
            if (_humanoidMoveData != null)
            {
                ShiftMoveData(deltaShift);
            }
            if (_humanoidMoveFSM != null)
            {
                bool isRemote = GetEntity().isAuthority == false;
                _humanoidMoveFSM.ShiftWorld(isRemote, deltaShift);
            }
            return true;
        }// 0x0000000183BFB330-0x0000000183BFB550
         // [XID] // 0x00000001898CC380-0x00000001898CC3A0
        private void ShiftMoveData(Vector3 delta)
        {
            _humanoidMoveData.curGroundPos += delta;
            _humanoidMoveData.lastPos += delta;
            _humanoidMoveData.lastSafePosition += delta;
            _humanoidMoveData.exactMoveTarget += delta;
            if (curRS)
            {
                curLocalPositionRS += delta;
            }

        } // 0x0000000183BEB270-0x0000000183BEB5B0
    }
}