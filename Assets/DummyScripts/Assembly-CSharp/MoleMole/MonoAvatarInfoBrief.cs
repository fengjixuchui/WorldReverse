/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoAvatarInfoBrief : MonoSpriteProxy // TypeDefIndex: 30438
	{
		// Fields
		private const int UNLOCK_MAX_LEVEL = 80; // Metadata: 0x00B10F3F
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _detailInfoGroup; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _baseInfoContainer; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _avatarDescText; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _avatarDescScrollbar; // 0x38
		private const string AVATAR_BASE_INFO_PATH = "ART/UI/Menus/Widget/AvatarBaseInfo"; // Metadata: 0x00B10F43
		private MonoAvatarBaseInfo _baseInfo; // 0x40
		private const string AVATAR_PROPERTY_ITEM_PATH = "ART/UI/Menus/Widget/AvatarPropertyItem"; // Metadata: 0x00B10F69
		public MonoAvatarMiniInfo avatarMiniInfo; // 0x48
	
		// Properties
		public MonoAvatarBaseInfo baseInfo { /* [XID] */ /* 0x00000001899034B0-0x00000001899034D0 */ get => default; } // 0x0000000184221F20-0x00000001842220C0 
		public bool showDetailInfo { /* [XID] */ /* 0x00000001899217A0-0x00000001899217C0 */ set {} } // 0x00000001842220C0-0x00000001842221C0
		public UnityEngine.UI.Text avatarDescText { /* [XID] */ /* 0x0000000189928EA0-0x0000000189928EC0 */ get => default; } // 0x0000000184221E80-0x0000000184221F20 
	
		// Constructors
		public MonoAvatarInfoBrief() {} // 0x0000000184221E00-0x0000000184221E80
	
		// Methods
		// [XID] // 0x000000018990AA00-0x000000018990AA20
		protected override void OnDestroy() {} // 0x00000001842217C0-0x0000000184221950
		// [XID] // 0x0000000189912690-0x00000001899126B0
		public void UpdateAvatarCfg(AvatarExcelConfig avatarCfg) {} // 0x0000000184221950-0x0000000184221AC0
		// [XID] // 0x0000000189919F60-0x0000000189919F80
		public void UpdateAvatarProp(AvatarDataItem dataItem, bool isLocalPlayer) {} // 0x0000000184221AC0-0x0000000184221E00
	}
}
