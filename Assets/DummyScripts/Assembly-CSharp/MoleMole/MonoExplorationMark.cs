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
	public class MonoExplorationMark : MonoSpriteProxy // TypeDefIndex: 30461
	{
		// Fields
		public RectTransform parentRect; // 0x20
		public Button btn; // 0x28
		public ulong currGuid; // 0x30
		public GameObject goNormal; // 0x38
		public GameObject exploring; // 0x40
		public GameObject exploringTimeGO; // 0x48
		public UnityEngine.UI.Text exploringTimeText; // 0x50
		public GameObject complete; // 0x58
		public GameObject completeTip; // 0x60
		public Sprite defaultSprite; // 0x68
		public Image avatarSprite; // 0x70
		public string currTimeText; // 0x78
		public GameObject selectGO; // 0x80
		public Transform redPointContainer; // 0x88
		public GameObject EffReadyToClaim; // 0x90
		public GameObject EffSendOut; // 0x98
		private Vector3[] corners; // 0xA0
		public ExpeditionDataExcelConfig currConfig; // 0xA8
		public AvatarExpeditionInfo expeditionInfo; // 0xB0
		private TimeSpan lastTimeSpan; // 0xB8
		private MonoNoticeContainer _redPoint; // 0xC0
		// [Header] // 0x0000000189616DB0-0x0000000189616E00
		[SerializeField] // 0x0000000189616DB0-0x0000000189616E00
		[Space] // 0x0000000189616DB0-0x0000000189616E00
		private GameObject _levelTag_S; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _levelTag_A; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _levelTag_B; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _levelTag_C; // 0xE0
		public ExpeditionActivityMarkerExcelConfig currAcitivityMarkerConfig; // 0xE8
		public ExpeditionPathInfo pathInfo; // 0xF0
		private List<ElementType> _upElements; // 0xF8
	
		// Properties
		public MonoNoticeContainer redPoint { /* [XID] */ /* 0x0000000189678B80-0x0000000189678BA0 */ get => default; } // 0x000000018562E320-0x000000018562E480 
		public ExpeditionPathExcelConfig pathCfg { /* [XID] */ /* 0x0000000189687DD0-0x0000000189687DF0 */ get => default; } // 0x000000018562E260-0x000000018562E320 
		public ExpeditionDifficultyExcelConfig diffCfg { /* [XID] */ /* 0x000000018968F7D0-0x000000018968F7F0 */ get => default; } // 0x000000018562E180-0x000000018562E260 
		public List<ElementType> upElements { /* [XID] */ /* 0x00000001896D18B0-0x00000001896D18D0 */ get => default; } // 0x000000018562E480-0x000000018562E580 
	
		// Nested types
		public enum MarkState // TypeDefIndex: 30462
		{
			None = 0,
			WaitingToSend = 1,
			Receive = 2,
			Callback = 3
		}
	
		private enum ExplorationLevel // TypeDefIndex: 30463
		{
			None = 0,
			Level_S = 1,
			Level_A = 2,
			Level_B = 3,
			Level_C = 4
		}
	
		// Constructors
		public MonoExplorationMark() {} // 0x000000018562E080-0x000000018562E180
	
		// Methods
		// [XID] // 0x000000018963C8E0-0x000000018963C900
		private void OnDisable() {} // 0x000000018562C420-0x000000018562C4E0
		// [XID] // 0x0000000189643FC0-0x0000000189643FE0
		public void Refresh(ExpeditionDataExcelConfig config) {} // 0x000000018562C4E0-0x000000018562C740
		// [XID] // 0x000000018964B770-0x000000018964B790
		public void SetAvatar(ulong guid) {} // 0x000000018562CCD0-0x000000018562CE70
		// [XID] // 0x0000000189652EE0-0x0000000189652F00
		public int FindRewardIndex() => default; // 0x000000018562BEC0-0x000000018562C050
		// [XID] // 0x000000018965A5C0-0x000000018965A5E0
		public void SetExpeditionInfo(AvatarExpeditionInfo info = null) {} // 0x000000018562CE70-0x000000018562D180
		// [XID] // 0x0000000189661C10-0x0000000189661C30
		public void UpdateTime() {} // 0x000000018562DB40-0x000000018562E080
		// [XID] // 0x00000001896697D0-0x00000001896697F0
		public void ClearGuid(ulong guid) {} // 0x000000018562BDC0-0x000000018562BEC0
		// [XID] // 0x00000001896712C0-0x00000001896712E0
		public MarkState GetCurrState() => default; // 0x000000018562C100-0x000000018562C240
		// [XID] // 0x00000001896801C0-0x00000001896801E0
		public void TriggerSendOutEff() {} // 0x000000018562D5A0-0x000000018562D670
		// [XID] // 0x0000000189697210-0x0000000189697230
		public void SetExplorationActivityLevel() {} // 0x000000018562D180-0x000000018562D350
		// [XID] // 0x000000018969E740-0x000000018969E760
		public void BindPathInfo(ExpeditionPathInfo pathInfo) {} // 0x000000018562BCB0-0x000000018562BDC0
		// [XID] // 0x00000001896A57B0-0x00000001896A57D0
		public void BindMarkerConfig(ExpeditionActivityMarkerExcelConfig markerConfig) {} // 0x000000018562BC00-0x000000018562BCB0
		// [XID] // 0x00000001896ACFD0-0x00000001896ACFF0
		public void SetAvatarIcon() {} // 0x000000018562CA40-0x000000018562CCD0
		// [XID] // 0x00000001896B4640-0x00000001896B4660
		public void SetMarkerPosition() {} // 0x000000018562D350-0x000000018562D5A0
		// [XID] // 0x00000001896BB870-0x00000001896BB890
		public void SetActivityMarkerCircleAndTagState() {} // 0x000000018562C740-0x000000018562CA40
		// [XID] // 0x00000001896C2CC0-0x00000001896C2CE0
		public ExpeditionState GetCurrActivityState() => default; // 0x000000018562C050-0x000000018562C100
		// [XID] // 0x00000001896CA1E0-0x00000001896CA200
		private List<ElementType> ParseElement(string superElement) => default; // 0x000000018562C240-0x000000018562C420
		// [XID] // 0x00000001896D90B0-0x00000001896D90D0
		public void UpdateActivityTime() {} // 0x000000018562D670-0x000000018562DB40
	}
}
