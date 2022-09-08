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
	public class MonoAvatarEquipInfo : MonoBehaviour // TypeDefIndex: 30435
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private AvatarEquipSlotGrp _avatarEquipSlotGrp; // 0x18
	
		// Nested types
		[Serializable]
		public class AvatarEquipSlot // TypeDefIndex: 30436
		{
			// Fields
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private EquipType _equipType; // 0x10
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private MonoBagProxySlot _bagSlot; // 0x18
	
			// Properties
			public EquipType equipType { /* [XID] */ /* 0x00000001898AD5D0-0x00000001898AD5F0 */ get => default; } // 0x0000000184215AC0-0x0000000184215B60 
			public MonoBagProxySlot bagSlot { /* [XID] */ /* 0x00000001898B4B70-0x00000001898B4B90 */ get => default; } // 0x0000000184215A20-0x0000000184215AC0 
	
			// Constructors
			public AvatarEquipSlot() {} // 0x00000001842159B0-0x0000000184215A20
		}
	
		[Serializable]
		public class AvatarEquipSlotGrp // TypeDefIndex: 30437
		{
			// Fields
			private Dictionary<int, AvatarEquipSlot> _slotDic; // 0x10
			private bool _inited; // 0x18
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			private AvatarEquipSlot[] _avatarEquipSlots; // 0x20
	
			// Properties
			public AvatarEquipSlot[] avatarEquipSlots { /* [XID] */ /* 0x00000001898CB500-0x00000001898CB520 */ get => default; } // 0x0000000184215910-0x00000001842159B0 
	
			// Constructors
			public AvatarEquipSlotGrp() {} // 0x0000000184215870-0x0000000184215910
	
			// Methods
			// [XID] // 0x00000001898C3C80-0x00000001898C3CA0
			public void Init() {} // 0x0000000184215390-0x00000001842155D0
			// [XID] // 0x00000001898D2C10-0x00000001898D2C30
			public void RegisterBagSlotClickHandler(Action<int> handler) {} // 0x0000000184215730-0x0000000184215870
			// [XID] // 0x00000001898DA520-0x00000001898DA540
			public void UpdateAvatarEquipSelected(int selected) {} // 0x00000001842155D0-0x0000000184215730
		}
	
		// Constructors
		public MonoAvatarEquipInfo() {} // 0x000000018421B470-0x000000018421B4E0
	
		// Methods
		// [XID] // 0x0000000189881130-0x0000000189881150
		private void Awake() {} // 0x000000018421B050-0x000000018421B160
		// [XID] // 0x0000000189888700-0x0000000189888720
		public void UpdateAvatarEquip(Dictionary<int, bool> dirty) {} // 0x000000018421B2D0-0x000000018421B470
		// [XID] // 0x000000018988FAE0-0x000000018988FB00
		private void OnAvatarEquipSlotClick(int index) {} // 0x000000018421B160-0x000000018421B210
		// [XID] // 0x0000000189896FC0-0x0000000189896FE0
		public void UpdateAvatarEquipSelected(int selected) {} // 0x000000018421B210-0x000000018421B2D0
	}
}
