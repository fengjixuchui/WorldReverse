/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class LCBaseIntee : LCBase // TypeDefIndex: 11713
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected string _triggerShapeIn; // 0x130
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _triggerShapeInHeight; // 0x138
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected string _triggerShapeOut; // 0x140
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _triggerShapeOutHeight; // 0x148
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected Vector3 _triggerShapeInOffset; // 0x14C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected Vector3 _triggerShapeOutOffset; // 0x158
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected string _triggerShapeFreeInteraction; // 0x168
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected float _triggerShapeFreeInteractionHeight; // 0x170
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected Vector3 _triggerShapeFreeInteractionOffset; // 0x174
		public const string PUSH_COLLIDER = "PushCollider"; // Metadata: 0x00AEA735
		public Action<ILuaActor, ILuaActorCollisionInfo> OnPushCollider; // 0x180
		protected InteeShareTaskData _interShareTaskData; // 0x188
		protected LCBaseInter _inter; // 0x190
		protected LCBaseInter _preInter; // 0x198
		protected LCExtraInterAction _extraAction; // 0x1A0
		private VCBaseHeadController _headCtrl; // 0x1A8
		protected bool _isTalking; // 0x1B1
		public uint curTalkId; // 0x1B4
		private uint _curPriority; // 0x1B8
		private RemoveActorType _removeType; // 0x1BC
		private bool _isInterDisable; // 0x1C0
		private bool _isLuaInterDisable; // 0x1C1
		public Action<LCBaseIntee> OnFieldEnterHandler; // 0x1C8
		public Action<LCBaseIntee> OnFieldBtnHandler; // 0x1D0
		public Action<LCBaseIntee> OnFieldExitHandler; // 0x1D8
		[NonSerialized]
		[NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
		public bool useTrigger; // 0x1E0
		[NonSerialized]
		[NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
		public bool useInteractionTrigger; // 0x1E1
		[NonSerialized]
		[NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
		public bool usePushCollider; // 0x1E2
		[NonSerialized]
		[NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
		public bool useHeadControlTrigger; // 0x1E3
		private float _triggerRadius; // 0x1E4
		private float _interactionTriggerRadius; // 0x1E8
		private float _headCtrlTriggerRadius; // 0x1EC
		public uint curPerformTalkId; // 0x1F0
		protected bool _triggerEnter; // 0x1F4
		protected bool _interactionTriggerEnter; // 0x1F5
		protected bool _prePerformTriggerEnter; // 0x1F6
		protected bool _headCtrlTriggerEnter; // 0x1F7
		protected bool _isLookAtOnly; // 0x1F8
		private GameObject _colliderObj; // 0x200
		private VCSpeechBubblePlugin _speechBubble; // 0x208
		private AnimatorCullingMode _originalMode; // 0x210
	
		// Properties
		public override int metaTypeID { /* [XID] */ /* 0x00000001899FA920-0x00000001899FA940 */ get => default; } // 0x0000000183A2B830-0x0000000183A2B8D0 
		public float triggerShapeInHeight { /* [XID] */ /* 0x0000000189A01B00-0x0000000189A01B20 */ get => default; } // 0x0000000183A2BB90-0x0000000183A2BC40 
		public InteeShareTaskData shareTaskData { /* [XID] */ /* 0x000000018972ED50-0x000000018972ED70 */ get => default; } // 0x0000000183A2B980-0x0000000183A2BA30 
		public LCBaseInter inter { /* [XID] */ /* 0x00000001897364D0-0x00000001897364F0 */ get => default; } // 0x0000000183A2B560-0x0000000183A2B620 
		public VCBaseHeadController headCtrl { /* [XID] */ /* 0x000000018975B8B0-0x000000018975B8D0 */ get => default; } // 0x0000000183A2B4B0-0x0000000183A2B560 
		public bool disableHeadCtrl { /* [XID] */ /* 0x0000000189763320-0x0000000189763360 */ get; /* [XID] */ /* 0x000000018976D960-0x000000018976D9A0 */ set; } // 0x0000000183A2B2F0-0x0000000183A2B350 0x0000000183A2BF60-0x0000000183A2BFD0
		public bool IsTalking { /* [XID] */ /* 0x0000000189777FD0-0x0000000189777FF0 */ get => default; /* [XID] */ /* 0x000000018977F4E0-0x000000018977F500 */ set {} } // 0x0000000183A2B1A0-0x0000000183A2B250 0x0000000183A2BE00-0x0000000183A2BEB0
		public RemoveActorType RemoveType { /* [XID] */ /* 0x0000000189786EE0-0x0000000189786F00 */ get => default; /* [XID] */ /* 0x000000018978E580-0x000000018978E5A0 */ set {} } // 0x0000000183A2B250-0x0000000183A2B2F0 0x0000000183A2BEB0-0x0000000183A2BF60
		public bool isLuaInterDisable { /* [XID] */ /* 0x0000000189BC9A50-0x0000000189BC9A70 */ set {} } // 0x0000000183A2BFD0-0x0000000183A2C080
		public bool IsInterDisable { /* [XID] */ /* 0x0000000189BBA4A0-0x0000000189BBA4C0 */ get => default; /* [XID] */ /* 0x000000018965D2E0-0x000000018965D300 */ set {} } // 0x0000000183A2B0E0-0x0000000183A2B1A0 0x0000000183A2BC40-0x0000000183A2BE00
		public float triggerRadius { /* [XID] */ /* 0x00000001897CB540-0x00000001897CB560 */ get => default; } // 0x0000000183A2BAE0-0x0000000183A2BB90 
		public float interactionTriggerRadius { /* [XID] */ /* 0x00000001897D2C80-0x00000001897D2CA0 */ get => default; } // 0x0000000183A2B6D0-0x0000000183A2B780 
		public float headCtrlTriggerRadius { /* [XID] */ /* 0x00000001897DA9E0-0x00000001897DAA00 */ get => default; } // 0x0000000183A2B400-0x0000000183A2B4B0 
		public bool triggerEnter { /* [XID] */ /* 0x0000000189630270-0x0000000189630290 */ get => default; } // 0x0000000183A2BA30-0x0000000183A2BAE0 
		public bool interactionTriggerEnter { /* [XID] */ /* 0x0000000189A80C80-0x0000000189A80CA0 */ get => default; } // 0x0000000183A2B620-0x0000000183A2B6D0 
		public bool prePerformTriggerEnter { /* [XID] */ /* 0x00000001897260E0-0x0000000189726100 */ get => default; } // 0x0000000183A2B8D0-0x0000000183A2B980 
		public bool headCtrlTriggerEnter { /* [XID] */ /* 0x0000000189882260-0x0000000189882280 */ get => default; } // 0x0000000183A2B350-0x0000000183A2B400 
		public bool isLookAtOnly { /* [XID] */ /* 0x0000000189825260-0x0000000189825280 */ get => default; } // 0x0000000183A2B780-0x0000000183A2B830 
	
		// Constructors
		public LCBaseIntee() {} // 0x0000000183A2AED0-0x0000000183A2B0E0
	
		// Methods
		// [XID] // 0x0000000189A180D0-0x0000000189A180F0
		public void SwitchInter(LCBaseInter newInter) {} // 0x0000000183A294B0-0x0000000183A29560
		// [XID] // 0x0000000189A1F790-0x0000000189A1F7B0
		public void SwitchPreInter(LCBaseInter newInter) {} // 0x0000000183A28FE0-0x0000000183A29090
		// [XID] // 0x0000000189A3D170-0x0000000189A3D190
		public void SetExtraAction(LCExtraInterAction extraAction) {} // 0x0000000183A28C20-0x0000000183A28CD0
		// [XID] // 0x0000000189754690-0x00000001897546B0
		public bool HasExtraBtnAction() => default; // 0x0000000183A29090-0x0000000183A29150
		// [XID] // 0x0000000189795C40-0x0000000189795C60
		public void FinishTalk() {} // 0x0000000183A2A730-0x0000000183A2A810
		// [XID] // 0x00000001898736B0-0x00000001898736D0
		public bool CallOnFieldEnterHandler() => default; // 0x0000000183A29FB0-0x0000000183A2A070
		// [XID] // 0x000000018987B170-0x000000018987B190
		public void CallOnFieldBtnHandler() {} // 0x0000000183A28530-0x0000000183A285E0
		// [XID] // 0x00000001897C3C10-0x00000001897C3C30
		public void CallOnFieldExitHandler() {} // 0x0000000183A289F0-0x0000000183A28AA0
		// [XID] // 0x0000000189AF8010-0x0000000189AF8030
		public void InitByInteeConfig(ConfigIntee configIntee) {} // 0x0000000183A29150-0x0000000183A29290
		// [XID] // 0x0000000189621170-0x0000000189621190
		public void UpdateTriggerEnter(bool value) {} // 0x0000000183A29A10-0x0000000183A29AC0
		// [XID] // 0x00000001898000E0-0x0000000189800100
		public void UpdateInteractionTriggerEnter(bool value) {} // 0x0000000183A28F30-0x0000000183A28FE0
		// [XID] // 0x000000018980EE40-0x000000018980EE60
		public void UpdatePrePerformTriggerEnter(bool value) {} // 0x0000000183A29BF0-0x0000000183A29CA0
		// [XID] // 0x000000018981DE90-0x000000018981DEB0
		public void UpdateHeadCtrlTriggerEnter(bool value) {} // 0x0000000183A29560-0x0000000183A29610
		// [XID] // 0x0000000189889890-0x00000001898898B0
		public void UpdateIsLookAtOnly(bool value) {} // 0x0000000183A2ABA0-0x0000000183A2AC50
		// [XID] // 0x0000000189834380-0x00000001898343A0
		public override void OnEntityReady() {} // 0x0000000183A2A8E0-0x0000000183A2A9B0
		// [XID] // 0x0000000189898380-0x00000001898983A0
		public override void Init() {} // 0x0000000183A29690-0x0000000183A29A10
		// [XID] // 0x000000018989F630-0x000000018989F650
		public virtual void InitPushCollider() {} // 0x0000000183A29390-0x0000000183A294B0
		// [XID] // 0x00000001898AEB30-0x00000001898AEB50
		protected void OnEnterPushCollider(Collision collider) {} // 0x0000000183A2AC50-0x0000000183A2AED0
		// [XID] // 0x0000000189A0DDA0-0x0000000189A0DDC0
		public BaseEntity CheckTargetForward(LCBaseInter inter) => default; // 0x0000000183A29D00-0x0000000183A29FB0
		// [XID] // 0x0000000189859050-0x0000000189859070
		protected static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000183A29290-0x0000000183A29390
		// [XID] // 0x00000001899BD420-0x00000001899BD440
		protected override bool OnEvent(BaseEvent e) => default; // 0x0000000183A2A9B0-0x0000000183A2ABA0
		// [XID] // 0x0000000189867910-0x0000000189867930
		private void OnOwnerActiveChange(EvtEntityActiveChange evt) {} // 0x0000000183A2A070-0x0000000183A2A140
		// [XID] // 0x000000018986F020-0x000000018986F040
		private void EnableCollider(bool b) {} // 0x0000000183A29AC0-0x0000000183A29BF0
		// [XID] // 0x0000000189876530-0x0000000189876550
		public override void Destroy() {} // 0x0000000183A28CD0-0x0000000183A28F30
		// [XID] // 0x000000018987E0D0-0x000000018987E0F0
		public bool ShowSpeechBubble(uint dialogID, uint priority, float time) => default; // 0x0000000183A28640-0x0000000183A289F0
		// [XID] // 0x0000000189736690-0x00000001897366B0
		public void ClearSpeechBubble(uint priority) {} // 0x0000000183A2A660-0x0000000183A2A730
		// [XID] // 0x000000018988C720-0x000000018988C740
		public void EnableAlwaysAnimator(bool value) {} // 0x0000000183A28AA0-0x0000000183A28C20
		// [XID] // 0x0000000189893C90-0x0000000189893CB0
		public void LoadFromConfig(ConfigLCBaseIntee config) {} // 0x0000000183A2A230-0x0000000183A2A600
		// [XID] // 0x000000018989B370-0x000000018989B390
		public override void OnComponentInitFinish(object compData) {} // 0x0000000183A2A810-0x0000000183A2A8E0
	}
}
