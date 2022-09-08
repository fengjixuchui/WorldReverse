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

namespace MoleMole
{
	public class MonoInLevelBuffInfo : MonoUIProxy // TypeDefIndex: 29733
	{
		// Fields
		public static readonly string buffIconRes; // 0x00
		private static readonly int SHOW_ELEMENT_COUNT; // 0x08
		private static readonly float _elementCountDownTime; // 0x0C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public Transform anchor; // 0x40
		public bool isSimple; // 0x48
		public int buffIconMax; // 0x4C
		private List<ElementStateExcelConfig> _elementBuffList; // 0x50
		private List<BuffIconExcelConfig> _buffIconConfig; // 0x58
		private List<int> _buffIDs; // 0x60
		private List<ElementStateExcelConfig> _oldElementBuffList; // 0x68
		private List<BuffIconExcelConfig> _oldBuffIconConfig; // 0x70
		private List<GameObject> _elementIconList; // 0x78
		private List<EntityTimer> _entityTimerList; // 0x80
		private List<LCAvatarCombat> _monitoredSkillOwners; // 0x88
		private List<uint> _monitoredSkillIDs; // 0x90
		private List<BuffIconProxy> _buffIconProxyList; // 0x98
		private BaseEntity _trackingEntity; // 0xA0
	
		// Constructors
		public MonoInLevelBuffInfo() {} // 0x0000000184703780-0x0000000184703970
		static MonoInLevelBuffInfo() {} // 0x00000001847036F0-0x0000000184703780
	
		// Methods
		// [XID] // 0x0000000189B85DA0-0x0000000189B85DC0
		private void Update() {} // 0x0000000184703650-0x00000001847036F0
		// [XID] // 0x0000000189B8CD90-0x0000000189B8CDB0
		public void InitValue(BaseEntity entity) {} // 0x0000000184702760-0x0000000184702830
		// [XID] // 0x0000000189B94580-0x0000000189B945A0
		public void RefreshValue(uint entityID, bool isNewChar = false /* Metadata: 0x00B0FD3D */) {} // 0x0000000184703380-0x00000001847034B0
		// [XID] // 0x0000000189B9BC30-0x0000000189B9BC50
		private void RefreshElementBuff() {} // 0x0000000184702450-0x0000000184702510
		// [XID] // 0x0000000189BA33B0-0x0000000189BA33D0
		private void RefreshBuffId() {} // 0x0000000184701540-0x0000000184701650
		// [XID] // 0x0000000189BAA710-0x0000000189BAA730
		private void RefreshBuffConfig() {} // 0x00000001847022E0-0x0000000184702450
		// [XID] // 0x0000000189BB1D90-0x0000000189BB1DB0
		private bool IsMutex(BuffIconExcelConfig config) => default; // 0x0000000184702DA0-0x0000000184702EF0
		// [XID] // 0x0000000189BB9150-0x0000000189BB9170
		private void RefreshMonitoredSkill() {} // 0x0000000184701650-0x0000000184701B30
		// [XID] // 0x0000000189BC0F00-0x0000000189BC0F20
		private void SetElementIconColor(Transform elementIcon, float duration) {} // 0x0000000184702510-0x0000000184702760
		// [XID] // 0x0000000189BC8650-0x0000000189BC8670
		private void UpdateElementIcon(float inDeltaTime) {} // 0x0000000184701B30-0x0000000184701EC0
		// [XID] // 0x0000000189BCFEB0-0x0000000189BCFED0
		private void SetBuffIconContainer(Transform trans, int index) {} // 0x0000000184701F20-0x00000001847022E0
		// [XID] // 0x0000000189BD74B0-0x0000000189BD74D0
		protected override void OnDestroy() {} // 0x0000000184703250-0x0000000184703380
		// [IDTag] // 0x0000000189BDEFD0-0x0000000189BDF010
		// [XID] // 0x0000000189BDEFD0-0x0000000189BDF010
		private bool checkIsNew(ElementStateExcelConfig elementConfig) => default; // 0x0000000184703040-0x0000000184703190
		// [IDTag] // 0x00000001895EEA00-0x00000001895EEA40
		// [XID] // 0x00000001895EEA00-0x00000001895EEA40
		private bool checkIsNew(BuffIconExcelConfig buffConfig) => default; // 0x0000000184702EF0-0x0000000184703040
		// [XID] // 0x00000001895F9350-0x00000001895F9370
		private void RefreshBuffIcon() {} // 0x0000000184702830-0x0000000184702DA0
		// [XID] // 0x0000000189600980-0x00000001896009A0
		private void RefreshOldData() {} // 0x0000000184703190-0x0000000184703250
		// [XID] // 0x00000001896082A0-0x00000001896082C0
		public void Resort() {} // 0x00000001847034B0-0x0000000184703650
	}
}
