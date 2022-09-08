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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoRelicChangeTip : MonoBehaviour // TypeDefIndex: 30475
	{
		// Fields
		private const string AVATAR_PROPERTY_ITEM_PATH = "ART/UI/Menus/Widget/AvatarPropertyItem"; // Metadata: 0x00B1117E
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _detailInfoContainer; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _suiteLabelAdd; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _suiteLabelDelete; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _suiteAddImage; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _suiteDeleteImage; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _noSuiteChangeTip; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoEquipNameChangeTip _nameChangeTip; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _needLevelText; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _needLevelBg; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _needLevelRoot; // 0x60
		private GameObject _avatarPropPrefab; // 0x68
		private List<GameObject> _avatarPropItemList; // 0x70
		private Dictionary<FightPropType, float> _propDic; // 0x78
	
		// Constructors
		public MonoRelicChangeTip() {} // 0x0000000184435450-0x0000000184435530
	
		// Methods
		// [XID] // 0x0000000189A70780-0x0000000189A707A0
		private void OnEnable() {} // 0x0000000184434F40-0x0000000184435050
		// [XID] // 0x0000000189A78050-0x0000000189A78070
		private void OnDisable() {} // 0x0000000184434E40-0x0000000184434F40
		// [XID] // 0x0000000189A7F640-0x0000000189A7F660
		public void UpdateByRelicInfo(ReliquaryItem oldRelic, ReliquaryItem newRelic, AvatarDataItem avatar) {} // 0x0000000184435320-0x0000000184435450
		// [XID] // 0x0000000189A87340-0x0000000189A87360
		private void UpdateRelicSet(ReliquaryItem oldRelic, ReliquaryItem newRelic, AvatarDataItem avatar) {} // 0x0000000184433290-0x00000001844340A0
		// [XID] // 0x0000000189A8EB80-0x0000000189A8EBA0
		private void UpdateAvatarProp(ReliquaryItem oldRelic, ReliquaryItem newRelic) {} // 0x0000000184434500-0x0000000184434E40
		// [XID] // 0x0000000189A961B0-0x0000000189A961D0
		private void AddValueToPropDic(FightPropType type, float value) {} // 0x00000001844340A0-0x00000001844341E0
		// [XID] // 0x0000000189A9D700-0x0000000189A9D720
		private void UpdateRelicName(ReliquaryItem oldRelic, ReliquaryItem newRelic) {} // 0x0000000184433030-0x0000000184433290
		// [XID] // 0x0000000189AA4FB0-0x0000000189AA4FD0
		private List<ReliquarySetInfo> GetNewRelicSetList(ReliquaryItem oldRelic, ReliquaryItem newRelic, AvatarDataItem avatar) => default; // 0x00000001844341E0-0x0000000184434500
		// [XID] // 0x0000000189AAC770-0x0000000189AAC790
		public void SetUseLevel(uint useLevel) {} // 0x0000000184435050-0x0000000184435320
	}
}
